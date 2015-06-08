using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health
{
    public partial class HelpDeskMenuMed : Form
    {
        public HelpDeskMenuMed()
        {
            InitializeComponent();
        }

        private void adicionarMédicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarMedico adm = new AdicionarMedico();
            adm.Show();
        }

        private void adicionarProficiênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarProficiencia adp = new AdicionarProficiencia();
            adp.Show();
        }

        private void pesquisarProficiênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesquisarProficiencia pp = new PesquisarProficiencia();
            pp.Show();
        }

        private void atualizarProficiênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesquisarProficiencia pp = new PesquisarProficiencia();
            pp.Show();
        }
    }
}
