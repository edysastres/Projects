using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDemo
{
    abstract class ProductAbstractFactory
    {
        protected abstract IProduct MakeProduct();

        public IProduct GetObject()
        {
            return this.MakeProduct();
        }
    }
}
