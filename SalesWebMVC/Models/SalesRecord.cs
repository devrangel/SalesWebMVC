using System;
using System.ComponentModel.DataAnnotations;
using SalesWebMVC.Models.Enums;

namespace SalesWebMVC.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }

        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        public double Amount { get; set; }

        [Display(Name = "Sale Status")]
        public SaleStatus SaleStatus { get; set; }

        public Seller Seller { get; set; }

        public SalesRecord()
        {

        }

        public SalesRecord(DateTime date, double amount, SaleStatus saleStatus, Seller seller)
        {
            this.Date = date;
            this.Amount = amount;
            this.SaleStatus = saleStatus;
            this.Seller = seller;
        }
    }
}
