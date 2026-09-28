#region Roll a dice Example (random numbers)
{
    Console.WriteLine("\nRoll a dice Example (random numbers):");

    Random dice = new Random();
    int roll = dice.Next(1, 7);
    Console.WriteLine($"The dice rolls and... {roll}");
}
#endregion

#region Larger value
Console.WriteLine("\nLarger value:");

int firstValue = 500;
int secondValue = 600;
int smallerValue = System.Math.Min(firstValue, secondValue);
int largerValue = System.Math.Max(firstValue, secondValue);
Console.WriteLine(smallerValue == largerValue ? $"{smallerValue} = {largerValue}" : $"{smallerValue} < {largerValue}");
#endregion

#region Exercise: Fraudulent order
{
    Console.WriteLine("\nExercise: Fraudulent order");

    string[] ids = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
    List<string> fraudulentIds = new List<string>();
    foreach (string id in ids)
    {
        if (id.StartsWith('B'))
        {
            fraudulentIds.Add(id);
            Console.WriteLine($"Fraudulent id found: {id}");
        }
    }
}
#endregion

#region Guided Project - Foreach and If-ElseIf-Else Student Grading System
{
    // 1. Inizializzazione dati (Arrays unidimensionali)
    int examAssignments = 5;

    string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan"];

    int[] sophiaScores = [90, 86, 87, 98, 100, 94, 90];
    int[] andrewScores = [92, 89, 81, 96, 90, 89];
    int[] emmaScores = [90, 85, 87, 98, 68, 89, 89, 89];
    int[] loganScores = [90, 95, 87, 88, 96, 96];

    int[] studentScores = new int[10];
    string currentStudentLetterGrade = "";

    // Intestazione del report
    Console.WriteLine("Student\t\tGrade\tLetter Grade\n");

    // 2. Iterazione sui nomi degli studenti
    foreach (string name in studentNames)
    {
        string currentStudent = name;

        // Mappatura dinamica degli array in base allo studente corrente
        if (currentStudent == "Sophia")
            studentScores = sophiaScores;
        else if (currentStudent == "Andrew")
            studentScores = andrewScores;
        else if (currentStudent == "Emma")
            studentScores = emmaScores;
        else if (currentStudent == "Logan")
            studentScores = loganScores;

        int sumAssignmentScores = 0;
        decimal currentStudentGrade = 0m;
        int gradedAssignments = 0;

        // 3. Calcolo somma voti tramite foreach (lettura read-only degli elementi dell'array)
        foreach (int score in studentScores)
        {
            gradedAssignments++;

            if (gradedAssignments <= examAssignments)
                sumAssignmentScores += score;
            else
                sumAssignmentScores += (int)(score / 10); // Extra credit weighted
        }

        // Cast esplicito a decimal per evitare la truncation della divisione intera
        currentStudentGrade = (decimal)sumAssignmentScores / examAssignments;

        // 4. Mappatura Voto Numerico -> Letter Grade tramite if / else-if
        if (currentStudentGrade >= 97)
            currentStudentLetterGrade = "A+";
        else if (currentStudentGrade >= 93)
            currentStudentLetterGrade = "A";
        else if (currentStudentGrade >= 90)
            currentStudentLetterGrade = "A-";
        else if (currentStudentGrade >= 87)
            currentStudentLetterGrade = "B+";
        else if (currentStudentGrade >= 83)
            currentStudentLetterGrade = "B";
        else if (currentStudentGrade >= 80)
            currentStudentLetterGrade = "B-";
        else if (currentStudentGrade >= 77)
            currentStudentLetterGrade = "C+";
        else if (currentStudentGrade >= 73)
            currentStudentLetterGrade = "C";
        else if (currentStudentGrade >= 70)
            currentStudentLetterGrade = "C-";
        else if (currentStudentGrade >= 67)
            currentStudentLetterGrade = "D+";
        else if (currentStudentGrade >= 63)
            currentStudentLetterGrade = "D";
        else if (currentStudentGrade >= 60)
            currentStudentLetterGrade = "D-";
        else
            currentStudentLetterGrade = "F";

        // Output formattato
        Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade:F1}\t{currentStudentLetterGrade}");
    }
}
#endregion