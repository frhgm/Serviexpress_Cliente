using System;

namespace CapaEntidades
{
    public class Reserva
    {
        public int Numero_Reserva { get; set; }
        public DateTime Fecha { get; set; }
        public int Hora { get; set; }
        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anno { get; set; }
        public string Descripcion { get; set; }
        public int Rut_Cliente { get; set; }
        public int Codigo_Servicio { get; set; }
        public int Rut_Empleado { get; set; }
        public int Id_Horario { get; set; }
        public bool Estado { get; set; }
        
        public TimeSpan Hora_Inicio { get; set; }
        public TimeSpan Hora_Final { get; set; }

        public Reserva()
        {
        }
    }
}