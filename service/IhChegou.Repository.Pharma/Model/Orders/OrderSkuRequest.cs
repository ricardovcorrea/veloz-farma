﻿
namespace IhChegou.Repository.Pharma.Model.Orders
{
    public class OrderSkuRequest
    {
        public virtual int Id { get; set; }
        public virtual int Quantity { get; set; }
        public virtual int? Sku_Id { get; set; }
        public virtual int? Order_Id { get; set; }

    }
}
