﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploFacade
{
    class Bank
    {
        public bool HasSufficientSavings(Customer c, int amount)
        {
            Console.WriteLine("Check bank for " + c.Name);
            return true;
        }
    }
}
