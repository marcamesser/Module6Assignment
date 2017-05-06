using System;
using System.Collections.Generic;

namespace Module6Assignment
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // declare students
            Student Joey = new Student("Joey", "Freshwater", 01);
            Student Jimmy = new Student("Jimmy", "Chestnut", 02);
            Student Lane = new Student("Lane", "Kiffin", 03);
            Student[] StudentArray = {Joey, Jimmy, Lane};

            // declare teacher
            Teacher Butch = new Teacher("Butch", "Jones", 01);
            Teacher[] TeacherArray = {Butch};

            // declare course
            Course Prog = new Course("Programming with C#", "P01", StudentArray, TeacherArray);
            Course[] CourseArray = {Prog};

            // declare degree
            Degree Bach = new Degree("Bachelor of Science", CourseArray);
            Degree[] DegreeArray = {Bach};

            // declare program
            UProgram IT = new UProgram("Information Technology",DegreeArray);

            Console.WriteLine("The {0} program contains the {1} degree.", IT.ProgramName, IT.ProgramDegree);
            Console.WriteLine("The {0} degree contains the course {1}.", Bach.DegreeName, Bach.DegreeCourse);
            Console.WriteLine("The {0} course contains {1} student(s).", Prog.CourseName, Student.SCount );
            Joey.SayName();
            Butch.SayTeacherID();

        }
    }
}