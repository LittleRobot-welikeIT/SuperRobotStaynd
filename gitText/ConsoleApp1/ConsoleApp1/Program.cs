using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string a,b,c,d,g,h;
            int A, B, C, D,H,G;
            //填座標
            Console.Write("請輸入第一個座標的X軸");
            a = Console.ReadLine();
            Console.Write("請輸入第一個座標的Y軸");
            b = Console.ReadLine();
            Console.Write("請輸入第二個座標的X軸");
            c = Console.ReadLine();
            Console.Write("請輸入第二個座標的Y軸");
            d = Console.ReadLine();
            //將string轉int
            A = Convert.ToInt32(a);
            B = Convert.ToInt32(b);
            C = Convert.ToInt32(c);
            D = Convert.ToInt32(d);
            //判斷正負,計算
            if (A * C >= 0)
            {
                int E = A - C;
                int e =Math.Abs(E);
                Console.WriteLine("E值為"+ e);
            }
            else
            {
                int AA = Math.Abs(A);
                int CC = Math.Abs(C);
                int E = AA + CC;
                Console.WriteLine("E值為"+E);
            }
            if(B * D >=0)
            {
                int F = B - D;
                int f = Math.Abs(F);
                Console.WriteLine("F值為"+f);
            }
            else
            {
                int BB =Math.Abs(B);
                int DD =Math.Abs(D);
                int F = BB + DD;
                Console.WriteLine("F值為" + F);
            }
            //手動輸入兩邊長度(不知道怎麼使用IF內的值)
            Console.WriteLine("請輸入E值");
            g = Console.ReadLine();
            Console.WriteLine("請輸入F值");
            h = Console.ReadLine();
            G = Convert.ToInt32(g);
            H = Convert.ToInt32(h);
            //計算斜邊長(也就是座標上兩點的直線距離了)
            double I = Math.Pow(G,2) + Math.Pow(H,2);//也可以使用 Math.Pow(數,平方);
            double Ans = Math.Sqrt(I);
            Console.WriteLine("兩座標的直線距離為:" + Ans);
            //求通過兩點直線方程式ax+by+c=0
            //解聯立方程式
            //假設Y=ax+by+c=0
            //算了不會算
            Console.WriteLine("");
            //55 66 77 88 99
            Console.WriteLine("某次考試成績如下");
            int AAA = 55;
            Console.WriteLine("第一個成績為" + AAA);
            int BBB = 66;
            Console.WriteLine("第二個成績為" + BBB);
            int CCC = 77;
            Console.WriteLine("第三個成績為" + CCC);
            int DDD = 88;
            Console.WriteLine("第四個成績為" + DDD);
            int EEE = 99;
            Console.WriteLine("第五個成績為" + EEE);
            int FFF = AAA + BBB + CCC + DDD + EEE;
            int GGG = FFF / 5;
            Console.WriteLine("此次考試成績總和為" + FFF);
            Console.WriteLine("此次考試成績平均為" + GGG);



        }
    }
}
