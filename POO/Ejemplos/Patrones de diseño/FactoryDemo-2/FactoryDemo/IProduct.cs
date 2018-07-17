using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDemo
{
    interface IProduct
    {
        string GetName();
        string SetPrice(double price);
    }
}
