using System;

namespace chsarp
{
    class Program {
        static void Main(String[]args){
            Println();
            Variable();
        }
        static void Println(){
            Console.WriteLine("I am Learning C#");
            Console.WriteLine("It is awesome!");
            Console.WriteLine(3 + 3);
            // Write method is similar to WriteLine method but do not insert a new line at the end
            /*Comments are similar to
            JavaScript comments
            */
        }
        static void Variable(){
            /*Types of Variables
            int - stores integers (whole numbers), without decimals, such as 123 or -123
            double - stores floating point numbers, with decimals, such as 19.99 or -19.99
            char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
            string - stores text, such as "Hello World". String values are surrounded by double quotes
            bool - stores values with two states: true or false*/
            int Integer = 24;
            double Decimal = 3.14;
            char character = 'A';
            string Text = "Hello World";
            bool boolean = true;
        }
    }
}