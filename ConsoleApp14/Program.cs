using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 多态
            // 让一个对象能到表现出多种的类型（状态）
            // 实现多态的方法有 1、虚方法 2、接口 3、抽象类

            // 父类 方法前加 标记虚方法 virtual
            // 子类 方法前加标记 override

        }
    }

    public class Person
    {
        private string _name;
        public string Name { get { return _name; } set { _name = value;} }

        public Person(string name)
        {
            this.Name = name;
        }
        public virtual void PersonSay()
        {
            Console.WriteLine("我是一个人类哦");
        }
    }

    public class Chinese : Person
    {
        public Chinese(string name) : base(name)
        {
            
        }

        public override void PersonSay()
        {
            Console.WriteLine("我是一个123123123123");
        }

        public void ChineseSay()
        {
            Console.WriteLine("我是中国人1,我叫{0}",this.Name);
        }
    }
}
