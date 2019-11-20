using System;
namespace Inheritance120and124
{
    // Inherited from Person class
    public class Employee : Person
    {
        // Employee ID
        public int Id { get; set; }

        // implementing the method from Person class
        public new void SayName()
        {
            base.SayName();
        }
    }
}
