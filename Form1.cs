using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemploGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string numeroCredito = txtNumeroCredito.Text;
            int numero = 0;
            try
            {
                numero = Convert.ToInt32(numeroCredito);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtNumeroCredito.Text = "";
            }
            
            lblNumeroCredito.Text = numero.ToString();

            string nombre = txtNombre.Text;
            if (nombre.Length > 0) 
            {
                MessageBox.Show("Debe ingresar un valor valido");
            }

            string sueldo = txtSueldo.Text;
            double sueldo_dou = 0;
            try
            {
                sueldo_dou = Convert.ToDouble(sueldo);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtSueldo.BackColor = Color.Red;
            }

            string montoCredito = txtMonto.Text;
            double monto= 0;
            try
            {
                monto = Convert.ToInt32(montoCredito);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Monto debe ser valor de tipo numerico");
               
            }

            string cuotas = txtCuotas.Text;
            int cuotas_int= 0;
            try
            {
                cuotas_int = Convert.ToInt32(cuotas);
            }catch(Exception ex)
            {
                MessageBox.Show("valor debe ser numero");
                txtCuotas.Text = "";
                txtCuotas.BackColor = Color.Red;

            }

            double maximoCredito = sueldo_dou * 1.5;


            if(monto<= maximoCredito)
            {
                if (cuotas_int >= 6)
                {
                    float tasaInteres = 0;
                    double valorMensual = 0;
                    if(cuotas_int <= 48)
                    {
                        tasaInteres = 1.85f / 12;

                    }
                    else
                    {
                        tasaInteres = 3.0f / 12;
                    }

                }
                else
                {
                    MessageBox.Show("NO PUEDE SER MENOR A 6");
                }
            }
            else
            {
                MessageBox.Show("ud no puede solicitar un monto tan grande");
            }

        }
    }
}
