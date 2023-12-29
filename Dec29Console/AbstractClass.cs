using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec29Console
{
    public abstract class Shap
    {
        public abstract void CalArea();
    }
    public class Circle : Shap{
    public override void CalArea()
        {
            double r = 3.5;
            double area = 3.14 * r * r;
            Console.WriteLine("Area of Circle(r={0}) : {1} ",r,area);
        }
    }
    public class Square : Shap
    {
        public override void CalArea()
        {
            double side = 5.556;
            double area=side * side;
            Console.WriteLine("Area of square(side={0}): {1} ", side, area);
        }
    }
    public class AbstractClass
    {
        static void Main(string[] args)
        {
            Shap circle=new Circle();
            Shap square=new Square();
            circle.CalArea();
            square.CalArea();
            Console.ReadLine(); 
        }
    }
}
