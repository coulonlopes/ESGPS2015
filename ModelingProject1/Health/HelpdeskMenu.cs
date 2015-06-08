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
    public partial class HelpdeskMenu : Form
    {
        public HelpdeskMenu()
        {
            InitializeComponent();
        }

        private void btMedicos_Click(object sender, EventArgs e)
        {
            HelpDeskMenuMed hpm = new HelpDeskMenuMed();
            hpm.ShowDialog();
        }

        private void btUtentes_Click(object sender, EventArgs e)
        {
            HelpDeskMenuUtt hpu = new HelpDeskMenuUtt();
            hpu.ShowDialog();
        }
    }
}
