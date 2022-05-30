using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Percentualproduto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            //DECLARAR E ATRIBUIR
            decimal produto = Convert.ToDecimal(txtProduto.Text);
            decimal porcentagem = Convert.ToDecimal(txtPorcentagem.Text);
            decimal calculo;
            decimal resultado;
            //CALCULO PERCENTUAL
            calculo = (produto * porcentagem / 100);
            //AUMENTO EM PERCENTUAL
            resultado = (produto + calculo);
            txtAumento.Text = resultado.ToString();

        }


    }
}
