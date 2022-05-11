using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExMenu
{
    public partial class FrmVermelho : Form
    {
        public FrmVermelho()
        {
            InitializeComponent();
        }

        private void ExibirFormAmarelo_Click(object sender, EventArgs e)
        {
            FrmAmarelo frmAmarelo = new FrmAmarelo(); // indico qual sera aberto
            this.Hide();// fechar o atual 
            frmAmarelo.ShowDialog();
        }

        private void ExibirFormAzul_Click(object sender, EventArgs e)
        {
            FrmAzul frmAzul = new FrmAzul(); // indico qual sera aberto
            this.Hide();// fechar o atual 
            frmAzul.ShowDialog();
        }

        private void ExibirFormVermelho_Click(object sender, EventArgs e)
        {
            FrmVermelho frmVermelho = new FrmVermelho(); // indico qual sera aberto
            this.Hide();// fechar o atual 
            frmVermelho.ShowDialog();
        }
    }
}
