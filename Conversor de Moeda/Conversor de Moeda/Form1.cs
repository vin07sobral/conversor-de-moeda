using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_de_Moeda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //fecha o Form
            this.Close();
        }

        private void btnConv_Click(object sender, EventArgs e)
        {
            double valReal, valConv = 0;
            //habilita o botão limpar
            btnClear.Enabled = true;
            //Desabilita o botão Converter
            btnConv.Enabled = false;

            valReal = Convert.ToInt32(txtVal.Text);
            // Aqui ele valida qual Radio Button foi marcado, para fazer a conversão
            {
                if (rbDolar.Checked == true)
                    {
                        valConv = valReal * 0.328;
                    }
              //  else (rbLibra.Checked == true)
                  //  {
                      // valConv = valReal * 0.428;
                  //  }
                else if (rbEuro.Checked == true)
                        {
                            valConv = valReal * 0.386;
                        }
               //faz a conversão do valor convertido, com o metodo format para sair no textBox
                txtValConv.Text = string.Format("{0:###,##0.00}", valConv);
              
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //hanilita o botão converter
            btnConv.Enabled = true;
            //Limpa os textBox's
            txtVal.Text = "";
            txtValConv.Text = "";

        }

        private void txtValConv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

