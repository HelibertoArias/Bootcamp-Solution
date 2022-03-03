
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
