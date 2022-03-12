// <copyright file="ValidationException.cs" company="Rocco Company">
// Copyright (c) 2022, Heliberto Arias
// </copyright>

namespace Rocco.Logic.Exceptions;

public class ValidationException : Exception
{
    public ValidationException(string name, object key)
      : base($"{name} has validation errors")
    {
    }
}
