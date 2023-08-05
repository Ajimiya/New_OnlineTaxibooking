using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace New_OnlineTaxibooking.Models
{
    public class CategoryDetails
    {

        public int CategoryId { get; set; }
        [Required(ErrorMessage ="Category name is required")]
        [StringLength(100,ErrorMessage ="Minimum 3 and minimum 5 and maximum 100 characters are allowed",MinimumLength =3)]
        public string CategoryName { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }

    }
    public class ProductDetails
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Minimum 3 and minimum 5 and maximum 100 characters are allowed", MinimumLength = 3)]
        [Display(Name ="Car name ")]
        public string ProductName { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string Description { get; set; }
        public string ProductImage { get; set; }
        public Nullable<bool> IsFeatured { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> Price { get; set; }
        public SelectList Categories { get; set; }
    }
}