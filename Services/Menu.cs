using EU123AMTaynaPech.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EU123AMTaynaPech.Services
{
    public class Menu
    {
        public int FMenu()          //revisar el tipo de variable !!!!
        {
            try
            {
                int TCompra = 0;
                Descuento descuento = new Descuento();
                Cliente dcliente = new Cliente();
                dcliente.PedirDatosCliente();
                Direccion ddireccion = new Direccion();
                ddireccion.PedirDatosDireccion();



                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("                   Bienvenido a su ticket");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Ingrese la cantidad total de su compra");
                Console.Write(" > ");
                TCompra = int.Parse(Console.ReadLine());

                if (TCompra < 1000)
                {
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("Usted pago por su compra: " + TCompra);
                    Console.WriteLine("Debera pagar 250 de envio :) ");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("Total compra mas envio: " + descuento.MenorMil(TCompra));
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine();

                }
                else if (TCompra >= 1000)
                {
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("Felicidades, por haber comprado mas de $1000 de compra recibe ");
                    Console.WriteLine("envio gratis, ademas, 3 meses sin intereses");
                    Console.WriteLine();
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("Usted pagara mensualmente: " + descuento.MayorMil(TCompra));
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine();
                }
                Console.WriteLine("================================================================");
                Console.WriteLine("Datos del cliente");
                Console.WriteLine("Nombre: " + dcliente.Nombre);
                Console.WriteLine("Correo: " + dcliente.Correo);
                Console.WriteLine("Supermanzana:" + ddireccion.SuperMnz);
                Console.WriteLine("Manzana:" + ddireccion.Mnz);
                Console.WriteLine("Lote:" + ddireccion.Lt);
                Console.WriteLine("Fechas " + ddireccion.Fecha);
                Console.WriteLine("================================================================");
                return 0;

            }
            catch (Exception ex)
            {
                throw new Exception("hubo un error en el sistema:("+ex.Message);
            }
          
        }
    }
}
