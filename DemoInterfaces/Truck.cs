namespace DemoInterfaces;

public class Truck : Car, IBaggageCarrier
{
    public override void MakeSound()
    {
        Console.WriteLine("La cocaracha!");
    }

    public override void Move()
    {
        Console.WriteLine("BROOOOOOOOOH!");
    }

    public double Capacity { get; set; }
}