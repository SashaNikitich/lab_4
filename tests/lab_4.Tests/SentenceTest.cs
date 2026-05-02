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
    [Test]
    public void Constructor_ShouldInitializePropertiesCorrectly()
    {
        var npc = new Npc("Vasya", "Bovdurito", "reading", 100, 21);

        Assert.Multiple(() =>
        {
            Assert.That(npc.Name,    Is.EqualTo("Vasya"));
            Assert.That(npc.Surname, Is.EqualTo("Bovdurito"));
            Assert.That(npc.Hobby,   Is.EqualTo("reading"));
            Assert.That(npc.Xp,      Is.EqualTo(100));
            Assert.That(npc.Age,     Is.EqualTo(21));
        });
    }

    [Test]
    public void ToString_ShouldContainAllFields()
    {
        var npc = new Npc("Vasya", "Bovdurito", "reading", 100, 21);

        string output = npc.ToString();

        Assert.Multiple(() =>
        {
            Assert.That(output, Does.Contain("Vasya"));
            Assert.That(output, Does.Contain("Bovdurito"));
            Assert.That(output, Does.Contain("reading"));
            Assert.That(output, Does.Contain("100"));
            Assert.That(output, Does.Contain("21"));
        });
    }

    [Test]
    public void Equals_ShouldReturnTrue_WhenIdentical()
    {
        var n1 = new Npc("Sasha", "Nikitich", "programming", 67, 17);
        var n2 = new Npc("Sasha", "Nikitich", "programming", 67, 17);

        Assert.That(n1.Equals(n2), Is.True);
    }

    [Test]
    public void Equals_ShouldReturnFalse_WhenDifferent()
    {
        var n1 = new Npc("Sasha", "Nikitich", "programming", 67, 17);
        var n2 = new Npc("Sasha", "Nikitich", "programming", 99, 17);

        Assert.That(n1.Equals(n2), Is.False);
    }

    [Test]
    public void GetHashCode_ShouldBeEqual_WhenObjectsAreEqual()
    {
        var n1 = new Npc("Sasha", "Nikitich", "programming", 67, 17);
        var n2 = new Npc("Sasha", "Nikitich", "programming", 67, 17);

        Assert.That(n1.GetHashCode(), Is.EqualTo(n2.GetHashCode()));
    }

    [Test]
    public void Sorting_ShouldOrderByAgeThenByXpDescending()
    {
        var youngHigh = new Npc("Young", "HighXP", "test", 100, 18);
        var youngLow  = new Npc("Young", "LowXP",  "test",  50, 18);
        var old        = new Npc("Old",   "AnyXP",  "test",  80, 25);

        var sorted = new[] { old, youngLow, youngHigh }
            .OrderBy(n => n.Age)
            .ThenByDescending(n => n.Xp)
            .ToArray();

        Assert.Multiple(() =>
        {
            Assert.That(sorted[0], Is.EqualTo(youngHigh)); // 18 років, 100 XP
            Assert.That(sorted[1], Is.EqualTo(youngLow));  // 18 років, 50 XP
            Assert.That(sorted[2], Is.EqualTo(old));        // 25 років
        });
    }

    [Test]
    public void CleanString_ShouldReplaceTabsAndExtraSpaces()
    {
        string input    = "Word1\t\tWord2   Word3";
        string expected = "Word1 Word2 Word3";

        Assert.That(Text.CleanString(input), Is.EqualTo(expected));
    }
}
