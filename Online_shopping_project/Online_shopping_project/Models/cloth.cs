//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Online_shopping_project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class cloth
    {
        public int ClothID { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public Nullable<int> MaterialID { get; set; }
        public string clothName { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Material Material { get; set; }
    }
}
