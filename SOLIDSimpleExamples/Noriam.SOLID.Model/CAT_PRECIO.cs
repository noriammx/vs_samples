//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Noriam.SOLID.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CAT_PRECIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAT_PRECIO()
        {
            this.MOVIMIENTO_PRODUCTO = new HashSet<MOVIMIENTO_PRODUCTO>();
        }
    
        public int ID_CAT_PRECIO { get; set; }
        public Nullable<decimal> PRECIO_COMPRA { get; set; }
        public System.DateTime FECHA_INICIO { get; set; }
        public Nullable<bool> ACTIVO { get; set; }
        public int CREADO_POR { get; set; }
        public Nullable<decimal> PRECIO_VENTA { get; set; }
        public int ID_CAT_PRODUCTO { get; set; }
        public Nullable<System.DateTime> FECHA_FIN { get; set; }
    
        public virtual CAT_USUARIO CAT_USUARIO { get; set; }
        public virtual CAT_PRODUCTO CAT_PRODUCTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MOVIMIENTO_PRODUCTO> MOVIMIENTO_PRODUCTO { get; set; }
    }
}
