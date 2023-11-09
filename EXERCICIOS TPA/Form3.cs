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
    public partial class frmConversão : Form
    {
        public frmConversão()
        {
            InitializeComponent();
        }

        private void lblvalor_Click(object sender, EventArgs e)
        {

        }

        private void lblConversão_Click(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
        
    }

        private void btnlimpar_Click(object sender, EventArgs e)
        {

            txtConversão.Clear();
            txtGraus.Clear();
            txtGraus.Focus();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPara_Click(object sender, EventArgs e)
        {
            double I, G, F;

            G = Convert.ToDouble(txtGraus.Text);

            for (I = 0; I == 100; I = I + 10) 
            { 
            G = G + I;
            F = G * 1.8 + 32;
            txtConversão.Text = String.Concat(txtConversão.Text + "\r\n" + "A conversão de " + G.ToString() + " é " + F.ToString());
            }

        }

        private void btnenquanto_Click(object sender, EventArgs e)
        {
            double I, G, F;

            G = Convert.ToDouble(txtGraus.Text);

            I=0;
            
            while (I <= 100)
            {
                G = G + I;
                F = G * 1.8 + 32;
                txtConversão.Text = String.Concat(txtConversão.Text + "\r\n" + "A conversão de " + G.ToString() + " é " + F.ToString());
                I = I + 10;
            }
        }

        private void btnRepita_Click(object sender, EventArgs e)
        {

            double I, G, F;

            G = Convert.ToDouble(txtGraus.Text);

            I = 0;
            do
            {
                G = G + I;
                F = G  * 1.8 + 32;
              
                txtConversão.Text = String.Concat(txtConversão.Text + "\r\n"+ "A conversão de " + G.ToString()+" é "+ F.ToString());
         

                I = I + 10;
            } while (I <= 90);
        }

        private void frmConversão_Load(object sender, EventArgs e)
        {

        }
    }
}
