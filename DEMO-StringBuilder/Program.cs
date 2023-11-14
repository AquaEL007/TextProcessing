using System.Diagnostics;
using System.Text;

namespace DEMO_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("a");
            sb.Append("b");
            sb.Append("c");

            Console.WriteLine(sb);

            sb.AppendLine("a"); // On new line
            sb.Replace("a", "b"); //Replaces a -> b



            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //string text = "";
            //for (int i = 0; i < 20000; i++)
            //{
            //    text += i;
            //}
            //sw.Stop();
            //Console.WriteLine(sw.ElapsedMilliseconds);

        }
    }
}