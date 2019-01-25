using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArithemeticOperations.Models
{
    //Provides difference of two given numbers
    public class Subtraction : IArithmetic
    {
        public int Operations(int value1, int value2)
        {
            if (value1 > value2)
            {
                return value1 - value2;
            }

            else
            {
                return value2 - value1;

            }

        }
    }
}