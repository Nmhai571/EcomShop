﻿using eShopSolution.Api.Models;

namespace eShopSolution.Api.ViewModel
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public int Stock { get; set; }
        public int ViewCount { get; set; }
        public DateTime DateCreate { get; set; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Details { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public decimal? OldPrice { get; set; }
        public string SeoAlias { get; set; }
        public List<ProductCategory> ProductCategories;
    }
}
