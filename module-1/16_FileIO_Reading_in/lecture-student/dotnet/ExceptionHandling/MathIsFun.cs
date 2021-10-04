using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    public class MathIsFun
    {
        public int Divide(int num1, int num2)
        {
            try
            {
                //potentially could return an error
                return num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                //handling exception
                Console.WriteLine($"Don't divide by zero");
            }
            catch (Exception e)
            {
                Console.WriteLine("something else");
            }
            finally
            {
                Console.WriteLine("Always executes");
            }

            return 0;
        }

        public int Multiply(int num1, int num2)
        {
            Exception e = new Exception;
            throw e;
            return num1 * num2;
        }
    }
}
