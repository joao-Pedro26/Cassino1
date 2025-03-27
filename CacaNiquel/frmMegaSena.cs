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
        private Random Mega= new Random();
        private int numSorteado;
        private int[,] cartao;
        public frmMegaSena()
        {
            InitializeComponent();
        }

        private void btnSortearNumeros_Click(object sender, EventArgs e)
        {
            //Consistência de dados - Verificar qtde de cartões

            if (String.IsNullOrWhiteSpace(txtQtdeCartoes.Text))
            {
                MessageBox.Show("Informe a qtde de cartões desejados!!",
                                "Mega Sena",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                return;
            }
        }
    }
}
