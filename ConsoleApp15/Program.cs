using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp15
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Test test = new Test();
            test.test2();
        }
    }

    public class Test
    {
        public void test1()
        {
            List<int> ints = new List<int>() { 1,2,3,4,5,6,7,8,9,11,12,13,14,15,16,171,18,19};
            List<int> jis = new List<int>();
            List<int> ous = new List<int>();
            List<int> ints1 = new List<int>();
            foreach (int i in ints)
            {
                if(i % 2 == 0)
                {
                    ous.Add(i);
                } 
                else if(i % 3 == 0)
                {
                    jis.Add(i);
                }
            }
            ints1.AddRange(jis);
            ints1.AddRange(ous);

            foreach (int i in ints1)
            {
                Console.WriteLine(i);
            }

        }
        public void test2()
        {
            Console.WriteLine("请输入");
            string str = Console.ReadLine();
            List<char> list = new List<char>();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char s in str)
            {
                list.Add(s);
            }

            Console.WriteLine("出现的次数");
          
            foreach (char s in list)
            {
                if (dict.ContainsKey(s))
                {
                    dict[s]++;
                } 
                else
                {
                    dict.Add(s, 1);
                }
            }
            foreach (KeyValuePair<char, int> kvp in dict)
            {
                Console.WriteLine("{0} ------ {1}", kvp.Key, kvp.Value);
            }







        }
    }
    


    
}
