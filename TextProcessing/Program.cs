using System.Net.WebSockets;

namespace TextProcessing
{
    internal class Program
    {
        static void Main()
        {
            string name = new string(new char[] { 'G', 'e', 'o' });
            Console.WriteLine(name);

            string symbol = new string('*', 100);
            Console.WriteLine(symbol);

            string result = string.Concat("Hello", "Georgi");
            Console.WriteLine(result);

            string test = "Georgi G";
            Console.WriteLine(test.Contains("G"));
            Console.WriteLine(test.Contains("y"));
            Console.WriteLine(test.Contains(" "));
            Console.WriteLine(test.IndexOf("G"));
            Console.WriteLine(test.LastIndexOf("G"));
            Console.WriteLine(test.IndexOf("X"));

            string text = "ABC";
            Console.WriteLine(text.Substring(0, 2));
            Console.WriteLine(text.Substring(0, text.Length));

            string text2 = "ABCDEFG";
            Console.WriteLine(text2.Substring(2, text.Length - 2));
            Console.WriteLine(text2.Substring(3));



        }
    }
}