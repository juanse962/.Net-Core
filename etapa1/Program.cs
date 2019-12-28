using CoreEscurela.Entidades;
using static System.Console;

namespace CoreEscurela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.inicializar();
            Printer.DibujarTitulo("Bienvenidos a la escuela");
            ImprimirCursosEscuela(engine.Escuela);
            Printer.Beep(10000,cantidad:10);
        }

        private static bool Predicado(Curso curobj)
        {
            return curobj.Nombre == "301" || curobj.Nombre == "502" || curobj.Jornada == TiposJornada.Mañana;
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.DibujarTitulo("Cursos de la escuela");
            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre: {curso.Nombre} , Id: {curso.UniqueId}");
                }
            }
        }
    }
}