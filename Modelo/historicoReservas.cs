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
    
    public partial class historicoReservas
    {
        public int reservaID { get; set; }
        public Nullable<int> habitacion { get; set; }
        public string nombre { get; set; }
        public string entrada { get; set; }
        public Nullable<System.DateTime> salida { get; set; }
        public string estado { get; set; }
        public Nullable<int> idIncidencia { get; set; }
    
        public virtual Reservas Reservas { get; set; }
    }
}
