public interface IEmployeeVisitor
{
    string VisitDeveloper(Developer developer);
    string VisitManager(Manager manager);
}
