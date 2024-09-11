using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 创建一个集合对象，是对象
            ArrayList list = new ArrayList();  
            // 集合 ，很多数据的一个集合
            // 数组 ，类型单一，长度不可变
            // 集合 ，长度可以任意改变，类型随意

            list.Add(1);
            list.Add(2.1545);
            list.Add("23");
            list.Add('2');
            // 添加集合 用AddRange
            list.AddRange(new int[] {1,3,4,5,6,7});

            Person person = new Person();

            list.AddRange(list);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            // 清空所有元素
            list.Clear();
            // 删除单个元素，输入值
            list.Remove(1);
            // 根据下标删除
            // list.RemoveAt(0);
            // 根据下标范围删除
            // list.RemoveRange(0, 2);
            // 升序排序 要数据类型差不多
            // list.Sort();
            // 反转
            // list.Reverse();
            // 插入 第一位下标，第二位值
            // list.Insert(0, 1);
            // 插入集合 参数同上
            // list.InsertRange(0, new int[10]);
            // 判断是否包含元素 指定的元素,返回一个bool值
            // bool a = list.Contains(1);
            // bool b = list.Contains("颜色");
            

            // 创建一个集合，添加一些数字，求平均值与和
            ArrayList list2 = new ArrayList();
            list2.AddRange(new int[] {1,2,3,4,5,6,7,8,9,0,12,12,1,21,2,1,21,32,234,234,3,545});
            int num = 0;
            double svg = 0;
            Console.WriteLine("{0},232323",list2[9]);
            for (int i = 0;i < list2.Count;i++)
            {
                num += (int)list2[i];
                   
            }
            svg = num / list2.Count;

            Console.WriteLine(num);
            Console.WriteLine(svg);

            // 写一个长度为10的集合，要求在里面随机存储10个数字（0-9）
            // 要求不重复
            ArrayList arrayList = new ArrayList();
            Random random = new Random();
            

            for (int i = 0; i < 10; i++) {

                int ra = random.Next(0, 10);
                if (arrayList.Contains(ra) == false)
                {

                    arrayList.Add(ra);
                } else {
                    i--;
                }
            }

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }


        }
    }
    public class Person
    {
        public int id;
    }
}
