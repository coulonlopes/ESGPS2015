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
        private int BICC;
        private int cp;
        private int telefone;
        private int sns;      

        public UtenteClass(int sns, string nome, string morada, DateTime dataNasc, MedicoClass medico, int BICC, int cp, int telefone)
            : base(sns, nome)
        {
            this.dataNasc = dataNasc;
            this.medico = medico;
            this.morada = morada;
            this.BICC = BICC;
            this.sns = sns;
            this.telefone = telefone;
            this.cp = cp;

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
      public int BICC1
      {
          get { return BICC; }
          set { BICC = value; }
      }
      public int Cp
      {
          get { return cp; }
          set { cp = value; }
      }
      public int Telefone
      {
          get { return telefone; }
          set { telefone = value; }
      }
      public int Sns
      {
          get { return sns; }
          set { sns = value; }
      }

    }
}
