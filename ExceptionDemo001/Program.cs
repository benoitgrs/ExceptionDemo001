using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exception demonstration");
            Divide(6, 3, "answer");

            int[] number = new int[2];
            try
            {
                number[0] = 0;
                number[1] = 1;
                number[2] = 2;

                foreach(int i in number)
                {
                    Console.WriteLine(i);
                }

            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("An IndexOutOfRangeException was thrown");
                Console.WriteLine(ex.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("An Generale exception was thrown");
            }
            finally
            {
                Console.WriteLine("Finished process exception thrown have closed all issues");
            }

            try
            {
                Divide(6, 0, "answer");
            }
            catch (DivideByZeroException ex)
            {

            }
            finally
            {

            }
            try
            {
                Show(null, 6);

            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }
        }
        private static void Divide(int a,int b, string s)
        {
            int result = a / b;
            Console.WriteLine($"{s.ToUpper()}: {result}");

        }
        private static void Show(string frame, int age)
        {
            if(frame is null)
            {
                throw new ArgumentException("parameter cannot be null", "frame");
            }


            Console.WriteLine($"{frame} is {age} years old");
        }
    }
}
