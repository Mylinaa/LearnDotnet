using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 多态 一个对象可以表现出多种类型
           
            Chinese cn1 = new Chinese("李梅");
            Chinese cn2 = new Chinese("高圆圆");
            Japanese j1 = new Japanese("树下君");
            Japanese j2 = new Japanese("樱花子");
            Korea k1 = new Korea("思密达");
            Korea k2 = new Korea("金秀贤");
            American a1 = new American("kebe");
            American a2 = new American("ainoer");
            Person[] people = new Person[8] { cn1, cn2, j1, j2, k1, k2, a1, a2 };

            for (int i = 0; i < people.Length; i++)
            {
                people[i].SayHello();
                // 显示子类的方法
                if (people[i] is Chinese)
                {
                    ((Chinese)people[i]).SayHello();
                }
            }

            Console.WriteLine("------------------------");
            // 实现多态
            // 虚方法，抽象类，接口
            // 虚方法
            // 先把父类的方法标记为虚方法 使用关键字  父类方法前加 virtual 子类方法前加 override
            for (int i = 0; i < people.Length; i++)
            {
                people[i].SayHello();
            }

        }
    }
    public class Person
    {
        // 字段
        private string _name;
        // 属性
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        // 构造函数
        public Person(string name)
        {
            this.Name = name;
        }
        public virtual void SayHello()
        {
            Console.WriteLine("我是人类");
        }


    }
    public class Chinese : Person
    {
        public Chinese(string name): base(name)
        {

        }
        public override void SayHello()
        {
            Console.WriteLine("我是中国人，我的名字是{0}",this.Name);
        }
    }
    public class Japanese: Person
    {
        public Japanese(string name): base(name)
        {

        }
        public override void SayHello()
        {
            Console.WriteLine($"我是日本人，我的名字是{Name}");
        }
    }
    public class Korea: Person
    {
        public Korea(string name): base(name)
        {

        }
        public override void SayHello()
        {
            Console.WriteLine("我是韩国人，我叫{0}", this.Name);
        }
    }
    public class American: Person
    {
        public American(string name): base(name)
        {

        }
        public override void SayHello()
        {
            Console.WriteLine("我是美国人{0}",this.Name);
        }
    }


   
}
