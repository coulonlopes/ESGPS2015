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
    public partial class AdicionarConsulta : Form
    {
        //isto trabalha????
        int sns;
        public AdicionarConsulta()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void AdicionarConsulta_Load(object sender, EventArgs e)
        {
            Dados d = new Dados();

            sns = Health.Properties.Settings.Default.SNS;
            Utente u = d.getUtente(sns);
            textBox1.Text = u.Nome;
            textBox2.Text = sns.ToString();
            textBox4.Text = u.Medico.Nome;
            textBox3.Text = u.Medico.Proficiencia.Nome;

            int numConslt = d.idUltConsulta();

            textBox7.Text = (numConslt + 1).ToString();



        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
