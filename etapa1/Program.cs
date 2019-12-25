using System;
using CoreEscurela.Entidades;
using static System.Console;

namespace etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Juan Academy", 2012, TiposEscuela.PreEscolar
                                        , ciudad: "Lima");
            WriteLine(escuela.Nombre + " " + escuela.AñoDeCreacio);
            escuela.TipoEscuela = TiposEscuela.Primaria;
            //escuela.Ciudad = "Medellín";
            //escuela.Pais = "Colombia";
            /**
            var arregloCursos = new Curso[3]{
                new Curso() { Nombre = "101" },
                new Curso() { Nombre = "201" },
                new Curso() { Nombre = "301" }
            };**/

            escuela.Cursos = new Curso[]{
                new Curso() { Nombre = "101" },
                new Curso() { Nombre = "201" },
                new Curso() { Nombre = "301" }
            };
            Curso[] arreglosCursos = {
                new Curso() { Nombre = "101" },
                new Curso() { Nombre = "201" },
                new Curso() { Nombre = "301" }
            };

            WriteLine("========================");
            ImprimirCursoForEach(arreglosCursos);
            ImprimirCursosEscuela(escuela);

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

        private static void ImprimirCursoForEach(Curso[] arregloCursos)
        {
            foreach (var curso in arregloCursos)
            {
                WriteLine($"Nombre: {curso.Nombre} , Id: {curso.UniqueId}");
            }
        }

        private static void ImprimirCursoFor(Curso[] arregloCursos)
        {
            for (int i = 0; i < arregloCursos.Length; i++)
            {
                WriteLine($"Nombre: {arregloCursos[i].Nombre} , Id: {arregloCursos[i].UniqueId}");
            }

        }

        private static void ImprimirCursoDoWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            do
            {
                WriteLine($"Nombre: {arregloCursos[contador].Nombre} , Id: {arregloCursos[contador].UniqueId}");
                contador++;
            } while (contador < arregloCursos.Length);
        }

        private static void ImprimirCursoWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            while (contador < arregloCursos.Length)
            {
                WriteLine($"Nombre: {arregloCursos[contador].Nombre} , Id: {arregloCursos[contador].UniqueId}");
                contador++;
            }
        }
    }
}