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

            // Console.WriteLine("please enter number ");
            //bool isparse= int.TryParse(Console.ReadLine(),out int num);
            // Console.Clear();
            // if (isparse)   //or isparse==true
            // {
            //     Console.WriteLine($"the number that you enterd is : {num}");
            // }
            // else
            // {
            //     Console.WriteLine($"the number is invalid  We add the default value {num}");
            // }





            #endregion

            #region Q2

            //Write C# program that converts a string to an integer, but the string contains non-numeric characters.
            //   And mention what will happen 

            string s1 = "123dsrr";
            //// if we used the convert it will be throw error because the string is invalid to convert 
            //int num = Convert.ToInt32(s1);

            // the same will happend when used static method (parse )  ===> throw exception
            //int num1 = int.Parse(s1);

            //to handle this erorr we can use tryparse 
            //// the default vlaue will assigned =[0]
            //if (int.TryParse(s1, out int num2))
            //{
            //    Console.WriteLine("Number: " + num2);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input {0}",num2);
            //}



            #endregion










        }
    }
}
