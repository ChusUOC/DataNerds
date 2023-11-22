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
    
    public partial class Habitacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Habitacion()
        {
            this.Reservas = new HashSet<Reservas>();
        }
    
        public int numeroHabitacion { get; set; }
        public string tipoHabitacion { get; set; }
        public string descripcion { get; set; }
        public Nullable<int> tipoID { get; set; }
        public Nullable<byte> minNoches { get; set; }
        public Nullable<byte> maxPersonas { get; set; }
        public Nullable<double> precioAlta { get; set; }
        public Nullable<double> PrecioMedia { get; set; }
        public Nullable<double> precioBaja { get; set; }
        public string estado { get; set; }
        public Nullable<byte> fueraServicio { get; set; }
    
        internal virtual TipoHabitacion TipoHabitacion1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<Reservas> Reservas { get; set; }
    }
}
