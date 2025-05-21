using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double k_masa, g_masa, masa_sobr;
            int cant_bud, cant_caja, cant_paq;

            Console.WriteLine("Ingrese los kg de masa producida ");
            k_masa = Convert.ToDouble(Console.ReadLine());

            g_masa = k_masa * 1000;
            cant_bud =(int)g_masa/55;
            cant_paq=(int)cant_bud / 12;
            cant_caja = (int)cant_bud / 20;
            masa_sobr = g_masa % 55;

            Console.WriteLine("Se producieron {0} budines", cant_bud);
            Console.WriteLine("Se completaron {0} paquetes ",cant_paq);
            Console.WriteLine("Se completaron {0} cajas",cant_caja);
            Console.WriteLine("Sobro {0} de masa",masa_sobr);

        }
    }
}
