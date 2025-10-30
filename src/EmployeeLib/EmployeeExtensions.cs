public static class EmployeeExtensions
{
    public static string GenerateReport(this Employee employee)
    {
        var visitor = new ReportVisitor();
        return employee.Accept(visitor);
    }
}
