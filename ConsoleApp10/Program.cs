using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hashtable 集合 键值对集合 字典集合
            Hashtable ht = new Hashtable();
            ht.Add(0,"张三");
            ht.Add(2,"李四");
            ht.Add(1,112131);
            ht.Add(false, "找不到我");

            // 在字典集合中 根据键去找值

            

            for (int i = 0; i < ht.Count; i++)
            {
                Console.WriteLine(ht[i]);   
            }

            Console.WriteLine(ht[false]);

            // 遍历键值对 用foreach 循环
            foreach (var i in ht.Values)
            {
                Console.WriteLine(i);
            }
        }
    }
}
