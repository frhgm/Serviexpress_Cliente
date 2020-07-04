using System;

namespace CapaEntidades
{
    public class BloqueHora
    {
        public int Id_Horario { get; set; }
        public int Rut_Empleado { get; set; }
        public int Dia_Habil { get; set; }
        public TimeSpan Hora_Inicio { get; set; }
        public TimeSpan Hora_Final { get; set; }
        public String Bloque { get; set; }
        public bool Disponibilidad { get; set; }
        public char Jornada_Hora { get; set; }
        
        public BloqueHora(){ }
    }
}