using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 把一个数组的奇数放到一个集合中，再把偶数放到另一个集合中
            // 最终将两个集合合并一集合，并且奇数显示在左边，偶数在右边

            int[] arr = { 1,2,3,4,5,6,7,8,10,12,131,14,15,161,73};
            List<int> jishu = new List<int>();
            List<int> oushu = new List<int>();
            foreach(int i in arr)
            {
                if(i % 2 == 0)
                {
                    oushu.Add(i);
                }
                else if(i % 3 == 0)
                {
                    jishu.Add(i);
                }
            }
            jishu.AddRange(oushu);

            foreach(int i in jishu)
            {
                Console.Write(i);
            }

            Console.WriteLine();    
            // 提示用户输入一个字符串，通过foreach循环将用户输入的内容赋值给字符串，统计字符串的数量

            string str = "qwertyuiodanfowieoikjvvnjkazeoiroievhciauri";
            Dictionary<char, int> dic = new Dictionary<char, int>();

            // 把 字符串的单词当成键
            // 把 数量当初值
            for (int i = 0; i < str.Length; i++)
            {

                if (dic.ContainsKey(str[i]))
                {
                    dic[str[i]]++;
                }
                else
                {
                    dic.Add(str[i], 1);
                }
            }

            foreach(KeyValuePair<char,int> item in dic)
            {
                Console.WriteLine("键{0} ----- 值{1}",item.Key,item.Value);
            }

          
       
           



        }
    }
    public class Test
    {
        public static void test()
        {
            // 创建泛型集合对象
            // 泛型定义了什么类型，就要忘里面加什么类型

            List<int> ints = new List<int>();

            // 集合可以转化成数组
            // 数组可以转换成集合
            // ToArray
            // ToList

            // 拆箱
            // 把引用类型转换成值类型
            // 装箱
            // 把值类型转化成引用类型

            // 看两种类型是否发生装箱和拆卸，看这两种关系有没有发生装箱和拆箱

            // 创建字典集合
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();

            keyValuePairs.Add(1, "1");
            keyValuePairs.Add(2, "2");
            keyValuePairs.Add(3, "3");
            keyValuePairs.Add(4, "4");
            keyValuePairs.Add(5, "5");

            foreach (KeyValuePair<int, string> pair in keyValuePairs)
            {
                Console.WriteLine("键{0}----值{1}", pair.Key, pair.Value);
            }
        }
    }
}
