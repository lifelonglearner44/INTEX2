﻿using Microsoft.EntityFrameworkCore;

namespace INTEX2.Models
{
    [PrimaryKey(nameof(transaction_ID), nameof(product_ID))]
    public class LineItem
    {
        public int transaction_ID { get; set; }
        public int product_ID { get; set; }
        public int qty { get; set; }
        public int ranting { get; set; }
    }
}
