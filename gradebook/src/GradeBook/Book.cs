namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            this.Grades = new List<double>();
            this.Name = name;
        }
        public void AddGrades(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                this.Grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }

        }
        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Agerage = 0.0;
            result.LowValue = double.MaxValue;
            result.HighValue = double.MinValue;

            foreach (var grade in this.Grades)
            {
                result.LowValue = Math.Min(grade, result.LowValue);
                result.HighValue = Math.Max(grade, result.HighValue);
                result.Agerage += grade;
            }
            result.Agerage /= Grades.Count;

            switch (result.Agerage)
            {
                case var d when d >= 90.0:
                    result.Letter = 'A';
                    break;
                case var d when d >= 80.0:
                    result.Letter = 'B';
                    break;
                case var d when d >= 70.0:
                    result.Letter = 'C';
                    break;
                case var d when d >= 60.0:
                    result.Letter = 'D';
                    break;

                default:
                    result.Letter = 'F';
                    break;
            }

            return result;
        }
        public List<double> Grades { get; set; }
        public string Name { get; set; }
    }
}