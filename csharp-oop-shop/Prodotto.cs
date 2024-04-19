using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Prodotto
    {
        public int Code { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Iva { get; set; }

        public int GetPriceIva()
        {
            return this.Iva * this.Price;
        }
        public string GetCodeName()
        {
            return this.Code.ToString() + this.Name;
        }

    }
}
