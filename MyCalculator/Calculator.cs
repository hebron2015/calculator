using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    public class Calculator: ICalculator
    {

        public Calculator(){}

        public int Add(int a, int b)
        {
            if(a == null || b == null) throw new NullReferenceException("Null value");
            if (a.GetType() != typeof(int) || b.GetType() != typeof(int)) throw new InvalidOperationException("Invalid operator value");
            
            return (int)a + b;            
        }

        public int Subtruction(int a, int b)
        {
            return a - b;
        }

        public int Multi(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
