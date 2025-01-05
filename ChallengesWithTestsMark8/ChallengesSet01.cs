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

        public string GetGreeting(string personName)
        {
            Console.WriteLine("What is your name?");

            if(String.IsNullOrEmpty(personName))
            {
                return "Hello!";
            }
            else
            {
                return $"Hello, {personName}!";
            }
        }
        
        public string GetHey()
        {
            Console.WriteLine();
            {
                return $"HEY!";
            }
        }
    }
}
