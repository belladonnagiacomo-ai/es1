namespace es2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "giacomo@gmail.com";
            string[] n = nome.Split("@");
            Console.WriteLine(n[1]);
        }
    }
}
