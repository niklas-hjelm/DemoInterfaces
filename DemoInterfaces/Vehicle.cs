namespace DemoInterfaces;

public abstract class Vehicle
{
    public string Content { get; set; }

    public virtual void MakeSound()
    {
        Console.WriteLine("HOOOOONK!");
    }

    public virtual void Move()
    {
        Console.WriteLine("BRRRRRR!");
    }
}