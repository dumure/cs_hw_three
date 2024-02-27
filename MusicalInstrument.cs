namespace task_two;
internal abstract class MusicalInstrument
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public DateTime Created { get; }
    public MusicalInstrument(string name, string description)
    {
        Name = name;
        Description = description;
        Created = DateTime.Now;
    }
    public void Show()
    {
        Console.WriteLine($"Name: {Name}");
    }
    public void Desc()
    {
        Console.WriteLine($"Description: {Description}");
    }
    public void History()
    {
        Console.WriteLine($"Creation date: {Created.ToString("dd-MM-yyyy HH:mm")}");
    }
    public abstract void Sound();
    public override string ToString()
    {
        return $"Name - {Name}\nDescription - {Description}\nCreation date - {Created.ToString("dd-MM-yyyy HH:mm")}\n";
    }
}
