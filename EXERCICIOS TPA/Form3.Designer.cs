
namespace EXERCICIOS_TPA
{
    partial class frmConversão
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
            this.lblvalor = new System.Windows.Forms.Label();
            this.lblConversão = new System.Windows.Forms.Label();
            this.btnPara = new System.Windows.Forms.Button();
            this.btnRepita = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnenquanto = new System.Windows.Forms.Button();
            this.txtConversão = new System.Windows.Forms.TextBox();
            this.txtGraus = new System.Windows.Forms.TextBox();
            this.lblCalcular = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalor.Location = new System.Drawing.Point(41, 57);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(198, 20);
            this.lblvalor.TabIndex = 2;
            this.lblvalor.Text = "Digite o valor em Graus:";
            this.lblvalor.Click += new System.EventHandler(this.lblvalor_Click);
            // 
            // lblConversão
            // 
            this.lblConversão.AutoSize = true;
            this.lblConversão.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversão.Location = new System.Drawing.Point(41, 102);
            this.lblConversão.Name = "lblConversão";
            this.lblConversão.Size = new System.Drawing.Size(346, 20);
            this.lblConversão.TabIndex = 3;
            this.lblConversão.Text = "Resultado da conversão de 10 em 10 Graus:";
            this.lblConversão.Click += new System.EventHandler(this.lblConversão_Click);
            // 
            // btnPara
            // 
            this.btnPara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPara.Location = new System.Drawing.Point(45, 314);
            this.btnPara.Name = "btnPara";
            this.btnPara.Size = new System.Drawing.Size(101, 32);
            this.btnPara.TabIndex = 15;
            this.btnPara.Text = "Para";
            this.btnPara.UseVisualStyleBackColor = false;
            this.btnPara.Click += new System.EventHandler(this.btnPara_Click);
            // 
            // btnRepita
            // 
            this.btnRepita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRepita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepita.ForeColor = System.Drawing.Color.Black;
            this.btnRepita.Location = new System.Drawing.Point(45, 276);
            this.btnRepita.Name = "btnRepita";
            this.btnRepita.Size = new System.Drawing.Size(101, 32);
            this.btnRepita.TabIndex = 14;
            this.btnRepita.Text = "Repita";
            this.btnRepita.UseVisualStyleBackColor = false;
            this.btnRepita.Click += new System.EventHandler(this.btnRepita_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(551, 406);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(102, 32);
            this.btnlimpar.TabIndex = 13;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(408, 406);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(110, 32);
            this.btnvoltar.TabIndex = 12;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(677, 406);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(99, 32);
            this.btnsair.TabIndex = 11;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnenquanto
            // 
            this.btnenquanto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnenquanto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenquanto.ForeColor = System.Drawing.Color.Black;
            this.btnenquanto.Location = new System.Drawing.Point(45, 238);
            this.btnenquanto.Name = "btnenquanto";
            this.btnenquanto.Size = new System.Drawing.Size(101, 32);
            this.btnenquanto.TabIndex = 10;
            this.btnenquanto.Text = "Enquanto";
            this.btnenquanto.UseVisualStyleBackColor = false;
            this.btnenquanto.Click += new System.EventHandler(this.btnenquanto_Click);
            // 
            // txtConversão
            // 
            this.txtConversão.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConversão.Location = new System.Drawing.Point(516, 102);
            this.txtConversão.Multiline = true;
            this.txtConversão.Name = "txtConversão";
            this.txtConversão.ReadOnly = true;
            this.txtConversão.Size = new System.Drawing.Size(222, 244);
            this.txtConversão.TabIndex = 17;
            // 
            // txtGraus
            // 
            this.txtGraus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGraus.Location = new System.Drawing.Point(516, 48);
            this.txtGraus.Name = "txtGraus";
            this.txtGraus.Size = new System.Drawing.Size(222, 29);
            this.txtGraus.TabIndex = 16;
            // 
            // lblCalcular
            // 
            this.lblCalcular.AutoSize = true;
            this.lblCalcular.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalcular.Location = new System.Drawing.Point(41, 154);
            this.lblCalcular.Name = "lblCalcular";
            this.lblCalcular.Size = new System.Drawing.Size(223, 20);
            this.lblCalcular.TabIndex = 18;
            this.lblCalcular.Text = "Escolha a forma de calcular:";
            // 
            // frmConversão
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCalcular);
            this.Controls.Add(this.txtConversão);
            this.Controls.Add(this.txtGraus);
            this.Controls.Add(this.btnPara);
            this.Controls.Add(this.btnRepita);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnenquanto);
            this.Controls.Add(this.lblConversão);
            this.Controls.Add(this.lblvalor);
            this.Name = "frmConversão";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Converção graus para Fahrenhent ";
            this.Load += new System.EventHandler(this.frmConversão_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.Label lblConversão;
        private System.Windows.Forms.Button btnPara;
        private System.Windows.Forms.Button btnRepita;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnenquanto;
        private System.Windows.Forms.TextBox txtConversão;
        private System.Windows.Forms.TextBox txtGraus;
        private System.Windows.Forms.Label lblCalcular;
    }
}