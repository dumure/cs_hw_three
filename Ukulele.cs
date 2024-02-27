namespace task_two;
internal class Ukulele : MusicalInstrument
{
    public string Material { get; }
    public int Size { get; }
    public Ukulele(string name, string description, string material, int size) :
        base(name, description)
    {
        Material = material;
        Size = size;
    }
    public override void Sound()
    {
        Console.WriteLine("Drin-drin-drin!");
    }
    public override string ToString()
    {
        return base.ToString() + $"Material - {Material}\nSize - {Size}";
    }
}