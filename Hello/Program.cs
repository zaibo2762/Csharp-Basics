using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int harry = 34;
            /*
             datatypes in C#:
            Integr - int harry; --> 4 bytes
            Long - long harry; --> 8 bytes
            floating point - float that;  --> 4 bytes
            Character - char a = 'A';  --> 2 bytes
            Boolean - bool isGreat = true;  --> 1 bit
            String - string inp = "HArry';  --> 2 bytes per characters
            */
            //string inp = Console.ReadLine();
            //Console.WriteLine(inp);
            //Console.WriteLine("Hello World!");
            //Console.Write("hello Zohaib");
            //Console.WriteLine("i love c# and the number " +harry);



            // Data Types

            //int a = 34;
            //float b = 34.4F;
            //double c = 34.4;
            //bool isGreat = true;
            //char d = 'a';
            //string e = "This is a String";
            //Console.WriteLine(e);
            //Console.WriteLine(d);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(isGreat);

            //Type CAsting - toconvert from one datatype to another
            //Two types:


            // 1. Implicit Casting

            // char to int to long to float to double
            //int a = 3;
            //double b = a;
            //int c = 'b';
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);


            // 2. Explicit Casting

            //int x = (int) 3.5;
            //double x1 = (double) 3.5;
            //double y = 'x';
            //float varr = Convert.ToInt32(3.55);
            //string x2 = "34 is Amazing";
            //float ax = 34.4F;
            //Console.WriteLine(x);
            //Console.WriteLine(x1);

            //Taking user input

            //Console.WriteLine("Enter Your Name:");
            //string name = Console.ReadLine();
            //Console.WriteLine(name);
            //Console.WriteLine("How many candies do you want:");
            //string can = Console.ReadLine();
            //Console.WriteLine("You will get 4 more candies:" + (Convert.ToInt32(can)+4));
            //Console.ReadLine();

            // Operators

            //1.Arithmatic Operators
            //int a = 4;
            //int b = 5;
            //Console.WriteLine("The value of a + b =" + (a+b));
            //Console.WriteLine("The value of a - b =" + (a-b));
            //Console.WriteLine("The value of a * b =" + (a*b));
            //Console.WriteLine("The value of a / b =" + (a/b));
            //Console.WriteLine("The value of a % b =" + (a%b));

            //Assignment Operator

            //int a = 4;
            //int b = 5;
            //b += 4;
            //a -= b;
            //a *= b;
            //a /= b;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //Logical Operators
            //Console.WriteLine("And Operator");
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);
            //Console.WriteLine(false && true);

            //Console.WriteLine("OR Operator");
            //Console.WriteLine(true || false);
            //Console.WriteLine(true || true);
            //Console.WriteLine(false || false);
            //Console.WriteLine(false || true);

            //Console.WriteLine("Not Operator");
            //Console.WriteLine(!false);
            //Console.WriteLine(!true);

            //Comparison Operators

            //Console.WriteLine(324 > 5);
            //Console.WriteLine(324 < 5);
            //Console.WriteLine(324 == 5);
            //Console.WriteLine(324 >= 5);
            //Console.WriteLine(324 <= 5);
            //Console.WriteLine(324 != 5);

            //Math Class

            //int a = Math.Max(34, 345);
            //int b = Math.Min(34, 345);
            //int d = Math.Abs(34);
            //double c = Math.Sqrt(33);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);

            //String Methods

            //string Hello = "Hello World This is harry!";
            //Console.WriteLine(Hello.Length);
            //Console.WriteLine(Hello.ToUpper());
            //Console.WriteLine(Hello.ToLower());
            //Console.WriteLine(Hello + " How Are You");
            //Console.WriteLine(string.Concat(Hello, " HOw are you"));

            //string Interpolation

            //string name = Console.ReadLine();
            //string candies = Console.ReadLine();
            //Console.WriteLine($"Your name is {name} and you will get {candies} candies");

            //string Hello = "Hello World This is harry!";
            //Console.WriteLine(Hello[0]);
            //Console.WriteLine(Hello.IndexOf("Hello"));
            //Console.WriteLine(Hello.Substring(2));

            // If Else Statements
            //Console.WriteLine("Enter your Age:");
            //string agestr = Console.ReadLine();
            //int age = Convert.ToInt32(agestr);
            //if(age <= 2)
            //{
            //    Console.WriteLine("You are jus born");
            //}
            //else if(age < 10)
            //{
            //    Console.WriteLine("Please Finish your High school");
            //}
            //else if(age < 18)
            //{
            //    Console.WriteLine("you are below 18");
            //}else if(age < 75)
            //{
            //    Console.WriteLine("You Can Drive");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input!");
            //}


            // Switch


            //Console.WriteLine("Enter your Age:");
            //string agestr = Console.ReadLine();
            //int age = Convert.ToInt32(agestr);
            //switch (age)
            //{
            //    case 18:
            //        Console.WriteLine("Please wait for a year");
            //        break;
            //    case 20:
            //        Console.WriteLine("You are 20");
            //        break;
            //    default:
            //        Console.WriteLine("Enjoy");
            //        break;
            //}

            //Loops 

            //While Loops

            //int i = 0;
            //while (i < 20)
            //{
            //    Console.WriteLine(i+1);
            //    i++;
            //}

            //do while loop

            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i + 1);
            //    i++;
            //} while (i < 20) ;

            //for Loop

            //for (int i= 0;i<20;i++)
            //{
            //    Console.WriteLine(i);
            //}

            //break and continue
            //break means that leave the loop forever
            //continue means leave that particular iteration


            //for (int i = 0; i < 20; i++)
            //{
            //    if (i == 0)
            //    {
            //        continue;

            //    }
                
            //    Console.WriteLine(i+1);
                
            //    //break;
            //}

         



            Console.ReadLine();

            
        }
    }
}
