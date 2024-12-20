using System;
using System.ComponentModel.Design;
using System.Net.Http.Headers;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Add(int number1, int number2)
        {
         return number1 + number2;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            int smallerNumber = number1 < number2 ? number1 : number2;
            Console.WriteLine($"The smaller number is: {smallerNumber}");
            
            int sum = number1 + number2;
            
            return smallerNumber;
        }

        public long Multiply(long factor1, long factor2)
        {
            long result = factor1 * factor2;

            Console.WriteLine($"The product of {factor1} and {factor2} is: {result}");
            
            return result;
            
        }

        public static void GetGreeting(string nameOfPerson)
        {
            Console.WriteLine("Hello, what is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {nameOfPerson}!");
        }

        public string GetHey()
        {
            throw new NotImplementedException();
        }
    }
}
