using ChallengeApp;

var employee0 = new Employee("Josh", "Good", "48");
var employee1 = new Employee("Andrea", "Red", "25");
var employee2 = new Employee("Frank", "Bull", "29");

employee0.AddRating(8);
employee0.AddRating(5);
employee0.AddRating(7);
employee0.AddRating(6);
employee0.AddRating(7);


employee1.AddRating(3);
employee1.AddRating(4);
employee1.AddRating(3);
employee1.AddRating(6);
employee1.AddRating(4);

employee2.AddRating(9);
employee2.AddRating(8);
employee2.AddRating(9);
employee2.AddRating(8);
employee2.AddRating(9);

List<Employee> employees = new List<Employee>()
{
    employee0, employee1, employee2
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}
Console.WriteLine("The best result have " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname +
    ", age " + employeeWithMaxResult.Age + ", points " + maxResult + ", Congratulations!");