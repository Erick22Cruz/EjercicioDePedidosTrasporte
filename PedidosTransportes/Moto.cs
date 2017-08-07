using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosTransportes
{
    /* 
      Hay 2 tipos de motos
      Motos (Terrestres y Acuáticas)
      y va heredar de transporte
    */
    public class Moto : Transporte // Clase padre
    {
        private bool _Terrestre;
        private bool _Acuatica;

        //Contructor
        public Moto(string _Placa, string _Marca, double _Precio, int _Cantidad, bool _Terrestre, bool _Acuatica):base(_Placa, _Marca, _Precio, _Cantidad)
        {
            this._Terrestre = _Terrestre;
            this._Acuatica = _Acuatica;
        }

        //Propiedades
        public bool Terrestre
        {
            get { return _Terrestre; }
            set { _Terrestre = value; }
        }

        public bool Acuatica
        {
            get { return _Acuatica; }
            set { _Acuatica = value; }
        }

        /*
         * Funcion para calcular el total a pagar
         * Si la moto es acuatica, 
         * se le sumaran $3000 a cada moto acuatica 
         * por permisos, papeleos, bla bla bla
         */
        public override double TotalAPagar()
        {
            if (Acuatica == true)
            {
                return (Cantidad) * (Precio + 3000);
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
