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

    public partial class Booking
    {
        public int BK_Id { get; set; }
        [Display(Name ="Customer name")]
        public string Cust_name { get; set; }
        [Display(Name ="Mobile")]
        public string Cust_no { get; set; }
        [Display(Name ="Date of booking")]
        public System.DateTime Book_Date { get; set; }

        [Display(Name = "Select car")]
        public int Prod_bid { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
