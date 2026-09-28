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