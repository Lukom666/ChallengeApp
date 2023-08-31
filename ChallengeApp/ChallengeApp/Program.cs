using ChallengeApp;

var employee = new Employee("Josh", "Good");
employee.AddGrade(9f);
employee.AddGrade("5000");
employee.AddGrade(2);
employee.AddGrade(6);
var statistics = employee.GetStatisticsDoWhile();
var statistics1 = employee.GetStatisticsWhile();
var statistics2 = employee.GetStatisticsForEach();
var statistics3 = employee.GetStatisticsFor();

Console.WriteLine("GetStatisticsDoWhile");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average: {statistics.Average:N2}");

Console.WriteLine("GetStatisticsWhile");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine($"Average: {statistics1.Average:N2}");

Console.WriteLine("GetStatisticsForEach");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");
Console.WriteLine($"Average: {statistics2.Average:N2}");

Console.WriteLine("GetStatisticsFor");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");
Console.WriteLine($"Average: {statistics3.Average:N2}");


// Console.WriteLine($"Average: {statistics.Average:N2}");
// Console.WriteLine($"Min: {statistics.Min}");
// Console.WriteLine($"Max: {statistics.Max}");
