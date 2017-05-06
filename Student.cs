using System;

namespace Module6Assignment
{
    public class Student : Person
    {
        public static int SCount = 0;
        // constructor
        public Student(string SFName, string SLName, int StID)
        {
            this.FirstName = SFName;
            this.LastName = SLName;
            this.StudentID = StID;
            SCount++;
        }

        // the following statements declare private member variables
        private int _StudentID;


        public int StudentID
        {
            get => _StudentID;
            set => _StudentID = value;
        }

        public void SayStudentID()
        {
            Console.WriteLine("My student ID is {0}", StudentID);
        }
    }
}