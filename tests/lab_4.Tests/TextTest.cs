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
public class TextTests
{
    [Test]
    [TestCase("Слово1\tСлово2",           "Слово1 Слово2", Description = "Заміна табуляції")]
    [TestCase("Слово1    Слово2",          "Слово1 Слово2", Description = "Заміна кількох пробілів")]
    [TestCase("\t  Слово1  \t  Слово2  ", "Слово1 Слово2", Description = "Комбінація з обрізанням")]
    public void CleanString_ShouldNormalizeWhitespace(string input, string expected)
    {
        Assert.That(Text.CleanString(input), Is.EqualTo(expected));
    }

    [Test]
    public void GetSentences_ShouldReturnProvidedArray()
    {
        var sentences = new Sentence[]
        {
            new(new[] { new Word("Hello") }, Array.Empty<Punct>()),
            new(new[] { new Word("World") }, Array.Empty<Punct>()),
        };

        var text   = new Text(sentences);
        var result = text.GetSentences();

        Assert.Multiple(() =>
        {
            Assert.That(result,        Is.Not.Null);
            Assert.That(result.Length, Is.EqualTo(2));
        });
    }

    [Test]
    public void GetSentences_ShouldHandleEmptyArray()
    {
        var text = new Text(Array.Empty<Sentence>());

        Assert.That(text.GetSentences(), Is.Empty);
    }
}
