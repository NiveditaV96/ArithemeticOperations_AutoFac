using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArithemeticOperations.Models
{
    //Provides sum of product given numbers
    public class Multiplication : IArithmetic
    {
        public int Operations(int value1, int value2)
        {
            return value1 * value2;

        }
    }
}