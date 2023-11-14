namespace _02.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string(Console.ReadLine()).Split();

            string result = string.Empty;

            foreach (string word in words)
            {
                int lenght = word.Length;

                for (int i = 0; i < lenght; i++) 
                {
                    result += word;
                }
            }
            Console.WriteLine(result);
        }
    }
}