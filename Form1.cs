using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tienda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double subtotal,total;

        private void btnpagar_Click(object sender, EventArgs e)
        {
            double pago = Convert.ToDouble(txtpaga.Text);
            if(pago > total)
            {
                double r = pago - total;
                txtcambio.Text = Convert.ToString(r);
            }
            else
            {
                txtcambio.Text = "0";
            }
            total -= pago;
            txtsubtotal.Text = Convert.ToString(subtotal);
            txtotal.Text = Convert.ToString(total);
        }

        private void btnticket_Click(object sender, EventArgs e)
        {
            SaveFileDialog guarda = new SaveFileDialog();
            guarda.FileName = "Ticket.txt";
            guarda.Filter = "Text File | *.txt";
            if (guarda.ShowDialog() == DialogResult.OK)
            {
                StreamWriter escritura = new StreamWriter(guarda.OpenFile());
                escritura.WriteLine("Ticket de Compra ");
                escritura.WriteLine("//Tienda don Pedro//");
                escritura.WriteLine("//////////////////////////////////////////////");
                for (int i = 0; i < lisdale.Items.Count; i++)
                {   
                    escritura.WriteLine(lisdale.Items[i].ToString());
                }
                escritura.WriteLine("//////////////////////////////////////////////");
                escritura.WriteLine("Su Subtotal fue de: ");
                escritura.WriteLine("$"+subtotal);
                escritura.WriteLine("El iva es de 16%");
                escritura.WriteLine("Su Total Fue de: ");
                escritura.WriteLine("$"+total);
                escritura.Dispose();

                escritura.Close();
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string nombre = txtproducto.Text;
            int cantidad = Convert.ToInt32(nudcantidad.Value);
            double costo = Convert.ToDouble(txtcosto.Text);
            Producto p = new Producto(nombre, cantidad, costo);
            double importe = p.importe();
            txtimporte.Text =Convert.ToString(importe);
            /* double subtotal = p.subtotales(importe);
             txtsubtotal.Text = Convert.ToString(subtotal);*/
            double a = subtotal += importe;
            txtsubtotal.Text = Convert.ToString(a);
            double iva = p.iva(subtotal);
            txtiva.Text = Convert.ToString(iva);
            double resultado = total = subtotal + iva;
            txtotal.Text = Convert.ToString(resultado);
            /*double total = p.totall(iva);
            txtotal.Text = Convert.ToString(total);*/
            lisdale.Items.Add(p.ToString());  
        }
    }
}
