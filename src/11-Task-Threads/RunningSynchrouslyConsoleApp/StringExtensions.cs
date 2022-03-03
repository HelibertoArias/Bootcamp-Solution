using System.Text.RegularExpressions;

namespace RunningSynchrouslyConsoleApp;

public static class StringExtensions
{
    public static Task<bool> IsValidXmlTag(this string input)
    {
        if (input == null)
        {
            return Task.FromException<bool>(new ArgumentNullException("Missing input parameter."));
        }

        if (input.Length == 0)
        {
            return Task.FromException<bool>(new ArgumentException("Input parameter is empty."));
        }
        var output = Regex.IsMatch(input, @"^<([a-z]+)([^<]+)*(?:>(.*)<\/\1>|\s+\/>)$");

        return Task.FromResult(output);
    }
}

