using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeromes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //OPÇÕES CAIXA DE SELECÃO
            cbNumero.Items.Add(01);
            cbNumero.Items.Add(02);
            cbNumero.Items.Add(03);
            cbNumero.Items.Add(04);
            cbNumero.Items.Add(05);
            cbNumero.Items.Add(06);
            cbNumero.Items.Add(07);
            cbNumero.Items.Add(08);
            cbNumero.Items.Add(09);
            cbNumero.Items.Add(10);
            cbNumero.Items.Add(11);
            cbNumero.Items.Add(12);


            cbNumeroCase.Items.Add(01);
            cbNumeroCase.Items.Add(02);
            cbNumeroCase.Items.Add(03);
            cbNumeroCase.Items.Add(04);
            cbNumeroCase.Items.Add(05);
            cbNumeroCase.Items.Add(06);
            cbNumeroCase.Items.Add(07);
            cbNumeroCase.Items.Add(08);
            cbNumeroCase.Items.Add(09);
            cbNumeroCase.Items.Add(10);
            cbNumeroCase.Items.Add(11);
            cbNumeroCase.Items.Add(12);
        }

        private void cbNumero_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DECLARAÇÃO VARIAVEL
            int mes;
            mes = Convert.ToInt32(cbNumero.SelectedItem);

            if (mes == 01)

            {
                txtMes.Text = ("Janeiro");

            }
            else if (mes == 02)
            {
                txtMes.Text = ("Fevereiro");

            }
            else if (mes == 03)
            {
                txtMes.Text = ("Março");
            }
            else if (mes == 04)
            {
                txtMes.Text = ("Abril");

            }
            else if (mes == 05)
            {
                txtMes.Text = ("Maio");

            }
            else if (mes == 06)
            {
                txtMes.Text = ("Junho");
            }
            else if (mes == 07)
            {
                txtMes.Text = ("Julho");
            }
            else if (mes == 08)
            {
                txtMes.Text = ("Agosto");
            }
            else if (mes == 09)
            {
                txtMes.Text = ("Setembro");
            }
            else if (mes == 10)
            {
                txtMes.Text = ("Outubro");
            }
            else if (mes == 11)
            {
                txtMes.Text = ("Novembro");

            }
            else if (mes == 12)
            {
                txtMes.Text = ("Dezembro");
            }
       
        
        }

        private void cbNumeroCase_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mes1 = Convert.ToInt32(cbNumeroCase.SelectedItem);

            switch (mes1)
            {
                case 01:
                    txtMesCase.Text = "Janeiro";
                    break;
                case 02:
                    txtMesCase.Text = "Fevereiro";
                    break;
                case 03:
                    txtMesCase.Text = "Março";
                    break;
                case 04:
                    txtMesCase.Text = "Abril";
                    break;
                case 05:
                    txtMesCase.Text = "Maio";
                    break;
                case 06:
                    txtMesCase.Text = "Junho";
                    break;
                case 07:
                    txtMesCase.Text = "Julho";
                    break;
                case 08:
                    txtMesCase.Text = "Agosto";
                    break;
                case 09:
                    txtMesCase.Text = "Setembro";
                    break;
                case 10:
                    txtMesCase.Text = "Outubro";
                    break;
                case 11:
                    txtMesCase.Text = "Novembro";
                    break;
                default:
                    txtMesCase.Text = "Dezembro";
                    break;



            }
            

            
        
        
        
        
        
        }
    }
}
