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
            Point p1 = new Point(1,4,'*');
            p1.Draw(p1.x, p1.y, p1.sym);
            
            Point p2 = new Point(3,6,'#');
            p2.Draw(p2.x, p2.y, p2.sym);

            Point p3 = new Point(5, 12, '@');

            Point p4 = new Point(12, 32, '&');

            List<int> numList=new List<int>();
            numList.Add(3);
            numList.Add(1);
            numList.Add(5);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            int sum = 0;
            foreach (int i in numList)
            {
                sum+=i;
            }

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            Console.ReadLine();
        }



    }
}
