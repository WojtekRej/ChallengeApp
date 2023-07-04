namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        // konstruktor. składa się z właściwości i metod 
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        // propercje czyli właściwości dla obiektów w klasie
        public string Name { get; private set; }

        public string Surname { get; private set; }

        // metoda
        public void AddGrade(float grade) 
        {
            int valueInInt = (int)grade;
            // walidacja, można wprowadzić oceny tylko z przedziału od 0 do 100
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else 
            {
                Console.WriteLine("Invalid grade value");
            }
        }
        // przerobienie string na float metodą Parse

        public void AddGrade(string grade)
        {
            if(float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
            // var value = float.Parse(grade);
            // this.AddGrade(value);
        }
        public void AddGrade(double grade)
        {
            // rzutowanie na float
            float gradesAsFloat = (float)grade;
            this.AddGrade(gradesAsFloat);

        }

        public void AddGrade(int grade)
        {
            float gradesAsFloat = grade;
            this.AddGrade(gradesAsFloat);
        }

        public Statistics GetStatistics() 
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach(var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average = statistics.Average / this.grades.Count; 
            return statistics;
        }
    }
}
