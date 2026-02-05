namespace lab_4;

using System.Text.RegularExpressions;

/// <summary>
/// Represents a complete text composed of multiple sentences.
/// Provides access to stored sentences and utilities
/// for basic text normalization.
/// </summary>
/// <remarks>
/// This class acts as a container for <see cref="Sentence"/> objects
/// and may be extended with additional text-processing logic
/// such as parsing, filtering, or formatting.
/// </remarks>
public class Text
{
    /// <summary>
    /// Internal collection of sentences that form the text.
    /// </summary>
    private readonly Sentence?[] _sentences;

    /// <summary>
    /// Initializes a new instance of the <see cref="Text"/> class.
    /// </summary>
    /// <param name="sentences">
    /// An array of <see cref="Sentence"/> objects representing the text.
    /// </param>
    public Text(Sentence?[] sentences)
    {
        _sentences = sentences;
    }

    /// <summary>
    /// Returns all sentences contained in the text.
    /// </summary>
    /// <returns>
    /// An array of <see cref="Sentence"/> objects.
    /// </returns>
    public Sentence?[] GetSentences()
    {
        return _sentences;
    }

    /// <summary>
    /// Normalizes a string by replacing multiple spaces and tabs
    /// with a single space and trimming leading and trailing whitespace.
    /// </summary>
    /// <param name="input">
    /// The input string to be cleaned.
    /// </param>
    /// <returns>
    /// A cleaned and normalized string.
    /// </returns>
    public static string CleanString(string input)
    {
        return Regex.Replace(input, @"[\t ]+", " ").Trim();
    }
}