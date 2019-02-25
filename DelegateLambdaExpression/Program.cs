using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLambdaExpression
{
    public delegate int MyDelegateSingleArg(int x);
    public delegate void MyDelegateMultipleArgs(int x , string y);
    public delegate bool MyDelegateBool(int x);

    class Program
    {
        static void Main(string[] args)
        {
            // Create the basic delegates that square a number
            MyDelegateSingleArg foo = (x) => x * x;
            // what does that (x) means, it takes the input and return square 
            // (x) -> input 
            // x * x -> output
            // => the arrow operator mean such that or goes to 
            Console.WriteLine($"The result of Foo is : {foo(5)}");

            // Dynamically change the delegate to something else 
            foo = (x) => x * 10;
            Console.WriteLine($"The result of Foo is : {foo(5)}");

            // Create the Delegate that take multiple arguments
            MyDelegateMultipleArgs bar = (x, y) =>
            {
                Console.WriteLine($"Two Lambda Expression -{x * 10} - {y}");
            };
            bar(5, "some string data");

            MyDelegateBool boo = (x) => x > 15; 

            Console.ReadKey();
                
        }
    }
}
