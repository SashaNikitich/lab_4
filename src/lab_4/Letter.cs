namespace lab_4;

/// <summary>
/// Represents a single letter (character) as a building block of text.
/// </summary>
/// <summary>
/// Represents a single letter.
/// </summary>
public class Letter
{
    public char Value { get; }
    public Letter(char value) => Value = value;
    public override string ToString() => Value.ToString();
}