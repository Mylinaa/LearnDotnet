using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test.test3();
        }
    }
    public class Test
    {
        public void test1()
        {
            // fileStream File 文件流
            // 1、创建FileStream类 第一个参数路径，操作，具体操作
            FileStream fileStream = new FileStream(@"D:\Desktop\123.txt", FileMode.OpenOrCreate, FileAccess.Read);
            byte[] buffer = new byte[1024];
            // 返回本次实际读取到的字节数
            int r = fileStream.Read(buffer, 0, buffer.Length);
            // 将字节数组中的每个元素按照指定的编码格式解码
            string s = Encoding.UTF8.GetString(buffer,0,r);
            Console.WriteLine(s);
            // 关闭
            fileStream.Close();
            // 释放资源
            fileStream.Dispose();
        }
        public void test2()
        {
            // 如果写在using当中，会自动释放资源
            using
            (
                FileStream file = new FileStream(@"D:\Desktop\123.txt",FileMode.OpenOrCreate,FileAccess.Write)    
            )
            {
                string str = "看我给你覆盖带哦";
                byte[] buffer = new byte[] { };
                // 转换编码格式返回字符数组
                buffer = Encoding.UTF8.GetBytes(str);
                file.Write(buffer, 0, buffer.Length);
            }
            Console.WriteLine("写入OK");
        }
        public void test3()
        {
            // 复制多媒体
            // 先把要复制的多媒体读取出来，在写入到指定的位置

            string str = "";
            using (FileStream file = new FileStream(@"D:\Desktop\123.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                
                byte[] buffer = new byte[1024];
                int t = file.Read(buffer,0, buffer.Length);
                str = Encoding.UTF8.GetString(buffer, 0, t); 
                Console.WriteLine(str);
            }

            using(FileStream file2 = new FileStream(@"D:\Desktop\123_old.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] buffer = new byte[] { };
                buffer = Encoding.UTF8.GetBytes(str);
                file2.Write(buffer, 0, buffer.Length);
                Console.WriteLine("复制成功");
            }
        }

    }
}
