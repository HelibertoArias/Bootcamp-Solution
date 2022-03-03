using System;

namespace Jalasoft.Entities;

public abstract class Client
{
    // Abstract: Method without body, requires implementation
    public abstract string GetName();

    // Virtual: can override this method
    public virtual double Discount()
    {
        return 0.1;
    }
}

// Concrete
public class RetailClient : Client
{
    public override string GetName()
    {
        return $"I am a retail client. Discount: {Discount() * 100 }%";
        // throw new System.NotImplementedException();
    }
}

public class WholeSaleClient : Client
{
    public override string GetName()
    {
        return $"I am a whosale client. Discount: {Discount() * 100 }%";
        // throw new System.NotImplementedException();
    }

    public override double Discount()
    {
        return Math.Round( base.Discount() + 0.259, 3);
    }
}






