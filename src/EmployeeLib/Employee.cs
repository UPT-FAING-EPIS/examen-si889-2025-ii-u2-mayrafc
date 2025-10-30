// IEmployeeVisitor.cs
public interface IEmployeeVisitor
{
    string VisitDeveloper(Developer developer);
    string VisitManager(Manager manager);
}

// Employee.cs
public abstract class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }

    // Accept returns the visitor result (in this case, the generated report)
    public abstract string Accept(IEmployeeVisitor visitor);
}

// Developer.cs
public class Developer : Employee
{
    public string ProgrammingLanguage { get; set; }

    public override string Accept(IEmployeeVisitor visitor)
    {
        return visitor.VisitDeveloper(this);
    }
}

// Manager.cs
public class Manager : Employee
{
    public int TeamSize { get; set; }

    public override string Accept(IEmployeeVisitor visitor)
    {
        return visitor.VisitManager(this);
    }
}

// ReportVisitor.cs
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