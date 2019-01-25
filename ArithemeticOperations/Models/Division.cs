using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArithemeticOperations.Models
{
    //Provides quotient of two given numbers
    public class Division : IArithmetic
    {
        public int Operations(int value1, int value2)
        {
            int qt = value1 / value2;
            return qt;
            //try
            //{
            //    qt = value1 / value2;

            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.Write(e.Message);
            //    Console.ReadLine();
            //}

        }
    }
}