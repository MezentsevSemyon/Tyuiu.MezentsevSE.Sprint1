using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MezentsevSE.Sprint1.Task3.Lib;
namespace Tyuiu.MezentsevSE.Sprint1.Task3.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Введите расстояние:");
            double x;
            double y;
            double z;
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Введите расход топлива: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Введите цену литра бензина: ");
            z = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Цена поездки в обе стороны = " + Math.Round(ds.TravelCost(x,y,z),2));

            Console.ReadKey();





        }
    }
}
