using System;

namespace CapaEntidades
{
    public class Reserva
    {
        public int Numero_Reserva { get; set; }
        public DateTime Fecha { get; set; }
        public int Hora { get; set; }
        public String Patente { get; set; }
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public int Anno { get; set; }
        public String Descripcion { get; set; }
        public int Rut_Cliente { get; set; }
        public int Codigo_Servicio { get; set; }
        public int Rut_Empleado { get; set; }
        public int Bloque_Hora { get; set; }

        public Reserva()
        {
            Fecha.ToString("MM/dd/yyyy");
        }
    }
}