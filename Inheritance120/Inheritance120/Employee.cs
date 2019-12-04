using System;
using System.Collections.Generic;
using InheritanceDrills;

namespace Inheritance
{
    // Inherited from Person class
    public class Employee<T> : Person, IQuittable
    {
        // Employee ID
        public int ID { get; set; }

        public List<T> Things { get; set; }







        // operator == overloaded to compare employees by IDs
        //public static bool operator ==(Employee employee1, Employee employee2)
        //{
        //    return employee1.ID == employee2.ID;
        //}

        //public static bool operator !=(Employee employee1, Employee employee2)
        //{
        //    return employee1.ID != employee2.ID;

        //}

        //public override bool Equals(object obj)
        //{
        //    Employee employee = obj as Employee;
        //    return employee != null && ID.Equals(employee.ID);
        //}

        //implementing the method from Person class
        public new void SayName()
        {
            base.SayName();
        }

        public void Quit()
        {
            Console.WriteLine("Quit Method Called");
        }

        public static implicit operator Employee<T>(Employee<int> v)
        {
            throw new NotImplementedException();
        }
    }
}






