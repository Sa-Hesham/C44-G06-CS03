using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Diagnostics.CodeAnalysis;
using System;
using System.Reflection.Metadata;

namespace assignment
{
    internal class Program
    {

        //class Person
        //{
        //    public int x;
        //}
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

            //string s1 = "123dsrr";
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





            #region Q3

            //Write C# program that Perform a simple arithmetic operation with
            //    floating-point numbers And mention what will happen

            // we can also using double datatype insead of  float 
            // because double [15-16 after precition] More accurate than float [7 after precition] 
            // decimal is More accurate than [28 ,29 digit]  after precition
            //Console.WriteLine("Enter the first number");

            //float.TryParse(Console.ReadLine(),out float num1);


            //Console.WriteLine("Enter the second number");

            //float.TryParse(Console.ReadLine(), out float num2);

            //float result = (num1 + num2);

            //Console.WriteLine($"sum = {result}");


            //Console.WriteLine($"sum = { (double)result}");

            //Console.WriteLine($"sum = {(decimal)result}");







            #endregion




            #region Q4

            //string Name = "Elsayed hesham";


            //string sub = Name.Substring(1,4); //lsay
            //Console.WriteLine(sub);

            #endregion



            #region Q5

            //Write C# program that Assigning one value type variable to another and modifying 
            //    the value of one variable and mention what will happen

            //int a = 10;
            //int b = 5;
            //b = a;
            //b=a because  they are value types 
            //b take a copy  from a value  and old value of (b deleted  ) 
            // b is indpendent and  a is indpendent 
            //Console.WriteLine("before");
            //Console.WriteLine("a = "+ a); //a=10
            //Console.WriteLine("b = "+ b); //b=10;

            // if we changed  the value of b  =20 
            // there is no changes in vlaue of a =10
            //b = 20;
            //Console.WriteLine(" after ");
            //Console.WriteLine("a = " + a); //a=10
            //Console.WriteLine("b = " + b); //b=20;





            #endregion



            #region Q6

            //Write C# program that assigns one reference type variable to another and modifies 
            //    the object through one variable, then explain what happens.


            //Person p =new Person() ;
            //p.x = 5;
            //Person c = p;

            //class is referance type  CLR created obj in heap 
            // p is refernce have the address of obj in stack
            // now referance c = referance p ==> both have same address of obj 
            // if c had change in values it will be affect on referance c 

            //Console.WriteLine("before changed");
            //Console.WriteLine("p = " + p.x);
            //Console.WriteLine("c = "+ c.x);

            //Console.WriteLine("after changed");
            //c.x = 20;
            //Console.WriteLine("p = " + p.x);
            //Console.WriteLine("c = " + c.x);



            #endregion




            #region Q7

            ////Write C# program that take two string variables and print them as one variable 
            //string s1 = "Sayed ";
            //string s2= "hesham";

            //string S3 = s1 +" "+ s2;

            //Console.WriteLine($"Welcom : {S3} ");


            #endregion



            #region Q8

            //Write a program that calculates the simple interest given the principal amount, rate of interest,
            // and time.The formula for simple interest is
            //Interest = (principal * rate * time) / 100.


            //Console.WriteLine("please enter primcipal amount ");

            //double.TryParse(Console.ReadLine(), out double amount);



            //Console.WriteLine("enter the rate  % ");

            //double.TryParse(Console.ReadLine(), out double rate);



            //Console.WriteLine("enter the hours   in year ");


            //double.TryParse(Console.ReadLine(), out double time );


            //double interest = (amount * rate * time) / 100;


            //Console.WriteLine(interest);













            #endregion




            #region Q9

            //Write a program that calculates the Body Mass Index(BMI) given a person's weight in kilograms and height in meters. 
            //The formula for BMI is BMI = (Weight) / (Height * Height)


            //Console.WriteLine("Enter  your weight  ");
            //double weight = checked(Convert.ToDouble(Console.ReadLine()));

            //Console.WriteLine("Enter  your height (meters)");
            //double height = checked(Convert.ToDouble(Console.ReadLine()));


            //double BMI = weight / (height * height);
            //Console.Clear();

            //Console.WriteLine($"Your BMI is: {BMI}");



            #endregion





            #region Q10

            //Write a program that uses the ternary operator to check if the temperature is too hot, 
            //too cold, or just good. Assign the result in a variable then display the result. 
            //Assume that below 10 degrees is "Just Cold", above 30 degrees is "Just Hot", and anything else is "Just Good".

            //   Console.WriteLine("welcome to the tempreture Checker \n \n");


            //   Console.WriteLine("Please Enter the dgree today");
            //bool Iscorrect=  int.TryParse(Console.ReadLine(), out int dgree);

            //   if (Iscorrect) {

            //       string message = (dgree > 30) ? "it is hot today" : 
            //                         (dgree < 10) ? "it is cold today" : 
            //                         "it is Good";

            //                     Console.WriteLine(message);
            //   }

            //   else
            //   {

            //       Console.WriteLine("invalid input please try again");
            //   }

            #endregion




            #region q11

            //Write a program that takes the date from the user and displays it in various formats using string interpolation.
            //Ex:
            //Today’s date : 20 , 11 , 2001
            //Today's date : 20 / 11 / 2001
            //Today's date : 20 – 11 – 2001

            //Console.Write("Enter day: ");
            //int day = int.Parse((Console.ReadLine()));


            //Console.Write("Enter month: ");
            //int month = int.Parse((Console.ReadLine()));


            //Console.Write("Enter year: ");
            //int year = int.Parse((Console.ReadLine()));



            //Console.Clear();

            //Console.WriteLine($"Today's date: {day} , {month} , {year} ");

            //Console.WriteLine($"Today's date: {day} / {month} / {year}");

            //Console.WriteLine($"Today's date: {day} – {month} – {year}");

            #endregion








            #region Q12



            //hat is the output of the following C# code?

            //the output (c) : 06/14/2024  

            #endregion









        }















    }
}

