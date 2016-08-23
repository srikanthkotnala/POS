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
    
    public partial class tbl_Material
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Material()
        {
            this.tbl_MaterialEAN = new HashSet<tbl_MaterialEAN>();
            this.tbl_PriceFile = new HashSet<tbl_PriceFile>();
        }
    
        public string MaterialID { get; set; }
        public string MaterialDesc1 { get; set; }
        public string MaterialDesc2 { get; set; }
        public string MaterialDesc3 { get; set; }
        public string ProductURL { get; set; }
        public string CategoryID { get; set; }
        public string SubCategoryID { get; set; }
        public string BaseUOM { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public string VendorID { get; set; }
        public Nullable<int> CustInt1 { get; set; }
        public Nullable<int> CustInt2 { get; set; }
        public Nullable<int> CustInt3 { get; set; }
        public Nullable<System.DateTime> CustDate1 { get; set; }
        public Nullable<System.DateTime> CustDate2 { get; set; }
        public Nullable<System.DateTime> CustDate3 { get; set; }
        public string CustText1 { get; set; }
        public string CustText2 { get; set; }
        public string CustText3 { get; set; }
        public string UserID { get; set; }
        public Nullable<System.DateTime> AddDate { get; set; }
        public Nullable<System.DateTime> UpdDate { get; set; }
        public int Dataid { get; set; }
    
        public virtual tbl_Category tbl_Category { get; set; }
        public virtual tbl_Material tbl_Material1 { get; set; }
        public virtual tbl_Material tbl_Material2 { get; set; }
        public virtual tbl_Vendor tbl_Vendor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_MaterialEAN> tbl_MaterialEAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PriceFile> tbl_PriceFile { get; set; }
    }
}
