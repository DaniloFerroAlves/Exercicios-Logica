namespace Avaliadoridade
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
            this.lbResultado = new System.Windows.Forms.Label();
            this.btVerificar = new System.Windows.Forms.Button();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite a idade:";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(162, 275);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(75, 18);
            this.lbResultado.TabIndex = 1;
            this.lbResultado.Text = "Resultado";
            // 
            // btVerificar
            // 
            this.btVerificar.Location = new System.Drawing.Point(68, 261);
            this.btVerificar.Name = "btVerificar";
            this.btVerificar.Size = new System.Drawing.Size(71, 49);
            this.btVerificar.TabIndex = 2;
            this.btVerificar.Text = "Verificar";
            this.btVerificar.UseVisualStyleBackColor = true;
            this.btVerificar.Click += new System.EventHandler(this.btVerificar_Click);
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(165, 225);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(55, 20);
            this.txtIdade.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(564, 128);
            this.label2.TabIndex = 4;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.btVerificar);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btVerificar;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label label2;
    }
}

