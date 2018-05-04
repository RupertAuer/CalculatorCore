using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorOP
    {
        public int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        public int Mul(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }

        public int Sub (int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }

        public double Div (double num1, double num2)
        {
            double result = (double)num1 / num2;

            return result;
        }
    }

}