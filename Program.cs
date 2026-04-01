namespace ConsoleApp1
{
    internal class WordleDominicano
    {
        public class JuegoWordle
        {
            public string palabraSecreta { get; }
            public int intentosMaximos = 6;

            public JuegoWordle(string palabra, int intentos)
            {
                palabraSecreta = palabra;
                intentosMaximos = intentos;
            }

            public void MsgInicial(string palabra)
            {
                Console.WriteLine("¡Bienvenido a WordleMMG!");
                Console.WriteLine($"Adivina la palabra de {palabra.Length} letras en {intentosMaximos} intentos.");
                Console.WriteLine("Después de cada intento, recibirás estas pistas:");
                Console.WriteLine("- Letra en verde: letra correcta en la posición correcta.");
                Console.WriteLine("- Letra en amarillo: letra correcta en la posición incorrecta.");
                Console.WriteLine("- Letra en gris: letra no está en la palabra.");
            }

            public List<string> PalabrasPosibles = new List<string> { "FULLIN", "PALOMO","WAWAWA","PATRON","POPI","ASARAR" };
            
            public string GenerarPalabra()
            {
                Random rnd = new Random();

                int palabra = rnd.Next(0, PalabrasPosibles.Count);

                return PalabrasPosibles[palabra];
            }
        }

        static void Main(string[] args)
        {
            string palabra = "";
            JuegoWordle juego1 = new JuegoWordle(palabra , 6);
            palabra = juego1.GenerarPalabra();
            juego1.MsgInicial(palabra);
            Console.ReadKey();


        }
    }
}
