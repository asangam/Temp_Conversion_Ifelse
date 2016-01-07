using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp_Conversion_Ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            double c, f, k;
            label: 
            Console.Write("\n Enter 1 to Convert from Celsius to Fahrenheit");
            Console.Write("\n Enter 2 to Convert from Fahrenheit to Celsius");
            Console.Write("\n Enter 3 to convert from Celsius to Kelvin");
            Console.Write("\n enter 4 to convert from Kelvin to Celsius");
            Console.Write("\n enter 5 to convert from Kelvin to Fahrenheit");
            Console.Write("\n Enter 6 to convert from Fahrenheit to Kelvin");
            Console.Write("\n \n Enter your Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("\n Enter number in celsius: ");
                c = Convert.ToDouble(Console.ReadLine());
                f = (c * 9 / 5) + 32;
                Console.Write("\n {0} Celsius is  {1} Fahrenheit\n\n", c, f);


                Console.Write("\n Do you want to convert another? y/n ");
                char ch = Convert.ToChar(Console.ReadLine());
                Console.Clear();
                if (ch == 'y' || ch == 'Y')
                    goto label;
                else return;

            }

            else if (choice == 2)
            {
                Console.Write("\n Enter number in Fahrenheit: ");
                f = Convert.ToDouble(Console.ReadLine());
                c = (f - 32) * 5 / 9;
                Console.Write("\n {0} Fahrrenheit is equal to {1} Celsius", f, c);
            }
            else if (choice == 3)
            {
                Console.Write("\n Enter number in Celsius: ");
                c = Convert.ToDouble(Console.ReadLine());
                k = c + 273.15;
                Console.Write("\n {0} Celsius is equals to {1} Kelvin", c, k);
            }
            else if (choice == 4)
            {
                Console.Write("\n Enter number in Kelvin: ");
                k = Convert.ToDouble(Console.ReadLine());
                c = k - 273.15;
                Console.Write("\n {0} Kelvin equals to {1} Celsius", k, c);
            }
            else if (choice == 5)
            {
                Console.Write("\n Enter number in Kelvin: ");
                k = Convert.ToDouble(Console.ReadLine());
                f = (k - 273.15) * 9 / 5 + 32;
                Console.Write("\n {0} Kelvin equals to {1} Fahrenheit", k, f);

            }

            else if (choice == 6)
            {
                Console.Write("\n Enter number in Fahrenheit: ");
                f = Convert.ToDouble(Console.ReadLine());
                k = (f - 32) * 5 / 9 + 273.15;
                Console.Write("\n {0} Fahrenheit is equals to {1} Kelvin", f, k);

            }


            else
            Console.Clear();
            Console.Write("\n Invalid Options Given\n\n");
            goto label;
        }
    }
}
