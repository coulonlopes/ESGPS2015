using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class PessoaClass
    {
        private int identificacao; // pode ser o numero de cedula para o medico ou SNS para o Utente
        private string nome;



        public PessoaClass(int identificacao, string nome)
        {
            this.identificacao = identificacao;
            this.nome = nome;

        }

        public PessoaClass() { }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Identificacao
        {
            get { return identificacao; }
            set { identificacao = value; }
        }
    }
}
