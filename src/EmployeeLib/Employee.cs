namespace EmployeeLib
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public abstract string Accept(IEmployeeVisitor visitor);
    }
}
