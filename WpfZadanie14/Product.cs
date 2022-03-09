using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfZadanie14
{
    public enum ProductCategorys
    {
        Motor,
        Body
    }
    public class Product
    {
        public string ProdName { get; set; }
        public decimal ProdPrice { get; set; }
        public string ProdImage { get; set; }
        public ProductCategorys ProblemCategory { get; set; }
        public ProductCategorys ProductCategory { get; internal set; }
    }
}
