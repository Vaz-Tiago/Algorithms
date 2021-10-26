using Algorithms;


Console.WriteLine("Qauntity of items: ");
int quantity = int.Parse(Console.ReadLine());

Student[] students = await GetStudents(quantity);
Console.WriteLine("Unsorted list: ");
Utils.Print(students);
Console.WriteLine("---------------");
MergeSort.Sort(students, 0, students.Length);
Utils.Print(students);



async Task<Student[]> GetStudents(int quantity)
{
    List<string> nameList = await Utils.ProccessNames(quantity);
    Student[] students = new Student[quantity];
    for (int i = 0; i < quantity; i++)
    {
        Random random = new Random();
        double grade = random.NextDouble() * 10;
        students[i] = new Student(nameList[i], grade);
    }

    return students;
}

