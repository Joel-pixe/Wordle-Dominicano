namespace ConsoleApp1
{
    internal class WordleDominicano
    {
        static void Main(string[] args)
        {
            List<char> lista = new List<char>();

            Console.WriteLine("Ingrese la palabra: ");
            string palabra = Console.ReadLine();

            foreach (char p in palabra)
            {
                lista.Add(p);
                // que frescura
            } 
        }
    }
}
