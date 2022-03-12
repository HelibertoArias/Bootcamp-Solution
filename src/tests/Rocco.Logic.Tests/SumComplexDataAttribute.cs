// <copyright file="SumComplexDataAttribute.cs" company="Rocco Company">
// Copyright (c) 2022, Heliberto Arias
// </copyright>

using System.Collections.Generic;
using System.Reflection;
using Xunit.Sdk;

namespace Rocco.Logic.Tests;

public class SumComplexDataAttribute : DataAttribute
{
    public override IEnumerable<object[]> GetData(MethodInfo method)
    {
        yield return new object[] { new Item { Value = 0 }, new Item { Value = 0 }, 0 };
        yield return new object[] { new Item { Value = 1 }, new Item { Value = 2 }, 3 };
        yield return new object[] { new Item { Value = -1 }, new Item { Value = 2 }, 1 };
        yield return new object[] { new Item { Value = 1 }, new Item { Value = -3 }, -2 };
    }
}
