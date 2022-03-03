using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkConsoleApp
{
    public static class SearchFind
    {

        public static void Run()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            Monitoring.Recorder.Start();
            var path = $"{Directory.GetCurrentDirectory()}\\search-add-find.txt";
            var lines = File.ReadAllLinesAsync(path).Result;



            List<List<string>> queries = new List<List<string>>();

            var addDictionary = new Dictionary<int, string>();
            var findDictionary = new Dictionary<int, string>();

            var iterate = lines.Skip(1).ToList();

            //iterate.Clear();
            //iterate.Add("add ed");
            //iterate.Add("add eddie");
            //iterate.Add("add edward");
            //iterate.Add("find ed");
            //iterate.Add("add edwina");
            //iterate.Add("find edw");
            //iterate.Add("find a");

            for (int i = 0; i < iterate.Count(); i++)
            {
                if (iterate[i].Substring(0, 3).Equals("add"))
                {
                    addDictionary.Add(i, iterate[i].Substring(3));
                }
                else
                {
                    findDictionary.Add(i, iterate[i].Substring(4));
                }

            }

            List<int> result = SearchFind.Contacts(addDictionary, findDictionary);


            //textWriter.Close();
            Monitoring.Recorder.Stop();
        }



        public static List<int> Contacts(Dictionary<int, string> addDictionary, Dictionary<int, string> findDictionary)
        {
            var result = new List<int>();
            int counter = 1;

            foreach (var keyPair in findDictionary)
            {
                if (counter % 1000 == 0)
                {
                    Console.Write($"{counter}, ");
                }
                var matches = addDictionary
                                .Where(x => x.Key < keyPair.Key && x.Value.StartsWith(keyPair.Value)).Count();
                result.Add(matches);
                counter++;
            }

            //List<Task<int>> tasks = new List<Task<int>>();

            //foreach (var keyPair in findDictionary)
            //{


            //    tasks.Add(Task.Factory.StartNew(() =>
            //    {
            //        if (counter % 1000 == 0)
            //        {
            //            Console.Write($"{counter}, ");
            //        }

            //        var matches = addDictionary
            //                    .Where(x => x.Key < keyPair.Key)
            //                    .Where(x => x.Value.StartsWith(keyPair.Value)).Count();

            //        return matches;
            //        counter++;
            //    }));

            //}

            //var tastAll = Task.WhenAll(tasks);

            //Console.WriteLine(String.Join(", ", tastAll.Result));


            return result;
        }

    }
}
