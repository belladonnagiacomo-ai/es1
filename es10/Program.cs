namespace es10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dammi una parola");
            string parola = Console.ReadLine();
            char[] ParolaT = parola.ToCharArray();
            char[] p = parola.ToCharArray();
            for (int i = ParolaT.Length - 1; i >= 0; i--)
            {
                Console.Write(ParolaT[i]);
                if (p == ParolaT)
                {
                    Console.WriteLine("le parole sono palindromi");
                }
            }
          
           

            
        }
    }
}
