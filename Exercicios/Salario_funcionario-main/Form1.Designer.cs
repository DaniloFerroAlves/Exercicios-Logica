namespace salariofuncionario
{
    partial class Form1
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
            this.btCalcular = new System.Windows.Forms.Button();
            this.txtHorast = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtGanhopor = new System.Windows.Forms.TextBox();
            this.txtFilhos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSalário = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(269, 317);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 41);
            this.btCalcular.TabIndex = 0;
            this.btCalcular.Text = "Calcular Salário ";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // txtHorast
            // 
            this.txtHorast.Location = new System.Drawing.Point(121, 310);
            this.txtHorast.Name = "txtHorast";
            this.txtHorast.Size = new System.Drawing.Size(100, 20);
            this.txtHorast.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(121, 271);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtGanhopor
            // 
            this.txtGanhopor.Location = new System.Drawing.Point(121, 345);
            this.txtGanhopor.Name = "txtGanhopor";
            this.txtGanhopor.Size = new System.Drawing.Size(100, 20);
            this.txtGanhopor.TabIndex = 3;
            // 
            // txtFilhos
            // 
            this.txtFilhos.Location = new System.Drawing.Point(121, 374);
            this.txtFilhos.Name = "txtFilhos";
            this.txtFilhos.Size = new System.Drawing.Size(100, 20);
            this.txtFilhos.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Horas trabalhadas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ganho p/Hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Qntd/Filhos";
            // 
            // lbSalário
            // 
            this.lbSalário.AutoSize = true;
            this.lbSalário.Location = new System.Drawing.Point(394, 331);
            this.lbSalário.Name = "lbSalário";
            this.lbSalário.Size = new System.Drawing.Size(61, 13);
            this.lbSalário.TabIndex = 9;
            this.lbSalário.Text = "Salário final";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.lbSalário);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilhos);
            this.Controls.Add(this.txtGanhopor);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtHorast);
            this.Controls.Add(this.btCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.TextBox txtHorast;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtGanhopor;
        private System.Windows.Forms.TextBox txtFilhos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbSalário;
    }
}

