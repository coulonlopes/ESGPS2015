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
    public partial class HelpDeskMenuUtt : Form
    {
        public HelpDeskMenuUtt()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HelpDeskMenuUtt_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pesquisaBox_Enter(object sender, EventArgs e)
        {

        }

        private void btAddConsulta_Click(object sender, EventArgs e)
        {
            AdicionarConsulta ad = new AdicionarConsulta();
            ad.ShowDialog();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void efetuarMarcaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarConsulta ad = new AdicionarConsulta();
            ad.ShowDialog();
        }
    }
}
