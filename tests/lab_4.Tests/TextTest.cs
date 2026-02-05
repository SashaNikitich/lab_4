namespace lab_4.Tests;

/// <summary>
/// Contains unit tests for the <see cref="Text"/> class.
/// </summary>
/// <remarks>
/// Tests verify whitespace normalization,
/// sentence storage, and edge-case handling.
/// NUnit framework is used.
/// </remarks>
[TestFixture]
public class TextTest
{
    /// <summary>
    /// Verifies that the <see cref="Text.CleanString(string)"/> method
    /// correctly replaces tabs and multiple spaces
    /// with a single space.
    /// </summary>
    [Test]
    [TestCase("Слово1\tСлово2", "Слово1 Слово2", Description = "Tab replacement")]
    [TestCase("Слово1    Слово2", "Слово1 Слово2", Description = "Multiple spaces replacement")]
    [TestCase("\t  Слово1  \t  Слово2  ", "Слово1 Слово2", Description = "Combination with trimming")]
    public void CleanString_ShouldNormalizeWhitespace(string input, string expected)
    {
        // Act
        string actual = Text.CleanString(input);

        // Assert
        Assert.That(
            actual,
            Is.EqualTo(expected),
            $"Text should be normalized for input: {input}"
        );
    }

    /// <summary>
    /// Verifies that the <see cref="Text"/> class
    /// correctly stores and returns an array of sentences.
    /// </summary>
    [Test]
    public void GetSentences_ShouldReturnProvidedArray()
    {
        // Arrange
        Sentence[] inputSentences =
        [
            new Sentence("Sasha", "Nikitich", "programming", 67, 17),
            new Sentence("Bogdan", "Tsiapko", "programming", 69, 17)
        ];

        var text = new Text(inputSentences);

        // Act
        var result = text.GetSentences();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Length, Is.EqualTo(2));
            Assert.That(result[0]?.Name, Is.EqualTo("Sasha"));
            Assert.That(result[1]?.Name, Is.EqualTo("Bogdan"));
        });
    }

    /// <summary>
    /// Verifies that the <see cref="Text"/> class
    /// correctly handles an empty array of sentences.
    /// </summary>
    [Test]
    public void Text_ShouldHandleEmptyArray()
    {
        // Arrange
        Sentence?[] emptyArr = [];
        var text = new Text(emptyArr);

        // Act & Assert
        Assert.That(text.GetSentences(), Is.Empty);
    }
}
