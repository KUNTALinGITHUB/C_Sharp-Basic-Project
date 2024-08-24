using System;
using System.Threading;
class Claculator
{
    public static void Main(string[] args)
    {
       


        for (Int32 i = 0; i >= 0; i++)
        {

            System.Console.WriteLine("                                       " + " Welcome to my area calculator " + "                                               ");
            System.Console.WriteLine("      " + " ...calculate area(feet) of circle, rectangle, triangle, trapezoid, sector, ellipse, parallelogram... " + "       \n");
            System.Console.Write("Choose the option: ");
            Thread.Sleep(500);
            System.Console.Write("1.area of circle ");
            Thread.Sleep(500);
            System.Console.Write("2.area of rectangle ");
            Thread.Sleep(500);
            System.Console.Write("3.area of triangle ");
            Thread.Sleep(500);
            System.Console.Write("4.area of trapezoid ");
            Thread.Sleep(500);
            System.Console.Write("5.area of ellipse ");
            Thread.Sleep(500);
            System.Console.Write("6.exit.... ");
            Int32 option = Convert.ToInt32(System.Console.ReadLine());
            switch (option)
            {
                case 1:
                    System.Console.Write("You choose the option: 1.area of circle ");
                    System.Console.Write("enter the redious of the circle(in feet): ");
                    float r = (float)Convert.ToDecimal(System.Console.ReadLine());
                    double Carea = 3.141592653 * (r * r);
                    System.Console.WriteLine("the area of the circle is: {0}feet", Carea);
                    break;
                case 2:
                    System.Console.Write("You choose the option: 2.area of rectangle ");
                    System.Console.WriteLine("enter the length and width of the rectangle(in feet): ");
                    float len = (float)Convert.ToDecimal(System.Console.ReadLine());
                    float wid = (float)Convert.ToDecimal(System.Console.ReadLine());
                    double Rarea = len * wid;
                    System.Console.WriteLine("the area of the rectangle is: {0}feet", Rarea);
                    break;
                case 3:
                    System.Console.Write("You choose the option: 3.area of triangle ");
                    System.Console.WriteLine("enter the bash and hight of the triangle(in feet): ");
                    float bas = (float)Convert.ToDecimal(System.Console.ReadLine());
                    float Hig = (float)Convert.ToDecimal(System.Console.ReadLine());
                    double Tarea = 0.5 * bas * Hig;
                    System.Console.WriteLine("the area of the triangle is: {0}feet", Tarea);
                    break;
                case 4:
                    System.Console.Write("You choose the option: 4.area of trapezoid ");
                    System.Console.WriteLine("enter the lengh of first-bash and length of secound-bash and hight of the trapezoid(in feet): ");
                    float bas1 = (float)Convert.ToDecimal(System.Console.ReadLine());
                    float bas2 = (float)Convert.ToDecimal(System.Console.ReadLine());
                    float hig = (float)Convert.ToDecimal(System.Console.ReadLine());
                    double Trarea = 0.5 * (bas1 + bas2) * hig;
                    System.Console.WriteLine("the area of the triangle is: {0}feet", Trarea);
                    break;
                case 5:
                    System.Console.Write("You choose the option: 5.area of ellipse ");
                    System.Console.WriteLine("enter the lengh of mejor axis and length of minor axis of the trapezoid(in feet): ");
                    float axis1 = (float)Convert.ToDecimal(System.Console.ReadLine());
                    float axis2 = (float)Convert.ToDecimal(System.Console.ReadLine());
                    double Earea = 3.141592653 * axis1 * axis2;
                    System.Console.WriteLine("the area of the triangle is: {0}feet", Earea);
                    break;
                case 6:
                    System.Console.WriteLine("Exit.....");
                    Environment.Exit(0);
                    break;
                default:
                    System.Console.WriteLine("Invalid input....");
                    break;
            }
        }

    }
}
