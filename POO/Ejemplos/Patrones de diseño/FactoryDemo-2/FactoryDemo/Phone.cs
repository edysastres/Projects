using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDemo
{
    class Phone:IProduct
    {
        private double _price;

        public string GetName()
        {
            return "Random Smartphone";
        }

        public string SetPrice(double price)
        {
            this._price = price;
            return "Phone price was set";
        }
    }
}
