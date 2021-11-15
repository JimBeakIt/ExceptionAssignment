using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numbers = { 11, 15, 23, 33, 50 };

                Console.WriteLine("Give me a number, and I'll divide my numbers with it.");
                int userNum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(numbers[0] + " divided by " + userNum + " is " + (numbers[0] / userNum));
                Console.ReadLine();

                Console.WriteLine(numbers[1] + " divided by " + userNum + " is " + (numbers[1] / userNum));
                Console.ReadLine();

                Console.WriteLine(numbers[2] + " divided by " + userNum + " is " + (numbers[2] / userNum));
                Console.ReadLine();

                Console.WriteLine(numbers[3] + " divided by " + userNum + " is " + (numbers[3] / userNum));
                Console.ReadLine();

                Console.WriteLine(numbers[4] + " divided by " + userNum + " is " + (numbers[4] / userNum));
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero");
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            
        }
        }
    }

