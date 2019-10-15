using System;
using System.Collections.Generic;
using System.Text;

namespace TheStore.BL.Entities
{
    public class OrderDetail
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        public decimal PurchasePrice { get; set; }

    }
}
