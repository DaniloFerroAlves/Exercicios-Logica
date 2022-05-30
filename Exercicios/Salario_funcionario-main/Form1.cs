using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salariofuncionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            decimal ganho_porhora = Convert.ToDecimal(txtGanhopor.Text);
            decimal horas_trabalho = Convert.ToDecimal(txtHorast.Text);
            int filhos = Convert.ToInt32(txtFilhos.Text);
            //calculos
            decimal salario_bruto = ganho_porhora * horas_trabalho;
            decimal salario_final = salario_bruto + (salario_bruto * filhos * 3 / 100);

            lbSalário.Text = salario_final.ToString();


        }
    
    
    
    
    
    
    
    
    }
}
