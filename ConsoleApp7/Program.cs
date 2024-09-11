using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 里氏转换
            // 子类可以赋值给父类
            // 如果某些地方需要一个父类作为参数，可以把子类代替传过去
            Student s = new Student();
            Person p = s;


            // 如果父类中装的是子类对象，那个可以把这个父类强制转换成子类对象
            // 子类可以调用父类，父类只能调用父类自己的成员
            Student ss = (Student)p;
            ss.StudentSay();

            // 里氏转化判断
            // as is
            // is 父类  is  子类  父类中如果有子类对象 返回 true 否则 返回 false

            // as 如果可以返回 返回对应的对象，否则返回一个null
            if(p is Student)
            {
                Student t = (Student)p;
                t.StudentSay();
            } else
            {
                Console.WriteLine("转化失败");
            }

            Student T = p as Student;
            T.StudentSay();



            Person person = new Person();
            person.PersonSay();

            Student student = new Student();

            student.PersonSay();
            student.StudentSay();

            Teacher teacher = new Teacher();


        }
    }

    public class Person
    {
        public void PersonSay()
        {
            Console.WriteLine("我是父类");
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
            Console.WriteLine("我是教师");
        }
    }
}
