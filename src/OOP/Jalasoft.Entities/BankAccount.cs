namespace Jalasoft.Entities;
public class BankAccount
{
    public int Id { get; set; }

    public decimal Balance { get; set; }

    public string Name { get; set; }

    public void Deposit(decimal value){ /* TODO */}

    public void WithDraw(decimal value) { /* TODO */}
}

