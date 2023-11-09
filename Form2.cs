using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXERCICIOS_TPA
{
    public partial class frmtabuada : Form
    {
        public frmtabuada()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtresult.Clear();
            txttabuada.Clear();
            txttabuada.Focus();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double nmr, i, result;
            nmr = Convert.ToDouble(txttabuada.Text);

            i = 1;


            while (i <= 10)
            {
                result = nmr * i;
                txtresult.Text = String.Concat(txtresult.Text + "\r\n" + nmr.ToString() + "X" + i.ToString() + " = " + result.ToString());
                i++;
            }



        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmtabuada_Load(object sender, EventArgs e)
        {

        }

        private void btnrepita_Click(object sender, EventArgs e)
        {

        }

        private void btnRepita_Click_1(object sender, EventArgs e)
        {
            Double nmr, i, result;
            nmr = Convert.ToDouble(txttabuada.Text);


            i = 1;

            do
            {
                result = nmr * i;

                txtresult.Text = String.Concat(txtresult.Text + "\r\n" + nmr.ToString() + "X" + i.ToString() + " = " + result.ToString());
                i++;
            } while (i <= 10);
        }

        private void btnFaça_Click(object sender, EventArgs e)
        {

            Double nmr, i, result;
            nmr = Convert.ToDouble(txttabuada.Text);
         
            for(i=1; i<=10;i++)
            {
                result = nmr * i;
                txtresult.Text = String.Concat(txtresult.Text + "\r\n" + nmr.ToString() + "X" + i.ToString() + " = " + result.ToString());

            }



          
         }
    }
}
