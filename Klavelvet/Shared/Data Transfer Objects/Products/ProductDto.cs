﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klavelvet.Shared.Data_Transfer_Objects.Products
{
    public class ProductDto
    {

        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string ImageURL { get; set; } = string.Empty;

        public decimal Price { get; set; }
    }
}