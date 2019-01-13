using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetanitEnum
{
    enum Operation
    {
        Add = 1,
        Substract,
        Multiply,
        Divide
    }

    class Calculator : MenuController
    {
        public double result = 0.0;
        public void MathOperation(double x, double y, Operation operation)
        {

            switch (operation)
            {
                case Operation.Add:
                    result = x + y;
                    break;
                case Operation.Substract:
                    result = x - y;
                    break;
                case Operation.Multiply:
                    result = x * y;
                    break;
                case Operation.Divide:
                    result = x / y;
                    break;
            }
        }
    }
}
