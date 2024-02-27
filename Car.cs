namespace task_one;
internal class Car : Device
{
    public string? Mark { get; }
    public int MaxSpeed { get; }
    public Car(string name, string description, string mark, int maxspeed) :
        base(name, description)
    {
        Mark = mark;
        MaxSpeed = maxspeed;
    }
    public override void Sound()
    {
        Console.WriteLine("Wroom-wroom!");
    }
    public override string ToString()
    {
        return base.ToString() + $"Mark - {Mark}\nMax speed - {MaxSpeed}";
    }
}