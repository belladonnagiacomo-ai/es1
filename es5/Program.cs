namespace es5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string voti = ("8,7,5,4,9");
            string[] voto = voti.Split(",");
            for(int i = 0; i < voto.Length; i++)
            {
                Console.WriteLine(voto[i]);
            }
        }
    }
}
