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
    
    public partial class pedido_cabecera
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pedido_cabecera()
        {
            this.detalle_pedido = new HashSet<detalle_pedido>();
        }
    
        public decimal id_pedido { get; set; }
        public System.DateTime fecha_emision { get; set; }
        public Nullable<System.DateTime> fecha_recepcion { get; set; }
        public decimal total { get; set; }
        public decimal empleado_rut_empleado { get; set; }
        public decimal proveedor_id_proveedor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detalle_pedido> detalle_pedido { get; set; }
        public virtual empleado empleado { get; set; }
        public virtual proveedor proveedor { get; set; }
    }
}