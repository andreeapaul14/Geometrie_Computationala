using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C+S_2
{
    class Program
    {
        /// <summary>
        /// Se dau 2 vectori sa se scrie programul de determinat:
        /// produsul scalar al vectorilor
        /// sa se veriice daca vectoriisunt perpendiculari 
        /// sa se calculeze marimea celor 2 vectori
        /// </summary>
        /// <param name="args"></param>
        /// 
        

        static void Main(string[] args)
        {
            int x1, x2, y1, y2, z1, z2;
            Console.WriteLine("Introduceti coeficientii vectorului v1:");
            x1= int.Parse(Console.ReadLine());
            y1= int.Parse(Console.ReadLine());
            z1= int.Parse(Console.ReadLine());
           
                Console.WriteLine("$v1={x1}x{y1}y{z1}z");
            Console.WriteLine("$v1={x1}x+{y1}y+{z1}z");
            Console.WriteLine("Introduceti coeficientii vectorului v2:");
            x2 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());
            z2 = int.Parse(Console.ReadLine());
            Console.WriteLine("$v2={x1}x+{y1}y+{z1}z");
        }
    }
}
