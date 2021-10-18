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
            Console.WriteLine("Enter the Points x1,y1, and x2,y2");//getting input from the user
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            z = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));//length of the line
            Console.WriteLine("Length of the line:{0}",z);
            Console.ReadLine();
        }
    }
}
