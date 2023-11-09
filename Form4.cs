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
    public partial class frmArea : Form
    {
        public frmArea()
        {
            InitializeComponent();
          



        }
        double areat;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal Principal = new frmPrincipal();
            Principal.Show();

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcomprimento.Clear();
            txtLargura.Clear();
            txtNome.Clear();
            txtResult.Clear();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtcomprimento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double comp, larg, area ;
            comp = Convert.ToDouble(txtcomprimento.Text);
            larg = Convert.ToDouble(txtLargura.Text);
          

            area = comp * larg;
            areat += area;
            txtResult.Text = "A area do cômodo " + txtNome.Text  + " é "+ area.ToString() + Environment.NewLine;

            var result = MessageBox.Show("Deseja continuar calculando?", "Pergunta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result== DialogResult.Yes)
            {
                txtcomprimento.Focus();
                txtNome.Clear();
                txtcomprimento.Clear();
                txtLargura.Clear();
            }
            else
            {
                lblAreatotal.Visible = true;
                txtAreatotal.Visible = true;
                txtAreatotal.Text = areat.ToString();

            }



        }

        private void frmArea_Load(object sender, EventArgs e)
        {

        }

        private void lblAreatotal_Click(object sender, EventArgs e)
        {

        }
    }
}
