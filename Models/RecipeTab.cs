//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RecipSuggestor.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RecipeTab
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RecipeTab()
        {
            this.RITabs = new HashSet<RITab>();
        }
    
        public string RecId { get; set; }
        public string RecName { get; set; }
        public string RecLink { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RITab> RITabs { get; set; }
    }
}
