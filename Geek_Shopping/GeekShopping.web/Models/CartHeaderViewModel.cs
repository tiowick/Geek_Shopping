﻿namespace GeekShopping.Web.Models
{
    public class CartHeaderViewModel
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public string CupomCode { get; set; }
        public decimal PurchaseAmount { get; set; }
    }
}
