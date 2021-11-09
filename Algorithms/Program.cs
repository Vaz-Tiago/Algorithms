using Algorithms;

Console.WriteLine("Quantity of items: ");
int quantity = int.Parse(Console.ReadLine());

#region Sort
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
        InsertionSort.Sort(students, students.Length - 1);
        Utils.Print(students);
        break;
    case 2:
        SelectionSort.Sort(students, students.Length);
        Utils.Print(students);
        break;
    case 3:
        MergeSort.Sort(students, 0, students.Length);
        Utils.Print(students);
        break;
    case 4:
        QuickSort.Sort(students, 0, students.Length - 1);
        Utils.Print(students);
        break;
}

#endregion


#region Search
Console.WriteLine("Search a grade? (1 - Yes, 2 - No)");
bool hasSearch = int.Parse(Console.ReadLine()) == 1;

if (hasSearch)
{
    var searchList = Constants.GetSearchList();
    Console.WriteLine("Choose the algorithm");
    PrintOptions(searchList);

    int search = 0;
    while (!searchList.ContainsKey(search))
        search = int.Parse(Console.ReadLine());


    int searchIndex;
    Console.WriteLine("Type de student id: ");
    searchIndex = int.Parse(Console.ReadLine());
    switch (search)
    {
        case 1:
            searchIndex = BinarySearch.Search(students, 0, students.Length, searchIndex);
            break;
        default:
            searchIndex = -1;
            break;
    }

    Console.WriteLine("---------------");
    if(searchIndex >= 0)
    {
        Student student = students[searchIndex];
        Console.WriteLine(student.ToString());
    }
    else
        Console.WriteLine("Student not found.");
}else
{
    Console.WriteLine("Thank you!");
}

#endregion



async Task<Student[]> GetStudents(int quantity)
{
    List<string> nameList = await Utils.ProccessNames(quantity);
    Student[] students = new Student[quantity];
    for (int i = 0; i < quantity; i++)
    {
        Random random = new Random();
        int id = random.Next(1000);
        students[i] = new Student(nameList[i], id);
    }

    return students;
}

void PrintOptions(Dictionary<int, string> list)
{
    foreach (var item in list)
        Console.WriteLine($"{item.Key} - {item.Value}");
}