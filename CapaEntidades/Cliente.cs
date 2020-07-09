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

        
        /*
         *  [Required]
    [StringLength(100)]
    public string Title { get; set; }

    [ClassicMovie(1960)]
    [DataType(DataType.Date)]
    [Display(Name = "Release Date")]
    public DateTime ReleaseDate { get; set; }

    [Required]
    [StringLength(1000)]
    public string Description { get; set; }

    [Range(0, 999.99)]
         */
        public Cliente() : this(0, "", "", 0, 0, "", DateTime.Today, true)
        {
        }

        public Cliente(int _Rut, string _Nombre, string _Apellido, int _Telefono, int _Telefono_Adicional, string _Direccion,
            DateTime _Fecha_Nacimiento, bool _Tipo_Cliente)
        {
            this.Rut = _Rut;
            this.Nombre = _Nombre;
            this.Apellido = _Apellido;
            this.Telefono = _Telefono;
            this.Telefono_Adicional = _Telefono_Adicional;
            this.Direccion = _Direccion;
            this.Fecha_Nacimiento = _Fecha_Nacimiento;
            this.Tipo_Cliente = _Tipo_Cliente;
        }
    }
}