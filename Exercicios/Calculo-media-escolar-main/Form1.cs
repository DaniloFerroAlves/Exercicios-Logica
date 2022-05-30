using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculomediaescola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)

        {   //VALIDAÇÃO DO PREENCHIMENTO DAS CAIXAS
            if (txtNota01.Text != "" && txtNota02.Text != "" && txtNota03.Text != "" && txtNota04.Text != "")
            {
                //VARIAVEL E ATRIBUIÇÃO
                decimal nota01 = Convert.ToDecimal(txtNota01.Text);
                decimal nota02 = Convert.ToDecimal(txtNota02.Text);
                decimal nota03 = Convert.ToDecimal(txtNota03.Text);
                decimal nota04 = Convert.ToDecimal(txtNota04.Text);
                decimal resultado = 0;

                //CÁLCULO DA MÉDIA
                resultado = (nota01 + nota02 + nota03 + nota04) / 4;
                //MOSTRAR O RESULTADO DA MÉDIA EM NUMERO
                txtResultado.Text = resultado.ToString();
                //CÁLCULO DA MÉDIA
                resultado = (nota01 + nota02 + nota03 + nota04) / 4;
                //MOSTRAR O RESULTADO DA MÉDIA EM NUMERO
                txtResultado.Text = resultado.ToString();

                if (resultado > 7) //APROVADO
                {
                    lbStatus.Text = ("Aprovado");
                    lbStatus.ForeColor = Color.Blue;
                    txtResultado.TextAlign = (HorizontalAlignment.Center);

                }
                else if (resultado >= 5 && resultado <= 7) //RECUPERAÇÃO
                {
                    lbStatus.Text = ("Recuperação");
                    lbStatus.ForeColor = Color.Gold;
                    txtResultado.TextAlign = (HorizontalAlignment.Center);

                }
                else //REPROVADO
                {
                    lbStatus.Text = ("Reprovado");
                    lbStatus.ForeColor = Color.Red;
                    txtResultado.TextAlign = (HorizontalAlignment.Center);


                }

            }
            else //SE FOR FALSO A VALIDAÇÃO DO PREENCHIMENTO DAS CAIXAS
            {
                MessageBox.Show("Favor preencher todos os campos corretamente","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }




            
            

        
        
        
        
        
        }
   
    
    
    
    }
}
