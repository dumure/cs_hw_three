namespace task_two;
internal class Cello : MusicalInstrument
{
    public int Pegs { get; }
    public int Weight { get; }
    public Cello(string name, string description, int pegs, int weight) :
        base(name, description)
    {
        Pegs = pegs;
        Weight = weight;
    }
    public override void Sound()
    {
        Console.WriteLine("Eeeeee-oooooo-eeeeee!");
    }
    public override string ToString()
    {
        return base.ToString() + $"Pegs - {Pegs}\nWeight - {Weight}";
    }
}