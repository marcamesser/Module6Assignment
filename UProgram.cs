namespace Module6Assignment
{
    public class UProgram
    {
        // constructor
        public UProgram(string PName, Degree[] PDegree)
        {
            this.ProgramName = PName;
            this.ProgramDegree = PDegree;
        }

        // the following statements declare private member variables
        private string _ProgramName;

        private Degree[] _ProgramDegree;

        public string ProgramName
        {
            get => _ProgramName;
            set => _ProgramName = value;
        }

        public Degree[] ProgramDegree
        {
            get => _ProgramDegree;
            set => _ProgramDegree = value;
        }

        // the following statements declare public methods
        public void DisplayDegrees()
        {
            foreach (Degree i in ProgramDegree)
            {
                System.Console.WriteLine("{0}", i);
            }
        }
    }
}