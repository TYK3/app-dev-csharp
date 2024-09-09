using System;

class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Grade { get; set; }

    public Student(int id, string name, int age, double grade)
    {
        ID = id;
        Name = CapitalizeWords(name);
        Age = age;
        Grade = grade;
    }

    public void DisplayDetails()
    {
        string status = IsPassing() ? "Passing" : "Failing";
        Console.WriteLine($"ID: {ID}, Name: {Name}, Age: {Age}, Grade: {Grade} - {status}");
    }

    public bool IsPassing()
    {
        return Grade >= 60;
    }

    private string CapitalizeWords(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        string[] words = input.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > 0)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
            }
        }

        return string.Join(" ", words);
    }
}
