namespace task_one;
internal class Kettle : Device
{
    public string? Color { get; }
    public int Capacity { get; }
    public Kettle(string name, string description, string color, int capacity) :
        base(name, description)
    {
        Color = color;
        Capacity = capacity;
    }
    public override void Sound()
    {
        Console.WriteLine("Pheeeeow!");
    }
    public override string ToString()
    {
        return base.ToString() + $"Color - {Color}\nCapacity - {Capacity}";
    }
}

