namespace OOPConsoleApp.Helpers;
public static class StringHelper
{
    public static string GetUniqueIdentifier()
    {
        return Guid.NewGuid().ToString();
    }
}
 
