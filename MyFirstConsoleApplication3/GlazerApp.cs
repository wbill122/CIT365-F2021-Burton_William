using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication3
{
     class GlazerApp
     {
         public static void RunExample()
         {
             double width, height, woodLength, glassArea;
             string widthString, heightString;

             widthString = Console.ReadLine();
             width = double.Parse(widthString);
           

             heightString = Console.ReadLine();
             height = double.Parse(heightString);

             woodLength = 2 * (width + height) * 3.25;
             glassArea = 2 * (width * height);

             Console.WriteLine("The Length of the wood is " + woodLength + " feet ");
             Console.WriteLine("The Area of the Glass is " + glassArea + "square meter");
         }
     }
}
