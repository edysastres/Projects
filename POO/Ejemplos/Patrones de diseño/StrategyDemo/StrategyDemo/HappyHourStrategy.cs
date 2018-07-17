﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDemo
{
    class HappyHourStrategy : IBillingStrategy
    {
        public double GetActPrice(double rawPrice)
        {
            return rawPrice * 0.5;
        }
    }
}
