namespace Algorithms
{
    public class Student
    {
        public Student(string name, int grade)
        {
            this.name = name;
            this.Id = grade;
        }

        private string name { get; set; }
        private int Id { get; set; }

        public string GetName() => name;
        public int GetId() => Id;

        public override string ToString()
        {
            return $"Id: {this.Id} - Name: {this.name}";
        }

    }
}
