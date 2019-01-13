using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetanitEnum
{
    class MenuController
    {
        int x, y;
        int operation;
        bool again = true;

        public void MakeCalculation()
        {
             Calculator calculator = new Calculator();

             Console.WriteLine("Enter first number:");
             x = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter second number:");
             y = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter operation 1-Add, 2-Substract, 3-Multiply, 4-Divide");
             operation = Convert.ToInt32(Console.ReadLine());
             Operation oper = (Operation)Enum.ToObject(typeof(Operation), operation);

             calculator.MathOperation(x, y, oper);
             Console.WriteLine("Result of this operation equals {0}", calculator.result);
        }
    }
}
