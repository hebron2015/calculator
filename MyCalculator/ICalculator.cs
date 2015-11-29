using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    interface ICalculator
    {
        int Add(int a, int b);
        int Subtruction(int a, int b);
        int Multi(int a, int b);
        int Divide(int a, int b);
    }
}
