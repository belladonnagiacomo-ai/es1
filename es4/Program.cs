namespace es4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dimmi una frase: ");
            string frase = Console.ReadLine();
            string nuova = frase.Replace("brutto", "***");
            Console.WriteLine(nuova);
        }
    }
}
