<<<<<<< HEAD
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
    
    public partial class Servicio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Servicio()
        {
            this.HistoricoServicios = new HashSet<HistoricoServicios>();
        }
    
        public int idServicio { get; set; }
        public Nullable<double> precioServicio { get; set; }
        public string descripcion { get; set; }
        public int tipoServicioID { get; set; }
        public Nullable<double> precioAlta { get; set; }
        public Nullable<double> precioBaja { get; set; }
        public Nullable<double> precioMedia { get; set; }
        public Nullable<byte> permisoAlta { get; set; }
        public Nullable<byte> permisoMedia { get; set; }
        public Nullable<byte> permisoBaja { get; set; }
        public Nullable<double> descVIP { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoricoServicios> HistoricoServicios { get; set; }
        public virtual TipoServicio TipoServicio { get; set; }
    }
}
=======
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
    
    public partial class Servicio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Servicio()
        {
            this.HistoricoServicios = new HashSet<HistoricoServicios>();
        }
    
        public int idServicio { get; set; }
        public Nullable<double> precioServicio { get; set; }
        public string descripcion { get; set; }
        public int tipoServicioID { get; set; }
        public Nullable<double> precioAlta { get; set; }
        public Nullable<double> precioBaja { get; set; }
        public Nullable<double> precioMedia { get; set; }
        public Nullable<byte> permisoAlta { get; set; }
        public Nullable<byte> permisoMedia { get; set; }
        public Nullable<byte> permisoBaja { get; set; }
        public Nullable<double> descVIP { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoricoServicios> HistoricoServicios { get; set; }
        public virtual TipoServicio TipoServicio { get; set; }
    }
}
>>>>>>> juan
