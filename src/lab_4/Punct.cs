namespace lab_4;

/// <summary>
/// Represents a single punctuation mark within a sentence.
/// </summary>
/// <remarks>
/// This class is used to encapsulate punctuation characters
/// such as '.', ',', '!', '?', etc., allowing them to be treated
/// as separate objects within text processing logic.
/// </remarks>
public class Punct
{
    /// <summary>
    /// Gets the punctuation character.
    /// </summary>
    public char Mark { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Punct"/> class.
    /// </summary>
    /// <param name="mark">
    /// A character representing a punctuation mark.
    /// </param>
    public Punct(char mark)
    {
        Mark = mark;
    }

    /// <summary>
    /// Returns the string representation of the punctuation mark.
    /// </summary>
    /// <returns>
    /// A string containing the punctuation character.
    /// </returns>
    public override string ToString()
    {
        return Mark.ToString();
    }
}