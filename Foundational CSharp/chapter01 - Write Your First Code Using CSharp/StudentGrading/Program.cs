class Student
{
    public string Name { get; set; }
    public List<int> Assignments { get; set; }

    public decimal Grade { get; private set; }
    public char GradeLetter { get; private set; }

    public Student(string name, List<int> assignments)
    {
        Name = name;
        Assignments = assignments;
        UpdateGrades();
    }

    public Student(string name, params int[] assignments)
    {
        Name = name;
        Assignments = new List<int>(assignments);
        UpdateGrades();
    }

    public Student(string name)
    {
        Name = name;
        Assignments = new List<int>();
        UpdateGrades();
    }

    private void UpdateGrades()
    {
        CalculateGrade();
        CalculateGradeLetter();
    }

    public void AddAssignment(int assignment)
    {
        Assignments.Add(assignment);
        UpdateGrades();
    }

    public void CalculateGrade()
    {
        if (Assignments.Count == 0){
            Grade = 0;
            return;
        }

        int sum = 0;
        foreach (var score in Assignments)
        {
            sum += score;
        }
        Grade = (decimal)sum / Assignments.Count;
    }

    public void CalculateGradeLetter()
    {
        char letter;
        if (Grade >= 90) letter = 'A';
        else if (Grade >= 80) letter = 'B';
        else if (Grade >= 70) letter = 'C';
        else if (Grade >= 60) letter = 'D';
        else if (Grade >= 50) letter = 'E';
        else letter = 'F';
        GradeLetter = letter;
    }
}


class Program
{
    private static void PrintStudent(Student s)
    {
        Console.WriteLine($"{(s.Name + "").PadRight(20)} {s.Grade} {s.GradeLetter}");
    }
    public static void Main()
    {
        Student sophia = new Student("Sophia", 93, 87, 98, 95, 100);
        Student nicolas = new Student("Nicolas", 80, 83, 82, 88, 85);
        Student zahirah = new Student("Zahirah", 84, 96, 73, 85, 79);
        Student jeong = new Student("Jeong", 90, 92, 98, 100, 97);

        Program.PrintStudent(sophia);
        Program.PrintStudent(nicolas);
        Program.PrintStudent(zahirah);
        Program.PrintStudent(jeong);

    }
}






