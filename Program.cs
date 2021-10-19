using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparision
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2,z;
            double x3, y3, x4, y4, z2;

            Console.WriteLine("Enter the Points x1,y1, and x2,y2 to find the Length of the First Line");//getting input from the user
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Points x3,y3, and x4,y4 to find the Length of the Second Line");//getting input from the user
            x3 = double.Parse(Console.ReadLine());
            y3 = double.Parse(Console.ReadLine());
            x4 = double.Parse(Console.ReadLine());
            y4 = double.Parse(Console.ReadLine());
            z = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));//length of the 1st line 
            z2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));//length of the 2st line 
            if (z == z2)
            {
            Console.WriteLine("Two Lines Are Equal.");
            }
            else
            {
                Console.WriteLine("Two Lines Are Not Equal");
            }
            Console.ReadLine();
        }
    }
}
