using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSeries
{
    class Controller
    {
        NumberOrSeries numberorseries = new NumberOrSeries();
        public void OptionsController()
        {
            bool isContinueFurther = true;

            while (isContinueFurther)
            {
                Console.WriteLine("enter the user option from 1 .... to... 5 anyone");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        numberorseries.DisplayFibonacciSeries(numberorseries.FibonacciSeries());
                        isContinueFurther = IsContinueFurtherProgramExecution();
                        break;
                    case 2:
                        numberorseries.DisplayPrimeNumberSeries(numberorseries.PrimeNumberSeries());
                        isContinueFurther = IsContinueFurtherProgramExecution();
                        break;
                    case 3:
                        numberorseries.DisplayPallindromeResult(numberorseries.PallindromeNunber());
                        isContinueFurther = IsContinueFurtherProgramExecution();
                        break;
                    case 4:
                        Console.WriteLine("Enter the Number for which we want to print factorial");
                        numberorseries.DisplayFactorial(numberorseries.FactorialSeries(int.Parse(Console.ReadLine())));
                        isContinueFurther = IsContinueFurtherProgramExecution();
                        break;
                    case 5:
                        numberorseries.DisplayArmstrongResult(numberorseries.ArmstrongNumber());
                        isContinueFurther = IsContinueFurtherProgramExecution();
                        break;
                    default:
                        Console.WriteLine("you have entered an unknow option.. please run the program again and choose correct options");
                        isContinueFurther = IsContinueFurtherProgramExecution();
                        break;
                }
            }
        }
        public bool IsContinueFurtherProgramExecution()
        {
            bool isContinueFurther = false;
            Console.WriteLine("do you want to continue Further enter either Yes/No");
            string enterString = Console.ReadLine();
            isContinueFurther = enterString.ToLower().Equals("yes") ? true : false;
            return isContinueFurther;
        }
        
    }
}
