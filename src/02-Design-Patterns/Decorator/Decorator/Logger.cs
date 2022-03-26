namespace Decorator
{

    public class Logger: ILogger
    {
        public void Info(string message)
        {
            Console.WriteLine(message);
        }
    }
}
