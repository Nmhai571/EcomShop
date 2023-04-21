﻿namespace eShopSolution.Api.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ImagePath { get; set; }
        public string Caption { get; set; }

        public bool IsDefault { get; set; }

        public Product Product { get; set; }

        public long FileSize { get; set; }

        public int SortOrder { get; set; }
    }
}
