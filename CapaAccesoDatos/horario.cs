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
    
    public partial class horario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public horario()
        {
            this.reservas = new HashSet<reserva>();
        }
    
        public decimal id_horario { get; set; }
        public decimal empleado_rut_empleado { get; set; }
        public decimal dia_habil_cod_dia { get; set; }
        public decimal hora { get; set; }
        public bool disponibilidad { get; set; }
    
        public virtual dia_habil dia_habil { get; set; }
        public virtual empleado empleado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reserva> reservas { get; set; }
    }
}
