using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosTransportes
{
    /* 
      Hay 2 tipos de autos:
      Automóviles (Livianos y Pesados) 
      y va heredar de Transporte
    */
    public class Automovil : Transporte // Clase padre
    {
        private bool _Liviano;
        private bool _Pesado;

        //Contructor
        public Automovil(string _Placa, string _Marca, double _Precio, int _Cantidad, bool _Liviano, bool _Pesado):base(_Placa, _Marca, _Precio, _Cantidad)
        {
            this._Liviano = _Liviano;
            this._Pesado = _Pesado;
        }

        //Propiedades
        public bool Liviano
        {
            get { return _Liviano; }
            set { _Liviano = value; }
        }

        public bool Pesado
        {
            get { return _Pesado; }
            set { _Pesado = value; }
        }

        /*
         * Funcion para calcular el total a pagar
         * Si el auto es pesado, 
         * se le sumaran $5000 a cada auto pesado, 
         * por papeleos, documentaciones, bla bla bla
         */
        public override double TotalAPagar()
        {
            if (Pesado == true)
            {
                return (Cantidad) * (Precio + 5000);
            }
            else
            {
                return Cantidad * Precio;
            }
        }

        public override int TotalTransporte()
        {
            return Cantidad;
        }

    }
}
