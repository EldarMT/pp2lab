﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab33
{
    class Program
    {
        static int s = 0, l = 0;
        static DirectoryInfo a = new DirectoryInfo(@"D:\Call of Duty - Modern Warfare 2");
        static FileSystemInfo[] b = a.GetFileSystemInfos();
        static DirectoryInfo q = a;
        static void shower(FileSystemInfo[] t, ConsoleKeyInfo p, int s2)
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            if (p.Key == ConsoleKey.Enter)
            {
                if (t[s2].GetType() == typeof(DirectoryInfo))
                {
                    a = new DirectoryInfo(t[s2].FullName);
                    b = a.GetFileSystemInfos();
                    s = 0;
                    s2 = s;
                    t = b;
                }
                else
                {
                    string text = File.ReadAllText(t[s2].FullName);

                    Console.WriteLine(text);
                    Console.ReadKey();
                    Console.Clear();

                }
            }
            if (p.Key == ConsoleKey.Escape)
            {

                if (a.FullName == q.FullName)
                {
                    l = 1;
                    return;
                }
                a = a.Parent;
                b = a.GetFileSystemInfos();
                s = 0;
                t = b;
            }
            int size = t.Length;
            if (p.Key == ConsoleKey.DownArrow)
            {
                s2++;
                if (s2 == size)
                    s2 = 0;

            }
            if (p.Key == ConsoleKey.UpArrow)
            {
                s2--;

                if (s2 == -1)
                    s2 = size - 1;
            }

            int m = 0;
            foreach (FileSystemInfo g in t)
            {
                if (m == s2)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine(g.Name);

                }
                else

                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    if (g.GetType() == typeof(FileInfo))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(g.Name);
                    }
                    if (g.GetType() == typeof(DirectoryInfo))
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(g.Name);
                    }


                }
                m++;
            }
            s = s2;

        }

        static void Main(string[] args)
        {


            Console.WriteLine("please type a letter 's' to start хыыыыыыыы=)");
            while (true)
            {

                ConsoleKeyInfo pk = Console.ReadKey();

                shower(b, pk, s);
                if (l == 1)
                    break;
            }

        }
    }
}
