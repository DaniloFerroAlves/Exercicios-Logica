
namespace Numeromes
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNumero = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbNumeroCase = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMesCase = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero do mês";
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(93, 65);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(97, 20);
            this.txtMes.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mês";
            // 
            // cbNumero
            // 
            this.cbNumero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumero.FormattingEnabled = true;
            this.cbNumero.Location = new System.Drawing.Point(93, 20);
            this.cbNumero.Name = "cbNumero";
            this.cbNumero.Size = new System.Drawing.Size(121, 21);
            this.cbNumero.TabIndex = 4;
            this.cbNumero.SelectedIndexChanged += new System.EventHandler(this.cbNumero_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(718, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Elaborar um sistema onde o usuário digita o número do mês e exibir o nome do mês " +
    "correspondente.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNumero);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMes);
            this.groupBox1.Location = new System.Drawing.Point(51, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 121);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IF";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbNumeroCase);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtMesCase);
            this.groupBox2.Location = new System.Drawing.Point(374, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 121);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SWITCH/CASE";
            // 
            // cbNumeroCase
            // 
            this.cbNumeroCase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumeroCase.FormattingEnabled = true;
            this.cbNumeroCase.Location = new System.Drawing.Point(93, 20);
            this.cbNumeroCase.Name = "cbNumeroCase";
            this.cbNumeroCase.Size = new System.Drawing.Size(121, 21);
            this.cbNumeroCase.TabIndex = 4;
            this.cbNumeroCase.SelectedIndexChanged += new System.EventHandler(this.cbNumeroCase_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Numero do mês";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mês";
            // 
            // txtMesCase
            // 
            this.txtMesCase.Location = new System.Drawing.Point(75, 69);
            this.txtMesCase.Name = "txtMesCase";
            this.txtMesCase.Size = new System.Drawing.Size(97, 20);
            this.txtMesCase.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbNumeroCase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMesCase;
    }
}

