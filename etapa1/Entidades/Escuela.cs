using System;
using System.Collections.Generic;

namespace CoreEscurela.Entidades
{
    class Escuela
    {
        string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value.ToUpper(); }
        }
        public string Pais { get; set; }
        public int AñoDeCreacio { get; set; }

        public string Ciudad { get; set; }
        public TiposEscuela TipoEscuela { get; set; }

        //        public Curso[] Cursos { get; set; }
        public List<Curso> Cursos { get; set; }
        /**
        public Escuela(string nombre, int año) 
        { 
            this.nombre = nombre;
            AñoDeCreacio = año;
        }**/

        //public Escuela(string nombre, int año ) => (Nombre, AñoDeCreacio) = (nombre,año);
        public Escuela(string nombre, int año,
                        TiposEscuela tipo,
                        string pais = "", string ciudad = "")
        {
            (Nombre, AñoDeCreacio) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
        }

        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} {Environment.NewLine}Pais: {Pais}, Ciudad: {Ciudad}";
        }
    }
}