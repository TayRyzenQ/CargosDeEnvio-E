using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EU123AMTaynaPech.Entities
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }

        public void PedirDatosCliente()
        {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("        Datos Personales ");
                Console.WriteLine("Ingrese su nombre: ");
                Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su correo: ");
                Correo = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("------------------------------------");                    
        }
    }
}
