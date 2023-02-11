using System;
namespace Basics1
{
    class square
    {
        public void areas()
        {
            double side, area;
            Console.WriteLine("Enter the Length of Side : ");
            side = Convert.ToDouble( Console.ReadLine());
            area = side * side;
            Console.WriteLine("\nArea of Square: " + area);          
            Console.ReadKey();
        }
    }
};