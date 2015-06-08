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
    public partial class HelpDeskMenuUtt : Form
    {
        Dados dados = new Dados();
        Utente u;
        Consulta c;
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
            try
            {
                Health.Properties.Settings.Default.SNS = Convert.ToInt32(listView2.SelectedItems[0].Text);
                AdicionarConsulta ad = new AdicionarConsulta();
                
                ad.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("selecione um utente da lista");
            }
            
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarUtente ut = new AdicionarUtente();
            ut.ShowDialog();
        }

        private void efetuarMarcaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            AdicionarConsulta ad = new AdicionarConsulta();
            ad.ShowDialog();
          
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dados dados = new Dados();
            int sns = Convert.ToInt32(textBox2.Text);
             u = dados.getUtente(sns);

            ListViewItem lv = new ListViewItem(u.Sns.ToString());
            lv.SubItems.Add(u.Nome);
            listView2.Items.Add(lv);
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            

            try
            {
                int sns = Convert.ToInt32(listView2.SelectedItems[0].Text);


                Utente u = dados.getUtente(sns);

                List<Consulta> consultas = u.Consultas.ToList();


                foreach (Consulta item in consultas)
                {
                    ListViewItem lv = new ListViewItem(item.Id.ToString());
                    lv.SubItems.Add(item.Data.ToString());
                    listView1.Items.Add(lv);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numCons= Convert.ToInt32(textBox1.Text);
             c = dados.getConsulta(numCons);

             ListViewItem lv = new ListViewItem(c.Id.ToString());
             lv.SubItems.Add(c.Data.ToString());
             listView1.Items.Add(lv);


             ListViewItem lv1 = new ListViewItem(c.Utente.Sns.ToString());
             lv1.SubItems.Add(c.Utente.Nome.ToString());
             listView2.Items.Add(lv1);
            
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            int idConsulta= Convert.ToInt32( listView1.SelectedItems[0].Text);
            Consulta c = dados.getConsulta(idConsulta);

            VizualizarDetalhes ad = new VizualizarDetalhes(c);
            ad.ShowDialog();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}