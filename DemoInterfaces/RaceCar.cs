namespace DemoInterfaces;

public class RaceCar : Car
{
    public override void MakeSound()
    {
        Console.WriteLine("...");
    }

    public override void Move()
    {
        Console.WriteLine("Vrooooom!");
    }
}