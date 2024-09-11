using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 当父类的方法不知道如何定义的时候 可以写成抽象类 关键字 abstract
            // abstract 修饰的方法 不能有方法体
            // 抽象类是无法创建对象的;
            // 求矩形，圆形的面积和周长

            Shape s1 = new Circle(5);
            double area = s1.GetArea();
            double permieter = s1.GetPerimeter();
            Console.WriteLine("这个形状的周长是{0}，面积是{1}",area,permieter);
        }
    }
    public abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }
    public class Circle: Shape
    {
        public double _r;
        public double R { get { return _r; } set { _r = value; } }
        public Circle(double r)
        {
            R = r;
        }
        public override double GetArea()
        {
            return Math.PI * R * R;
        }
        public override double GetPerimeter()
        {
            return Math.PI * (R * 2);
        }

    }
    public class Square: Shape
    {
        public double _height;
        public double _weight;
        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public Square(double height,double weight)
        {
            Height = height;
            Weight = weight;
        }
        public override double GetArea()
        {
            return Height * Weight;
        }
        public override double GetPerimeter()
        {
            return 2 * (Height * Weight);
        }
    }
}
