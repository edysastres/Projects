using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDemo
{
    class PhoneConcreteFactory:ProductAbstractFactory
    {
        private Random rand = new Random();

        protected override IProduct MakeProduct()
        {
            IProduct product = new Phone();
            Console.WriteLine(product.SetPrice(rand.NextDouble()));
            
            return product;
        }
    }
}
