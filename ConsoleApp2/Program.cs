using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        // 定义地图数量
        public static int[] Maps = new int[100];
        // 声明静态数组 用来存储玩家A和玩家B的坐标
        public static int[] playerPos = new int[2];
        // 存储玩家的姓名
        public static string[] playerNames = new string[2];
        // 存储玩家是否标记暂停
        public static bool[] flags = new bool[2];

        static void Main(string[] args)
        {
            GameHeade();
            GameNames();

            Console.Clear();
            GameHeade();

            Console.WriteLine("{0}的士兵用A表示", playerNames[0]);
            Console.WriteLine("{0}的士兵用B表示", playerNames[1]);

            Console.WriteLine();

            InitailMap();
            DarwMap();

            Console.WriteLine();
            // 当没有到达终点的时候一直执行
            while (playerPos[0] < 99 && playerPos[1] < 99)
            {
                if (flags[0] == false)
                {
                    PlayGame(0);
                }
                else
                {
                    flags[0] = false;
                }

                if (playerPos[0] >= 99)
                {
                    Console.WriteLine("玩家{0} 好运的赢了 玩家{1}", playerNames[0],playerNames[1]);
                    break;
                }

                if (flags[1] == false)
                {
                    PlayGame(1);
                }
                else 
                {
                    flags[1] = false;
                }
                if (playerPos[1] >= 99)
                {
                    Console.WriteLine("玩家{1} 好运的赢了 玩家{0}", playerNames[1], playerNames[0]);
                    break;
                }



            }


            while (true)
            {
                int str = 0;
                if(str < 90)
                {
                    Console.ReadKey(true);
                }
                else
                {
                    str++;
                    break;
                }
            }






        }
        // 游戏头部
        public static void GameHeade()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***************");
            Console.WriteLine("***************");
            Console.WriteLine("***************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("****飞行棋*****");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
         

          
        }

        // 初始化地图
        // 将整数数组中的数字变成特殊的字符串
        public static void InitailMap()
        {
            // 幸运轮盘 ◎
            int[] luckyturn = { 6, 23, 40, 55, 69, 83 };
            for (int i = 0; i < luckyturn.Length; i++)
            {
                int index = luckyturn[i];
                // Maps 的 下标和 luckyturn的值相等就赋值 1
                Maps[index] = 1;
            }
            // 地雷 ☆
            int[] landMine = { 5,13,17,33,38,50,64,80,94 };
            for (int i = 0; i < landMine.Length; i++)
            {
                int index = landMine[i];
                // Maps 的 下标和 landMine的值相等就赋值 1
                Maps[index] = 2;
            }

            // 暂停 ▲
            int[] pause = { 9, 27, 60, 93 };
            for (int i = 0; i < pause.Length; i++)
            {
                int index = pause[i];
                // Maps 的 下标和 pause的值相等就赋值 1
                Maps[index] = 3;
            }

            // 时空隧道 卍
            int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 };
            for (int i = 0; i < timeTunnel.Length; i++)
            {
                int index = timeTunnel[i];
                // Maps 的 下标和 timeTunnel的值相等就赋值 1
                Maps[index] = 4;
            }
        }

        // 画地图
        public static void DarwMap()
        {
            Console.WriteLine("图例：幸运轮盘◎  地雷☆  暂停▲  时空隧道卍");
            Console.WriteLine();




            // 第一行
            for (int i = 0;i < 30;i++)
            {
                // 如果玩家a和b相同，画一个<>
                // 确保玩家在一行
                Console.Write(DrawStringMap(i));
            }
            Console.WriteLine();
            for (int i = 30; i < 35; i++)
            {
                for(int j = 0; j <= 28; j++)
                {
                    Console.Write("  ");
                   
                }
                Console.Write(DrawStringMap(i));
                Console.WriteLine();
            }

            
            // 第二横
            for (int i = 64;i >= 35;i--)
            {
                Console.Write(DrawStringMap(i));
            }
            Console.WriteLine();

            // 竖行
            for (int i = 65; i <= 69; i++)
            {

                Console.WriteLine(DrawStringMap(i));
            }
            // 第三横行
            for (int i = 70; i <= 99; i++)
            {
                Console.Write(DrawStringMap(i));
            }


            Console.WriteLine();
            Console.WriteLine();

        }

        // 画图方法
        public static string DrawStringMap(int i)
        {
            string str = "";
            if (playerPos[0] == playerPos[1] && playerPos[0] == i)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                str = "<>";
            }
            else if (playerPos[0] == i)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                str = "Ａ";
            }
            else if (playerPos[1] == i)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                str = "Ｂ";
            }
            else
            {
                switch (Maps[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.White;
                        str = "□";
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        str = "◎";
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        str = "☆";
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        str = "▲";
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        str = "卍";
                        break;
                }

            }
            return str;
        }

        public static void GameNames()
        {
            Console.WriteLine("请输入玩家A的姓名");
            playerNames[0] = Console.ReadLine();
            while (playerNames[0] == "")
            {
                Console.WriteLine("玩家A的姓名不能为空；请输入玩家A的姓名");
                playerNames[0] = Console.ReadLine();
            }
            Console.WriteLine("请输入玩家B的姓名");
            playerNames[1] = Console.ReadLine();
            while (playerNames[1] == "" || playerNames[1] == playerNames[0])
            {
                if (playerNames[1] == "" && playerNames[1] != playerNames[0])
                {
                    Console.WriteLine("玩家B的姓名不能为空；请输入玩家B的姓名");
                    playerNames[1] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("玩家B的姓名不能和玩家A的姓名相同；请输入玩家B的姓名");
                    playerNames[1] = Console.ReadLine();
                }
            }
        }

        public static void PlayGame(int playerNumber)
        {
            Random r = new Random();

            int rNumber = r.Next(1,7);

            Console.WriteLine("玩家 {0} 按任意键开始投掷骰子", playerNames[playerNumber]);
            // 参数为true 不显示按下的键
            Console.ReadKey(true);

            Console.WriteLine("玩家 {0} 掷出了 {1}", playerNames[playerNumber], rNumber);

            playerPos[playerNumber] += rNumber;
            ChangePos();
            Console.ReadKey(true);

            Console.WriteLine("玩家 {0} 按任意键开始行动", playerNames[playerNumber]);
            Console.ReadKey(true);

            if (playerPos[playerNumber] == playerPos[1 - playerNumber])
            {
                Console.WriteLine("玩家 {0} 踩到了 玩家 {1} , 玩家 {2} 退6格", playerNames[playerNumber], playerNames[1 - playerNumber], playerNames[1 - playerNumber]);
                playerPos[1 - playerNumber] -= 6;
                ChangePos();
                Console.ReadKey(true);
            }
            // 判断踩到关卡
            else
            {
                // 玩家的坐标
                switch (Maps[playerPos[playerNumber]])
                {
                    case 0:
                        Console.WriteLine("玩家 {0} 踩到了方块，什么都没有发生", playerNames[playerNumber]);
                        Console.ReadKey(true);
                        break;
                    case 1:
                        Console.WriteLine("玩家 {0} 踩到了幸运轮盘，请选择 1 --- 交换位置 , 2 -- 轰炸对方退6格", playerNames[playerNumber]);
                        Console.ReadKey(true);
                        string input = Console.ReadLine();
                        while (true)
                        {
                            if (input == "1")
                            {
                                Console.WriteLine("玩家{0} 选择和 玩家{1} 交换了位置", playerNames[playerNumber], playerNames[1 - playerNumber]);
                                Console.ReadKey(true);

                                int temp = playerPos[playerNumber];
                                playerPos[playerNumber] = playerPos[1 - playerNumber];
                                playerPos[1 - playerNumber] = temp;

                                Console.WriteLine("交换完成，按任意键结束!!!");
                                Console.ReadKey(true);
                                break;
                            }
                            else if (input == "2")
                            {
                                Console.WriteLine("玩家{0} 选择了轰炸 玩家{1} , 玩家{2} 退6格", playerNames[playerNumber], playerNames[1 - playerNumber], playerNames[1 - playerNumber]);

                                playerPos[1 - playerNumber] -= 6;
                                ChangePos();
                                Console.ReadKey(true);
                                Console.WriteLine("玩家{0} 退了6格", playerNames[1 - playerNumber]);
                                Console.ReadKey(true);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("只能输入 1 和 2 , 1 --- 交换位置 , 2 -- 轰炸对方退6格");
                                input = Console.ReadLine();
                            }

                        }

                        break;
                    case 2:
                        Console.WriteLine("玩家{0} 踩到了地雷，退6格", playerNames[playerNumber]);

                        playerPos[playerNumber] -= 6;
                        ChangePos();
                        Console.ReadKey(true);
                        break;
                    case 3:
                        Console.WriteLine("玩家{0} 踩到了暂停，暂停一回合", playerNames[playerNumber]);
                        flags[playerNumber] = true;
                        Console.ReadKey(true);
                        break;
                    case 4:
                        Console.WriteLine("玩家{0} 踩到了时空隧道，前进10格", playerNames[playerNumber]);

                        playerPos[playerNumber] += 10;
                        ChangePos();
                        Console.ReadKey(true);
                        break;

                }   
            }
            Console.WriteLine("玩家 {0} 行动完了", playerNames[playerNumber]);
            Console.ReadKey(true);

            Console.Clear();
            DarwMap();
        }

        public static void ChangePos()
        {
            if (playerPos[0] < 0)
            {
                playerPos[0] = 0;
            }
            else if (playerPos[0] > 99) 
            {
                playerPos[0] = 99;
            }

            if (playerPos[1] < 0)
            {
                playerPos[1] = 0;
            }
            else if (playerPos[1] > 99)
            {
                playerPos[1] = 99;
            }
        }
    }
}
