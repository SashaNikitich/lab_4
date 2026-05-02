namespace lab_4;

public class Npc
{
    public string Name { get; }
    public string Surname { get; }
    public string Hobby { get; }
    public int Xp { get; }
    public int Age { get; }

    public Npc(string name, string surname, string hobby, int xp, int age)
    {
        Name = name;
        Surname = surname;
        Hobby = hobby;
        Xp = xp;
        Age = age;
    }

    public override bool Equals(object? obj)
    {
        return obj is Npc other &&
               Name == other.Name &&
               Surname == other.Surname &&
               Hobby == other.Hobby &&
               Xp == other.Xp &&
               Age == other.Age;
    }

    public override int GetHashCode() => HashCode.Combine(Name, Surname, Hobby, Xp, Age);

    public override string ToString() =>
        $"{Name,-8} | Surname: {Surname,-10} | Hobby: {Hobby,-11} | XP: {Xp,-5} | Age: {Age}";
}