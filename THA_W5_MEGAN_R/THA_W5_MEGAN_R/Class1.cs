using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THA_W5_MEGAN_R
{
    internal class Product
    {
        public string Name { get; set; }
        public string Harga { get; set; }
        public string Stock { get; set; }
        public string Category { get; set; }
        public string CategoryID { get; set; }
        public string IDProduct { get; set; }
        public Product(string name, string harga, string stock, string category)
        {
            this.Name = name;
            this.Harga = harga;
            this.Stock = stock;
            this.Category = category;
        }
    }
}
