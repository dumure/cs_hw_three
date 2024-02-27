namespace task_two;
internal class Violin : MusicalInstrument
{
    public string? Mark { get; }
    public string? Shape { get; }
    public Violin(string name, string description, string mark, string shape) :
        base(name, description)
    {
        Mark = mark;
        Shape = shape;
    }
    public override void Sound()
    {
        Console.WriteLine("Ee-oo-ee-ooo-ee-o-eee-o!");
    }
    public override string ToString()
    {
        return base.ToString() + $"Mark - {Mark}\nShape - {Shape}";
    }
}