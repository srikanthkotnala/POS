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
    
    public partial class tbl_PreferUOM
    {
        public string MaterialID { get; set; }
        public string EAN13 { get; set; }
        public string UOM { get; set; }
        public Nullable<decimal> Conv { get; set; }
        public string TerminalID { get; set; }
    
        public virtual tbl_PreferUOM tbl_PreferUOM1 { get; set; }
        public virtual tbl_PreferUOM tbl_PreferUOM2 { get; set; }
        public virtual tbl_PreferUOM tbl_PreferUOM11 { get; set; }
        public virtual tbl_PreferUOM tbl_PreferUOM3 { get; set; }
    }
}
