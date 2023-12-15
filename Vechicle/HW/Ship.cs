namespace HW;

public class Ship : IVechicle
{
    public string? Name { get; set; }

    public void Move()
    {
        Console.WriteLine("Ship moved");
    }
}
