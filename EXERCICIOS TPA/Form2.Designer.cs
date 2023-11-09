
namespace EXERCICIOS_TPA
{
    partial class frmtabuada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltabuada = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.txttabuada = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btnenquanto = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnRepita = new System.Windows.Forms.Button();
            this.btnPara = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltabuada
            // 
            this.lbltabuada.AutoSize = true;
            this.lbltabuada.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltabuada.Location = new System.Drawing.Point(35, 70);
            this.lbltabuada.Name = "lbltabuada";
            this.lbltabuada.Size = new System.Drawing.Size(155, 20);
            this.lbltabuada.TabIndex = 0;
            this.lbltabuada.Text = "Digite um número:";
            this.lbltabuada.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(35, 121);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(90, 20);
            this.lblresult.TabIndex = 1;
            this.lblresult.Text = "Resultado:";
            // 
            // txttabuada
            // 
            this.txttabuada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttabuada.Location = new System.Drawing.Point(420, 70);
            this.txttabuada.Name = "txttabuada";
            this.txttabuada.Size = new System.Drawing.Size(126, 29);
            this.txttabuada.TabIndex = 2;
            this.txttabuada.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtresult
            // 
            this.txtresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresult.Location = new System.Drawing.Point(420, 121);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.ReadOnly = true;
            this.txtresult.Size = new System.Drawing.Size(126, 224);
            this.txtresult.TabIndex = 3;
            // 
            // btnenquanto
            // 
            this.btnenquanto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnenquanto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenquanto.ForeColor = System.Drawing.Color.Black;
            this.btnenquanto.Location = new System.Drawing.Point(39, 234);
            this.btnenquanto.Name = "btnenquanto";
            this.btnenquanto.Size = new System.Drawing.Size(101, 32);
            this.btnenquanto.TabIndex = 4;
            this.btnenquanto.Text = "Enquanto";
            this.btnenquanto.UseVisualStyleBackColor = false;
            this.btnenquanto.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(689, 406);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(99, 32);
            this.btnsair.TabIndex = 5;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(420, 406);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(110, 32);
            this.btnvoltar.TabIndex = 6;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(563, 406);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(102, 32);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnRepita
            // 
            this.btnRepita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRepita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepita.ForeColor = System.Drawing.Color.Black;
            this.btnRepita.Location = new System.Drawing.Point(39, 272);
            this.btnRepita.Name = "btnRepita";
            this.btnRepita.Size = new System.Drawing.Size(101, 32);
            this.btnRepita.TabIndex = 8;
            this.btnRepita.Text = "Repita";
            this.btnRepita.UseVisualStyleBackColor = false;
            this.btnRepita.Click += new System.EventHandler(this.btnRepita_Click_1);
            // 
            // btnPara
            // 
            this.btnPara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPara.Location = new System.Drawing.Point(39, 310);
            this.btnPara.Name = "btnPara";
            this.btnPara.Size = new System.Drawing.Size(101, 32);
            this.btnPara.TabIndex = 9;
            this.btnPara.Text = "Para";
            this.btnPara.UseVisualStyleBackColor = false;
            this.btnPara.Click += new System.EventHandler(this.btnFaça_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Escolha a forma de calcular:";
            // 
            // frmtabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPara);
            this.Controls.Add(this.btnRepita);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnenquanto);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txttabuada);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lbltabuada);
            this.Name = "frmtabuada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "11 enquanto";
            this.Load += new System.EventHandler(this.frmtabuada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltabuada;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txttabuada;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btnenquanto;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnRepita;
        private System.Windows.Forms.Button btnPara;
        private System.Windows.Forms.Label label2;
    }
}