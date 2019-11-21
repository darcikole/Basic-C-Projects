using System;
using InheritanceDrills;

namespace Inheritance
{
    // Inherited from Person class
    public class Employee : Person, IQuittable
    {
        // Employee ID
        public int Id { get; set; }

        // implementing the method from Person class
        public new void SayName()
        {
            base.SayName();
        }

        public void Quit()
        {
            Console.WriteLine("Quit Method Called");
        }
    }
}
