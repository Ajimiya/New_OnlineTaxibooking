//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace New_OnlineTaxibooking.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web;
    using System.Xml.Linq;

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Bookings = new HashSet<Booking>();
        }
    
        public int Prod_Id { get; set; }
        [Display(Name = "Product name")]
        public string Prod_Name { get; set; }
        [Display(Name = "Description")]
        public string Prod_Disc { get; set; }
        [Display(Name = "Price")]
        public string Price { get; set; }
        [Display(Name = "Image")]
        public string Prod_Pic { get; set; }
        [Display(Name = "Category")]
        public int Cat_Fid { get; set; }
    
        public HttpPostedFileBase Pro_Pic { get; set; }
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}