using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 创建10个对象，通过一个循环，去调用他们各自打招呼的方法
            Person person = new Person();
            Student student = new Student();
            Teacher teacher = new Teacher();
            Meinv meinv = new Meinv();
            Shuaiguo shuaiguo = new Shuaiguo();
            Yeshou yeshou = new Yeshou();

            Person[] per = new Person[10];

            Random r = new Random();

            for(int i = 0; i < per.Length; i++)
            {
                int rNumber = r.Next(1,7);
                switch(rNumber)
                {
                    case 1:
                        per[i] = new Person();
                        break;
                    case 2:
                        per[i] = new Student();
                        break;
                    case 3:
                        per[i] = new Teacher();
                        break;
                    case 4:
                        per[i] = new Meinv();     
                        break;
                    case 5:
                        per[i]= new Shuaiguo();
                        break;
                    case 6:
                        per[i]= new Yeshou();
                        break;
                }
            }

            for (int i = 0; i < per.Length; i++)
            {
                if (per[i] is Student)
                {
                    ((Student)per[i]).StudentSay();
                }
            }

            // 里氏转化 第一条 子类可以赋值给父类
            // person = student;

                // 里氏转化 第二条 如果父类中装的是子类对象，那个可以把这个父类强制转换成子类对象
                // student = (Student)person;
                //通过这个的转换 ，父类也可以调用子类的成员
                // student.PersonSay();





        }
    }

    public class Person
    {
        public void PersonSay()
        {
            Console.WriteLine("我是人类");
        }
    }
    public class Student : Person
    {
        public void StudentSay()
        {
            Console.WriteLine("我是学生");
        }
    }
    public class Teacher : Person
    {
        public void TeacherSay()
        {
            Console.WriteLine("我是老师");
        }
    }
    public class Meinv : Person
    {
        public void MeinvSay()
        {
            Console.WriteLine("我是美女");
        }
    }
    public class Shuaiguo : Person
    {
        public void ShuaiguoSay()
        {
            Console.WriteLine("我是帅哥");
        }
    }
    public class Yeshou : Person
    {
        public void YeshouSay()
        {
            Console.WriteLine("我是野兽");
        }
    }
}
