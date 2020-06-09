//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaAccesoDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public empleado()
        {
            this.horarios = new HashSet<horario>();
            this.pedido_cabecera = new HashSet<pedido_cabecera>();
            this.reservas = new HashSet<reserva>();
        }
    
        public decimal rut_empleado { get; set; }
        public string nombre_empleado { get; set; }
        public string apellido_empleado { get; set; }
        public string direccion { get; set; }
        public decimal telefono { get; set; }
        public Nullable<decimal> telefono_adicional { get; set; }
        public System.DateTime fecha_nacimiento { get; set; }
        public decimal usuario_id_usuario { get; set; }
    
        public virtual usuario usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<horario> horarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pedido_cabecera> pedido_cabecera { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reserva> reservas { get; set; }
    }
}