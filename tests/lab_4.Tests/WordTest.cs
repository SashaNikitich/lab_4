namespace lab_4.Tests;

/// <summary>
/// Contains unit tests for the <see cref="Word"/> class.
/// </summary>
/// <remarks>
/// Tests verify correct conversion of strings into letter collections,
/// handling of empty input, and preservation of character order.
/// NUnit framework is used.
/// </remarks>
[TestFixture]
public class WordTest
{
    /// <summary>
    /// Verifies that the constructor correctly converts
    /// a string into a collection of <see cref="Letter"/> objects.
    /// </summary>
    [Test]
    public void Constructor_ShouldConvertStringToLetters()
    {
        // Arrange
        string input = "Sasha";

        // Act
        var word = new Word(input);

        // Assert
        Assert.That(word.ToString(), Is.EqualTo(input));
    }

    /// <summary>
    /// Verifies that an empty string produces
    /// an empty word content.
    /// </summary>
    [Test]
    public void Word_EmptyString_ShouldReturnEmptyContent()
    {
        // Arrange
        var word = new Word(string.Empty);

        // Act & Assert
        Assert.That(word.Content, Is.EqualTo(string.Empty));
    }

    /// <summary>
    /// Verifies that each character in the input string
    /// is preserved in the correct order within the word.
    /// </summary>
    [Test]
    public void Word_ShouldMaintainCharacterIntegrity()
    {
        // Arrange
        string input = "NPC";
        var word = new Word(input);

        // Act
        string result = word.Content;

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Length, Is.EqualTo(3));
            Assert.That(result[0], Is.EqualTo('N'));
            Assert.That(result[2], Is.EqualTo('C'));
        });
    }
}