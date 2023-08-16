using System.Diagnostics;

namespace Collection.ListPerformance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            List<string> list = new List<string>();

            stopWatch.Start();
            string file = @"D:\Temp\13_6_1_Text.txt";

            if (File.Exists(file))
            {
                using (StreamReader sr = File.OpenText(file))
                {
                    string s = sr.ReadToEnd();
                    char[] delimiters = { ' ', '\r', '\n' };
                    string[] w = s.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in w)
                        list.Add(word);
                }
            }

            stopWatch.Stop();
            Console.WriteLine($"Прошло {stopWatch.Elapsed.Milliseconds} миллисек.");

            Console.ReadKey();
        }
    }
}