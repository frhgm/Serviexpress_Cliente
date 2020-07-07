using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Cliente
    {
        public int Rut { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public int Telefono_Adicional { get; set; }
        public string Direccion { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }

        public bool Tipo_Cliente { get; set; }

        public Cliente() : this(0, "", "", 0, 0, "", DateTime.Now, true)
        {
        }

        public Cliente(int Rut, string Nombre, string Apellido, int Telefono, int Telefono_Adicional, string Direccion,
            DateTime Fecha_Nacimiento, bool Tipo_Cliente)
        {
            this.Rut = Rut;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Telefono = Telefono;
            this.Telefono_Adicional = Telefono_Adicional;
            this.Direccion = Direccion;
            this.Fecha_Nacimiento = Fecha_Nacimiento;
            this.Tipo_Cliente = Tipo_Cliente;
        }
    }
}