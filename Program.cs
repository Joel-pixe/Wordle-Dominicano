namespace ConsoleApp1
{
    internal class WordleDominicano
    {
        public class JuegoWordle
        {
            public string palabraSecreta { get; }
            public int intentosMaximos = 6;

            public void MsgInicial()
            {
                Console.WriteLine("¡Bienvenido a WordleMMG!");
                Console.WriteLine($"Adivina la palabra de {palabraSecreta.Length} letras en {intentosMaximos} intentos.");
                Console.WriteLine("Después de cada intento, recibirás estas pistas:");
                Console.WriteLine("- Letra en verde: letra correcta en la posición correcta.");
                Console.WriteLine("- Letra en amarillo: letra correcta en la posición incorrecta.");
                Console.WriteLine("- Letra en gris: letra no está en la palabra.");
            }

            public List<string> PalabrasPosibles = new List<string> { "FULLIN", "PALOMO","WAWAWA","PATRON","POPI","ASARAR" };
            
            public string GenerarPalabra()
            {
                Random rnd = new Random();

                int palabraSecreta = rnd.Next(0, PalabrasPosibles.Count);

                return PalabrasPosibles[palabraSecreta];
            }
        }

        static void Main(string[] args)
        {
            JuegoWordle juego1 = new JuegoWordle(); 

            Console.WriteLine(juego1.GenerarPalabra());
        }
    }
}
