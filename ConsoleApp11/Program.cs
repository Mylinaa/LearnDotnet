using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] buffer = File.ReadAllBytes(@"D:\Desktop\123.txt");
            string s = Encoding.UTF8.GetString(buffer);



            string s3 = "则会是11111111111111111111111111111";
            byte[] buffer2 = Encoding.UTF8.GetBytes(s3);
            File.WriteAllBytes(@"D:\Desktop\123.txt",buffer2);

            string s4 = "23232434444444444444";
            File.WriteAllText(@"D:\Desktop\123.txt",s4);

            string s2 = File.ReadAllText(@"D:\Desktop\123.txt");

            Console.WriteLine(s2);
        }
    }
}
