namespace HW;

public class Truck : IVechicle
{
    public string? Name { get; set ; }

    public void Move()
    {
        Console.WriteLine("Truck moved");
    }
}
