namespace Algorithms
{
    public class Student
    {
        public Student(string name, double grade)
        {
            this.name = name;
            this.grade = grade;
        }

        private string name { get; set; }
        private double grade { get; set; }

        public string GetName() => name;
        public double GetGrade() => grade;

        public override string ToString()
        {
            return $"Grade: {this.grade:N2} - Name: {this.name}";
        }

    }
}
