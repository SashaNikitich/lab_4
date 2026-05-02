namespace lab_4;

public class Sentence
{
    private List<Word> _words = new();
    private List<Punct> _puncts = new();

    public Sentence(IEnumerable<Word> words, IEnumerable<Punct> puncts)
    {
        _words.AddRange(words);
        _puncts.AddRange(puncts);
    }

    public int WordCount => _words.Count;

    public override string ToString()
    {
        return string.Join(" ", _words) + string.Concat(_puncts);
    }
}
