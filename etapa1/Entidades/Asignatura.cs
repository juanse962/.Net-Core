using System;

namespace CoreEscurela.Entidades
{
    public class Asignatura
    {
        public string UniqueId { get; set; }
        public string Nombre { get; set; }
        public Asignatura() => UniqueId = Guid.NewGuid().ToString();

    }
}