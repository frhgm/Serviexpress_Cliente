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
    
    public partial class reserva
    {
        public decimal n_reserva { get; set; }
        public System.DateTime fecha { get; set; }
        public decimal hora { get; set; }
        public string patente { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public decimal anno_vehiculo { get; set; }
        public string descripcion_vehiculo { get; set; }
        public decimal cliente_rut_cliente { get; set; }
        public decimal servicios_cod_servicio { get; set; }
        public decimal empleado_rut_empleado { get; set; }
        public decimal horario_id_horario { get; set; }
    
        public virtual cliente cliente { get; set; }
        public virtual empleado empleado { get; set; }
        public virtual horario horario { get; set; }
        public virtual servicio servicio { get; set; }
    }
}
