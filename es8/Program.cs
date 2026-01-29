namespace es8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dammi una parola");
            string parola = Console.ReadLine();
            char[] Parola = parola.ToCharArray();
            for (int i = Parola.Length - 1; i>= 0; i--)
            {
                Console.Write(Parola[i]);
            }
        }
    }
}
