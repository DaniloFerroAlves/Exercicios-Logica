using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aumentosalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSalario.Text != "")
            {
                decimal salario = Convert.ToDecimal(txtSalario.Text);

                if (salario >= 5000)

                {

                    decimal aumento = salario * 10 / 100;
                    decimal resultado = salario + aumento;
                    txtAumento.Text = resultado.ToString();
                }
                else if (salario < 5000 && salario >= 2000)
                {
                    decimal aumento = salario * 20 / 100;
                    decimal resultado = salario + aumento;
                    txtAumento.Text = resultado.ToString();
                }
                else
                {
                    decimal aumento = salario * 30 / 100;
                    decimal resultado = salario + aumento;
                    txtAumento.Text = resultado.ToString();
                }


            }
            else
            {
                MessageBox.Show("Preencher o campo corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
                

            
        
       

        }
    
    
    
    
    
    
    
    }
}
