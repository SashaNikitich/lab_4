namespace lab_4;

/// <summary>
/// Entry point of the application.
/// Demonstrates initialization, sorting, searching,
/// and output of Sentence objects.
/// </summary>
class Program
{
    /// <summary>
    /// The main method of the program.
    /// </summary>
    public static void Main()
    {
        // Array of Sentence objects with initial data
        Sentence?[] npcSentences =
        [
            new("Sasha", "Nikitich", "programming", 67, 17),
            new("Bogdan", "Tsiapko", "programming", 69, 17),
            new("Dmytro", "Pankevich", "cooking", 911, 19),
            new("Max", "Shapirenko", "fighting", 42, 18),
            new("Danya", "Sych", "running", 52, 25)
        ];

        Text myText = new Text(npcSentences);
        Sentence?[] sentences = myText.GetSentences();

        // Output initial list
        Console.WriteLine("\nInitial list:\n");
        PrintArr(sentences);

        // Sorting by Age (ascending) and XP (descending)
        var sortedSentences = sentences
            .OrderBy(s => s!.Age)
            .ThenByDescending(s => s!.Xp)
            .ToArray();

        // Output sorted list
        Console.WriteLine("\nSorted list:\n");
        PrintArr(sortedSentences);

        // Search for identical object
        Sentence target = new Sentence("Sasha", "Nikitich", "programming", 67, 17);
        Sentence? found = Array.Find(sortedSentences, s => s!.Equals(target));

        Console.WriteLine("\nSearch for Sasha Nikitich:");
        Console.WriteLine(found != null ? $"Found: {found}" : "Not found");
    }

    /// <summary>
    /// Prints an array of Sentence objects.
    /// </summary>
    /// <param name="arr">Array of Sentence objects.</param>
    public static void PrintArr(Sentence?[] arr)
    {
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }
}