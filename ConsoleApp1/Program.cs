using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // 枚举
    // 枚举就是一个简单的变量类型和int，string一样
    public enum Gender
    {
        man,wman
    }
    public enum Sesons
    {
        春,夏,秋,冬
    }
    public enum QQstate
    {
        // 会默认递增 ONline=23,默认从0开始
        ONline,Offline,Leave,Busy,QME
    }

    // 结构
    // 字段在命名的时候要在前面加下划线和变量作区分_
    // 结构中定义的为字段
    // 和枚举结合使用
    public struct Person
    {
        public string _name; // 字段
        public int _age;
        public char _gender;
        public QQstate _qqState;
    }

    public struct MyColor
    {
        public int _red;
        public int _green;
        public int _blue;
    }
    public enum MyColorEnum
    {
        红色,绿色,蓝色
    }
    public struct Person2
    {
        public string _name;
        public int _age;
        public Gender2 _gender;
    }
    public enum Gender2
    {
        男,女
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
    class learn01
    {
        public static void test()
        {
            Console.WriteLine("Hello World");
            // Console.ReadKey();

            // 声明一个变量
            int num;
            // 给变量赋值
            num = 1232323;
            Console.WriteLine(num);

            int a = 343434;
            Console.WriteLine($"{a}");

            double b = 4.555555;
            Console.WriteLine($"{b}");

            string c = "你好";
            Console.WriteLine($"{c}");

            decimal d = 2323232323m;
            Console.WriteLine($"{d}");

            int number;
            number = 0;
            Console.WriteLine(number);
        }
    }
    class learn02
    {
        public static void test()
        {
            Console.WriteLine("请输入你的姓名");

            string name = Console.ReadLine();
            Console.WriteLine("您的姓名是{0}", name);
            Console.ReadKey();
        }
    }
    class learn03
    {
        public static void test()
        {
            string str = "今天天气好晴朗，处处好风光";
            System.IO.File.WriteAllText(@"D:\Desktop\123.txt", str);
            Console.WriteLine("输入完成");
        }
    }
    class learn04
    {
        public void test()
        {
            int a = 100;
            int b = 20;
            Console.WriteLine(a + b);

            int r = 5;
            double s = Math.PI * r * r;
            double c = Math.PI * 2 * r;
            Console.WriteLine(s);
            Console.WriteLine(c);

            int tShirt = 35;
            int trousers = 120;
            double m = (tShirt * 3 + trousers * 2) * 0.88;
            Console.WriteLine(m);

            int n1 = 10;
            int n2 = 3;
            double n3 = (double)(n1 / n2);
            Console.WriteLine(n3);
        }
    }
    class learn05
    {
        public static void test()
        {
            /*string year;
        string month;
        string day;
        Console.WriteLine("请输入年");
        year = Console.ReadLine();
        Console.WriteLine("请输入月");
        month = Console.ReadLine();
        Console.WriteLine("请输入日");
        day = Console.ReadLine();
        Console.WriteLine(year,month, day);*/

            /*Console.WriteLine("请输入天数");
            string days = Console.ReadLine();
            double week = Int32.Parse(days) / 7;
            double day = Int32.Parse(days) % 7; 302400 Int32.Parse(secondes)
            Console.WriteLine("共{0}周，{1}天",week,day);*/


            // 一分钟 = 60 秒
            // 一小时 = 3600 秒
            // 一天 = 86400 秒


            Console.WriteLine("请输入秒数");
            string secondes = Console.ReadLine();
            int secindesInt = Convert.ToInt32(secondes);
            double day = secindesInt / 86400;
            double h = (secindesInt % 86400) / 3600;
            double m = ((secindesInt % 86400) % 3600) / 60;
            double s = m % 60;
            Console.WriteLine("共{0}天,{1}小时,{2}分钟,{3}秒", day, h, m, s);
        }
    }
    class learn06
    {
        public void test()
        {
            // 判断闰年
            // 润年 
            // 能被400整除
            // 能被4整除但是不能被100整除
            Console.WriteLine("请输入年份");
            string year = Console.ReadLine();
            int yearInt = Convert.ToInt32(year);
            bool a = yearInt % 400 == 0;
            bool b = yearInt % 4 == 0 && yearInt % 100 != 0;
            if (a || b)
            {
                Console.WriteLine($"{yearInt}，是润年");
            }
            else
            {
                Console.WriteLine($"{yearInt}，是平年");
            }
        }
    }
    class learn07
    {
        public static void test()
        {
            /*   Console.WriteLine("请输入年龄");
          string age = Console.ReadLine();
          int ageInt = Convert.ToInt32(age);
          if(ageInt > 23)
          {
              Console.WriteLine("你{0}岁了，到了结婚的年龄",age);
          } else
          {
              Console.WriteLine("你{0}岁了，还没有到结婚的年龄",age);
          }*/

            /* Console.WriteLine("请输入语文成绩");
             string chinese = Console.ReadLine();
             int chineseInt = Convert.ToInt32(chinese);
             Console.WriteLine("请输入音乐成绩");
             string music = Console.ReadLine();
             int musicInt = Convert.ToInt32(music);
             if(chineseInt > 90 && musicInt > 80)
             {
                 Console.WriteLine("你的语文成绩为{0}，音乐成绩为{1}，奖励50",chineseInt, musicInt);
             } else if(chineseInt == 100 && musicInt > 70)
             {
                 Console.WriteLine("你的语文成绩为{0}，音乐成绩为{1}，奖励100",chineseInt,musicInt);
             } else
             {
                 Console.WriteLine("你的语文成绩为{0}，音乐成绩为{1}，无奖励", chineseInt, musicInt);
             }*/

            Console.WriteLine("请输入账户");
            string admin = Console.ReadLine();

            Console.WriteLine("请输入密码");
            string password = Console.ReadLine();

            if (admin == "admin" && password == "mypass")
            {
                Console.WriteLine("登录成功");
            }
            else
            {
                Console.WriteLine("登录失败");
            }
        }
    }
    class learn08
    {
        public static void test()
        {
            int longs = 1;
            bool isShow;
            isShow = false;
            for (int i = 0; i < longs; i++)
            {
                string accout;
                string password;
                if (isShow == false)
                {
                    Console.WriteLine("请输入账号");
                    accout = Console.ReadLine();
                    Console.WriteLine("请输入密码");
                    password = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("密码错误,请再次输入密码");
                    password = Console.ReadLine();
                }

                if (password == "88888")
                {
                    Console.WriteLine("密码正确");
                    break;
                }
                else
                {
                    isShow = true;
                    longs++;
                    continue;
                }
            }
        }
    }
    class learn09
    {
        public static void test()
        {
            // 输入年份，在输入月份，输出当月天数
            // 年份分为平年和润年 闰年29天，平年28天
            // 闰年 能被400整除 或者 能被4整除 但是 不能被 100整除
            // 30天的月份有 4,6,9,11
            // 31天的月份有 1,3,5,7,8,10,12
            int longInt = 1;
            Console.WriteLine("输入q退出");
            Console.WriteLine();

            for (int i = 0; i < longInt; i++)
            {

                Console.WriteLine("请输入年份");
                string year = Console.ReadLine();
                if (String.Equals(year, "") == true)
                {
                    longInt++;
                    continue;
                }
                else
                {
                    if (String.Equals(year, "q") == false && String.Equals(year, "Q") == false)
                    {
                        int yearInt = Convert.ToInt32(year);
                        Console.WriteLine("请输入月份");
                        string month = Console.ReadLine();
                        int monthInt = Convert.ToInt32(month);
                        bool yearStyle = yearInt % 400 == 0 || (yearInt % 4 == 0 && yearInt % 100 != 0);
                        string yearStr;
                        if (yearStyle == true)
                        {
                            yearStr = "闰年";
                        }
                        else
                        {
                            yearStr = "平年";
                        }
                        bool yearBool = String.Equals(month, "1") || String.Equals(month, "3") || String.Equals(month, "5") || String.Equals(month, "7") || String.Equals(month, "8") || String.Equals(month, "10") || String.Equals(month, "12");

                        if (monthInt <= 12)
                        {
                            if (yearBool)
                            {
                                Console.WriteLine("当前年份为{0}，是{1}", year, yearStr);
                                Console.WriteLine("当前月份为{0}，天数为31天", month);
                            }
                            else
                            {
                                if (String.Equals(month, "2") && yearStyle == true)
                                {
                                    Console.WriteLine("当前年份为{0}，是{1}", year, yearStr);
                                    Console.WriteLine("当前月份为{0}，天数为29天", month);
                                }
                                else if (String.Equals(month, "2") && yearStyle == false)
                                {
                                    Console.WriteLine("当前年份为{0}，是{1}", year, yearStr);
                                    Console.WriteLine("当前月份为{0}，天数为28天", month);
                                }
                                else
                                {
                                    Console.WriteLine("当前年份为{0}，是{1}", year, yearStr);
                                    Console.WriteLine("当前月份为{0}，天数为30天", month);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("当前年份为{0}，是{1}", year, yearStr);
                            Console.WriteLine("您输入的月份为{0},一年有12个月，不合法", month);
                        }
                        Console.WriteLine();
                        Console.WriteLine("---------------------");
                        Console.WriteLine();
                        longInt++;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("---------------------");
                        Console.WriteLine("结束");
                        Console.WriteLine();

                        break;
                    }
                }

            }
        }
    }
    class learn10
    {
        public static void test()
        {
            // 100-999 直接的水仙花数
            int a;
            int b;
            int c;
            int num;
            for (int i = 100; i <= 999; i++)
            {

                a = i / 100;
                b = (i % 100) / 10;
                c = (i % 100) % 10;
                num = (int)(Math.Pow(a, 3) + (int)Math.Pow(b, 3) + (int)Math.Pow(c, 3));
                if (num == i)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
    class learn11
    {
        public static void test()
        {
            // 99乘法表
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write("{0}X{1}={2}\t", i, j, i * j);

                }
                Console.WriteLine();
            }
            Console.WriteLine();


            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}X{1}={2}\t", i, j, i * j);

                }
                Console.WriteLine();
            }

            Console.WriteLine();



            for (int i = 9; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("{0}X{1}={2}\t", i, j, i * j);

                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 1; i < 10; i++)
            {
                for (int k = 9 - i; k > 0; k--)
                {
                    Console.Write("\t");
                }
                for (int j = i; j > 0; j--)
                {
                    Console.Write("{0}X{1}={2}\t", i, j, i * j);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 9; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("{0}X{1}={2}\t", i, j, i * j);
                }
                Console.WriteLine();
                for (int k = 10 - i; k > 0; k--)
                {
                    Console.Write("\t");
                }

            }

            Console.WriteLine();
        }
    }
    class learn12
    {
        public static void test()
        {
            // TryParse 如果转换成功会返回一个布尔类型 并且把 字符串赋值给out 后面的变量
            int num = 0;
            bool a = int.TryParse("232323", out num);
            Console.WriteLine(num);
            Console.WriteLine(a);
        }
    }
    class learn13
    {
        public static void test()
        {
            Gender gender = Gender.man;
            Sesons sesons = Sesons.秋;
            QQstate qQstate = QQstate.Leave;

            // 枚举和其他类型的转化
            // 枚举类型默认可以和int类型转化

            int a = (int)qQstate;
            Console.WriteLine(a);
            Console.WriteLine((int)QQstate.Busy);
            Console.WriteLine((int)QQstate.ONline);
            Console.WriteLine((int)QQstate.QME);
            Console.WriteLine(sesons);

            // 把int类型转换成枚举
            QQstate b = (QQstate)2;
            Console.WriteLine(b);

            // 所有类型都可以转换成string类型 使用ToString()
            Console.WriteLine(gender.ToString());
            string c = b.ToString();
            c = false.ToString();
            Console.WriteLine(c);

            // string 转换成枚举,为数字时必须要和枚举对应，为字符串时也需要和枚举对应
            string d = "0";
            QQstate e = (QQstate)Enum.Parse(typeof(QQstate), d);
            Console.WriteLine(e);

            Console.WriteLine("请选择您的qq状态，0--online，1--offline,...");
            string input = Console.ReadLine();
            switch (input)
            {
                case "0":
                    QQstate s1 = (QQstate)Enum.Parse(typeof(QQstate), input);
                    Console.WriteLine($"您的状态是{s1}");
                    break;
                case "1":
                    QQstate s2 = (QQstate)Enum.Parse(typeof(QQstate), input);
                    Console.WriteLine($"您的状态是{s2}");
                    break;
                case "2":
                    QQstate s3 = (QQstate)Enum.Parse(typeof(QQstate), input);
                    Console.WriteLine($"您的状态是{s3}");
                    break;
                case "3":
                    QQstate s4 = (QQstate)Enum.Parse(typeof(QQstate), input);
                    Console.WriteLine($"您的状态是{s4}");
                    break;
            }
        }
    }
    class learn14
    {
        public static void test()
        {
            // 结构
            // 字段可以存多个值，变量只能存一个值 person1._name 和 person2._name
            Person person1;
            person1._gender = '女';
            person1._age = 20;
            person1._name = "你还";
            person1._qqState = QQstate.ONline;

            Person person2;
            person2._gender = '男';
            person2._age = 352;
            person2._name = "大黄";
            person2._qqState = QQstate.Leave;

            Console.WriteLine(person2._qqState);

            // 定义一个结合叫MyColor，有三个成员，分别定义为int类型的red，green，blue
            // 声明一个MyColor类型的变量，并对成员赋值，使用MyColor可以表示红色
            MyColor myColor;
            myColor._red = (int)MyColorEnum.红色;

            myColor._red = 255;
            myColor._green = 0;
            myColor._blue = 0;

            Console.WriteLine(myColor._red);

            // 定义一个结构Person2，有三个成员姓名，性别，年龄，性别用枚举类型
            // 声明 张三 男 18 小兰 女 16
            Person2 man1;
            man1._age = 18;
            man1._name = "张三";
            man1._gender = Gender2.男;

            Person2 man2;
            man2._age = 16;
            man2._name = "小兰";
            man2._gender = Gender2.女;

            Console.WriteLine("我叫{0}，我今年{1}岁了，我是{2}生", man1._name, man1._age, man1._gender);
            Console.WriteLine("我叫{0}，我今年{1}岁了，我是{2}生", man2._name, man2._age, man2._gender);
        }
    }
    class learn15
    {
        public static void test()
        {
            // 数组
            int[] ints = new int[10];
            // 声明了长度和值,值必须和长度对应
            int[] ints2 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int[] ints3 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] ints4 = { 1, 2, 3, 4, 5, 6, 7 };
            ints[4] = 13;
            int a = ints[4];
            Console.WriteLine(a);

            // 数组中的最大值
            int min = 0;
            int max = 0;
            int sum = 0;
            double svg;
            foreach (int i in ints2)
            {
                if (i < min)
                {
                    min = i;
                }
                if (i > max)
                {
                    max = i;
                }
                sum += i;
            }
            svg = (double)sum / ints2.Length;
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(svg);

            // 交换数组第一个和最后一个的值
            for (int i = 0; i < (ints3.Length / 2); i++)
            {
                int temp = ints3[i];
                ints3[i] = ints3[ints3.Length - 1 - i];
                ints3[ints3.Length - 1 - i] = temp;
            }
            foreach (int i in ints3)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            // 冒泡排序
            // 从大到小和从小到大排序
            int[] arr3 = new int[] { 8, 9, 7, 8, 523, 45, 12, 3, 67, 78, 56, 12, 4, 41654, 456, 45, 0 };
            int mp1 = 0;
            for (int i = 0; i < arr3.Length - 1; i++)
            {
                for (int j = 0; j < arr3.Length - i - 1; j++)
                {
                    if (arr3[j] > arr3[j + 1])
                    {
                        mp1 = arr3[j];
                        arr3[j] = arr3[j + 1];
                        arr3[j + 1] = mp1;
                    }
                }

            }

            // 对数组进行升序排列
            Array.Sort(arr3);
            // 对数组进行翻转
            Array.Reverse(arr3);

            for (int i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine(arr3[i].ToString(), "2323232323");
            }
        }
    }
    class learn16
    {
        public static void test()
        {
            // 方法（函数）能将代码进行重复的使用

            // out 参数
            // 写一个方法求数组的最大值，最小值，总和，平均值


            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int[] a = ints1(numbers);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // 如果返回同一个类型的值可以用数组
            // 但是返回多个不同类型的值的时候就不可以，这个时候使用out参数
            // out参数必须在方法内给参数赋值

            int max;
            int min;
            int num;
            double svg;
            Test2(numbers, out max, out min, out num, out svg);


            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(num);
            Console.WriteLine(svg);

            // 自己写TryParse方法 把字符串数组转化成int类型
            string num2 = "134343434";
            int num23;
            bool bo = MyTryParse(num2, out num23);
            Console.WriteLine(num23);
            Console.WriteLine(bo);
        }
        public static int[] ints1(int[] arr)
        {
            int[] res = new int[4];
            res[0] = arr[0];
            res[1] = arr[0];
            res[2] = arr[0];
            res[3] = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (res[0] < arr[i])
                {
                    res[0] = arr[i];
                }
                if (res[1] > arr[i])
                {
                    res[1] = arr[i];
                }
                res[2] += arr[i];
            }
            res[3] = res[2] / arr.Length;
            return res;
        }
        public static void Test2(int[] arr, out int max, out int min, out int num, out double avg)
        {
            // out参数必须在方法内给参数赋值
            max = arr[0];
            min = arr[0];
            num = arr[0];
            avg = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
                if (min > arr[i])
                {
                    min = arr[i];
                }
                num += arr[i];
            }
            avg = num / arr.Length;


        }
        public static bool MyTryParse(string str, out int result)
        {
            result = 0;
            try
            {
                result = Int32.Parse(str);
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
    class learn17
    {
        public static void test()
        {
            // ref
            // 可以把一个变量带入一个方法中改变
            // 在带出，特点是可以不用写返回值了
            // ref 必须要在方法外部赋值
            double salary = 5000;
            Jiangjing(ref salary);
            Console.WriteLine(salary);
            Console.WriteLine();
            Console.WriteLine();
            int a = 10;
            int b = 20;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine();
            JiaoHuan(ref a, ref b);

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        public static void JiaoHuan(ref int a, ref int b)
        {
            a = a - b;
            b = a + b;
            a = b - a;
        }
        public static void Jiangjing(ref double s)
        {
            s += 500;

        }
        public static void FaKuan(double s)
        {
            s -= 500;

        }
    }
    class learn18
    {
        public static void test()
        {

            // 数组类型的参数都必须要放到最后面
            // params 不能传多个 可变参数
            // params
            // 配合数组类型使用
            // 将实参列表中的可变参数，和数组类型一直的元素，都当做数组类型处理
            Test("张三", 1, 3, 4, 5, 6);
        }
        public static void Test(string args, params int[] score)
        {
            int sum = 0;
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }
            Console.WriteLine("{0}的总成绩是{1}", args, sum);
        }
    }
    class learn19
    {
        public static void test()
        {
            // 方法的重载
            // 同一个方法可以接受多个不同类型的值,
            // 方法的名称相同，参数不同
            // 特点1：参数的个数相同，参数的类型就不能相同
            // 特点2：参数的类型相同，参数的个数就不可以相同
            // 方法的重载和返回值没有关系
            int a = add(1, 3);
            double b = add(23.232, 454.125);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        public static int add(int x, int y)
        {
            return x + y;
        }
        public static double add(double x, double y)
        {
            return x + y;
        }
        public static double add(double x, double y, double z)
        {
            return x + y + z;
        }
        public static string add(string x)
        {
            return x;
        }
        public static bool add(bool x)
        {
            return x;
        }
    }
    class learn20
    {
        public static int a = 0;
        public static void test()
        {
            // 方法的递归
            // 意思就是方法: 自己调用自己
            // 在方法自己的方法体里在调用方法，就是递归

            TellStory();
            Console.WriteLine(a);
        }
        public static void TellStory()
        {
            Console.WriteLine("从前有座山");
            Console.WriteLine("山里有座庙");
            Console.WriteLine("庙里有个老和尚和小和尚");
            Console.WriteLine("有一天小和尚哭了，老和尚对小和尚说");
            Console.WriteLine();
            Console.WriteLine();
            if (a < 20)
            {
                a++;
                TellStory();
            }
            else
            {
                return;
            }

        }
    }
}
