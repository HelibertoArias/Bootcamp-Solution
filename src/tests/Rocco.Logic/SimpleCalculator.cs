// <copyright file="SimpleCalculator.cs" company="Rocco Company">
// Copyright (c) 2022, Heliberto Arias
// </copyright>

namespace Rocco.Logic;
public class SimpleCalculator
{

    public int SumPositiveNumbers(int a, int b)
    {        
        // A complex calcultation task here
        if( a < 0 || b < 0)
        {
            throw new ArgumentException("Only positive numbers are valid in this operation");
        }
        return Math.Abs( a ) + Math.Abs(b);
    }

    public int SumBasic(int a, int b)
    {
        // A complex calcultation task here
        return a + b;
    }

    public int SumComplex(Item a, Item b)
    {
        // A complex calcultation task here
        return a.Value + b.Value;
    }

}
