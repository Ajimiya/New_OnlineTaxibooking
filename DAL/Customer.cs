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

    public partial class Customer
    {
        public int Customer_Id { get; set; }
        [Display(Name ="First name")]
        public string Customer_FirstName { get; set; }
        [Display(Name = "Lasst name")]
        public string Customer_LastName { get; set; }
        [Display(Name = "Email")]
        public string Customer_Email { get; set; }
        [Display(Name = "Password")]
        public string Customer_Password { get; set; }
        [Display(Name = "Mobile no")]
        public string Customer_Contact { get; set; }
        [Display(Name = "Address")]
        public string Customer_Address { get; set; }
    }
}
