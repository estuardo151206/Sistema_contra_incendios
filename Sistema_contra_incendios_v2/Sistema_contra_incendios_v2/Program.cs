using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sistema_contra_incendios_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Random rbn = new Random();
                int d1 = rbn.Next(25, 66);
                int d2 = rbn.Next(25, 66);
                int d3 = rbn.Next(25, 66);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("╔════════════════════════╗");
                Console.WriteLine("║SISTEMA CONTRA INCENDIOS║");
                Console.WriteLine("╚════════════════════════╝");
                Console.ResetColor();
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Estacion 1: ");
                Console.ResetColor();
                if (d1 < 62)
                {
                    Random o1 = new Random();
                    int m1 = o1.Next(20, 50);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Thread.Sleep(500);
                    Console.WriteLine(d1+"° Normal");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(d1+"° Peligro");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                    break;
                }
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Estacion 2: ");
                Console.ResetColor();
                if (d2 < 62)
                {
                    Random o2 = new Random();
                    int m2 = o2.Next(20, 50);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Thread.Sleep(500);
                    Console.WriteLine(d2+"° Normal");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(d2+"° Peligro");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                    break;
                }
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Estacion 3: ");
                Console.ResetColor();
                if (d3 < 62)
                {
                    Random o3 = new Random();
                    int m3 = o3.Next(20, 50);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Thread.Sleep(500);
                    Console.WriteLine(d3+"° Normal");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(d3+"° Peligro");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                    break;
                }
                Console.Write("Actualizando");
                Thread.Sleep(550);
                Console.Write(" ■");
                Thread.Sleep(550);
                Console.Write(" ■");
                Thread.Sleep(550);
                Console.Write(" ■");
                Thread.Sleep(550);
                Console.Clear();
            }
            Console.Clear();
            for(int i = 0; i < 5; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("PELIGRO");
                Console.ResetColor();
                Console.Beep(10000,500);
                Thread.Sleep(500);
                Console.Clear();
                Console.BackgroundColor= ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("PELIGRO");
                Console.ResetColor();
                Console.Beep(10000, 500);
                Thread.Sleep(500);
                Console.Clear();
            }
        }
    }
}
