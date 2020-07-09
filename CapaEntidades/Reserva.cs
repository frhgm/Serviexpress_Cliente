using System;
using System.Globalization;

namespace CapaEntidades
{
    public class Reserva
    {
        public int Numero_Reserva { get; set; }
        public DateTime Fecha { get; set; }

        

        //public int Hora { get; set; }
        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anno { get; set; }
        public string Descripcion { get; set; }
        
        public Servicio Servicio { get; set; }
        public Cliente Cliente { get; set; }
        public Empleado Empleado { get; set; }
        public BloqueHora BloqueHora { get; set; }
        public bool Estado { get; set; }
        public BloqueHora Hora_Inicio { get; set; }
        public BloqueHora Hora_Final { get; set; }


        public Reserva() : this(0, DateTime.Today, String.Empty, String.Empty, String.Empty, 0, String.Empty, 
            new Servicio(), new Cliente(), new Empleado(), new BloqueHora(),
            false, new BloqueHora(), new BloqueHora())
        {
            
        }
        
        
        public Reserva(int _Numero_Reserva, DateTime _Fecha, string _Patente, string _Marca, string _Modelo, int _Anno,string _Descripcion, 
            Servicio _Servicio, Cliente _Cliente, Empleado _Empleado, BloqueHora _Bloque_Hora
            , bool _Estado, BloqueHora _Hora_Inicio,BloqueHora _Hora_Final)
        {
            this.Numero_Reserva = _Numero_Reserva;
            this.Fecha = _Fecha;
            this.Patente = _Patente;
            this.Marca = _Marca;
            this.Modelo = _Modelo;
            this.Anno = _Anno;
            this.Descripcion = _Descripcion;
            this.Servicio = _Servicio;
            this.Cliente = _Cliente;
            this.Empleado = _Empleado;
            this.BloqueHora = _Bloque_Hora;
            this.Estado = _Estado;
            this.Hora_Inicio = _Hora_Inicio;
            this.Hora_Final = _Hora_Final;

        }
    }
}