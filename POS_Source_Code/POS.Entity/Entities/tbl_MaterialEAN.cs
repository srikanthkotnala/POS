//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POS.Entity.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_MaterialEAN
    {
        public string EAN13 { get; set; }
        public string MaterialID { get; set; }
        public string UOM { get; set; }
        public Nullable<decimal> ConvertValue { get; set; }
        public string BaseUOM { get; set; }
        public string MaterialMix { get; set; }
    
        public virtual tbl_Material tbl_Material { get; set; }
        public virtual tbl_MaterialEAN tbl_MaterialEAN1 { get; set; }
        public virtual tbl_MaterialEAN tbl_MaterialEAN2 { get; set; }
        public virtual tbl_PriceFile tbl_PriceFile { get; set; }
        public virtual tbl_UOM tbl_UOM { get; set; }
        public virtual tbl_UOM tbl_UOM1 { get; set; }
    }
}
