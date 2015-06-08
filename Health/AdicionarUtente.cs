using ClassLibrary1;
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
    public partial class AdicionarUtente : Form
    {
        int sns;
        Dados d = new Dados();
        Utente u = new Utente();
        public AdicionarUtente()
        {
            InitializeComponent();

        }

        private void AdicionarUtente_Load(object sender, EventArgs e)
        {
            
           
            
            
            List<Medico> allmedicos = d.getAllmedicos();
            foreach (Medico item in allmedicos)
            {
                comboBox1.Items.Add(item.Nome);
            }
            
          //  tbNomeUtente.Text = u.Nome;
          //  tbbicc.Text = u.BICC.ToString();
          //  tbCP.Text = u.Sns.ToString();
          //  tbTelefone.Text = u.Telefone.ToString();
          //  tbCP.Text = u.CodigoPostal.ToString();
          //dtpDataNasc.Text = u.DataNasc.ToString();

          //  int numUtente = d.idUltUtente();

        }

        private void btGuardarUtente_Click(object sender, EventArgs e)
        {
            
            string nomeUtente = tbNomeUtente.Text;
            int bicc = Convert.ToInt32(tbbicc.Text);
            DateTime dataNasc = dtpDataNasc.Value;
            int sns = Convert.ToInt32(tbSNS.Text);
            int cp = Convert.ToInt32(tbCP.Text);
            int telefone = Convert.ToInt32(tbTelefone.Text);
            string morada = rtbMorada.Text;
            string medico = comboBox1.Text;

            d.RegistarUtt(nomeUtente, bicc, dataNasc, sns, cp, telefone, morada, medico);

        }
    }
}
