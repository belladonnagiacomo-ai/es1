namespace es7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dammi una frase: ");
            string frase = Console.ReadLine();
            char[] parole = frase.ToCharArray();
            char[] lettera = {'a','A'};
            int z = 0;
            for(int i = 0; i < parole.Length; i++)
            {
                if (lettera.Contains(parole[i]))
                {
                    z++;
                }
            }
            if(z > 0)
            {
                Console.WriteLine("la lettera a e contenuta nella frase " + frase + " per " + z);
            }
        }
    }
}
