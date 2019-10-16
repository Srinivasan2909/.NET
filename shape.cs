using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingment1
{
    class shape
    {
        public shape()
        {

        }
        public shape(int side)
        {
            int area;
            area = side * side;
            Console.WriteLine("Area is:" + "" + area);
        }
        public shape(int l, int b)
        {
            int area = l * b;
            Console.WriteLine("Area is: " + "" + area);
        }
        public void square()
        {


        }
        public void rect()
        {




        }
        public void cir()
        {
            int r;
            double area;
            Console.WriteLine("Enter the radius of circle");
            r = int.Parse(Console.ReadLine());
            area = (3.14) * r * r;
            Console.WriteLine("Area is: " + "" + area);
        }
        public void tria()
        {
            int b, h;
            double area;
            Console.WriteLine("Enter the height of traingle");
            h = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the base of traingle");
            b = int.Parse(Console.ReadLine());
            area = 0.5 * b * h;
            Console.WriteLine("Area is: " + "" + area);
        }

        static void Main(string[] args)
        {
            shape s = new shape();
            int shap;
            Console.WriteLine("Enter the shape you want to choose:\n 1-Square\n 2-Rectangle\n 3-Circle\n 4-Triangle");
            shap = int.Parse(Console.ReadLine());

            switch (shap)
            {
                case 1:
                    Console.WriteLine("Square is choosen\n");
                    Console.WriteLine("Enter the side of the square");
                    int side;
                    side = int.Parse(Console.ReadLine());
                    shape sha = new shape(side);
                    break;
                case 2:
                    Console.WriteLine("REctangle is choosen\n");
                    int l, b;
                    Console.WriteLine("Enter the length of Rectangle");
                    l = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the breadth of Rectangle");
                    b = int.Parse(Console.ReadLine());

                    shape sh = new shape(l, b);


                    break;
                case 3:
                    Console.WriteLine("Circle is choosen\n");
                    s.cir();
                    break;
                case 4:
                    Console.WriteLine("Triangle is choosen\n");
                    s.tria();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
