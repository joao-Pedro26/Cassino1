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
    public partial class frmMegaSena : Form
    {
        private Random Mega = new Random();
        private int numeroSorteado;
        private int numSorteado;
        private int[,] cartao;
        private int[,] jogoVelha = new int[3, 3] {{ 1,0,1 },
                                                      { 0,1,0 },
                                                      { 1,1,1 }};

        public frmMegaSena()
        {
            InitializeComponent();
        }

        private void btnSortearNumeros_Click(object sender, EventArgs e)
        {
            //Consistência de dados - Verificar qtde de cartões

            if (String.IsNullOrWhiteSpace(txtQtdeCartoes.Text))
            {
                MessageBox.Show("Informe a qtde de  cartões desejados!!",
                                "Mega Sena",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                return;
            }
            cartao = new int[Convert.ToInt32(txtQtdeCartoes.Text), 6];
            GerarCartoes();
        }

        private void GerarCartoes()
        {
            int linhas = cartao.GetLength(0);
            int colunas = cartao.GetLength(1);

            for (int i = 0; i < linhas; i++)
            {
                StringBuilder numeros = new StringBuilder();
                HashSet<int> numerosSorteados = new HashSet<int>();

                for (int j = 0; j < colunas; j++)
                {
                    int numeroSorteado;
                    do
                    {
                        numeroSorteado = Mega.Next(1, 61);
                    } while (numerosSorteados.Contains(numeroSorteado));

                    numerosSorteados.Add(numeroSorteado);
                    cartao[i, j] = numeroSorteado;
                    numeros.Append(numeroSorteado.ToString() + " - ");
                }

                lblNumeros.Text = numeros.ToString();
                lstCartoes.Items.Add(numeros.ToString().TrimEnd(' ', '-'));
            }
        }
    }
}
