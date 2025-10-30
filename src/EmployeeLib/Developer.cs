namespace EmployeeLib
{
    public class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public override string Accept(IEmployeeVisitor visitor)
        {
            return visitor.VisitDeveloper(this);
        }
    }
}
