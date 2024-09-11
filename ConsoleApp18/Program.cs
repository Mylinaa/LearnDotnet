using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Yazi1 yazu1 = new Yazi1("木头", "吱吱");
            Yazi2 yazu2 = new Yazi2("橡皮", "唧唧");
            Yazi3 yazu3 = new Yazi3("真的", "嘎嘎");
            Yazi[] yaziArr = new Yazi[3] { yazu3, yazu1, yazu2 };
            for (int i = 0; i < yaziArr.Length; i++)
            {
                yaziArr[i].Say();
            }
            
        }
    }
    public class Yazi
    {
        // 字段
        public string _name;
        public string _sound;
        // 定义属性
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Sound
        {
            get { return _sound; }
            set { _sound = value; }
        }
        // 定义构造函数
        public Yazi(string name,string sound)
        {
            Name = name;
            Sound = sound;
        }
        // 定义方法
        public virtual void Say()
        {
            Console.WriteLine("我是鸭子");
        }
    }

    public class Yazi1: Yazi
    {
        public Yazi1(string name,string sound): base(name,sound)
        {

        }
        public override void Say()
        {
            Console.WriteLine("{0}鸭子，{1}叫", Name, Sound);
        }
    }
    public class Yazi2: Yazi
    {
        public Yazi2(string name,string sound): base(name,sound)
        {

        }
        public override void Say()
        {
            Console.WriteLine("{0}鸭子，{1}叫", Name, Sound);
        }
    }
    public class Yazi3 : Yazi
    {
        public Yazi3(string name, string sound) : base(name, sound)
        {

        }
        public override void Say()
        {
            Console.WriteLine("{0}鸭子，{1}叫", Name, Sound);
        }
    }
}
