namespace lab_4.Tests;

/// <summary>
/// Contains unit tests for the <see cref="Sentence"/> class.
/// </summary>
/// <remarks>
/// These tests verify correct object initialization,
/// equality comparison, and string representation.
/// NUnit framework is used.
/// </remarks>
[TestFixture]
public class SentenceTest
{
    /// <summary>
    /// Verifies that the constructor correctly initializes
    /// all properties of the <see cref="Sentence"/> object.
    /// </summary>
    [Test]
    public void Constructor_ShouldPopulatePropertiesCorrectly()
    {
        // Arrange
        var sentence = new Sentence("Ivan", "Ivanov", "testing", 500, 22);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(sentence.Name, Is.EqualTo("Ivan"));
            Assert.That(sentence.Surname, Is.EqualTo("Ivanov"));
            Assert.That(sentence.Hobby, Is.EqualTo("testing"));
            Assert.That(sentence.Xp, Is.EqualTo(500));
            Assert.That(sentence.Age, Is.EqualTo(22));
        });
    }

    /// <summary>
    /// Verifies that <see cref="Sentence.Equals(object)"/>
    /// returns <c>true</c> for objects with identical data.
    /// </summary>
    [Test]
    public void Equals_ShouldReturnTrue_ForMatchingData()
    {
        // Arrange
        var s1 = new Sentence("Sasha", "Nikitich", "programming", 67, 17);
        var s2 = new Sentence("Sasha", "Nikitich", "programming", 67, 17);

        // Act & Assert
        Assert.That(s1.Equals(s2), Is.True);
    }

    /// <summary>
    /// Verifies that <see cref="Sentence.Equals(object)"/>
    /// returns <c>false</c> for objects with different data.
    /// </summary>
    [Test]
    public void Equals_ShouldReturnFalse_ForDifferentData()
    {
        // Arrange
        var s1 = new Sentence("Sasha", "Nikitich", "programming", 67, 17);
        var s2 = new Sentence("Max", "Shapirenko", "fighting", 42, 18);

        // Act & Assert
        Assert.That(s1.Equals(s2), Is.False);
    }

    /// <summary>
    /// Verifies that <see cref="Sentence.ToString"/>
    /// returns a properly formatted string representation.
    /// </summary>
    [Test]
    public void ToString_ShouldReturnFormattedString()
    {
        // Arrange
        var s = new Sentence("Danya", "Sych", "running", 52, 25);

        // Act
        var result = s.ToString();

        // Assert
        Assert.That(result, Does.Contain("Danya"));
        Assert.That(result, Does.Contain("Surname: Sych"));
        Assert.That(result, Does.Contain("XP: 52"));
    }
}
