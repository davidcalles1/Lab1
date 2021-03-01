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
        public int tipoUsuario;

        private void button1_Click(object sender, EventArgs e)
        {
            ClsDominio objetoDominio = new ClsDominio();
            ClsNegocioLoguin objetoLoguin = new ClsNegocioLoguin();


            objetoDominio.User = txtUser.Text;
            objetoDominio.Pass = txtPass.Text;

            Boolean acceso = objetoLoguin.acceder(objetoDominio);

            if (acceso == true) {
                if (tipoUsuario == 0)
                {
                    if (txtUser.Text == "Carlos")
                    {
                        MessageBox.Show("ACCESO CONSEDIDO", "" + txtUser.Text);
                        Form2 fr = new Form2();
                        fr.txtNombreP.Text = "LAPTOP";
                        fr.txtNombreP.Enabled = false;
                        fr.txtIva.Enabled = false;
                        fr.lblusuario.Text = txtUser.Text;



                        fr.Show();
                    }
                    if (txtUser.Text == "Eva")
                    {
                        MessageBox.Show("ACCESO CONSEDIDO", "" + txtUser.Text);
                        Form2 fr = new Form2();
                        fr.txtNombreP.Text = "LAPTOP";
                        fr.txtNombreP.Enabled = false;
                        fr.txtIva.Enabled = false;
                        fr.lblusuario.Text = txtUser.Text;


                        fr.Show();
                    }
                    if (txtUser.Text == "Raquel")
                    {
                        MessageBox.Show("ACCESO DENEGADO ERES ADMIN", "" + txtUser.Text);



                    }
                    if (txtUser.Text == "Agustin")
                    {
                        MessageBox.Show("ACCESO DENEGADO ERES ADMIN", "" + txtUser.Text);




                    }

                }
                else
                {
                    if (txtUser.Text == "Carlos")
                    {
                        MessageBox.Show("ACCESO CONSEDIDO", "" + txtUser.Text);
                        Form2 fr = new Form2();
                        fr.txtNombreP.Text = "LAPTOP";
                        fr.txtNombreP.Enabled = false;
                        fr.txtIva.Enabled = false;
                        fr.lblusuario.Text = txtUser.Text;



                        fr.Show();
                    }
                    if (txtUser.Text == "Eva")
                    {
                        MessageBox.Show("ACCESO DENEGADO ERES USER", "" + txtUser.Text);

                        if (txtUser.Text == "Raquel")
                        {
                            MessageBox.Show("ACCESO CONCEDIDO", "" + txtUser.Text);
                            Form2 fr = new Form2();

                            fr.txtNombreP.Enabled = true;
                            fr.txtIva.Enabled = true;
                            fr.lblusuario.Text = txtUser.Text;
                            fr.lblusuario.Text = txtUser.Text;
                            fr.Show();
                        }



                    }
                    if (txtUser.Text == "Agustin")
                    {
                        MessageBox.Show("ACCESO CONCEDIDO", "" + txtUser.Text);
                        Form2 fr = new Form2();
                        fr.txtNombreP.Enabled = true;
                        fr.txtIva.Enabled = true;                       
                        fr.lblusuario.Text = txtUser.Text;
                        fr.Show();




                    }

                }



                this.Hide();
            }
            else
            {
                MessageBox.Show("ACCESO DENEGADO");

            }



        }
    }
}
