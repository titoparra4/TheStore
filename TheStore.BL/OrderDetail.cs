using System;
using System.Collections.Generic;
using System.Text;

namespace TheStore.BL
{
    public class OrderDetail
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        public decimal PurchasePrice { get; set; }

        //Save
        public bool Save(OrderDetail newOrder)
        {
            return true;
        }

        //Get all
        public List<OrderDetail> GetAll()
        {
            return new List<OrderDetail>();
        }

        //Get by id
        public OrderDetail GetById(int id)
        {
            return new OrderDetail();
        }

        //Delete
        public bool Delete(int Id)
        {
            return true;
        }
    }
}
