namespace lab_4;

/// <summary>
/// Represents a sentence composed of words and punctuation marks.
/// Internally stores sentence elements such as words and punctuation
/// in a unified collection.
/// </summary>
/// <remarks>
/// This class is also used to model an NPC entity,
/// where specific elements of the sentence represent
/// name, surname, hobby, experience points (XP), and age.
/// </remarks>
public class Sentence
{
    /// <summary>
    /// Internal collection of sentence elements.
    /// Elements may include <see cref="Word"/> and <see cref="Punct"/> objects.
    /// </summary>
    private readonly List<object> _elements = new();

    /// <summary>
    /// Gets the name extracted from the sentence.
    /// </summary>
    public string Name => _elements[0].ToString()!;

    /// <summary>
    /// Gets the surname extracted from the sentence.
    /// </summary>
    public string Surname => _elements[1].ToString()!;

    /// <summary>
    /// Gets the hobby extracted from the sentence.
    /// </summary>
    public string Hobby => _elements[2].ToString()!;

    /// <summary>
    /// Gets the experience points (XP) extracted from the sentence.
    /// </summary>
    public int Xp => int.Parse(_elements[3].ToString()!);

    /// <summary>
    /// Gets the age extracted from the sentence.
    /// </summary>
    public int Age => int.Parse(_elements[4].ToString()!);

    /// <summary>
    /// Initializes a new instance of the <see cref="Sentence"/> class
    /// using NPC-related data.
    /// </summary>
    /// <param name="name">The name value.</param>
    /// <param name="surname">The surname value.</param>
    /// <param name="hobby">The hobby value.</param>
    /// <param name="xp">Experience points.</param>
    /// <param name="age">Age value.</param>
    public Sentence(string name, string surname, string hobby, int xp, int age)
    {
        _elements.Add(new Word(name));
        _elements.Add(new Word(surname));
        _elements.Add(new Word(hobby));
        _elements.Add(new Word(xp.ToString()));
        _elements.Add(new Word(age.ToString()));
        _elements.Add(new Punct('.'));
    }

    /// <summary>
    /// Determines whether the specified object is equal to the current sentence.
    /// </summary>
    /// <param name="obj">The object to compare with the current sentence.</param>
    /// <returns>
    /// <c>true</c> if the specified object is a <see cref="Sentence"/> and
    /// contains the same key values; otherwise, <c>false</c>.
    /// </returns>
    public override bool Equals(object? obj)
    {
        if (obj is Sentence other)
        {
            return Name == other.Name &&
                   Surname == other.Surname &&
                   Xp == other.Xp &&
                   Age == other.Age;
        }

        return false;
    }

    /// <summary>
    /// Determines whether two <see cref="Sentence"/> objects are equal
    /// by comparing their internal elements.
    /// </summary>
    /// <param name="other">Another sentence to compare.</param>
    /// <returns>
    /// <c>true</c> if the internal element collections are equal;
    /// otherwise, <c>false</c>.
    /// </returns>
    protected bool Equals(Sentence other)
    {
        return _elements.Equals(other._elements);
    }

    /// <summary>
    /// Returns a hash code for the current sentence.
    /// </summary>
    /// <returns>
    /// A hash code based on the internal elements collection.
    /// </returns>
    public override int GetHashCode()
    {
        return _elements.GetHashCode();
    }

    /// <summary>
    /// Returns a formatted string representation of the sentence.
    /// </summary>
    /// <returns>
    /// A string containing NPC information in a readable format.
    /// </returns>
    public override string ToString()
    {
        return $"{Name,-8} | Surname: {Surname,-10} | Hobby: {Hobby,-11} | XP: {Xp,-5} | Age: {Age}";
    }
}
