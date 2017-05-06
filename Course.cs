namespace Module6Assignment
{
    public class Course
    {
        // constructor
        public Course(string CName, string CID, Student[] CStudent, Teacher[] CTeacher)
        {
            this.CourseName = CName;
            this.CourseID = CID;
            this.CourseStudent = CStudent;
            this.CourseTeacher = CTeacher;
        }
        // the following statements declare private member variables

        private string _CourseName;

        private string _CourseID;

        private Student[] _CourseStudent;

        private Teacher[] _CourseTeacher;

        public string CourseName
        {
            get => _CourseName;
            set => _CourseName = value;
        }

        public string CourseID
        {
            get => _CourseID;
            set => _CourseID = value;
        }

        public Student[] CourseStudent
        {
            get => _CourseStudent;
            set => _CourseStudent = value;
        }

        public Teacher[] CourseTeacher
        {
            get => _CourseTeacher;
            set => _CourseTeacher = value;
        }

        // the following statements declare public methods
        public void DisplayStudents()
        {
            foreach (Student i in CourseStudent)
            {
                System.Console.WriteLine("{0}", i);
            }
        }

        public void DisplayTeachers()
        {
            foreach (Teacher i in CourseTeacher)
            {
                System.Console.WriteLine("{0}", i);
            }
        }
    }
}