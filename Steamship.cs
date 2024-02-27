namespace task_one;
internal class Steamship : Device
{
    public int Length { get; }
    public int Weight { get; }
    public Steamship(string name, string description, int length, int weight) :
        base(name, description)
    {
        Length = length;
        Weight = weight;
    }
    public override void Sound()
    {
        Console.WriteLine("Bozzzzz!");
    }
    public override string ToString()
    {
        return base.ToString() + $"Length - {Length}\nWeight - {Weight}";
    }
}