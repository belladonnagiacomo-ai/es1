namespace es1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il tuo nome completo ");
            string nome = Console.ReadLine();
            string n = nome.Trim();
            Console.WriteLine(n.ToUpper());
            string p = n.ToUpper();
            int l = n.Length;
            Console.WriteLine(l);
        }
    }
}
