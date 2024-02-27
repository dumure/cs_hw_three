namespace task_one;
internal class Microwave : Device
{
    public int Power { get; }
    public int MaxTemp { get; }
    public Microwave(string name, string description, int power, int maxtemp) :
        base(name, description)
    {
        Power = power;
        MaxTemp = maxtemp;
    }
    public override void Sound()
    {
        Console.WriteLine("Beep-beep-beep!");
    }
    public override string ToString()
    {
        return base.ToString() + $"Power - {Power}W\nMax temperature - {MaxTemp}°C / {MaxTemp / 5 * 9 + 32}°F";
    }
}