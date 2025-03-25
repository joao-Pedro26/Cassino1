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
        public CacaNiquel()
        {
            InitializeComponent();
            
        }

        private void btnGirar_Click(object sender, EventArgs e)
        {
            int niquel1,niquel2, niquel3;


            niquel1 = sorteio.Next(0, 10);
            niquel2 = sorteio.Next(0, 10);
            niquel3 = sorteio.Next(0, 10);
            lblNiquel1.Text = niquel1.ToString();
            lblNiquel2.Text = niquel3.ToString();
            lblNiquel3.Text = niquel2.ToString();
        }
    }
}
