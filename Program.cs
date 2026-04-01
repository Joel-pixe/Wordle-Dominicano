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

            public void Juego()
            {

            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}
