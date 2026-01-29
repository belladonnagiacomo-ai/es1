namespace es9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dammi una data: ");
            string data = Console.ReadLine();
            string[] Data = data.Split('/');
            string data2;
            for (int i = Data.Length - 1; i >= 0; i--)
            {
               
                Console.Write(Data[i]);
                if (i > 0)
                {
                    Console.Write("/");
                }
            }
           
            
        }
    }
}
