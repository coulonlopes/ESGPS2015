using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class UtenteClass : PessoaClass
    {
        private string morada;        
        private DateTime dataNasc;        
        private MedicoClass medico;


        public UtenteClass (int sns, string nome, string morada, DateTime dataNasc, MedicoClass medico)
            : base(sns, nome)
        {
            this.dataNasc = dataNasc;
            this.medico = medico;
            this.morada = morada;

        }

        public UtenteClass()
            : base()
        {

        }
            

        public string Morada
        {
            get { return morada; }
            set { morada = value; }
        }

        public DateTime DataNasc
        {
            get { return dataNasc; }
            set { dataNasc = value; }
        }

      public MedicoClass Medico
        {
          get { return medico; }
          }
    }
}
