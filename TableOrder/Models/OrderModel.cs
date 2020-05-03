using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TableOrder.Models
{
    public class OrderModel
    {
        public Guid OrderID { get; set; }
        [Display(Name = "Danie")]
        [Required(ErrorMessage = "Proszę wybrać danie")]
        public string Name { get; set; }
        [Display(Name = "Liczba sztuk")]
        public int Quantity { get; set; }
        [Display(Name = "Cena jednostkowa")]
        public double Price { get; set; }
        [Display(Name = "Stolik")]
        [Required(ErrorMessage = "Proszę wybrać stolik")]
        public string TableName { get; set; }
    }
}