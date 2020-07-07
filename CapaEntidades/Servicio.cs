using System;

namespace CapaEntidades
{
    public class Servicio
    {
        public int Codigo_Servicio { get; set; }
        public string Descripcion { get; set; }
        public string Tarifa { get; set; }
        public bool Estado { get; set; }
        public string Nombre { get; set; }
        public int Categoria { get; set; }

        public Servicio()
        {
        }
    }
}