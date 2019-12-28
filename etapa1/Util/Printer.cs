using static System.Console;

namespace CoreEscurela.Entidades
{
    public static class Printer
    {
        public static void DibujarLinea(int tam = 10)
        {
            WriteLine("".PadLeft(tam, '='));
        }
        public static void DibujarTitulo(string titulo)
        {
            var tamaño = titulo.Length + 4;
            DibujarLinea(tamaño);
            WriteLine($"| {titulo} |");
            DibujarLinea(tamaño);
        }
        public static void Beep(int Hz = 2000, int tiempo = 500, int cantidad = 1)
        {
            while(cantidad > 0){
                System.Console.Beep(Hz,tiempo);
                cantidad --;
            }
        }
    }
}