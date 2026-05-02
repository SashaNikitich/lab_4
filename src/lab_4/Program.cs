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
        var npcs = new List<Npc>
        {
            new("Sasha", "Nikitich", "programming", 67, 17),
            new("Bogdan", "Tsiapko", "programming", 69, 17),
            new("Dmytro", "Pankevich", "cooking", 911, 19),
            new("Max", "Shapirenko", "fighting", 42, 18),
            new("Danya", "Sych", "running", 52, 25),
        };

        // Output initial list
        Console.WriteLine("\nInitial list:\n");
        npcs.ForEach(Console.WriteLine);

        // Sorting by Age (ascending) and XP (descending)
        var sorted = npcs
            .OrderBy(s => s.Age)
            .ThenByDescending(s => s.Xp)
            .ToList();

        // Output sorted list
        Console.WriteLine("\nSorted list:\n");
        sorted.ForEach(Console.WriteLine);

        // Search for identical object
        var target = new Npc("Sasha", "Nikitich", "programming", 67, 17);
        var found = npcs.Find(n => n.Equals(target));

        Console.WriteLine("\nSearch for Sasha Nikitich:");
        Console.WriteLine(found != null ? $"Found: {found}" : "Not found");
    }
}