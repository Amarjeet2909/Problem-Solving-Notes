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
            // This is single line comment example

            /* 
               This is a multi line comment 
               structure example
            */

            /* 
                Data Type in C#:-
                Integer: int var; 4 bytes
                Character: int var = 'A'; 2 bytes
                Boolean: bool isGreat = true; 1 bit
                Floating: float num; 4 bytes
                String: string str = "Amar"; 2 bytes per char
                Long: long amar; 8 bytes
                Double: double amar; 8 bytes

            */

            /*
                // Data type 
                int var1 = 10;
                double var2 = 12.2;
                // While declaring float type variable use 'F' while declaring it otherwise  it will throw a error 
                // Bcs C# is type safe language and decimal number is by default double that's why we should mention
                float var3 = 12.3F;
                char var4 = 'A';
                bool isTrue = false;
                string str = "Hey BoldTek";
                long lng = 6328762;
            */

            /*
                // Printing the diffrent type of variables decalred above
                Console.WriteLine("Hello Amarjeet");
                Console.WriteLine("Your Intger number is: " + var1);
                Console.WriteLine("Your Double number is: " + var2);
                Console.WriteLine("Your Float number is: " + var3);
                Console.WriteLine(var2 + var3);
                Console.WriteLine("Character is: " + var4);
                Console.WriteLine("Boolean Value is:" + isTrue);
                Console.WriteLine("String is: " + str);
                Console.WriteLine("Long value is: " + lng);
            */

            /* 
                Type casting:-
                There are two type of type casting
                1. Implicit casting: Happens automatically
                  char to int to long to float to double

                2.Explicit casting: Happens manually
                int x = (int) 3.5;
                double x1 = (double) 3.5;
            */

            /*
                // Another way to Typecast
                float var = Convert.ToInt32(5.46);
                Convert.ToString(Variable_name);
                Convert.ToDouble(Variable_name);
                Console.WriteLine("Through aother way of typecasting " + var);
            */

            // /*
            // Taking user Input: User Input in C# takes string, If we want to use some other type of variable then convert it after taking input
            Console.WriteLine("Enter Your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Your name is: " + name);

            Console.WriteLine("Enter the Number of candy you want: ");
            string candy = Console.ReadLine();
            Console.WriteLine("Total no of candy you will get is: " + (Convert.ToInt32(candy) + 4));

            // */

            // This is to instruct the console to present until I close it
            Console.ReadLine();
        }
    }
}
