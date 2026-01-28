namespace es3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dimmi il tuo nome: ");
            string nome = Console.ReadLine();
            char[] n = nome.ToCharArray();
            Console.WriteLine("Dimmi il tuo cognome: ");
            string cognome = Console.ReadLine();
            char[] c = cognome.ToCharArray();
            Console.WriteLine(nome[0] + " " + cognome[0]);
        }
    }
}
