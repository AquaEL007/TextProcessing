namespace _5.Digits_LettersAndOthers_Var2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Console.WriteLine(string.Join("", text.Where(char.IsDigit)));
            Console.WriteLine(string.Join("", text.Where(char.IsLetter)));
            Console.WriteLine(string.Join("", text.Where(x => !char.IsDigit(x) && !char.IsLetter(x))));
        }
    }
}