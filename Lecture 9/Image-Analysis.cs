using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Drawing;
using Azure;
using Azure.AI.Vision.ImageAnalysis;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace KotoDemo
{
    public class ImageAnalysisFunction
    {
        private readonly ILogger<ImageAnalysisFunction> _logger;
        private readonly IConfiguration _configuration;

        public ImageAnalysisFunction(ILogger<ImageAnalysisFunction> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [Function("ImageAnalysis")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            try
            {
                // Get config settings from AppSettings
                string aiSvcEndpoint = _configuration["https://rsp-demo-ai-service.cognitiveservices.azure.com/"];
                string aiSvcKey = _configuration[""];

                // Get image file path from the request
                string imageFile = req.Query["imageFile"];
                if (string.IsNullOrEmpty(imageFile))
                {
                    imageFile = "images/street.jpg"; // Default image file
                }

                // Authenticate Azure AI Vision client
                ImageAnalysisClient client = new ImageAnalysisClient(
                    new Uri(aiSvcEndpoint),
                    new AzureKeyCredential(aiSvcKey)
                );

                // Analyze image
                AnalyzeImage(imageFile, client);

                // Remove the background or generate a foreground matte from the image
                //await BackgroundForeground(imageFile, aiSvcEndpoint, aiSvcKey);

                return new OkObjectResult("Image analysis and background removal completed successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error occurred: {ex.Message}");
                return new BadRequestObjectResult("An error occurred while processing the request.");
            }
        }

        private void AnalyzeImage(string imageFile, ImageAnalysisClient client)
        {
            _logger.LogInformation($"Analyzing {imageFile}");

            // Use a file stream to pass the image data to the analyze call
            using FileStream stream = new FileStream(imageFile, FileMode.Open);

            // Get result with specified features to be retrieved
            ImageAnalysisResult result = client.Analyze(
                BinaryData.FromStream(stream),
                VisualFeatures.Caption |
                VisualFeatures.DenseCaptions |
                VisualFeatures.Objects |
                VisualFeatures.Tags |
                VisualFeatures.People
            );

            // Display analysis results (log instead of console output)
            if (result.Caption.Text != null)
            {
                _logger.LogInformation($"Caption: \"{result.Caption.Text}\", Confidence {result.Caption.Confidence:0.00}");
            }

            _logger.LogInformation("Dense Captions:");
            foreach (DenseCaption denseCaption in result.DenseCaptions.Values)
            {
                _logger.LogInformation($"Caption: '{denseCaption.Text}', Confidence: {denseCaption.Confidence:0.00}");
            }

            if (result.Tags.Values.Count > 0)
            {
                _logger.LogInformation("Tags:");
                foreach (DetectedTag tag in result.Tags.Values)
                {
                    _logger.LogInformation($"'{tag.Name}', Confidence: {tag.Confidence:F2}");
                }
            }

            if (result.Objects.Values.Count > 0)
            {
                _logger.LogInformation("Objects:");

                // Prepare image for drawing
                stream.Close();
                System.Drawing.Image image = System.Drawing.Image.FromFile(imageFile);
                using Graphics graphics = Graphics.FromImage(image);
                Pen pen = new Pen(Color.Cyan, 3);
                Font font = new Font("Arial", 16);
                SolidBrush brush = new SolidBrush(Color.WhiteSmoke);

                foreach (DetectedObject detectedObject in result.Objects.Values)
                {
                    _logger.LogInformation($"\"{detectedObject.Tags[0].Name}\"");

                    // Draw object bounding box
                    var r = detectedObject.BoundingBox;
                    Rectangle rect = new Rectangle(r.X, r.Y, r.Width, r.Height);
                    graphics.DrawRectangle(pen, rect);
                    graphics.DrawString(detectedObject.Tags[0].Name, font, brush, r.X, r.Y);
                }

                // Save annotated image
                string outputFile = "objects.jpg";
                image.Save(outputFile);
                _logger.LogInformation($"Results saved in {outputFile}");
            }

            if (result.People.Values.Count > 0)
            {
                _logger.LogInformation("People:");

                // Prepare image for drawing
                System.Drawing.Image image = System.Drawing.Image.FromFile(imageFile);
                using Graphics graphics = Graphics.FromImage(image);
                Pen pen = new Pen(Color.Cyan, 3);
                Font font = new Font("Arial", 16);
                SolidBrush brush = new SolidBrush(Color.WhiteSmoke);

                foreach (DetectedPerson person in result.People.Values)
                {
                    var r = person.BoundingBox;
                    Rectangle rect = new Rectangle(r.X, r.Y, r.Width, r.Height);
                    graphics.DrawRectangle(pen, rect);
                }

                // Save annotated image
                string outputFile = "persons.jpg";
                image.Save(outputFile);
                _logger.LogInformation($"Results saved in {outputFile}");
            }
        }

        private async Task BackgroundForeground(string imageFile, string endpoint, string key)
        {
            _logger.LogInformation("Background removal:");

            // Define the API version and mode
            string apiVersion = "2023-02-01-preview";
            string mode = "backgroundRemoval";

            string url = $"computervision/imageanalysis:segment?api-version={apiVersion}&mode={mode}";

            // Make the REST call
            using var client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.BaseAddress = new Uri(endpoint);
            client.DefaultRequestHeaders.Accept.Add(contentType);
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", key);

            var data = new
            {
                url = $"https://github.com/MicrosoftLearning/mslearn-ai-vision/blob/main/Labfiles/01-analyze-images/Python/image-analysis/{imageFile}?raw=true"
            };

            var jsonData = JsonSerializer.Serialize(data);
            var contentData = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url, contentData);

            if (response.IsSuccessStatusCode)
            {
                File.WriteAllBytes("background.png", response.Content.ReadAsByteArrayAsync().Result);
                _logger.LogInformation("Results saved in background.png");
            }
            else
            {
                _logger.LogError($"API error: {response.ReasonPhrase} - Check your body url, key, and endpoint.");
            }
        }
    }
}
