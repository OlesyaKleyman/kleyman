using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ab = 2; // посчитаем все пути, чтобы потом заполнить массив
            int ac = 4;
            int ad = 10;
            int cd = 3;
            int be = 5;
            int bd = 11;
            int cf = 1;
            int de = 8;
            int df = 7;
            int eg = 6;
            int fg = 9;

            int acd = ac + cd;
            int abe = ab + be;
            int acf = ac + cf;
            int ade = ad + de;
            int adf = ad + df;
            int abd = ab + bd;
            int abeg = abe + eg;
            int acfg = acf + fg;
            int adfg = adf + fg;
            int adeg = ade + eg;
            int acdfg = acd + df + fg;
            int acdeg = acd + de + eg;
            int abdeg = abd + de + eg;
            int abdfg = abd + df + fg;
            int x1 = abeg;
            int x2 = acfg;
            int x3 = adfg;
            int x4 = adeg;
            int x5 = acdfg;
            int x6 = acdeg;
            int x7 = abdeg;
            int x8 = abdfg;

            int[] num = new int[] { x1, x2, x3, x4, x5, x6, x7, x8 };
            int r = x1;
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
                if (r > num[i])
                    r = num[i];
            }
            Console.WriteLine("Кратчайший путь = " + r);
        }
    }
}