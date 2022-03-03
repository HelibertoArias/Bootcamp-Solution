using static System.Console;
namespace DelegateFuncConsoleApp
{
    public class Demo01
    {

        // - A Delegate is a pointer to a function.
        public delegate void Greeting(string message);




        public void GreetLowercase(string message)
        {
            WriteLine(message.ToLower());
        }

        public void GreetUppercase(string message)
        {
            WriteLine(message.ToUpper());
        }

        public void GreetNormal(string message)
        {
            WriteLine(message);
        }


        public void SetGreet(int printMode, string message)
        {
            //if (printMode == -1)
            //{
            //    GreetLowercase(message);
            //}
            //else if (printMode == 0)
            //{
            //    GreetNormal(message);
            //}
            //else if (printMode == 1)
            //{
            //    GreetUppercase(message);
            //}

            //else if (printMode == 2)
            //{
            //    GreetLowercase(message);
            //    GreetUppercase(message);
            //    GreetNormal(message);
            //}


















            //switch (printMode)
            //{
            //    case -1:
            //        GreetLowercase(message);
            //        break;
            //    case 0:
            //        GreetNormal(message);
            //        break;
            //    case 1:
            //        GreetUppercase(message);
            //        break;
            //    case 2:
            //        GreetLowercase(message);
            //        GreetUppercase(message);
            //        GreetNormal(message);
            //        break;
            //    default:

            //        break;
            //}


























            Greeting grettingReference;
            switch (printMode)
            {
                case -1:
                    grettingReference = GreetLowercase;
                    break;
                case 0:
                    grettingReference = GreetNormal;
                    break;
                case 1:
                    grettingReference = GreetUppercase;
                    break;
                case 2:
                    grettingReference = GreetLowercase;
                    grettingReference += GreetNormal;
                    grettingReference += GreetUppercase;
                    break;

                default:
                    grettingReference = delegate (string message)
                    {
                        WriteLine($"What!!!, { message }");
                    };
                    break;
            }

            /*
             asdasdfas
             
             
             */

            grettingReference.Invoke(message);
        }





    }
}
