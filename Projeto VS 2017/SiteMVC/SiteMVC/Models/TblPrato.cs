//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SiteMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblPrato
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblPrato()
        {
            this.TblRestaurantes = new HashSet<TblRestaurante>();
        }
    
        public int Idprato { get; set; }
        public string NomePrato { get; set; }
        public int IdRestauranteDono { get; set; }
    
        public virtual TblRestaurante TblRestaurante { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblRestaurante> TblRestaurantes { get; set; }
    }
}
