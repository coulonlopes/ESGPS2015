using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Dados
    {
        /// esta classe contem os metodos nocessarios para ir buscar o dados à base de dados 
        /// 
        
        HealthBDContainer model = new HealthBDContainer();
        public Utente getUtente(int sns){
            //var query = from b in model.Utentes
            //            where (b.Sns == 123456)
            //            select b;
            //Utente u = query.First();
            Utente u = model.Utentes.Where(i => i.Sns == sns).First();
            
            //ProficienciaClass proficiencia = new ProficienciaClass(u.Medico.Proficiencia.Nome, u.Medico.Proficiencia.Descricao);
            //MedicoClass medico = new MedicoClass(21, u.Medico.Nome,u.Medico.Nif,proficiencia,u.Medico.CheckIn, u.Medico.CheckOut);




            //UtenteClass utente = new UtenteClass(u.Sns,u.Nome,u.Morada,u.DataNasc);
            return u;
        }

        public Consulta getConsulta(int numConsulta) {

            Consulta c = model.Consultas.Where(i => i.Id == numConsulta).First();


            return c;


        }

        public int idUltConsulta()
        {

            List<Consulta> list = model.Consultas.ToList();
            Consulta c = list.Last();
          int num = c.Id;

          return num;
        }

        public LogInClass getUser(string user, string pass)
        {
            //bool certo = false;
            LogInClass logIn;
            try { 
            LogIn log = model.LogIns.Where(i => i.Username == user).First();

           
             logIn = new LogInClass(log.Username, log.Password, log.Tipo);

            }
            catch (Exception ex)
            {
                logIn = null;
            }
            return logIn;
        }
    }
}
