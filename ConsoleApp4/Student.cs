using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Student
    {
        // 构造函数 修饰符 必须是public
        // 创建对象的时候会执行构造函数
        public Student(string name,int age,char gender) {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public Student(string name,int age): this(name,age,'女')
        {
           
        }







        private string _name;
        public string Name
        {
            set { this._name = value;}
            get { return this._name;}  
        }

        private int _age;
        public int Age
        {
            set {
                if(value < 0 || value > 100)
                {
                    value = 0;
                }
                this._age = value; 
            }
            get { return this._age; }
        }

        private char _gender;
        public char Gender {
            get { return this._gender;}
            set { this._gender = value; } 
        }

        public void Say()
        {
            Console.WriteLine("我的名字是{0}，年龄{1}，性别是{2}",this.Name, this.Age,this.Gender);
        }

    }
}
