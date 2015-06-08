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

        private void atualizarProficiênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pesquisar_AtualizarProficiencia f = new Pesquisar_AtualizarProficiencia();
            f.Show();
        }

        private void adicionarProficiênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarProficiencia fp = new AdicionarProficiencia();
            fp.Show();
        }

        private void adicionarMédicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarMedico fm = new AdicionarMedico();
            fm.Show();
        }

        private void pesquisarProficiênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pesquisar_AtualizarProficiencia fpa = new Pesquisar_AtualizarProficiencia();
            fpa.Show();
        }

        private void HelpDeskMenuMed_Load(object sender, EventArgs e)
        {

        }
    }
}
