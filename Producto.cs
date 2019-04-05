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
        private double _costo;/*_subtotal,_total*/
        private string _nombre;
        public int cantidad
        {
            get { return _cantidad; }
        }
        public double costo
        {
            get { return _costo; }
        }
       /* public double subtotal
        {
            get { return _subtotal; }
        }
        public double total
        {
            get { return _total; }
        }*/
        public string nombre
        {
            get { return _nombre; }
        }
        public Producto(string nombr, int cantida,double cost)
        {
            _nombre = nombr;
            _cantidad = cantida;
            _costo = cost;
        }
        public double importe()
        {
            double importe = _costo * _cantidad;
            return importe;
        }
        /*public double subtotales(double import)
        {
            return _subtotal += import;
        }*/
        public double iva(double num)
        {
            double a = 0.16;
            double res = num * a;
            return res;
        }
        /*public double totall(double nume)
        {
           return _total += _subtotal + nume;
        }*/
        public override string ToString()
        {
            return "Producto: " + _nombre + " Compro: " +_cantidad +Environment.NewLine+ " Costo por Unidad: $" + _costo + Environment.NewLine;
        }
    }
}
