using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace New_OnlineTaxibooking.Models
{
    public class BookingDetails
    {
        public int BookingdetailsId { get; set; }
        [Required]
        public Nullable<int> MemberId { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string state { get; set; }
        [Required]  
        public string Zipcode { get; set; }
        public Nullable<int> BookingId { get; set; }
        public Nullable<decimal> Amountpaid { get; set; }
        public string PaymentType { get; set; }
    }
}