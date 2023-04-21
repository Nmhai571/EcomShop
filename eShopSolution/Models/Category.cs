using eShopSolution.Api.Contracts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Api.Models
{
    public class Category
    {
        public int Id { get; set; }
        public int SortOrder { get; set; }
        public bool IsShowinHome { get; set; }
        public int? ParentId { get; set; }
        public Status Status { get; set; }

        public string Name { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTitle { get; set; }
        public string SeoAlias { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }

    }
}
