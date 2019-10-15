using System;
using System.Collections.Generic;
using System.Text;
using TheStore.BL.Entities;

namespace TheStore.BL.Repositories
{
    public class CustomerRepository
    {
        //Save
        public bool Save(Customer newCustomer)
        {
            return true;
        }

        //Get all
        public List<Customer> GetAll()
        {
            return new List<Customer>();
        }

        //Get by id
        public Customer GetById(int id)
        {
            return new Customer();
        }

        //Delete
        public bool Delete(int id)
        {
            return true;
        }
    }
}
