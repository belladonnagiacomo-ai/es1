namespace es6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dammi un file(compresa l'esetnsione)");
            string file = Console.ReadLine();
            bool estensione = file.EndsWith(".pdf");
            if(estensione == true)
            {
                Console.WriteLine(estensione);
            }
            else
            {
                Console.WriteLine(estensione);
            }
        }
    }
}
