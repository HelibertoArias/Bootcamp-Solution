namespace OOPConsoleApp.Extensions;

public static class ArrayExtension
{
    public static int WordCount(this string str)
    {
        return str.Split(new char[] { ' ', '.', '?' },
                         StringSplitOptions.RemoveEmptyEntries).Length;
    }

    public static string GetFirstItem(this string[] value)
    {
        return $"First: {value[0]}";
    }

    public static string GetNameWeekDay(this decimal value)
    {

        var isPossible = int.TryParse(value.ToString(), out int result);
        if (!isPossible)
        {
            return string.Empty;
        }

        var dayOfWeek = baseCalcule(result);


        return string.Empty;
    }

    //interface INumber
    //{
    //    //
    //}
    //public static string GetNameWeekDay(this INumber value) {  }

    public static string GetNameWeekDay(this int value)
    {
        var dayOfWeek = string.Empty;

        dayOfWeek = baseCalcule(value);

        return dayOfWeek;
    }

    private static string baseCalcule(int value)
    {
        string dayOfWeek;
        switch (value)
        {
            case 1:
                dayOfWeek = DayOfWeek.Monday.ToString();
                break;
            case 2:
                dayOfWeek = DayOfWeek.Tuesday.ToString();
                break;
            case 3:
                dayOfWeek = DayOfWeek.Wednesday.ToString();
                break;
            case 4:
                dayOfWeek = DayOfWeek.Thursday.ToString();
                break;
            case 5:
                dayOfWeek = DayOfWeek.Friday.ToString();
                break;
            default:
                dayOfWeek = "Wrong number";
                break;
        }

        return dayOfWeek;
    }
}

