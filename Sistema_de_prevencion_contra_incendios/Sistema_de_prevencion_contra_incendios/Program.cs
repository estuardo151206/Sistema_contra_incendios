using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Funcionamiento;
using Alarma;

namespace Sistema_de_prevencion_contra_incendios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔══════════════════════════════════════╗");
                Console.WriteLine("║SISTEMA DE PREVENCION CONTRA INCENDIOS║");
                Console.WriteLine("╚══════════════════════════════════════╝");
                Console.ForegroundColor= ConsoleColor.DarkGreen;
                Console.WriteLine("============PANEL DE CONTROL============");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Revisar detectores de temperatura [1]");
                Console.WriteLine("Revisar detectores de humo [2]");
                Console.WriteLine("Sonar alarma [3]");
                Console.WriteLine("Finalizar secion [4]");
                Console.Write("Elija ");
                opcion = int.Parse(Console.ReadLine());
                Console.ResetColor();
                menu(opcion);
            }
            while (opcion != 4);
        }
        static void menu(int opcion) 
        {
                switch (opcion)
                {
                    case 1: OP1(); break;
                    case 2: OP2(); break;
                    case 3: OP3(); break;
                    case 4: Salida(); break;
                }
        }
        static void OP1() 
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Thread.Sleep(1000);
            Console.WriteLine("=====Temperaturas de las estaciones=====");
            Thread.Sleep(500);
            Console.ResetColor();
            Random rnd = new Random();
            int d1, d2, d3, d4;
            d1 = rnd.Next(30, 76);
            d2 = rnd.Next(30, 76);
            d3 = rnd.Next(30, 76);
            d4 = rnd.Next(30, 76);
            Console.WriteLine("estacion 1:");
            Detector f1 = new Detector(d1);
            Console.WriteLine("estacion 2:");
            Detector f2 = new Detector(d2);
            Console.WriteLine("estacion 3:");
            Detector f3 = new Detector(d3);
            Console.WriteLine("estacion 4:");
            Detector f4 = new Detector(d4);
            Console.WriteLine("Presione enter para regresar al panel de control");
            Console.ReadKey();
            Console.Clear();
        }
        static void OP2() 
        {
            Console.WriteLine("2QQQ");
            Console.ReadKey();
            Console.Clear();
        }
        static void OP3()
        {
            Console.Clear();
            int e;
            Console.WriteLine("===========Control de alarmas===========");
            Console.Write("Activar alarma en la estacion ");
            e = int.Parse(Console.ReadLine());
            alarma f = new alarma(e);
            Console.WriteLine("Presione enter para regresar al panel de control");
            Console.ReadKey();
            Console.Clear();
        }
        static void Salida() 
        {
            Console.WriteLine("Cerrando secion");
        }
    }
}
