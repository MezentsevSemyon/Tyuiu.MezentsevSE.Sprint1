﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MezentsevSE.Sprint1.Task5.V6.Lib
{
    public class DataService : ISprint1Task5V6
    {
        public int Calculate(int k)
        {
            if (k % 7 > 0)
            {
                return k % 7;
            }
            else
            {
                return 7;
            }
            
        }
    }
}
