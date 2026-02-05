namespace lab_4;

/// <summary>
/// Represents a single word consisting of a collection of letters.
/// </summary>
/// <remarks>
/// The <see cref="Word"/> class encapsulates a word as an array of
/// <see cref="Letter"/> objects, allowing character-level processing
/// while still providing convenient string access.
/// </remarks>
public class Word
{
    /// <summary>
    /// Internal array of letters that form the word.
    /// </summary>
    private readonly Letter[] _letters;

    /// <summary>
    /// Gets the full textual content of the word.
    /// </summary>
    public string Content => string.Join("", _letters.Select(l => l.Value));

    /// <summary>
    /// Initializes a new instance of the <see cref="Word"/> class
    /// from the specified string.
    /// </summary>
    /// <param name="word">
    /// A string representing the word.
    /// </param>
    public Word(string word)
    {
        _letters = word.Select(c => new Letter(c)).ToArray();
    }

    /// <summary>
    /// Returns the string representation of the word.
    /// </summary>
    /// <returns>
    /// The textual content of the word.
    /// </returns>
    public override string ToString()
    {
        return Content;
    }
}