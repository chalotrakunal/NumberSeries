using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace NumberSeries
{
    class NumberOrSeries
    {
        public List<double> FibonacciSeries()
        {
            List<double> listofFibonacciSeries = new List<double>();
            Console.WriteLine("How many numbers we want to print in Fibonacci series");
            int lengthOfFibonacciSeries = int.Parse(Console.ReadLine());
            double firstNumber = 0;
            double secondNumber = 1;
            int index = 0;
            listofFibonacciSeries.Add(firstNumber);
            listofFibonacciSeries.Add(secondNumber);
            while (index < lengthOfFibonacciSeries - 2)   // subtracting two because we alreasy stores 0 and 1 in list
            { 
                double sum = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = sum;
                listofFibonacciSeries.Add(sum);
                index++;
            }
            return listofFibonacciSeries;
        }
        public void DisplayFibonacciSeries(List<double> fibonacciSequence)
        {
            foreach(double number in fibonacciSequence)
            {
                Console.WriteLine(number);
            }
        }
        public List<int> PrimeNumberSeries()
        {
            List<int> listOfPrimeNumbers = new List<int>();
            int number = 3;
            bool isSetPrimeFlag = true;
            listOfPrimeNumbers.Add(2);
            Console.WriteLine("Enter the length upto which we want to print the prime numbers");
            int primeLength = int.Parse(Console.ReadLine());
            for (int index = 2; index <=primeLength;)
            {
                isSetPrimeFlag =  IsPrimeInnerLoopFunctionality(2, number, true);
                if (isSetPrimeFlag)
                {
                    listOfPrimeNumbers.Add(number);
                    index++;
                }
                isSetPrimeFlag = true;
                number++;
            }
            return listOfPrimeNumbers;
        } 
        public bool IsPrimeInnerLoopFunctionality(int getfactor, int number, bool isSetPrimeFlag)
        {
            for (  int factor=getfactor; factor <= Math.Sqrt(number); factor++)
            {
                if (number % factor == 0)
                {
                    isSetPrimeFlag = false;
                    break;
                }
            }
            return isSetPrimeFlag;
        }
        public void DisplayPrimeNumberSeries(List<int> listOfPrimeNumbers)
        {
            foreach(int primeNumber in listOfPrimeNumbers)
            {
                Console.WriteLine(primeNumber);
            }
        }
        public string CommonFunctionalityOfPallindromeArmstrong()
        {
            Console.WriteLine("How many digits you want in an integer");
            int integerLength = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the digits of length {0} ", integerLength);
            string stringInNumericFormat = Console.ReadLine();
            return stringInNumericFormat;
        }
        public bool IsParsingStringToInteger(string value)
        {
            bool isParsedToInteger = BigInteger.TryParse(value, out BigInteger integerInNumericFormat);
            return isParsedToInteger;
        }
        public bool PallindromeNunber()
        {
            bool isPallindrome = true;
            BigInteger convertedBigInteger = 0, actualNumericFormat = 0;
            string stringInNumericFormat = CommonFunctionalityOfPallindromeArmstrong();
            bool isParsedToNumericString = IsParsingStringToInteger(stringInNumericFormat);
            if (!isParsedToNumericString)
            {
                Console.WriteLine("you have entered a unrecognised numeric string.");
                isPallindrome = false;
            }
            else
            {
                actualNumericFormat = BigInteger.Parse(stringInNumericFormat);
                char[] reversalOfStringInNumeric = stringInNumericFormat.ToCharArray();
                Array.Reverse(reversalOfStringInNumeric);
                string stringInNumericAfterReversal = new string(reversalOfStringInNumeric);
                convertedBigInteger = BigInteger.Parse(stringInNumericAfterReversal);
                isPallindrome = (actualNumericFormat == convertedBigInteger) ? true : false;
            }
            return isPallindrome;
        }
        public void  DisplayPallindromeResult(bool isPallindrome)
        {
            if(!isPallindrome)
            {
                Console.WriteLine("Number is not Pallindrome");
            }
            else
            {
                Console.WriteLine("Number is pallindrome");
            }
        }
        public double FactorialSeries(int baseValue)
        {
            double factorial = 1;
            if (baseValue==0 || baseValue==1)
            {
                return 1;
            }
            else
            {
                factorial = baseValue * FactorialSeries(baseValue-1);
            }
            return factorial;
        }
        public void DisplayFactorial(double result)
        {
            Console.WriteLine(result);
        }
        public bool ArmstrongNumber()
        {
            bool isArmstrongNumber = true;
            string stringInNumericFormat = CommonFunctionalityOfPallindromeArmstrong();
            bool isParsedToNumericString = IsParsingStringToInteger(stringInNumericFormat);
            BigInteger computedArmstrongNumber = 0, cubeOfDigit = 0, individualDigit = 0, actualIntegerInNumericFormat;
            if (!isParsedToNumericString)
            {
                Console.WriteLine("you have entered a unrecognised numeric string");   
            }
            else
            {
                BigInteger integerInNumericFormat = BigInteger.Parse(stringInNumericFormat);
                actualIntegerInNumericFormat = integerInNumericFormat;
                while (integerInNumericFormat > 0)
                {
                    individualDigit = integerInNumericFormat % 10;
                    integerInNumericFormat = integerInNumericFormat / 10;
                    cubeOfDigit = (individualDigit) * (individualDigit) * (individualDigit);
                    computedArmstrongNumber += cubeOfDigit;
                }
                 isArmstrongNumber = (computedArmstrongNumber == actualIntegerInNumericFormat) ? true : false;
            }
            return isArmstrongNumber;
        }
        public void DisplayArmstrongResult(bool isArmstrongNumber)
        {
            if (!isArmstrongNumber)
            {
                Console.WriteLine("Number is not Armstrong");
            }
            else
            {
                Console.WriteLine("Number is Armstrong");
            }
        }
    }
}
