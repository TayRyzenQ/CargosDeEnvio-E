using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EU123AMTaynaPech.Entities
{
    public class Direccion
    {

        public int SuperMnz { get; set; }
        public int Mnz { get; set; }
        public int Lt { get; set; }
        public DateTime Fecha { get; set; }

        public void PedirDatosDireccion()
        {
          
                Console.WriteLine();
                Console.WriteLine("        Direccion ");
                Console.WriteLine(" Ingrese su supermanzana: ");
                SuperMnz = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su manzana: ");
                Mnz = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su lote: ");
                Lt = int.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------------");
                Console.WriteLine(Fecha = DateTime.Now);
                Console.Clear();
               
        }
    }
}
