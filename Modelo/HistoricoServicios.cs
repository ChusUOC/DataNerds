//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Producto_2.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class HistoricoServicios
    {
        public int idServicio { get; set; }
        public int reservaID { get; set; }
        public int historicoID { get; set; }
    
        public virtual Reservas Reservas { get; set; }
        public virtual Servicio Servicio { get; set; }
    }
}
