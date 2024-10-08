﻿using OOPConsoleApp.Entities.Interfaces;

namespace OOPConsoleApp.Entities;

public class WashingMachine : IProduct, IPhysicalProduct
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Type { get; set; }

    public int HeightDimension { get; set; }
    public int WidthDimension { get; set; }
}

