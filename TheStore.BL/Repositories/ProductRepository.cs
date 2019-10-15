using System;
using System.Collections.Generic;
using System.Text;
using TheStore.BL.Entities;

namespace TheStore.BL.Repositories
{
    public class ProductRepository
    {

        //Save
        public bool Save(Product newProduct)
        {
            return true;
        }

        //Get all
        public List<Product> GetAll()
        {
            return new List<Product>();
        }

        //Get by id
        public Product GetById(int id)
        {
            return new Product();
        }

        //Delete
        public bool Delete(int Id)
        {
            return true;
        }
    }
}
