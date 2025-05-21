using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int e1, e2, e3, e4, e_tot;
            double p1,p2,p3,p4,m,m1,m2,m3,m4;

            Console.WriteLine("Ingrese las 4 edades ");
            e1=Convert.ToInt32(Console.ReadLine());
            e2=Convert.ToInt32(Console.ReadLine());
            e3=Convert.ToInt32(Console.ReadLine());
            e4=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el monto a repartir ");
            m=Convert.ToDouble(Console.ReadLine());

            e_tot = e1 + e2 + e3 + e4;

            p1 = (double)e1 / e_tot * 100;
            p2 = (double)e2 / e_tot * 100;
            p3 = (double)e3 / e_tot * 100;
            p4 = (double)e4 / e_tot * 100;

            m1 = m * p1 / 100;
            m2 = m * p2 / 100;
            m3 = m * p3 / 100;
            m4 = m * p4 / 100;

            Console.WriteLine("La niña con edad {0} le correspone un %{1:F2}, el pago es de {2:F2}", e1, p1, m1);
            Console.WriteLine("La niña con edad {0} le correspone un %{1:F2}, el pago es de {2:F2}", e2, p2, m3);
            Console.WriteLine("La niña con edad {0} le correspone un %{1:F2}, el pago es de {2:F2}", e3, p3, m3);
            Console.WriteLine("La niña con edad {0} le correspone un %{1:F2}, el pago es de {2:F2}", e4, p4, m4);
            Console.ReadKey();
            
         
            Console.ReadKey();




        }
    }
}
