using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reporter reporter = new Reporter("苗苗",16,'女',"当记者");
            reporter.ReporterSay();
            Programmer programmer = new Programmer("胡浩",17,'男',"做程序猿",10);
            programmer.ProgrammerSay();
            programmer.ReporterSay();



        }
    }

    public class Person
    {
        public string _name;
        public string Name { 
            set { this._name = value; }
            get { return this._name;} 
        }
        public int _age;
        public int Age
        {
            set { this._age = value; }
            get { return this._age; }
        }
        public char _gender;
        public char Gender
        {
            set { this._gender = value; }
            get { return this._gender; }
        }

        public Person(string Name,int Age,char Gender)
        {
            this.Name = Name;
            this.Age = Age;
            this.Gender = Gender;
        }
    }

    public class Reporter : Person
    {
        public Reporter(string Name, int Age, char Gender,string Hobby) : base(Name,Age,Gender)
        {
            this.Hobby = Hobby;
        }
        public string _hobby;
        public string Hobby
        {
            set { this._hobby = value; }
            get { return this._hobby; }
        }
        public void ReporterSay()
        {
            Console.WriteLine("我叫{0}，今年{1}岁，性别是{2}，爱好是{3}",Name,Age,Gender,Hobby);
        }
    }

    public class Programmer : Reporter
    {
        public Programmer(string Name, int Age, char Gender, string Hobby,int WorkYear) : base(Name,Age,Gender,Hobby)
        {
            this.WorkYear = WorkYear;
        }

        public int _workYear;
        public int WorkYear
        {
            set { this._workYear = value; }
            get { return this._workYear; }
        }
        public void ProgrammerSay()
        {
            Console.WriteLine("我叫{0}，今年{1}岁，性别是{2}，爱好是{3},工作年限是{4}", Name, Age, Gender, Hobby,WorkYear);
        }

        public new void ReporterSay()
        {
            Console.WriteLine("11111111111111");
        }
    }
}
