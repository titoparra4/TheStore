using System;
using System.Collections.Generic;
using System.Text;

namespace TheStore.BL.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public DateTimeOffset Date { get; set; }

    }
}
