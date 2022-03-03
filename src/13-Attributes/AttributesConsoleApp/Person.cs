using System.ComponentModel.DataAnnotations; //  [Required], [StringLength(150)]
using System.Diagnostics;
using static System.Console;
namespace AttributesConsoleApp;

[DebuggerDisplay("Current name is = {FirstName} {LastName}")]
public class Person
{
    [Required]
    [StringLength(150)]
    public string FirstName { get; set; }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [Display("Hello ", ConsoleColor.Green)]
    public string LastName { get; set; }

    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public List<string> Options { get; private set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    public Person(string firstName, string lastName)
    {
        OutputDebugInfo();
        OutputDebugExtraInfo();


        FirstName = firstName;
        LastName = lastName;
        Options = new List<string>() { "Option 1", "Option 2", "Option 3" };
    }

    //public override string ToString()
    //{
    //    return $"{ FirstName} {LastName}";
    //}

    //[Obsolete]
    //[Obsolete("You should use 'NewCalculateSales' instead.")]
    //[Obsolete("You should use 'NewCalculateSales' instead.", error:true)]
    public int CalculateSales()
    {
        return new Random().Next(100, 500);
    }

    public int NewCalculateSales()
    {
        return new Random().Next(100, 500);
    }

    // [Conditional("DEBUG")]
    public void OutputDebugInfo()
    {
        WriteLine("Running in debug mode");
    }

    //[Conditional("EXTRA")]
    // Extra will be a custom "C# preprocessor directives"
    // More info https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/preprocessor-directives
    public void OutputDebugExtraInfo()
    {
 
        WriteLine("Extra condition mode");
    }



}



 


// ======DisplayAttribute
[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
public class DisplayAttribute : Attribute
{
    public string Label { get; set; }

    public ConsoleColor Color { get; private set; }

    public DisplayAttribute(string label, ConsoleColor color = ConsoleColor.White)
    {
        Label = label ?? throw new ArgumentNullException(nameof(label));
        Color = color;
    }
}
