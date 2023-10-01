using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MezentsevSE.Sprint1.Task4.V23.Lib;
namespace Tyuiu.MezentsevSE.Sprint1.Task4.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double x;
            double y;
            Console.WriteLine(" Введите переменную х, не равную 3  :  ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Введите переменную у  :  ");
            y = Convert.ToDouble(Console.ReadLine());
            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Решение = " + Math.Round(ds.Calculate(x,y),3));

            Console.ReadKey();

        }
    }
}
