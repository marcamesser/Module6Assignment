namespace Module6Assignment
{
    public class Degree
    {
        // constructor
        public Degree(string DName, Course[] DCourse)
        {
            this.DegreeName = DName;
            this.DegreeCourse = DCourse;
        }

        // the following statements declare private member variables
        private string _DegreeName;

        private Course[] _DegreeCourses;

        public string DegreeName
        {
            get => _DegreeName;
            set => _DegreeName = value;
        }

        public Course[] DegreeCourse
        {
            get => _DegreeCourses;
            set => _DegreeCourses = value;
        }

        // the following statements declare public methods
        public void DisplayCourses()
        {
            foreach (Course i in DegreeCourse)
            {
                System.Console.WriteLine("{0}", i);
            }
        }
    }
}