using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2
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

        static string Afis(double x)
        {
            if (x >= 0)
                return "+" + x.ToString();
            else
                return x.ToString();
        }
        /// <summary>
        /// Se dau 2 vectori sa se scrie programul de determinat:
        /// produsul vectorial al vectorilor
        /// sa se veriice daca vectoriisunt coliniari 
        /// sa se calculeze aria paralelogramului construit pe cei doi vectori ca laturi
        /// </summary>
        /// <param name="args"></param>
        /// 
        /// <summary>
        /// Se dau 3 vectori sa se scrie programul de determinat:
        /// produsul mixt
        /// sa se verifice daca vectorii sunt coplanari 
        /// sa se calculeze volumul paralelogramului construit pe cei trei vectori 
        /// </summary>
        /// <param name="args"></param>
        /// 
        static string Afis2(double x, double y, double x2, double y2, int i)
        {
            if(i==2)
                if (((x*y)-(x2*y2))>= 0)
                    return  "-"+((x * y) - (x2 * y2)).ToString();
                else
                    return ((x * y) - (x2 * y2)).ToString();
            else
                if (((x * y) - (x2 * y2)) >= 0)
                return "+" + ((x * y) - (x2 * y2)).ToString();
            else
                return ((x * y) - (x2 * y2)).ToString();
        }
      
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, z1, z2, prodScalar1,x3,y3,z3,det;
            double marime1,marime2 ;
            Console.WriteLine("Introduceti coeficientii vectorului v1:");
            x1 = int.Parse(Console.ReadLine());
            y1 = int.Parse(Console.ReadLine());
            z1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"v1={Afis(x1)}x{Afis(y1)}y{Afis(z1)}z");
            Console.WriteLine("Introduceti coeficientii vectorului v2:");
            x2 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());
            z2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"v2={Afis(x2)}x{Afis(y2)}y{Afis(z2)}z");
            prodScalar1 = x1 * x2 + y1 * y2 + z1 * z2;
            Console.WriteLine($"Produs scaalr: {prodScalar1}");
            if (prodScalar1 == 0)
                Console.WriteLine($"Vectorii sunt perpendiculari");
            else
                Console.WriteLine($"Vectorii nu sunt perpendiculari");
            marime1 = x1 * x1 + y1 * y1 + z1 * z1;
            marime2 = x2 * x2 + y2 * y2 + z2 * z2;
            Console.WriteLine("Marimea v1:");
            Console.Write(Math.Sqrt(marime1));
            Console.WriteLine();
            Console.WriteLine("Marimea v2:");
            Console.Write(Math.Sqrt(marime2));
            Console.WriteLine();
            Console.WriteLine($"v1xv2={Afis2(y1, z2, z1, y2,1)}i{Afis2(x1, z2, x2, z1,2)}j{Afis2(x1, y2, x2, y1,1)}k");
            if(y1*z2-z1*y2==0 && x1*z2-x2*z1 ==0 && x1*y2-x2*y1==0 )
                Console.WriteLine("Vectorii sunt coliniari");
            else
                Console.WriteLine("Vectorii nu sunt coliniari");
            double aria = (y1 * z2 - z1 * y2) * (y1 * z2 - z1 * y2) + (x1 * z2 - x2 * z1) * (x1 * z2 - x2 * z1) + (x1 * y2 - x2 * y1) * (x1 * y2 - x2 * y1);
            Console.WriteLine("Aria paralelogram");
            Console.WriteLine(Math.Sqrt(aria));
            Console.WriteLine("Introduceti coeficientii vectorului v3:");
             x3 = int.Parse(Console.ReadLine());
             y3 = int.Parse(Console.ReadLine());
             z3 = int.Parse(Console.ReadLine());
             Console.WriteLine($"v3={Afis(x3)}x{Afis(y3)}y{Afis(z3)}z");
            det = x1 * y2 * z3 + x2 * y3 * z1 + y1 * z2 * x3 - z1 * y2 * x3 - y3 * z2 * x1 - y1 * x2 * z3;
            Console.WriteLine($"Produsul mixt este {det}");
            if(det==0)
                Console.WriteLine("Vectorii sunt coplanari");
            else
                Console.WriteLine("Vectorii nu sunt coplanari");
            Console.WriteLine($"Volumul paralelipipedului este {Math.Abs(det)}"); 

        }
    }
}
