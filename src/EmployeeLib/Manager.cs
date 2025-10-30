namespace EmployeeLib
{
    public class Manager : Employee
    {
        public int TeamSize { get; set; }

        public override string Accept(IEmployeeVisitor visitor)
        {
            return visitor.VisitManager(this);
        }
    }
}
