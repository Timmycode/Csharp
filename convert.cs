using System;

namespace Basics1
{
    class convert
    {
        public void convertDays()
      {
            
            int days, years, weeks;
            Console.WriteLine("Enter days:");
            days = Convert.ToInt32( Console.ReadLine());
            years = (days / 365);
            weeks = (days % 365) / 7;
            days = days - ((years * 365) + (weeks * 7));
            Console.WriteLine("Years : "+ years);
            Console.WriteLine("weeks : "+ weeks);
            Console.WriteLine("Days : "+ days);
                    
            Console.ReadKey();
        }
    }
};