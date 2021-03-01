using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1App.VISTA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public String estadouser;
       
        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MENOR o IGUAL 50 NO TENDRA DESCUENTO", "<=50");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR A 50 Y MENOR QUE 100 TENDRA UN DESUENTO DEL 0.05 ", ">50 and <100");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR o IGUAL A 100 O MENOR QUE 101 TENDRA UN DESUENTO DEL 0.10 ", ">= 100 and <101");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR o IGUAL 101 Y MENOR QUE 150 TENDRA UN DESUENTO DEL 0.20 ", ">101 and <150");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR A 150 TENDRA UN DESUENTO DEL 0.50 ", ">150");

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string lb = txtNombreP.Text;
            lblNombrePro.Text = lb;
            if (txtIva.Text=="" || txtIva.Text==null)
            {
                double a = Convert.ToDouble(txtPrecio.Text);
                double b = Convert.ToDouble(txtCantidad.Text);
                double t = a * b;
                lblTotalSinIva.Text = t.ToString();

                double c = Convert.ToDouble(txtPrecio.Text);
                double r = t * 0.13;
                lblAgregarIva.Text = r.ToString();

                double p = t + r;

                lblTotalSinDescuento.Text = p.ToString();

                if (t <= 50)
                {
                    double f = t + r;
                    lblTotalPago.Text = f.ToString();

                }
                else if (t > 50 && t < 100)
                {
                    double resul = t * 0.05;
                    double res = t - resul + r;
                    lblTotalPago.Text = res.ToString();
                }
                else if (t >= 100 && t < 101)
                {
                    double resul = t * 0.10;
                    double res = (t + r) - resul;
                    lblTotalPago.Text = res.ToString();
                }
                else if (t >= 101 && t < 150)
                {
                    double resul = t * 0.20;
                    double res = t - resul + r;
                    lblTotalPago.Text = res.ToString();
                }
                else if (t > 150)
                {
                    double resul = t * 0.50;
                    double res = t - resul + r;
                    lblTotalPago.Text = res.ToString();
                }



            }
            else
            {
                double a = Convert.ToDouble(txtPrecio.Text);
                double b = Convert.ToDouble(txtCantidad.Text);
                double t = a * b;
                lblTotalSinIva.Text = t.ToString();

                double c = Convert.ToDouble(txtPrecio.Text);
                double r = t *( Convert.ToDouble(txtIva.Text))/100;
                lblAgregarIva.Text = r.ToString();

                double p = t + r;

                lblTotalSinDescuento.Text = p.ToString();

                if (t <= 50)
                {
                    double f = t + r;
                    lblTotalPago.Text = f.ToString();

                }
                else if (t > 50 && t < 100)
                {
                    double resul = t * 0.05;
                    double res = t - resul + r;
                    lblTotalPago.Text = res.ToString();
                }
                else if (t >= 100 && t < 101)
                {
                    double resul = t * 0.10;
                    double res = (t + r) - resul;
                    lblTotalPago.Text = res.ToString();
                }
                else if (t >= 101 && t < 150)
                {
                    double resul = t * 0.20;
                    double res = t - resul + r;
                    lblTotalPago.Text = res.ToString();
                }
                else if (t > 150)
                {
                    double resul = t * 0.50;
                    double res = t - resul + r;
                    lblTotalPago.Text = res.ToString();
                }
            }
            



        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
