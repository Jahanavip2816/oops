// See https://aka.ms/new-console-template for more information

using System.IO.Pipelines;

namespace Program
{
    // Demonstration of Encapsulation
    public class Employee
    {
        public int empExp;

        static void Main(string[] args)
        {
            Employee objEmp = new Employee();
            objEmp.empExp = 3;

            Console.WriteLine("Experience" + objEmp.empExp);

        }

        // public class Employee
        // {
        //     private int empExp;

        //     public int EmpExp
        //     {
        //         get { return empExp; }

        //         set { empExp = value; }
        //     }
        //         static public void Main()
        //         {
        //             Employee objEmp = new Employee();
        //             objEmp.EmpExp = 3;

        //             // Displaying value
        //             Console.WriteLine(" Experience: " + objEmp.EmpExp);
        //         }
        //     }
    }
}
//     class Car
    // {
    //     public string Brand;
    //     public string Color;

    //     // Constructor (same name as class)
    //     public Car(string brand, string color)
    //     {
    //         Brand = brand;
    //         Color = color;
    //     }

    //     public void Drive()
    //     {
    //         Console.WriteLine(Brand + " is driving...");
    //     }
    // }

    // class Program
    // {
    //     static void Main()
    //     {
    //         // Object created with values directly
    //         Car car1 = new Car("BMW", "Red");
    //         Car car2 = new Car("Audi", "Black");

    //         car1.Drive();   // BMW is driving...
    //         car2.Drive();   // Audi is driving...
    //     }




    // public class Program
    // {
    //     public void Calc(double c) {

    //         // int age = 24;
    // System.Console.WriteLine("my age is " + age);
    // System.Console.WriteLine("Hello, World!");
    // System.Console.WriteLine(23 + 25);

    // int myInt = 10;
    // double myDouble = 5.25;
    // bool myBool = true;
    // string myString = "jaanu";

    // Console.WriteLine(Convert.ToString(myInt));    // convert int to string
    // Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
    // Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
    // Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
    // Console.WriteLine(myString);  

    // int i = 345;
    // float a = i;
    // Console.WriteLine(a);

    // float f1 = 4567.3334F;
    // int i1 = Convert.ToInt32(f1);

    // Console.WriteLine(i1);

    // string strNumber = "123";
    // int number = int.Parse(strNumber); // Succeeded, number is 123
    // Console.WriteLine(number);

    // string strInvalid = "abc";
    // int invalidNumber = int.Parse(strInvalid); // Throws a FormatException

    // Console.WriteLine(invalidNumber);

    // string a = "abcd12";
    // int n;
    // bool s = int.TryParse(a, out n);
    // Console.WriteLine(s);

    // Console.WriteLine("Enter your name:");
    // string name = Console.ReadLine();
    // Console.WriteLine("Your name is:" + name);

    // Console.WriteLine("Enter your age:");
    // int age =Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine("Your age is:" +age);

    // int a = 10;
    // int b = 20;

    // Console.WriteLine("Result of " + a + " and " + b + " is " + (a + b));

    // MATH METHODS //

    // Console.WriteLine(Math.Max(10, 3));
    // Console.WriteLine(Math.Min(10, 3));
    // Console.WriteLine(Math.Sqrt(4));
    // Console.WriteLine(Math.Abs(-3.45));
    // Console.WriteLine(Math.Round(5.5));
    // Console.WriteLine(Math.Min(10, -10));
    // Console.WriteLine("Sin(PI/2) = " + Math.Sin(Math.PI / 2));
    // Console.WriteLine("Cos(0) = " + Math.Cos(0));
    // Console.WriteLine("Tan(PI/4) = " + Math.Tan(Math.PI / 4));
    // Console.WriteLine("Atan(1) = " + Math.Atan(1));
    // Console.WriteLine("Atan2(1,1) = " + Math.Atan2(1, 1));
    // Console.WriteLine(Math.PI);
    // Console.WriteLine(Math.E);
    // Console.WriteLine(Math.Ceiling(5.5));
    // Console.WriteLine(Math.Floor(5.5));
    // Console.WriteLine(Math.Truncate(5.5));
    // Console.WriteLine(Math.Pow(5, 5));
    // Console.WriteLine(Math.Cbrt(27));
    // Console.WriteLine(Math.Exp(5));
    // Console.WriteLine(Math.Log(5));// Returns base e
    // Console.WriteLine(Math.Log10(5));// Returns base 10


    // Console.WriteLine("Enter a number");
    // int a = Convert.ToInt32(Console.ReadLine());
    // if (a >= 18)
    // {
    //     Console.WriteLine("a can have lisence");
    // }
    // else
    // {
    //     Console.WriteLine("They are minor");
    // }

    // Conditional Statements //

    // Console.WriteLine("Enter a number");
    // int a = Convert.ToInt32(Console.ReadLine());
    // if (a < 0)
    // {
    //     Console.WriteLine("a is negative");
    // }
    // if (a > 0)
    // {
    //     Console.WriteLine(" a is positive");
    // }
    // else
    // {
    //     Console.WriteLine("a is zero");
    // }

    // Loops //

    // for (int i = 1; i <= 10; i++)
    // {
    //     if (i == 7)
    //     {
    //         continue;
    //     }
    //     if (i % 2 != 0)
    //     {
    //         Console.WriteLine(i);
    //     }
    // }

    // int i = 1;
    // while (i <= 10)
    // {
    //     if (i % 2 != 0)
    //     {
    //         Console.WriteLine(i);
    //     }
    //     i++;
    // }

    // int a = 1;
    // while (a <= 10)
    // {
    //     Console.WriteLine(a);
    //     a += 2;
    // }

    // int b = 1;
    // do
    // {
    //     Console.WriteLine(b);
    //     if (b == 7)
    //     {
    //         break;
    //     }
    //     b += 2;
    // }
    // while (b <= 10);

    //     double f = ((9 * c) / 5) + 32;
    //     Console.WriteLine("Fahrenheit value is " + f);
    // }
    // static void Main(string[] args)
    // {
    //     double c;
    //     Console.WriteLine("Enter Centigrade value ");
    //     c = Convert.ToDouble(Console.ReadLine());
    //     Program obj = new Program();
    //     obj.Calc(c);



// }

//         }
        
//     }
