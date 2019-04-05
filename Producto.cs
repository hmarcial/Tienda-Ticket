using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Producto
    {
        private int _cantidad;
        private double _costo, _total;
        private string _nombre;
        public int cantidad
        {
            get { return _cantidad; }
        }
        public double costo
        {
            get { return _costo; }
        }
        public double total
        {
            get { return _total; }
        }
        public string nombre
        {
            get { return _nombre; }
        }
        public Producto(string nombr, int cantida,double cost)
        {
            _nombre = nombr;
            _cantidad = cantida;
            _costo = cost;
            _total = cost * cantida;
        }
        public double importe()
        {
            double importe = _costo * _cantidad;
            return importe;
        }
        public double iva(double num)
        {
            double a = 0.16;
            double res = num * a;
            return res;
        }
        public override string ToString()
        {
            return "Producto: " + _nombre + " Compro: " +_cantidad +Environment.NewLine+ " Costo por Unidad: $" + _costo + Environment.NewLine + " Total: $" +_total+ Environment.NewLine;
        }
    }
}
