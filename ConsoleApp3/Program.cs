using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 创建Person类 对象
            Person person = new Person();
            person.Name = "小乔";
            person.Age = 17;
            person.Gender = "女";
            person.CHLSS();

            Person2 person2 = new Person2();
            person2.M1();

            Person2.M2();
        }
    }
}
