using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
   public class ProficienciaClass
    {

        private string nome;
        private string descricao;

        public ProficienciaClass(string nome, string descricao)
        {
            this.descricao = descricao;
            this.nome = nome;
        }

        public ProficienciaClass(string descricao)
        {
            this.descricao = descricao;

        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
    }
}
