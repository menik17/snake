using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 26);
            Console.SetBufferSize(80, 26);

            HorizontalLine upline = new HorizontalLine(0,78,0,'*');
            HorizontalLine downline = new HorizontalLine(0,78,24,'*');
            VerticalLine leftLine = new VerticalLine(0, 0, 24, '*');
            VerticalLine rightLine = new VerticalLine(78, 0, 24, '*');

            upline.Drow();
            downline.Drow();
            leftLine.Drow();
            rightLine.Drow();


            Console.ReadLine();
        }
    }
}
