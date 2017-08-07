using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosTransportes
{
    public class Pedidos
    {
        private List<Transporte> _TransportePedidos;

        public List<Transporte> TransportePedidos
        {
            get { return _TransportePedidos; }
            set { _TransportePedidos = value; }
        }

        // Contructor
        public Pedidos()
        {
            //Intanciar mi lista
            TransportePedidos = new List<Transporte>();

            //Intanciar mi moto
            Moto motoA1 = new Moto("MA-00001", "Serpento", 1000, 3, false, true);
            Moto motoA2 = new Moto("MA-00002", "Toyota", 1000, 3, false, true);
            Moto motoA3 = new Moto("MA-00003", "Honda", 1000, 3, false, true);
            Moto motoT1 = new Moto("MT-00001", "Ninja", 1000, 5, true, false);
            Moto motoT2 = new Moto("MT-00002", "XXX", 1000, 5, true, false);
            Moto motoT3 = new Moto("MT-00003", "F1", 1000, 5, true, false);
            //Agregar instancias a la lista
            TransportePedidos.Add(motoA1);
            TransportePedidos.Add(motoA2);
            TransportePedidos.Add(motoA3);
            TransportePedidos.Add(motoT1);
            TransportePedidos.Add(motoT2);
            TransportePedidos.Add(motoT3);

            //Instanciar mis autos
            Automovil AutomovilLiviano1 = new Automovil("AU-00001-Liv", "Ford", 1000, 2, true, false);
            Automovil AutomovilLiviano2 = new Automovil("AU-00002-Liv", "Toyota", 1000, 2, true, false);
            Automovil AutomovilLiviano3 = new Automovil("AU-00003-Liv", "Honda", 1000, 2, true, false);
            Automovil AutomovilPesado1 = new Automovil("AU-00001-Pe", "Truck", 1000, 4, false, true);
            Automovil AutomovilPesado2 = new Automovil("AU-00002-Pe", "Ford", 1000, 4, false, true);
            Automovil AutomovilPesado3 = new Automovil("AU-00003-Pe", "Truck", 1000, 4, false, true);
            //Agregar a la lista
            TransportePedidos.Add(AutomovilLiviano1);
            TransportePedidos.Add(AutomovilLiviano2);
            TransportePedidos.Add(AutomovilLiviano3);
            TransportePedidos.Add(AutomovilPesado1);
            TransportePedidos.Add(AutomovilPesado2);
            TransportePedidos.Add(AutomovilPesado3);
        }

        #region Calcular n° Motos Acuaticas, Terrestres y totales        
        //Calcular el total de Motos Acuaticas     
        public int NunMotoAcuatica()
        {
            int NunMotoAcuatica = 0;
            for (int i = 0; i < TransportePedidos.Count; i++)
            {
                if ((TransportePedidos[i] is Moto) && (TransportePedidos[i] as Moto).Acuatica == true)
                {
                    NunMotoAcuatica += TransportePedidos[i].TotalTransporte();
                }
            }
            return NunMotoAcuatica;
        }

        //Calcular el total de Motos Terrestres
        public int NunMotoTerrestre()
        {
            int NunMotoTerrestre = 0;
            for (int i = 0; i < TransportePedidos.Count; i++)
            {
                if ((TransportePedidos[i] is Moto) && (TransportePedidos[i] as Moto).Terrestre == true)
                {
                    NunMotoTerrestre += TransportePedidos[i].TotalTransporte();
                }
            }
            return NunMotoTerrestre;
        }

        //Calcular el total de Motos en General
        public int TotalMotosGeneral()
        {
            int TotalMotosGeneral = 0;
            for (int i = 0; i < TransportePedidos.Count; i++)
            {
                if ((TransportePedidos[i] is Moto))
                {
                    TotalMotosGeneral += TransportePedidos[i].TotalTransporte();
                }

            }
            return TotalMotosGeneral;
        }
        #endregion

        #region Calcular n° autos livianos, pesados y totales
        //Calcular el total de Autos Livianos
        public int NunAutosLivianos()
        {
            int NunAutosLivianos = 0;
            for (int i = 0; i < TransportePedidos.Count; i++)
            {
                if ((TransportePedidos[i] is Automovil) && (TransportePedidos[i] as Automovil).Liviano == true)
                {
                    NunAutosLivianos += TransportePedidos[i].TotalTransporte();
                }
            }
            return NunAutosLivianos;
        }

        //Calcular el total de autos Pesados
        public int NunAutosPesados()
        {
            int NunAutosPesados = 0;
            for (int i = 0; i < TransportePedidos.Count; i++)
            {
                if ((TransportePedidos[i] is Automovil) && (TransportePedidos[i] as Automovil).Pesado == true)
                {
                    NunAutosPesados += TransportePedidos[i].TotalTransporte();
                }
            }
            return NunAutosPesados;
        }
        public int TotalAutosGeneral()
        {
            int TotalAutosGeneral = 0;
            for (int i = 0; i < TransportePedidos.Count; i++)
            {
                if ((TransportePedidos[i] is Automovil))
                {
                    TotalAutosGeneral += TransportePedidos[i].TotalTransporte();
                }
            }
            return TotalAutosGeneral;
        }
        #endregion

        #region Total a pagar motos acuaticas, terrestres y subtotal        
        //Total a pagar Motos
        public double TotalAPagarMotos()
        {
            double TotalAPagarMotos = 0;
            for (int i = 0; i < TransportePedidos.Count; i++)
            {
                if ((TransportePedidos[i] is Moto))
                {
                    TotalAPagarMotos += TransportePedidos[i].TotalAPagar();
                }
            }
            return TotalAPagarMotos;
        }

        //Total a pagar en Motos Acuaticas
        public double TotalAPagarMotosAcuaticas()
        {
            double TotalAPagarMotosAcuaticas = 0;
            for (int i = 0; i < TransportePedidos.Count; i++)
            {
                if ((TransportePedidos[i] is Moto) && (TransportePedidos[i] as Moto).Acuatica == true)
                {
                    TotalAPagarMotosAcuaticas += TransportePedidos[i].TotalAPagar();
                }
            }
            return TotalAPagarMotosAcuaticas;
        }

        //Total a pagar en motos Terrestres
        public double TotalAPagarMotosTerrestres()
        {
            double TotalAPagarMotosTerrestres = 0;
            for (int i = 0; i < TransportePedidos.Count; i++)
            {
                if ((TransportePedidos[i] is Moto) && (TransportePedidos[i] as Moto).Terrestre == true)
                {
                    TotalAPagarMotosTerrestres += TransportePedidos[i].TotalAPagar();
                }
            }
            return TotalAPagarMotosTerrestres;
        }
        #endregion

        #region Total a pagar en autos livianos, pesados y subtotal        
        //Total a pagar en autos
        public double TotalAPagarAutos()
        {
            double TotalAPagarAutos = 0;
            for (int i = 0; i < TransportePedidos.Count; i++)
            {
                if ((TransportePedidos[i] is Automovil))
                {
                    TotalAPagarAutos += TransportePedidos[i].TotalAPagar();
                }
            }
            return TotalAPagarAutos;
        }

        //Total a pagar en autos livianos
        public double TotalAPagarAutosLivianos()
        {
            double TotalAPagarAutosLivianos = 0;
            for (int i = 0; i < TransportePedidos.Count; i++)
            {
                if ((TransportePedidos[i] is Automovil) && (TransportePedidos[i] as Automovil).Liviano == true)
                {
                    TotalAPagarAutosLivianos += TransportePedidos[i].TotalAPagar();
                }
            }
            return TotalAPagarAutosLivianos;
        }

        //Total a pagar en autos pesados
        public double TotalAPagarAutosPesados()
        {
            double TotalAPagarAutosPesados = 0;
            for (int i = 0; i < TransportePedidos.Count; i++)
            {
                if ((TransportePedidos[i] is Automovil) && (TransportePedidos[i] as Automovil).Pesado == true)
                {
                    TotalAPagarAutosPesados += TransportePedidos[i].TotalAPagar();
                }
            }
            return TotalAPagarAutosPesados;
        }
        #endregion

        #region Neto a pagar y total de articulos        
        //Neto a pagar
        public double NetoAPagar()
        {
            double TotalTotal = 0;
            for (int i = 0; i < TransportePedidos.Count; i++)
            {
                TotalTotal += TransportePedidos[i].TotalAPagar();
            }
            return TotalTotal;
        }

        //Total de Articulos
        public int TotalArticulos()
        {
            int TotalArticulos = 0;
            for (int i = 0; i < TransportePedidos.Count; i++)
            {
                TotalArticulos += TransportePedidos[i].TotalTransporte();
            }
            return TotalArticulos;
        }
        #endregion

    }
}