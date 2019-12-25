using System;

namespace CoreEscurela.Entidades
{
    public class Curso
    {
        public string Nombre { get; set; }
        public string UniqueId { get; set; }
        public TiposJornada Jornada { get; set; }

        public Curso() => UniqueId = Guid.NewGuid().ToString();

    }
}