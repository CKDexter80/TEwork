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
            //potentially could go awry
               return num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                //handling the exception
                Console.WriteLine($"dont divide by zero");
            }
            catch(Exception e)
            {
                Console.WriteLine("something else happened");
            }
            finally
            {
                //cleanup connection/ resources/
                Console.WriteLine("Always executes");
            }

            return 0;
        }

        public int Multiply(int num1, int num2){

            Exception e = new Exception();
            throw e;
            return num1 * num2;

        }

        public void NotEnoughMoney()
        {
            ExceptionHandling.Exceptions.OverdraftException overdraftException = new Exceptions.OverdraftException("you broke", 0);
            throw overdraftException;

        }
    }
}
