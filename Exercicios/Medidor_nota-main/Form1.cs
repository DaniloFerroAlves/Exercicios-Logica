using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medidornota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            //ATRIBUIÇÃO VARIAVEIS
            decimal nota01 = Convert.ToDecimal(txtNota01.Text);
            decimal nota02 = Convert.ToDecimal(txtNota02.Text);
            decimal nota03 = Convert.ToDecimal(txtNota03.Text);
            decimal nota04 = Convert.ToDecimal(txtNota04.Text);
            decimal media;
            decimal menornota = nota01;
            decimal maiornota = nota01;

            
            media = (nota01 + nota02 + nota03 + nota04) / 4;
            txtMedia.Text = media.ToString("n1");

            
            //COMEÇO DAS CONDIÇÕES NOTAS MAIS BAIXAS
            
            if (nota02 < menornota) 
            {
                menornota = nota02;
            }
            if (nota03 < menornota)
            {
                menornota = nota03;
            }
            if (nota04 < menornota)
            {
                menornota = nota04;
            }

            //COMEÇO DAS CONDIÇÕES DAS NOTAS MAIS ALTA
            
            if (nota02 > maiornota)
            {
                maiornota = nota02;
            }
            if (nota03 > maiornota)
            {
                maiornota = nota03;
            }
            if (nota04 > maiornota)
            {
                maiornota = nota04;
            }

            txtAlta.Text = maiornota.ToString("n1");
            txtBaixa.Text = menornota.ToString("n1");














        }     
    
    
    
    
    
    
    
    
    }
}
