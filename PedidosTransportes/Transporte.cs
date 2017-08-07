using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosTransportes
{
    /* 1- vamos a crear la clase transporte 
     * de la cual van a heredar las motos y los autos*/
    public class Transporte
    {
        private string _Placa;
        private string _Marca;
        private double _Precio;
        private int _Cantidad;

        public Transporte(string _Placa, string _Marca, double _Precio, int _Cantidad)
        {
            this.Placa = _Placa;
            this.Marca = _Marca;
            this.Precio = _Precio;
            this.Cantidad = _Cantidad;
        }

        public string Placa
        {
            get { return _Placa; }
            set { _Placa = value; }
        }

        public string Marca
        {
            get { return _Marca; }
            set { _Marca = value; }
        }

        public double Precio
        {
            get { return _Precio; }
            set { _Precio = value; }
        }

        public int Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }

        public virtual double TotalAPagar()
        {
            return 0;
        }

        public virtual int TotalTransporte()
        {
            return 0;
        }       

    }
}