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
    
    public partial class Factura
    {
        public int numeroFactura { get; set; }
        public Nullable<System.DateTime> fechaFactura { get; set; }
        public Nullable<double> precioTotal { get; set; }
        public Nullable<int> servicioID { get; set; }
    
        public virtual Reservas Reservas { get; set; }
    }
}