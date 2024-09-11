using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 文件流
            // 一点一点读取文件
            // FileStream 
            // 主要用来操作字节 代表所有的文件都可以操作
            // streamReader 和 streamWriter
            // 操作字符，字符串文件

            // 优势，可以操作大文件
            // 第一个参数，路径，操作，干嘛 -》 路径 打开 读
            FileStream fileStream = new FileStream(@"D:\Desktop\123.txt",FileMode.OpenOrCreate,FileAccess.Read);
            byte[] buffer =  new byte[1024 * 1024 * 5];
            // 参数 空间大小 从哪里开始 最多一次多大的文件
            int r = fileStream.Read(buffer, 0, buffer.Length);  
            // 从 0 开始
            string s = Encoding.UTF8.GetString(buffer,0,r);

            // 文件流要自己手动回收
            // 关闭流
            fileStream.Close();
            // 释放资源
            fileStream.Dispose();


            Console.WriteLine(s);


            // fileStream 写在 using 中会自动释放
            using(FileStream sr = new FileStream(@"D:\Desktop\123.txt", FileMode.OpenOrCreate, FileAccess.Write)) 
            {
                string str1 = "你好，我在这里等你哦";

                byte[] bytes1 = Encoding.UTF8.GetBytes(str1);

                

                sr.Write(bytes1, 0, bytes1.Length);

                
            }


        }
    }
}
