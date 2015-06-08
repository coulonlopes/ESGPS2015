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
        int sns;
        Dados d = new Dados();
        Consulta c;
        public AdicionarConsulta()
        {
            InitializeComponent();
        }

        public AdicionarConsulta(Consulta c)
        {
            InitializeComponent();
            this.c = c;
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void AdicionarConsulta_Load(object sender, EventArgs e)
        {
           
          
            sns = Health.Properties.Settings.Default.SNS;
            Utente u = d.getUtente(sns);
            textBox1.Text = u.Nome;
            textBox2.Text = sns.ToString();
            textBox4.Text = u.Medico.Nome;
            textBox3.Text = u.Medico.Proficiencia.Nome;

            int numConslt = d.idUltConsulta();

            textBox7.Text = (numConslt + 1).ToString();

            List<Proficiencia> proficiencias = d.getProficiencias();
            List<string> nomeProfcs= new List<string>();
            nomeProfcs.Add("Selecione uma proficiencia ");
            foreach (Proficiencia item in proficiencias)
            {
                nomeProfcs.Add(item.Nome);
            }
            comboBox2.DataSource = nomeProfcs;

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string proficiencia = comboBox2.SelectedItem.ToString();
             List<Medico> medicos= new List<Medico>();
             comboBox1.Items.Clear();
            if (proficiencia != "Selecione uma proficiencia") {
                    
                medicos = d.getMedicoProficiencia(proficiencia);

                foreach (Medico item in medicos)
                {
                    comboBox1.Items.Add(item.Nome);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nomeMedico= comboBox1.SelectedItem.ToString();
            int sns = Convert.ToInt32(textBox2.Text);
            DateTime data = dateTimePicker1.Value;
            TimeSpan ts = new TimeSpan(Convert.ToInt32(textHora.Text), Convert.ToInt32(textMin.Text), 0);
            data = data.Date + ts;

            d.AdicionarConsulta(nomeMedico, data, sns);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
