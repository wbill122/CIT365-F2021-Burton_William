using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication4
{
    class GlazerApp
    {
        public static void RunExample()
        {
            double width = 0, height, woodLength, glassArea;
            string widthString, heightString;
            
            Console.WriteLine("This will Figure the Area of the Window and wood for the frame. ");
            Console.Write("Please enter the HEIGHT dimension of the Window (in feet only x.xx). "  );
           
            widthString = Console.ReadLine();
            if (widthString != null) width = double.Parse(widthString);

            Console.Write("Please enter the WIDTH dimension of the Window (in feet only x.xx).   ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) ;
            glassArea =  (width * height);

            Console.WriteLine("The Frame Length = " + woodLength + " feet");
            Console.WriteLine("The Area of Window Glass = " + glassArea + " Square Feet");
        }
    }
}
