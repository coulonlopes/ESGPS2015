using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;


namespace Health
{
    public partial class AdicionarProficiencia : Form
    {
        public AdicionarProficiencia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProficienciaClass m = new ProficienciaClass(textBox2.Text, richTextBox1.Text);
            MessageBox.Show(Dados.AdicionarProficiencia(m));
            this.Close();
        }
    }
}
