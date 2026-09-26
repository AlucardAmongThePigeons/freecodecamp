/*
You're developing a Student GPA Calculator that will help calculate students' overall Grade Point Average. The parameters for your application are:

    You're given the student's name and class information.
    Each class has a name, the student's grade, and the number of credit hours for that class.
    Your application needs to perform basic math operations to calculate the GPA for the given student.
    Your application needs to output/display the student’s name, class information, and GPA.

To calculate the GPA:

    Multiply the grade value for a course by the number of credit hours for that course.
    Do this for each course, then add these results together.
    Divide the resulting sum by the total number of credit hours.

You're provided with the following sample of a student's course information and GPA:

Student: Sophia Johnson

Course          Grade   Credit Hours	
English 101         4       3
Algebra 101         3       3
Biology 101         3       4
Computer Science I  3       4
Psychology 101      4       3

Final GPA:          3.35
*/

class Course
{
    public string Name { get; private set; }
    public int Grade { get; private set; }
    public int CreditHours { get; private set; }

    public Course(string name, int grade, int creditHours)
    {
        this.Name = name;
        this.Grade = grade;
        this.CreditHours = creditHours;
    }
}

class Program
{
    public static void Main()
    {

        string studentName = "Sophia Johnson";
        List<Course> courses = [
            new Course("English 101", 4, 3),
            new Course("Algebra 101", 3,3),
            new Course("Biology 101",3,4),
            new Course("Computer Science I",3,4),
            new Course("Psychology 101",4,3)
        ];

        int totalCreditHours = 0;
        double totalGradePoints = 0;
        

        Console.WriteLine($"Student: {studentName}\n");
        Console.WriteLine($"{"Name".PadRight(25)}{"Grade".PadLeft(7)}{"Credit Hours".PadLeft(14)}");
        foreach(var course in courses)
        {
            Console.WriteLine($"{course.Name.PadRight(25)}{course.Grade.ToString().PadLeft(7)}{course.CreditHours.ToString().PadLeft(14)}");
            totalCreditHours += course.CreditHours;
            totalGradePoints += course.CreditHours * course.Grade;
        }

        double GPA = totalGradePoints / totalCreditHours;

        Console.WriteLine($"\nGPA: {GPA:0.00}");
    }
}


