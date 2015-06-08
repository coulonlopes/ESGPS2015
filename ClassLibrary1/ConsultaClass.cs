using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class ConsultaClass
    {
        private MedicoClass medico;
        private UtenteClass utente;       
        private DateTime DataConsulta;       
        private string diagnostico;       
        private string sintomas;       
        private string estado; // o estado assume apenas dois valores "C" = cancelada  "A"= em aberto (ou seja nao foi cancelada)

        


        public ConsultaClass(MedicoClass medico, UtenteClass utente, DateTime DataConsulta, String estado)
        {
            this.medico = medico;
            this.utente = utente;
            this.DataConsulta = DataConsulta;
            this.estado = estado;
        }


        public ConsultaClass(MedicoClass medico, UtenteClass utente, DateTime DataConsulta, string estado, string diagnostico, string sintomas)
        {
            this.medico = medico;
            this.utente = utente;
            this.DataConsulta = DataConsulta;
            this.estado = estado;
            this.diagnostico = diagnostico;
            this.estado = estado;
        }

        public string Estado
        {
            get { return estado; }

        }

        public string Sintomas
        {
            get { return sintomas; }
            set { sintomas = value; }
        }

        public DateTime DataConsulta1
        {
            get { return DataConsulta; }
            set { DataConsulta = value; }
        }

        public UtenteClass Utente
        {
            get { return utente; }
            set { utente = value; }
        }

        internal MedicoClass Medico
        {
            get { return medico; }
            set { medico = value; }
        }
    }
}
