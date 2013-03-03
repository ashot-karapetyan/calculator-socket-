using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsyncSocketServer
{
    
   public class Expression
    {
        public Expression(){}

        public double argument1 { get; set; }
        public double argument2 { get; set; }
        public String oper { get; set; }


        public double eval()
        {
            double result = 0;
            switch (this.oper)
            {
                case "+":
                    result = argument1 + argument2;
                    break;
                case "-":
                    result = argument1 - argument2;
                    break;
                case "*":
                    result = argument1 * argument2;
                    break;
                case "/":
                    if (argument2 == 0)
                    {
                        throw new InvalidOperationException("Dividing by 0");
                    }
                    else
                    {
                        result = argument1 / argument2;
                    }
                    break;


            }

            return result;
        }

        //public static void Main(String[] args)
        //{
        //    Expression a = new Expression();
        //    a.argument1 = 5;
        //    a.argument2 = 4.50;
        //    a.oper= "/";
        //    Console.WriteLine(JSONHelper.To<Expression>(a));

        //}

    }


   
}
