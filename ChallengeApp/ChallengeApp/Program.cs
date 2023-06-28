using ChallengeApp;

var employee = new Employee("Wojtek", "Rej");
employee.AddGrade(3);
employee.AddGrade(3);
employee.AddGrade(4);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");


