using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Prodotto
    {
        // Costruttore Prodotto
        public Prodotto() 
        {
            Random random = new Random();
            this.Code = random.Next(0,200);
            this.Iva = 22;
        }
        public int Code { get; }
        public string Name { get; set; } = String.Empty; // Quando è stringa inizializzare la variabile vuota, cosi non è NULL
        public string Description { get; set; } = String.Empty;
        public double Price { get; set; }
        public double Iva { get; set; }

        public double GetPriceIva()
        {
            return this.Price + (this.Price * (this.Iva / 100));
        }
        public string GetCodeName()
        {
            return this.Code.ToString() + this.Name;
        }

        public string GetCodePad()
        {
            string Code = this.Code.ToString();
            if (Code.Length < 8) 
            {
                string CodeZero = "";
                for (int i = 0; i < 8 - Code.Length; i++)
                {
                     CodeZero += "0";
                }
                Code = CodeZero + Code; 
            }

            return Code;
        }

        // Oppure usare  return this.Code.ToString().PadLeft(8, '0'); 

    }
}
