﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Empleado
    {
        public int Rut { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public int Telefono_Adicional { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public int Id_Usuario { get; set; }

        public Empleado() : this(0, "", "", "", 0, 0, DateTime.Today, 0)
        {
        }

        public Empleado(int Rut, string Nombre, string Apellido, string Direccion, int Telefono, int Telefono_Adicional,
            DateTime Fecha_Nacimiento, int Id_Usuario)
        {
            this.Rut = Rut;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Direccion = Direccion;
            this.Telefono = Telefono;
            this.Telefono_Adicional = Telefono_Adicional;
            this.Fecha_Nacimiento = Fecha_Nacimiento;
            this.Id_Usuario = Id_Usuario;
        }
    }
}