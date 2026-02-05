namespace lab_4.Tests;

/// <summary>
/// Contains unit tests for core functionality
/// of the lab_4 application.
/// </summary>
/// <remarks>
/// Tests cover sentence creation, equality comparison,
/// sorting logic, and text normalization.
/// NUnit framework is used.
/// </remarks>
[TestFixture]
public class ProgramTest
{
    /// <summary>
    /// Verifies that the <see cref="Sentence"/> constructor
    /// correctly initializes properties and that
    /// <see cref="Sentence.ToString"/> returns valid output.
    /// </summary>
    [Test]
    public void Sentence_Constructor_ShouldInitializeCorrectly()
    {
        // Arrange
        var sentence = new Sentence("Vasya", "Bovdurito", "reading", 100, 21);

        // Act
        string output = sentence.ToString();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(output, Does.Contain("Vasya"));
            Assert.That(output, Does.Contain("Bovdurito"));
            Assert.That(sentence.Age, Is.EqualTo(21));
            Assert.That(sentence.Xp, Is.EqualTo(100));
        });
    }

    /// <summary>
    /// Verifies that <see cref="Sentence.Equals(object)"/>
    /// returns <c>true</c> for two identical sentence objects.
    /// </summary>
    [Test]
    public void Equals_ShouldReturnTrue_WhenObjectsAreIdentical()
    {
        // Arrange
        var s1 = new Sentence("Sasha", "Nikitich", "programming", 67, 17);
        var s2 = new Sentence("Sasha", "Nikitich", "programming", 67, 17);

        // Act & Assert
        Assert.That(s1.Equals(s2), Is.True);
    }

    /// <summary>
    /// Verifies correct sorting of sentences:
    /// first by Age in ascending order,
    /// then by XP in descending order.
    /// </summary>
    [Test]
    public void Sorting_ShouldOrderCorrectly()
    {
        // Arrange
        var s1 = new Sentence("Young", "HighXP", "test", 100, 18);
        var s2 = new Sentence("Young", "LowXP", "test", 50, 18);
        var s3 = new Sentence("Old", "AnyXP", "test", 80, 25);

        Sentence[] list = { s3, s2, s1 };

        // Act
        var sorted = list
            .OrderBy(s => s.Age)
            .ThenByDescending(s => s.Xp)
            .ToArray();

        // Assert
        Assert.That(sorted[0], Is.EqualTo(s1)); // 18 years, 100 XP
        Assert.That(sorted[1], Is.EqualTo(s2)); // 18 years, 50 XP
        Assert.That(sorted[2], Is.EqualTo(s3)); // 25 years
    }

    /// <summary>
    /// Verifies that the <see cref="Text.CleanString(string)"/> method
    /// correctly removes extra spaces and tab characters.
    /// </summary>
    [Test]
    public void Text_CleanString_ShouldHandleTabsAndSpaces()
    {
        // Arrange
        string input = "Word1\t\tWord2   Word3";
        string expected = "Word1 Word2 Word3";

        // Act
        string actual = Text.CleanString(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
