using Algorithms;

Console.WriteLine("Quantity of items: ");
int quantity = int.Parse(Console.ReadLine());

var optionList = Constants.GetSortList();
Console.WriteLine("Choose the algorithm: ");
PrintOptions(optionList);
int sort = 0;
while (!optionList.ContainsKey(sort))
    sort =  int.Parse(Console.ReadLine());

Student[] students = await GetStudents(quantity);
Console.WriteLine("---------------");
Console.WriteLine("Unsorted list: ");
Utils.Print(students);
Console.WriteLine("---------------");

switch (sort)
{
    case 1:
        MergeSort.Sort(students, 0, students.Length);
        Utils.Print(students);
        break;
    case 2:
        Console.WriteLine("Not implemented.");
        break;
}









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

void PrintOptions(Dictionary<int, string> list)
{
    foreach (var item in list)
        Console.WriteLine($"{item.Key} - {item.Value}");
}