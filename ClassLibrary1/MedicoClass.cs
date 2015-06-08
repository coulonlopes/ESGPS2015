using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MedicoClass: PessoaClass
    {
        private int nif;           
        private DateTime checkIn;        
        private DateTime checkOut;      
        private ProficienciaClass proficiencia;

        

        public MedicoClass(int identificacao, string nome,int nif, ProficienciaClass proficiencia, DateTime checkIn, DateTime checkOut)
            : base(identificacao,nome)
        {
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.nif = nif;
            this.proficiencia = proficiencia;

        }


        internal ProficienciaClass Proficiencia
        {
            get { return proficiencia; }
            set { proficiencia = value; }
        }
          public DateTime CheckOut
        {
            get { return checkOut; }
            set { checkOut = value; }
        }

          public int Nif
          {
              get { return nif; }
              set { nif = value; }
          }
          public DateTime CheckIn
          {
              get { return checkIn; }
              set { checkIn = value; }
          }
    }
}
