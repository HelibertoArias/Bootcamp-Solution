namespace Jalasoft.Entities;
public class Car
{
    public int Id { get; set; }

    public Engine Engine { get; set; }

    public Wheel Wheel { get; set; }

}

public class CarDriver
{
    public Car Car { get; set; }

    public Person SeatDriver { get; set; }
}
