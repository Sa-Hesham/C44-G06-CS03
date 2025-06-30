using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Text;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)

        {


            #region Fractions And discards
            //// by defualt  decimal numbers is d ouble 
            //double  d =3.5; // 8 byte  15 or 16 digit after  Decimal point
            //float a = 3.3f; //4 byt  7 digit after  Decimal point
            //decimal d = 3.3m; //16 byte  28-29 digit after  Decimal point


            //there are many ways  to formating numbers

            //currency formating 
            //double n =45454.34554676;
            //Console.WriteLine( "n= {0:c1}", n);
            //Console.WriteLine($"n= {n:c1}");
            //Console.WriteLine(n.ToString("c3"));






            #endregion

            #region Implicit and Explicit-Casting
            // there is two types of casting 
            //implicit the compiler  casting automaticly from small data type to big data type
            //but can not convert from small to  big data type because c#  type save 
            //examp

            //int x = 5000000;
            //double z = x;
            //Console.WriteLine(z);

            // but in Explicit  user will convert data type for other data type   

            //long a= 100;
            //int x =  (int)a;
            //Console.WriteLine(x);
            // can not convert type implicit  
            // in this case  need  Explicit casting 

            //  checked
            //{



            //      long a = 1007585;
            //      int x = (int)a;
            //      Console.WriteLine(x);


            //  }

            // if  the value in long is bigger than int (max vlaue ) 
            //will be occured data loss (overflowing)
            // to handle this errors  used chaked

            //long a = 1007585655757575;


            //if (a > int.MaxValue || a < int.MinValue)
            //{

            //    Console.WriteLine("you cant Explicit (over flowing)");
            //}
            //else
            //{
            //    int x = (int)a;
            //    Console.WriteLine(x);
            //}





            #endregion


            #region convert & parsing & tryParse(casting...)
            #region convert
            // class provide methods that convert between  different data taypes
            //accept null values 
            //// convert null value to zero with int 
            //throw exceptions if the values invalid 

            //Console.WriteLine("please enter your name ");
            //string? name = Console.ReadLine();

            //Console.WriteLine("please enter your age ");
            //int? age = (Convert.ToInt32(Console.ReadLine()));

            //Console.WriteLine("enter your salary ");
            //decimal Salary = Convert.ToDecimal(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine("name is :" + name);
            //Console.WriteLine("age :{0}",age);
            //Console.WriteLine("salary{0}",Salary);


            #endregion

            #region Parse

            //Console.WriteLine("please enter your name ");
            //string? name = Console.ReadLine();

            //Console.WriteLine("please enter your age ");
            //int? age = (int.Parse(Console.ReadLine()));

            //Console.WriteLine("enter your salary ");
            //decimal? Salary = decimal.Parse(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine("name is :" + name);
            //Console.WriteLine("age :{0}", age);
            //Console.WriteLine("salary{0:c}", Salary);

            #endregion

            #region tryparse
            //string s1 = "Ahmed";
            //int x;
            //bool istrue = int.TryParse(s1,out x);
            //Console.WriteLine(x);
            //Console.WriteLine(istrue );

            //Console.WriteLine("please enter your name ");
            //string? name = Console.ReadLine();

            //Console.WriteLine("please enter your age ");
            //int.TryParse(Console.ReadLine() ,out int age);

            //Console.WriteLine("enter your salary ");
            // decimal.TryParse(Console.ReadLine(),out decimal salary);
            //Console.Clear();
            //Console.WriteLine("name is :" + name);
            //Console.WriteLine("age :{0}", age);
            //Console.WriteLine("salary{0:c}", salary);

            #endregion






            #endregion


            #region operations

            #region Arithmetic Operations 
            //int a = 10;
            //int b = 3;

            //Console.WriteLine(a + b);  // 13
            //Console.WriteLine(a - b);  // 7
            //Console.WriteLine(a * b);  // 30
            //Console.WriteLine(a / b);  // 3 
            //Console.WriteLine(a % b);  // 1

            #endregion


            #region  Logical Operations

            //bool x = true;
            //bool y = false;

            //Console.WriteLine(x && y);  // false
            //Console.WriteLine(x || y);  // true
            //Console.WriteLine(!x);      // false

            #endregion


            #region Assignment Operators
            //int a = 10;

            //a += 5;   // a = 15
            //a -= 2;   // a = 13
            //a *= 2;   // a = 26
            //a /= 2;   // a = 13
            //a %= 5;   // a = 3

            //Console.WriteLine(a); 

            #endregion


            #endregion



            #region String Foramting 

            //1- string concatonation
            //10+5=15
            //int a = 10 ,b=5 ,result =a+b;
            //Console.WriteLine(a + "+" + b + " = "+result);

            // 2-CompositeFormating

            //Console.WriteLine("{0} + {1} = {2}",a,b,result);


            //3-string.format


            //string message = string.Format("{0} + {1} = {2}", a, b, result);
            //Console.WriteLine(message);



            //4 interpolation 
            //Console.WriteLine($"{a} + {b} = {result}");




            Console.WriteLine(@"C: \Users\sayed\OneDrive\Desktop\all_projects\Session3\Session3.sln");






            #endregion


            #region conditional statments

            #region if statement exampl_1

            //Console.WriteLine("please Enter the month number existed in 1ST quarter");
            //int.TryParse(Console.ReadLine(), out int month);

            //if (month == 1)
            //{

            //    Console.WriteLine("jeanuary");

            //}
            //else if (month == 2)
            //{


            //    Console.WriteLine("february");

            //}
            //else if (month == 3)
            //{

            //    Console.WriteLine("march");

            //}else
            //{

            //    Console.WriteLine("invalid month");
            //}

    
                #region switch


            //switch (month)
            //{
            //    case 1:
            //        Console.WriteLine("february");
            //        break;

            //    case 2:
            //        Console.WriteLine("february");
            //        break;

            //    case 3:

            //        Console.WriteLine("march");
            //        break;

            //    default:
            //        Console.WriteLine("invalid month");
            //        break;

            //}


            #endregion


            #endregion

            #region Example_2

            //int age =22;

            //switch(age)
            //{
            //    case > 22:
            //        Console.WriteLine("he is greater than 22");
            //        break;
            //    case < 22:
            //        Console.WriteLine("less than 22");
            //        break;
            //    default:
            //        Console.WriteLine("he is 22 ");
            //        break;
            //}


            #endregion


            #endregion


        }
    }
}
