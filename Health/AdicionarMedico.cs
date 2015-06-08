﻿using System;
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
    public partial class AdicionarMedico : Form
    {
        Proficiencia p;
        //iujhklyj
        public AdicionarMedico()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int identificacao, string nome,int nif, ProficienciaClass proficiencia, DateTime checkIn, DateTime checkOut)
            ProficienciaClass pf = new ProficienciaClass(p.Nome, p.Descricao);
            MedicoClass m = new MedicoClass(Convert.ToInt32(textBox2.Text), textBox1.Text, Convert.ToInt32(textBox4.Text), pf, DateTime.Parse(textBox5.Text), DateTime.Parse(textBox6.Text));
            MessageBox.Show(Dados.AdicionarMedico(m));
            this.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String res = comboBox1.Text;
            p = Dados.PesquisarProficiencia(res);
            
        }

        private void AdicionarMedico_Load(object sender, EventArgs e)
        {
            List<String> ps = new List<String>();
            ps = Dados.listarProficienciasNome();
            comboBox1.DataSource = ps;
        }
    }
}
