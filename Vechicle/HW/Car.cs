namespace HW;

public class Car : IVechicle
{
    public string? Name { get; set; }

    public void Move()
    {
        Console.WriteLine("Car moved");
    }
}
