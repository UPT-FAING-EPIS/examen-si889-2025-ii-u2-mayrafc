using Xunit;

public class EmployeeReportTests
{
    [Fact]
    public void Should_Generate_Developer_Report_Using_Visitor()
    {
        var dev = new Developer
        {
            Name = "Alice",
            Salary = 80000,
            ProgrammingLanguage = "C#"
        };

        var visitor = new ReportVisitor();
        var report = dev.Accept(visitor);

        Assert.Equal("Developer: Alice, Language: C#, Salary: 80000", report);
    }

    [Fact]
    public void Should_Generate_Manager_Report_Using_Visitor()
    {
        var mgr = new Manager
        {
            Name = "Bob",
            Salary = 100000,
            TeamSize = 5
        };

        var visitor = new ReportVisitor();
        var report = mgr.Accept(visitor);

        Assert.Equal("Manager: Bob, Team Size: 5, Salary: 100000", report);
    }
}

public static class EmployeeExtensions
{
    public static string GenerateReport(this Employee employee)
    {
        var visitor = new ReportVisitor();
        return employee.Accept(visitor);
    }
}