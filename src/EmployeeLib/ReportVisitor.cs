public class ReportVisitor : IEmployeeVisitor
{
    public string VisitDeveloper(Developer developer)
    {
        return $"Developer: {developer.Name}, Language: {developer.ProgrammingLanguage}, Salary: {developer.Salary}";
    }

    public string VisitManager(Manager manager)
    {
        return $"Manager: {manager.Name}, Team Size: {manager.TeamSize}, Salary: {manager.Salary}";
    }
}
