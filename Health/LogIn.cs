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
    public partial class LogIn : Form
    {

        Dados d = new Dados();
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = tbUsername.Text;
            string pass = tbPwd.Text;

            LogInClass log = d.getUser(user, pass);



            if (log != null)
            {

                if (log.Tipo.Equals("M"))
                {

                    MenuMedico m = new MenuMedico();
                    m.ShowDialog();
                }
                else
                {
                    this.Hide();
                    HelpdeskMenu hp = new HelpdeskMenu();
                   
                    hp.ShowDialog();
                    
                }

            }
            else
                MessageBox.Show("Verifique as suas credenciais. Username ou Password erradas.");

        }

        private void LogIn_Load(object sender, EventArgs e)
        {



        }
    }
}
