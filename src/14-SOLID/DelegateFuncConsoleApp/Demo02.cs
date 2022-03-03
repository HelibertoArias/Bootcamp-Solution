namespace DelegateFuncConsoleApp
{
    //public class Logger
    //{


    //    public void LogEvent(string desc, DateTime time)
    //    {
    //        //some sort of logging happens here
    //        Console.WriteLine($"{desc} - {time.ToShortDateString()}");
    //    }
    //}


    //public class Email
    //{
    //    private Logger logger = new Logger();


    //    public void Send()
    //    {
    //        //Omitted code that sends.
    //        logger.LogEvent("An email was sent", DateTime.Now);
    //    }
    //}

















































    /*
     * 
     * - For notifications between class is possible to use Events or Delegates but .Net framework provide a built-in solution, EventHandler Delegate. 
     * - For delegates without data use EventHandler or use EventHandler<TEventArg> delegate for events that include data to be sent to handlers.
     * - Advantages to use delegate is that your code will be loosely couple this means a better code for maintenance and encouraging code reuse.
     * 
    */


    public class Logger
    {
        public void Email_OnSent(object sender, EventArgs e)
        {
            LogEvent("Message Sent", DateTime.Now);
        }

        public void LogEvent(string desc, DateTime time)
        {
            //some sort of logging happens here
            Console.WriteLine($"{desc} - {time.ToShortDateString()}");
        }
    }


    public class Email
    {
        public event EventHandler<EventArgs> Sent;
        private void OnSent(EventArgs e)
        {
            if (Sent != null)
                Sent(this, e);
        }

        public void Send()
        {
            //Omitted code that sends.

            OnSent(new EventArgs());//raise the event
        }
    }


}
