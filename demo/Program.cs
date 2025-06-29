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

            Console.WriteLine("please enter your name ");
            string? name = Console.ReadLine();

            Console.WriteLine("please enter your age ");
            int? age = (int.Parse(Console.ReadLine()));

            Console.WriteLine("enter your salary ");
            decimal? Salary = decimal.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("name is :" + name);
            Console.WriteLine("age :{0}", age);
            Console.WriteLine("salary{0:c}", Salary);

            #endregion
            #endregion

        }
    }
}
