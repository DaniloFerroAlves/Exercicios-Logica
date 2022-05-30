using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliadoridade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btVerificar_Click(object sender, EventArgs e)
        {
            //VARIAVEL E ATRIBUIÇÃO
            
            int idade = 0;
            idade = Convert.ToInt16(txtIdade.Text);

            if (idade >= 18)
            {
                lbResultado.Text = ("Permissão concedida");
                lbResultado.ForeColor = Color.Green;
                lbResultado.Font = new Font("Arial", 16);

            }
            else
            {
                lbResultado.Text = ("Sem permissão");
                lbResultado.ForeColor = Color.Red;
                lbResultado.Font = new Font("Arial", 16);


            }
        
        
        
        }
   
    
    
    
    
    
    
    
    
    }

}
