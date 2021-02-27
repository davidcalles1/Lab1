using Lab1App.DOMINIO;
using Lab1App.NEGOCIO;
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
    public partial class FrmLoguin : Form
    {
        public FrmLoguin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsDominio objetoDominio = new ClsDominio();
            ClsNegocioLoguin objetoLoguin = new ClsNegocioLoguin();
               

            objetoDominio.User = txtUser.Text;
            objetoDominio.Pass = txtPass.Text;

            Boolean acceso = objetoLoguin.acceder(objetoDominio);

            if (acceso == true) {
                MessageBox.Show("ACCESO CONSEDIDO");
                Form2 fr = new Form2();
                fr.estadouser = txtUser.Text;
               


                fr.Show();
                 
            }
            else
            {
                MessageBox.Show("ACCESO DENEGADO");

            }



        }
    }
}
