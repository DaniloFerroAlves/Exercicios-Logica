namespace Percentualproduto
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
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtAumento = new System.Windows.Forms.TextBox();
            this.Aumento = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPorcentagem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor do produto";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(184, 250);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(100, 20);
            this.txtProduto.TabIndex = 1;
            // 
            // txtAumento
            // 
            this.txtAumento.Location = new System.Drawing.Point(500, 267);
            this.txtAumento.Name = "txtAumento";
            this.txtAumento.Size = new System.Drawing.Size(100, 20);
            this.txtAumento.TabIndex = 2;
            // 
            // Aumento
            // 
            this.Aumento.AutoSize = true;
            this.Aumento.Location = new System.Drawing.Point(392, 270);
            this.Aumento.Name = "Aumento";
            this.Aumento.Size = new System.Drawing.Size(102, 13);
            this.Aumento.TabIndex = 3;
            this.Aumento.Text = "Aumento percentual";
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(312, 254);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(61, 44);
            this.btCalcular.TabIndex = 4;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(515, 72);
            this.label3.TabIndex = 5;
            this.label3.Text = "Elaborar um sistema onde o usuário informa o preço de custo de um produto e calcu" +
    "lar o valor de venda, através do percentual informado pelo usuário.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Porcentagem desejada";
            // 
            // txtPorcentagem
            // 
            this.txtPorcentagem.Location = new System.Drawing.Point(184, 285);
            this.txtPorcentagem.Name = "txtPorcentagem";
            this.txtPorcentagem.Size = new System.Drawing.Size(100, 20);
            this.txtPorcentagem.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPorcentagem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.Aumento);
            this.Controls.Add(this.txtAumento);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtAumento;
        private System.Windows.Forms.Label Aumento;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPorcentagem;
    }
}

