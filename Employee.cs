using System;
using System.Runtime.ConstrainedExecution;

namespace Module6Assignment
{
    public abstract class Employee
    {
        //variables
        private string empNumber;
        private string firstName;
        private string lastName;
        private string address;

        //properties
        public string EmpNumber
        {
            get => empNumber;
            set => empNumber = value;
        }

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public string Address
        {
            get => address;
            set => address = value;
        }

        //methods
        public virtual void Login()
        {
            Console.WriteLine("Employee Login");
        }

        public abstract void Hire();

    }
}