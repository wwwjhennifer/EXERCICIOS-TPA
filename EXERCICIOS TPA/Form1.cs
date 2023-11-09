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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void exercicío12ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void exercicío11EnquantoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmtabuada tabuada= new frmtabuada();
            tabuada.Show(); 

        }

        private void exercicío11RepitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConversão Conversão = new frmConversão();
            Conversão.Show();


        }


        private void paraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frmArea Area = new frmArea();
            Area.Show();

        }
    }
}
