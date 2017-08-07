using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosTransportes
{
    class Program
    {
        /*
        Hacer un sistema de pedidos de medios de transporte en los cuales hay 2 tipos de pedidos:
        1- Motos (Terrestre y Acuáticas)
        2- Automóviles (Livianos y Pesados)

        En función de cuales soliciten los clientes calcular (EN FUNCIONES SEPARADAS - OBLIGATORIO):
        01- Numero total de motos
        02- Numero total de motos Acuaticas
        03- Numero total de motos terrestres

        04- Total a pagar en Motos
        05- Total a pagar en motos acuaticas
        06- Total a pagar en motos terrestres
        
        07- Numero total de autos
        08- Numero total de autos livianos
        09- Numero total de autos Pesados

        10-Total a pagar en Automóviles
        11- Total a pagar en autos livianos
        12- Total a pagar en autos pesados
        
        13- Neto a Pagar
        14- Total de articulos

        Si la moto es acuatica, se le sumaran $3000 a cada moto acuatica por permisos bla bla bla
        Si el auto es pesado, se le sumaran $5000 a cada auto pesado, por papeleos, bla bla bla

        */
                  
        static void Main()
        {
            Console.WriteLine("************************************");
            Console.WriteLine("*     Pedidos de Motos y Autos     *");
            Console.WriteLine("************************************");
            Pedidos pedidos = new Pedidos();
            Console.WriteLine("\n\nCantidad de Motos\n");
            Console.WriteLine("N° Motos Acuaticas  : {0}", pedidos.NunMotoAcuatica());
            Console.WriteLine("N° Motos Terrestres : {0}", pedidos.NunMotoTerrestre());
            Console.WriteLine("__________________________");
            Console.WriteLine("Total Motos         : {0}", pedidos.TotalMotosGeneral());

            Console.WriteLine("\n\nPrecios de Motos\n");
            Console.WriteLine("{0} motos acuaticas   : {1:C2}", pedidos.NunMotoAcuatica(), pedidos.TotalAPagarMotosAcuaticas());
            Console.WriteLine("{0} motos terrestres : {1:C2}", pedidos.NunMotoTerrestre(), pedidos.TotalAPagarMotosTerrestres());
            Console.WriteLine("__________________________");
            Console.WriteLine("Sub Total en Motos  : {0:C2}", pedidos.TotalAPagarMotos());

            Console.WriteLine("\n\nCantidad de Autos\n");
            Console.WriteLine("Total Autos Livianos  : {0}", pedidos.NunAutosLivianos());
            Console.WriteLine("Total Autos Pesados   : {0}", pedidos.NunAutosPesados());
            Console.WriteLine("__________________________");
            Console.WriteLine("Total Autos           : {0}", pedidos.TotalAutosGeneral());

            Console.WriteLine("\n\nPrecios de Autos\n");
            Console.WriteLine("{0} autos livianos   : {1:C2}", pedidos.NunAutosLivianos(), pedidos.TotalAPagarAutosLivianos());
            Console.WriteLine("{0} autos pesados   : {1:C2}", pedidos.NunAutosPesados(), pedidos.TotalAPagarAutosPesados());
            Console.WriteLine("__________________________");
            Console.WriteLine("Sub Total en Autos : {0:C2}", pedidos.TotalAPagarAutos());

            Console.WriteLine("\n\nNeto a Pagar: {0:C2} por un total de {1} articulos", pedidos.NetoAPagar(),pedidos.TotalArticulos());
            Console.ReadKey();
        }
    }
}
