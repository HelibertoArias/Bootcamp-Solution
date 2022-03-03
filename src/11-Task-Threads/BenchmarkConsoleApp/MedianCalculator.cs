using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkConsoleApp
{
    public class MedianCalculator
    {
        private List<int> values = new List<int>();
        public MedianCalculator()
        {
            //values = new List<int> { 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //values = new List<int> {  1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //values = new List<int> { 2, 6, 5, 3, 4, 1 };

            var path = $"{Directory.GetCurrentDirectory()}\\median-data.txt";
            var lines = File.ReadAllLinesAsync(path).Result;

            foreach (var item in lines.Take(1000))
            {
                values.Add(int.Parse(item));
            }

            Monitoring.Recorder.Start();
            Initial();
            Monitoring.Recorder.Stop();

            Console.WriteLine("======================");

            Monitoring.Recorder.Start();
            var result = Version01(values);
            Monitoring.Recorder.Stop();

            //var expected = new List<double>() { 1.0, 1.5, 2.0, 2.5, 3.0, 3.5, 4.0, 4.5, 5.0, 5.5 };
            //if (Enumerable.SequenceEqual(result, expected))
            //{
            //    Console.WriteLine("OK");
            //}
            //else { Console.WriteLine("Failed"); }

            //Console.WriteLine("Result " + String.Join(", ", result));
            //Console.WriteLine("Expected " + String.Join(", ", expected));
            //Console.WriteLine("Input " + String.Join(", ", values));




        }


        public List<double> Initial()
        {

            var result = new List<double>();
            for (int index = 0; index < values.Count; index++)
            {
                var position = index + 1;
                var temValues = values.Take(position).OrderBy(x => x).ToList();

                if (position % 2 == 0)
                {
                    var median = (temValues[index / 2] + temValues[index / 2 + 1]) / 2D;
                    result.Add(median);
                }
                else
                {
                    if (position == 1) { result.Add(temValues.First()); }
                    else
                    {
                        result.Add(temValues.Skip((position - 1) / 2).First());
                    }
                }
            }
            return result;

        }


        //public List<double> Version01(List<int> values)
        //{

        //    //var result = new List<double>();

        //    var result = Enumerable.Range(1, values.Count)
        //         .Select(position =>
        //         {
        //             if (position == 1) { return values[0]; }
        //             else
        //             {
        //                 var valuesSorted = values.Take(position).OrderBy(x => x).ToList();

        //                 if(position % 2 == 0)
        //                 {
        //                     return (valuesSorted.ElementAt(position/2-1) + valuesSorted.ElementAt(position / 2 ))/2D;
        //                 }
        //                 else
        //                 {
        //                     return valuesSorted.ElementAt((position-1)/2);
        //                 }

        //             }
        //         }


        //         ).ToList();


        //    return result;

        //} 

        public List<double> Version01(List<int> values)
        {

            var result = new List<double>();

            if ((values.Count - 1) >0)
            {
                var subValues = values.Take(values.Count - 1).ToList();
                var subResult = Version01(subValues);
                result.AddRange(subResult);
            }

          


            if (values.Count == 1) { result.Add(values[0]); }
            else if (values.Count % 2 == 0)
            {

                var position = values.Count / 2;
                var valuesSorted = values.OrderBy(x => x).ToList();
                result.Add(valuesSorted.Skip(position - 1).Take(2).Average());

            }
            else
            {
                var position = 1 + ((values.Count - 1) / 2);
                var valuesSorted = values.OrderBy(x => x);
                result.Add(valuesSorted.Skip(position - 1).First());
            }


          

            
           



            return result;

        }






    }
}
