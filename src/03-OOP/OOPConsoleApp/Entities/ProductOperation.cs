// File ProductOperation.cs
namespace OOPConsoleApp.Entities;
public partial class Product
{
    public void ApplyDiscount()
    {
        /* Using the Decimal.Multiply will force
          the multiply to take inputs of type decimal */
        this.Price = Decimal.Multiply(this.Price, (7 / 100));
    }
}