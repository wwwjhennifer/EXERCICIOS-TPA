
namespace EXERCICIOS_TPA
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.exerciíio11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercicío11EnquantoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercicío11RepitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 48);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 24);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exerciíio11ToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(800, 24);
            this.menuStrip3.TabIndex = 3;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // exerciíio11ToolStripMenuItem
            // 
            this.exerciíio11ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercicío11EnquantoToolStripMenuItem,
            this.exercicío11RepitaToolStripMenuItem,
            this.paraToolStripMenuItem});
            this.exerciíio11ToolStripMenuItem.Name = "exerciíio11ToolStripMenuItem";
            this.exerciíio11ToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exerciíio11ToolStripMenuItem.Text = "MENU";
            // 
            // exercicío11EnquantoToolStripMenuItem
            // 
            this.exercicío11EnquantoToolStripMenuItem.Name = "exercicío11EnquantoToolStripMenuItem";
            this.exercicío11EnquantoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exercicío11EnquantoToolStripMenuItem.Text = "Exercicío 11";
            this.exercicío11EnquantoToolStripMenuItem.Click += new System.EventHandler(this.exercicío11EnquantoToolStripMenuItem_Click);
            // 
            // exercicío11RepitaToolStripMenuItem
            // 
            this.exercicío11RepitaToolStripMenuItem.Name = "exercicío11RepitaToolStripMenuItem";
            this.exercicío11RepitaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exercicío11RepitaToolStripMenuItem.Text = "Exercicío 12";
            this.exercicío11RepitaToolStripMenuItem.Click += new System.EventHandler(this.exercicío11RepitaToolStripMenuItem_Click);
            // 
            // paraToolStripMenuItem
            // 
            this.paraToolStripMenuItem.Name = "paraToolStripMenuItem";
            this.paraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.paraToolStripMenuItem.Text = "Exercicío 13 ";
            this.paraToolStripMenuItem.Click += new System.EventHandler(this.paraToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal ";
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem exerciíio11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercicío11EnquantoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercicío11RepitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraToolStripMenuItem;
    }
}

