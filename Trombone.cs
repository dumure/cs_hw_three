namespace task_two;
internal class Trombone : MusicalInstrument
{
    public int Tone { get; }
    public int Frets { get; }
    public Trombone(string name, string description, int tone, int frets) :
        base(name, description)
    {
        Tone = tone;
        Frets = frets;
    }
    public override void Sound()
    {
        Console.WriteLine("Boooo-booo-booooo!");
    }
    public override string ToString()
    {
        return base.ToString() + $"Tone - {Tone}\nFrets - {Frets}";
    }
}