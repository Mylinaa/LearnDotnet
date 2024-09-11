using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Person
    {
        // 结构和类的写法相似，但是结构是过程的写法
        // 类 有多态，继承，封装
        // 类有字段，属性，方法
        // 属性就是对字段进行保护和取值，赋值进行限制
        // 属性的本质就是两个方法，set和get
        // 有get和set称呼为可读写属性
        // 只有get称呼为只读属性
        // 只有set称呼为只写属性

        // 字段
        string _name;
        int _age;
        string _gender;

        // 属性
        public string Name
        {
            set 
            {
                this._name = value; 
            }
            get { return _name; }
        }

        public int Age
        {
            set 
            {
                if(value < 0 ||  value > 100)
                {
                    value = 0;
                }
                this._age = value;
            }
            get { return this._age; }
        }

        public string Gender
        {
            set { this._gender = value; }
            get { return this._gender; }
        }

        // 方法
        public void CHLSS()
        {
            Console.WriteLine("吃喝拉撒睡");
            Console.WriteLine("{0},{1},{2}", this.Age.ToString(), this.Gender, this.Name);
        }
    }
}
