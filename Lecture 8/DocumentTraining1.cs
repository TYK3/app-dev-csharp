using Azure;
using Azure.AI.FormRecognizer.DocumentAnalysis;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace KOTOTraining
{
    public class DocumentTraining1
    {
        private readonly ILogger<DocumentTraining1> _logger;        
        private readonly DocumentAnalysisClient _recognizerClient;
        public DocumentTraining1(ILogger<DocumentTraining1> logger)
        {
            _logger = logger;

            string recognizerEndpoint = Environment.GetEnvironmentVariable("DocumentIntelligenceEndpoint") ?? throw new InvalidOperationException("Endpoint not configured");
            string recognizerKey = Environment.GetEnvironmentVariable("DocumentIntelligenceKey") ?? throw new InvalidOperationException("Key not configured");

            _recognizerClient = new DocumentAnalysisClient(new Uri(recognizerEndpoint), new AzureKeyCredential(recognizerKey));
        }

        [Function("DocumentTraining1")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var invoiceUrl = "https://github.com/MicrosoftLearning/mslearn-ai-document-intelligence/blob/main/Labfiles/01-prebuild-models/sample-invoice/sample-invoice.pdf?raw=true";

            var documentAnalysisResult = await AnalyzeInvoiceAsync(_recognizerClient, invoiceUrl);

            if (documentAnalysisResult == null)
            {
                return new BadRequestObjectResult("Failed to analyze the invoice.");
            }

            return new OkObjectResult(documentAnalysisResult);
        }

        private async Task<IDictionary<string, string>> AnalyzeInvoiceAsync(DocumentAnalysisClient client, string invoiceUrl)
        {
            var response = await client.AnalyzeDocumentFromUriAsync(WaitUntil.Completed, "prebuilt-invoice", new Uri(invoiceUrl));
            var result = new Dictionary<string, string>();

            foreach (var document in response.Value.Documents)
            {
                if (document.Fields.TryGetValue("CustomerName", out DocumentField customerNameField))
                {
                    result["CustomerName"] = customerNameField.Content;
                }

                if (document.Fields.TryGetValue("InvoiceTotal", out DocumentField invoiceTotalField))
                {
                    result["InvoiceTotal"] = invoiceTotalField.Content;
                }

                if (document.Fields.TryGetValue("DueDate", out DocumentField dueDateField))
                {
                    result["CustomerName"] = customerNameField.Content;
                }
            }

            return result;
        }
    }
}
