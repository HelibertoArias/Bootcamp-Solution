using Monitoring;
using static System.Console;



int[] numbers = Enumerable.Range(start: 1, count: 50_000).ToArray();


//=============================================================================
// String with "+"
//=============================================================================
WriteLine("\n//=============================================================================");
WriteLine("// Using string with + ");
WriteLine("//=============================================================================");

Recorder.Start();

string s = string.Empty; // i.e. "";

for (int i = 0; i < numbers.Length; i++)
{
    s += numbers[i] + ", ";
}
Recorder.Stop();




//WriteLine("\n//=============================================================================");
//WriteLine("// Using StringBuilder ");
//WriteLine("//=============================================================================");


//Recorder.Start();

//System.Text.StringBuilder builder = new();

//for (int i = 0; i < numbers.Length; i++)
//{
//    builder.Append(numbers[i]);
//    builder.Append(", ");
//}
//Recorder.Stop();

