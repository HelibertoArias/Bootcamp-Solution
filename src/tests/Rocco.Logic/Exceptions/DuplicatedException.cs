// <copyright file="NotFoundException.cs" company="Rocco Company">
// Copyright (c) 2022, Heliberto Arias
// </copyright>

namespace Rocco.Logic.Exceptions;

public class DuplicatedException : Exception
{
    public DuplicatedException(string name, object key)
        : base($"{name} ({key}) already exists!")
    {
    }
}
