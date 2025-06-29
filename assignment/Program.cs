using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            //Write a program that allows the user to enter a number then print it.

            Console.WriteLine("please enter number ");
           bool isparse= int.TryParse(Console.ReadLine(),out int num);
            Console.Clear();
            if (isparse)   //or isparse==true
            {
                Console.WriteLine($"the number that you enterd is : {num}");
            }
            else
            {
                Console.WriteLine($"the number is invalid  We add the default value {num}");
            }
           
            
            
            
            
            #endregion










        }
    }
}
