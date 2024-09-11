using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp5
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 继承
            // 把公共的一些成员 抽离出来 写成一个类
            // 继承可以继承字段，方法
            // 父类 也叫基类
            // 子类 也叫派生类
            // 子类继承父类的方法和属性，但是继承不了父类的私有方法和属性
            // 子类继承只能继承一个父类
            // 继承具有传递性 person     a: person  b:a  c:b  c也可以拿到person的公共属性和方法
            // 子类不能继承父类的构造函数，但是子类会默认调用父类无参的构造函数，创建父类的对象，让子类可以使用父类的成员
            // 解决办法 重新在父类中写一个无参数的构造函数
            // 在子类中使用 :Base
       
        }

        public class Person
        {
            public string Name { get; set; }
            public int age { get; set; }
            public string gender { get; set; }
            public string op = "苗苗";

            public Person(string name)
            {
                this.Name = "小苗苗";
                this.age = 14;

            }
            
        }
        public class Student : Person
        {
            public Student(string name) :base(name)
            {

            }
            public void test()
            {
                Console.WriteLine(op);
            }
        }
    }
}
