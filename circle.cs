using System;

namespace Basics1
{
    class areaofcircle
    {
        public void areaOfCircle()
       {
       double radius, area;                        
            Console.WriteLine("Enter Radius: ");
            radius = Convert.ToDouble( Console.ReadLine());
            area = Math.PI * radius * radius;
            Console.WriteLine("\nArea of circle: "+area);          
            Console.ReadKey();
        }
    }
};