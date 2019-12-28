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
            ImprimirCursosEscuela(engine.Escuela);
        }

        private static bool Predicado(Curso curobj)
        {
            return curobj.Nombre == "301" || curobj.Nombre == "502" || curobj.Jornada == TiposJornada.Mañana;
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("========================");
            WriteLine("Cursos de la escuela");
            WriteLine("========================");
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