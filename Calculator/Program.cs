using System;
using System.Collections;
using System.Linq;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //the user must choose between +, -, *, / and %
            //must choose between two integers, once it's done, show it in the console
            //nb1 operator nb2 = rest
            //ex : 1 + 1 = 2
            //after res shows on the console, let the user choose between quitting the app or make a new calcul

            string ope;
            string nb1;
            string nb2;
            bool stay = true;

            //you don't necessarly need to write != or ==, you can also just write !stay to test the equality
            while (stay)
            {
                Console.WriteLine("Hi ! Please choose among the following :");
                Console.WriteLine("+, -, *, /, %");
                ope = Console.ReadLine();

                Console.WriteLine("Please pick a number :");
                nb1 = Console.ReadLine();
                float num1 = float.Parse(nb1);

                Console.WriteLine("Pick a second number :");
                nb2 = Console.ReadLine();
                float num2 = float.Parse(nb2);

                float res = DisplayResult(num1, ope, num2);

                Console.WriteLine(num1 + ope + num2 + "=" + res);
                Console.ReadLine();

                Console.WriteLine("Make a new calcul ? (y/n)");
                string strStay = Console.ReadLine();

                if (strStay != "y")
                    stay = false;

            }
        }
        private static float DisplayResult(float num1, string ope, float num2)
        {

            float res = 0;

            if (ope == "+")
            {
                res = num1 + num2;
            }
            else if (ope == "-")
            {
                res = num1 - num2;
            }
            else if (ope == "*")
            {
                res = num1 * num2;
            }
            else if (ope == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("The second number cannot be 0");
                }
                else
                {
                    res = num1 / num2;
                }
            }
            else if (ope == "%")
            {
                res = num1 % num2;
            }
            return res;
        }
    }
}