using System;

namespace Checkout
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Below is a demo of the Till()");

            // Arrange
            Till till = new Till();
            
            // Act
            till.Scan("BCCbCcCCC"); 

            Console.WriteLine("Total cost = " + till.Total());      // Total cost = 165 for items "BCCbCcCCC"
        }
    }
}
