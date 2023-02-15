﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Models
{
    public class OrderProduct
    {
        public int Id { get; set; }
        public Product Product{ get; set; }

        public int OrderIdP { get; set; }
        public Order Order { get; set; }

    }
}
