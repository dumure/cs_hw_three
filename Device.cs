namespace task_one;
internal abstract class Device
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public Device(string name, string description)
    {
        Name = name;
        Description = description;
    }
    public void Show()
    {
        Console.WriteLine($"Name: {Name}");
    }
    public void Desc()
    {
        Console.WriteLine($"Description: {Description}");
    }
    public abstract void Sound();
    public override string ToString()
    {
        return $"Name - {Name}\nDescription - {Description}\n";
    }
}

