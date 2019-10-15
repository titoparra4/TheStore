using System;
using System.Collections.Generic;
using System.Text;
using TheStore.BL.Entities;

namespace TheStore.BL.Repositories
{
    public class OrderRepository
    {
        //Save
        public bool Save(Order newOrder)
        {
            return true;
        }

        //Get all
        public List<Order> GetAll()
        {
            return new List<Order>();
        }

        //Get by id
        public Order GetById(int id)
        {
            return new Order();
        }

        //Delete
        public bool Delete(int id)
        {
            return true;
        }

    }
}
