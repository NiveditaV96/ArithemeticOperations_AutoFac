using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ArithemeticOperations.Models;
using Autofac;

namespace ArithemeticOperations.Controllers
{
    public class MathController : ApiController
    {
        private IArithmetic _IArith;

        public MathController(IArithmetic IArith)
        {
            _IArith = IArith;
        }

        [HttpGet]
        public int Add(int num1, int num2)
        {
            return _IArith.Operations(num1, num2);

            //using (var scope = AutoFac.Container.BeginLifetimeScope())
            //{
            //    var a = scope.Resolve<IArithmetic>();
            //    int sum = a.Operations(num1, num2);
            //    return sum;
            //}

        }

        [HttpGet]
        public int Subtract(int num1, int num2)
        {
            return _IArith.Operations(num1, num2);

        }

        [HttpGet]
        public int Multiply(int num1, int num2)
        {

            return _IArith.Operations(num1, num2);

        }

        [HttpGet]
        public int Divide(int num1, int num2)
        {

            return _IArith.Operations(num1, num2);

        }
    }
}
