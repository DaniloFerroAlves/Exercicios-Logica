namespace Calculomediaescola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNota01 = new System.Windows.Forms.TextBox();
            this.txtNota02 = new System.Windows.Forms.TextBox();
            this.txtNota04 = new System.Windows.Forms.TextBox();
            this.txtNota03 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(654, 141);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota 01";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota 02";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nota 03";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nota 04";
            // 
            // txtNota01
            // 
            this.txtNota01.Location = new System.Drawing.Point(98, 200);
            this.txtNota01.Name = "txtNota01";
            this.txtNota01.Size = new System.Drawing.Size(100, 20);
            this.txtNota01.TabIndex = 5;
            // 
            // txtNota02
            // 
            this.txtNota02.Location = new System.Drawing.Point(98, 234);
            this.txtNota02.Name = "txtNota02";
            this.txtNota02.Size = new System.Drawing.Size(100, 20);
            this.txtNota02.TabIndex = 6;
            // 
            // txtNota04
            // 
            this.txtNota04.Location = new System.Drawing.Point(98, 304);
            this.txtNota04.Name = "txtNota04";
            this.txtNota04.Size = new System.Drawing.Size(100, 20);
            this.txtNota04.TabIndex = 8;
            // 
            // txtNota03
            // 
            this.txtNota03.Location = new System.Drawing.Point(98, 267);
            this.txtNota03.Name = "txtNota03";
            this.txtNota03.Size = new System.Drawing.Size(100, 20);
            this.txtNota03.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Resultado";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(426, 241);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(81, 13);
            this.lbStatus.TabIndex = 11;
            this.lbStatus.Text = "Status do aluno";
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(417, 256);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 12;
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(256, 237);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(74, 56);
            this.btCalcular.TabIndex = 13;
            this.btCalcular.Text = "Calcular Média";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNota03);
            this.Controls.Add(this.txtNota04);
            this.Controls.Add(this.txtNota02);
            this.Controls.Add(this.txtNota01);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNota01;
        private System.Windows.Forms.TextBox txtNota02;
        private System.Windows.Forms.TextBox txtNota04;
        private System.Windows.Forms.TextBox txtNota03;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btCalcular;
    }
}

