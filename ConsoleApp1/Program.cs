using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathUtil util = new MathUtil();
            int result = util.Add(2, 5);
            Console.WriteLine(result);
            Console.WriteLine(util.Sub(100, 3));

            Console.WriteLine(util.round(12.567));

        }
    }

    public class MathUtil
    { public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
        public int Multiply(int num1, int num2)
        { 
            return num1 * num2;
        }
        public int Divid(int num1, int num2)//相除,但傳回只會是整數

        {
            if(num2==0)
            {
                throw new Exception("分母不可以是零");
            }
            return num1 / num2;
        }
        public int round(double value)
        {
            return(int)Math.Round(value,MidpointRounding.AwayFromZero);
        }

    }
}

