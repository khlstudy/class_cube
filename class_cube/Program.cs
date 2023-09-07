using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_cube
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            double x;
            try
            {
                Console.Write("x="); x = Convert.ToDouble(Console.ReadLine());
                Cube cube = new Cube(x);
                cube.Print();
                if (cube.Correct()) //перевірка існування куба
                {
                    double area = cube.Area();
                    double v = cube.Volume();
                    Console.WriteLine("Area={0} Volume={1}", area, v);
                }
                else Console.WriteLine("Такого куба не існує");
            }
            catch
            {
                Console.WriteLine("Помилка!");
            }
            Console.ReadLine();
        }
        public class Cube
        {
            double a;
            
            public Cube()
            { }

            public Cube(double x)
            { a = x; }

            public void Print() //виводить на екран значення поля
            { Console.WriteLine("a={0}", a); }

            public double Area() //обчислює площу поверхні куба
            { 
                double area = Math.Pow(a, 2) * 6; 
                return area;
            }

            public double Volume() //обчислює обсяг куба
            {
                double v = Math.Pow(a, 3);
                return v;
            }

            public bool Correct() //перевіряє, чи може існувати такий об'єкт
            {
                bool c = false;
                if (a > 0) { c = true; }
                return c;
            }
        }
    }
}
