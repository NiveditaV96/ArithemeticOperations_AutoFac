using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArithemeticOperations.Models
{
    
        //Provides sum of two given numbers
        public class Addition : IArithmetic
        {

            public int Operations(int value1, int value2)
            {
                return value1 + value2;
            }


        }
    
}