using System;
namespace ConstVarDrill162
{
    public class Employee
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public DateTime HireDate { get; set; }

        // Chained the two Employee constructors together 
        public Employee(string lastName, string firstName, int Id) : this(lastName, firstName, Id, DateTime.Today)
        {

        }

        public Employee(string lastName, string firstName, int Id, DateTime hireDate)
        {
            LastName = lastName;
            FirstName = firstName;
            ID = Id;
            HireDate = hireDate;
        }

    }
}
