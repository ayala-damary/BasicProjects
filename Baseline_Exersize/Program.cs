﻿
using System;
using System.Collections.Generic;

namespace Baseline_Exersize
{

    public class Program
    {
        //2
        public static List<int> doubleList(List<int> l)
        {
            List<int> doubleList = new List<int>();
            for (int i = 0; i < doubleList.Count; i++, doubleList[i] = l[i] * 2) ;
            return doubleList;
        }
        //3

        public static List<int> divideByThreeList(List<int> l)
        {
            List<int> divideByThreeList = new List<int>();
            int k = 0;
            for (int i = 0; i < divideByThreeList.Count; i++)
            {
                if (l[i] % 3 == 0)
                {
                    divideByThreeList[k++] = l[i];
                }
            }
            return divideByThreeList;
        }

        //4
        public static void printRectangle(int width, int hight)
        {
            if (width <= 0 || hight <= 0)
            {
                Console.Write("error valid ");
            }
            string tav = "*";

            for (int i = 0; i < width; i++)
            {
                Console.Write(tav);
            }
            Console.WriteLine();
            for (int i = 1; i < hight - 1; i++)
            {
                Console.Write(tav);
                for (int j = 1; j < width - 1; j++)
                {
                    Console.Write(" ");
                }
                Console.Write(tav);
                Console.WriteLine();
            }
            for (int i = 0; i < width; i++)
            {
                Console.Write(tav);
            }
        }
        //5
        public enum Options
        {
            FIRST,
            SECOND,
            THIRD,
            EXIT
        }

        //6
        public static void IntegerValueOfRational()
        {
            Console.Write("enter rational number");
            string rationalNumber = Console.ReadLine();

            if (double.TryParse(rationalNumber, out double number))
            {
                int integerValue = (int)Math.Round(number, MidpointRounding.AwayFromZero);
                Console.WriteLine("int value best soon" + integerValue);
            }
            else
            {
                Console.WriteLine("valid input");
            }

        }

        //7
        public static void IntegerValueOfRational2()

        {
            Console.Write("enter rational number");
            string rationalNumber = Console.ReadLine();

            if (double.TryParse(rationalNumber, out double number))
            {
                int integerValue = (int)number;
                Console.WriteLine("int value " + integerValue);
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }

        //8
        public static void printNumberPow2()
        {
            Console.WriteLine("enter number");
            string numberUser = Console.ReadLine();

            if (double.TryParse(numberUser, out double number))
            {
                double square = Math.Pow(number, 2);
                Console.WriteLine("the number pow 2 " + square);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        //9
        public static void PerfectNumbersWithFor()
        {

            for (int i = 6; i <= 1000000; i++)
            {
                int sum = 1;

                for (int div = 2; div * div <= i; div++)
                {
                    if (i % div == 0)
                    {
                        if (div * div != i)
                        {
                            sum += div + i / div;
                        }
                        else
                        {
                            sum += div;
                        }
                    }
                }

                if (sum == i)
                {
                    Console.Write(i + ",");
                }
            }
        }

        public static void PerfectNumbersWithWhile()
        {
            int n = 1000000;
            int sum = 1;
            int div = 2;

            while (div * div <= n)
            {
                if (n % div == 0)
                {
                    if (div * div != n)
                    {
                        sum += div + n / div;
                    }
                    else
                    {
                        sum += div;
                    }
                }
                div++;
            }

            if (sum == n)
            {
                Console.Write(n + ",");
            }

            n++;
        }


        //10
        public static void SumDigitOfNumber()
        {
            Console.Write("enter rational number");
            string numberUser = Console.ReadLine();

            if (int.TryParse(numberUser, out int number))
            {
                int sumDigit = 0;
                while (number != 0)
                {
                    sumDigit += number % 10;
                    number /= 10;
                }
                Console.WriteLine("sum digit:" + sumDigit);
            }
            else
            {
                Console.WriteLine("valid input");
            }

        }

//1.2
    static int CalculateDigital(int num)
    {
        while (num >= 10)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            num = sum;
        }
        return num;
    }
        public static void Main(string[] args)
        {
            //1
            int primeNumber = 0;
            for (int y = 2; y < 14; y++)
            {
                if (IsPrimeNumber(y))
                {
                    primeNumber = y;
                    break;
                }
            }

            Console.WriteLine($"{primeNumber} is a prime number.");
            printRectangle(3, 4);

            //5
            var options = new Dictionary<Options, string>(){
    {Options.FIRST,"first" },
    {Options.SECOND,"second" },
    {Options.THIRD,"third"},
    {Options.EXIT,"exit"}
};
            Console.WriteLine("enter options");
            String strUser = Console.ReadLine().ToLower();
            bool flagOpt = false;
            foreach (var opt in options)
            {
                if (opt.Value == strUser)
                {
                    Console.WriteLine((Options)opt.Key);
                    flagOpt = true;
                }
            }
            if (strUser == "exit")
            {
                Console.WriteLine("exit from progam");
            }
            else if (flagOpt != true)
            {
                Console.WriteLine("invalid input");
            }

//1.2
       Console.WriteLine("Insert a number:");
        string numberUser = Console.ReadLine();

        if (int.TryParse(numberUser, out int num))
        {
            if (num >= 0)
            {
               
             int resultCalc = CalculateDigital(num);
            Console.WriteLine("Output: " + resultCalc);
            }
            else
            {
          Console.WriteLine("Invalid number");
            }
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }



        }


        //1
        static bool IsPrimeNumber(int number)
        {
            for (int c = 2; c * c <= number; c++)
            {
                if (number % c == 0)
                {
                    return false;
                }
            }

            return true;
        }

    
    }
}


