using System;

namespace CapaEntidades
{
    public class BloqueHora
    {
        public int Id_Horario { get; set; }
        public int Rut_Empleado { get; set; }
        public int Dia_Habil { get; set; }
        public DateTime Hora_Inicio { get; set; }
        public DateTime Hora_Final { get; set; }
        public Boolean Disponibilidad { get; set; }
        public char Jornada_Hora { get; set; }

        
        public BloqueHora()
        {
            Hora_Inicio.ToString("hh:mm tt");
            Hora_Final.ToString("hh:mm tt");
        }
    }
}