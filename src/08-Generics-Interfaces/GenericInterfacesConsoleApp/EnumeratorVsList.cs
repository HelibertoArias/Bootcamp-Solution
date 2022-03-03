using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterfacesConsoleApp
{
    public static class EnumeratorVsList
    {
        public static void FillAndIterate()
        {
            IEnumerable<int> Integers()
            {
                yield return 1;
                yield return 2;
                yield return 3;
            }

            foreach (int i in Integers())
            {
                Console.WriteLine(i.ToString());
            }

            List<int> list = new List<int>(){
                1,
                2,
                3 };

            foreach (int i in list)
            {
                Console.WriteLine(i.ToString());
            }

        }
    }
}
