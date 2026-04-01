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

            public void ColorAzul(char mychar)
            {
                ConsoleColor colorOriginal = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(mychar);
                Console.ForegroundColor = colorOriginal;
            }

            public void ColorBlanco(char mychar)
            {
                ConsoleColor colorOriginal = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(mychar);
                Console.ForegroundColor = colorOriginal;
            }

            public void ColorRojo(char mychar)
            {
                ConsoleColor colorOriginal = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(mychar);
                Console.ForegroundColor = colorOriginal;
            }

            public void MsgInicial(string palabra)
            {
                Console.WriteLine("¡Bienvenido a WordleMMG!");
                Console.Write("\n");
                Console.WriteLine($"Adivina la palabra de {palabra.Length} letras en {intentosMaximos} intentos.");
                Console.Write("\n");
                Console.WriteLine("Después de cada intento, recibirás estas pistas:");
                Console.Write("\n");
                Console.WriteLine("- Letra en azul: letra correcta en la posición correcta.");
                Console.WriteLine("- Letra en blanco: letra correcta en la posición incorrecta.");
                Console.WriteLine("- Letra en rojo: letra no está en la palabra.");
                Console.Write("\n");
            }

            public List<string> PalabrasPosibles = new List<string> { "FULLIN", "PALOMO","WAWAWA","PATRON","POPI","ASARAR" };
            
            public string GenerarPalabra()
            {
                Random rnd = new Random();

                int palabra = rnd.Next(0, PalabrasPosibles.Count);

                return PalabrasPosibles[palabra];
            }

            public string ObtenerPalabra(string palabra)
            {
                Console.Write($"Ingrese una palabra de {palabra.Length} letras:");
                string intento = Console.ReadLine().ToUpper();
                
                //Andy, aquí se podría agregar validación para asegurarse de que el intento tenga la longitud correcta, que solo contenga letras, etc.

                return intento;
            }

            public void EvaluarIntento(string intento, string palabra)
            {
                for (int i = 0; i < palabra.Length; i++)
                {
                    if (intento[i] == palabra[i])
                    {
                        ColorAzul(intento[i]);
                    }
                    else if (palabra.Contains(intento[i])) //letra posicion incorrecta
                    {
                        ColorBlanco(intento[i]);
                    }
                    else
                    {
                        ColorRojo(intento[i]);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            string palabra = "";
            JuegoWordle juego1 = new JuegoWordle(palabra , 6);
            palabra = juego1.GenerarPalabra();
            juego1.MsgInicial(palabra);
            juego1.EvaluarIntento(juego1.ObtenerPalabra(palabra), palabra);
            Console.ReadKey();
            //----------------------------------------------------

        }
    }
}
