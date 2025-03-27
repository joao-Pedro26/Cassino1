using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CacaNiquel
{
    public partial class CacaNiquel : Form
    {

        private Random sorteio = new Random();
        private int niquel1, niquel2, niquel3;
        private int contaNiquel = 1;
        private int contaGiro = 0;
        public CacaNiquel()
        {
            InitializeComponent();
        }

        private void btnGirar_Click(object sender, EventArgs e)
        {
            MostraNiquel();
        }

        private void MostraNiquel ()
        {

            niquel1 = sorteio.Next(0, 11);
            niquel2 = sorteio.Next(0, 11);
            niquel3 = sorteio.Next(0, 11);
            lblNiquel1.Text = niquel1.ToString();
            lblNiquel2.Text = niquel3.ToString();
            lblNiquel3.Text = niquel2.ToString();
        }

     
        private void tmrNiquel_Tick(object sender, EventArgs e)
        {

          {
            contaGiro++;
            lblNiquel1.Text = niquel1.ToString();
            if (contaNiquel == 1)
            {
                    niquel1 = sorteio.Next(0, 10);
                    lblNiquel1.Text = niquel1.ToString();
            }
            else if (contaNiquel == 2)
            {
                    niquel2 = sorteio.Next(0,10);
                    lblNiquel2.Text= niquel2.ToString();

            }
            else if(contaNiquel == 3)
            {
                    niquel3 = sorteio.Next(0,10);
                    lblNiquel3.Text= niquel3.ToString();
            }
            else
                {
                    
                    tmrNiquel.Enabled=false;
                    
                    VerificarGanho();
                    lblNiquel1.Text = String.Empty;
                    lblNiquel2.Text = String.Empty;
                    lblNiquel3.Text = String.Empty;
                    btnJogar.Text = "$Jogar";
                    contaNiquel = 1;


                }

                if (contaGiro == 10)
                {
                    contaNiquel++;
                    contaGiro = 0;
                }
            }

        }

        private void VerificarGanho()
        {
            if (niquel1 == niquel2 && niquel2 == niquel3)
            {
                MessageBox.Show("Três nuemros iguais. \n\nSequência: " +
                                    niquel1.ToString() + " - " +
                                    niquel2.ToString() + " - " +
                                    niquel3.ToString(), "Tigrinho Wins !!!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (niquel1 == niquel2 || niquel2 == niquel3 || niquel1 == niquel3)
            {
                MessageBox.Show("Dois iguais. \n\n Sequência: " +
                                    niquel1.ToString() + " - " +
                                    niquel2.ToString() + " - " +
                                    niquel3.ToString(), "Tigrinho Wins !!!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Todos diferentes. \n\n Sequência: " +
                                    niquel1.ToString() + " - " +
                                    niquel2.ToString() + " - " +
                                    niquel3.ToString(), "Tigrinho Wins !!!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnGiro_Click(object sender, EventArgs e)
        {

            tmrSorteioGeral.Enabled = true;

        }

        private void tmrSorteioGeral_Tick(object sender, EventArgs e)
        {
            MostraNiquel(); 
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            btnJogar.Text = "$Stop";
            tmrNiquel.Enabled = true;
        }
    }
}