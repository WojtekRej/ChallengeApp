using ChallengeApp;

var employee = new Employee("Wojtek", "Rej");
employee.AddGrade("Kot");
employee.AddGrade("4000");
employee.AddGrade(7f);
employee.AddGrade(5);
employee.AddGrade(3);
var statistics = employee.GetStatistics();

// Ctrl + K + C szybki komentarz
// Ctrl + K + U zdjęcie komentarza

Console.WriteLine($"average: {statistics.Average:n2}");
Console.WriteLine($"max: {statistics.Max}");
Console.WriteLine($"min: {statistics.Min}");


