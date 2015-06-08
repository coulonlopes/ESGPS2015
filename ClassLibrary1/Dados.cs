﻿using System;
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

        public static string AdicionarProficiencia(ProficienciaClass proficiencia)
        {
            string res = String.Empty;
            try
            {
                using (var context = new HealthBDContainer())
                {
                    Proficiencia h = new Proficiencia
                    {
                        Nome = proficiencia.Nome,
                        Descricao = proficiencia.Descricao

                    };
                    context.Proficiencias.Add(h);
                    context.SaveChanges();
                    res = "Adicionado com sucs…";
                }
            }
            catch (Exception ex)
            {
                res = "erro…" + ex.InnerException.Message;
            } return res;
        }

        public static string AdicionarMedico(MedicoClass medico)
        {
            string res = String.Empty;
            try
            {
                using (var context = new HealthBDContainer())
                {
                    HelpDesk h = new HelpDesk
                    {
                        Nome = "Jussara"
                    };

                    LogIn log = PesquisarLogin("Jussara");
                    Proficiencia p = PesquisarProficiencia("pediatria");
                    Medico med = new Medico
                    {
                        Nome = medico.Nome,
                        Cedula = medico.Identificacao,
                        Nif = medico.Nif,
                        CheckIn = medico.CheckIn,
                        CheckOut = medico.CheckOut,

                    };

                    med.Proficiencia = p;
                    med.LogIn = log;
                    h.LogIn = log;
                    log.HelpDesk = h;


                    context.Medicos.Add(med);
                    context.SaveChanges();
                    res = "Adicionado com sucs…";
                }
            }
            catch (Exception ex)
            {
                res = "erro…" + ex.InnerException.Message;
            } return res;
        }



        public static string Adicionar(MedicoClass medico)
        {
            string res = String.Empty;
            try
            {
                using (var context = new HealthBDContainer())
                {
                    HelpDesk h = new HelpDesk
                    {
                        Nome = "Jussara"


                        //Address = "Leiria"
                    };
                    LogIn l = new LogIn
                    {
                        Username = "Jussara",
                        Password = "pass",
                        Tipo = "blabla"

                        //Address = "Leiria"
                    };
                    Medico m = new Medico
                    {
                        Nome = "Jussara",
                        Cedula = 1234,
                        Nif = 1234,
                        CheckIn = DateTime.Now,
                        CheckOut = DateTime.Now

                        //Address = "Leiria"
                    };
                    Proficiencia p = new Proficiencia
                    {
                        Nome = "Proficiencia teste",
                        Descricao = "Descriçao teste"

                        //Address = "Leiria"
                    };
                    context.LogIns.Add(l);
                    context.Medicos.Add(m);
                    h.LogIn = l;
                    l.HelpDesk = h;
                    l.Medico = m;
                    //  m.Proficiencia = p;


                    context.Proficiencias.Add(p);
                    context.SaveChanges();
                    res = "Added…";
                }
            }
            catch (Exception ex)
            {
                res = "erro…" + ex.Message;
            } return res;
        }


        public static Proficiencia PesquisarProficiencia(String nomeProficiencia)
        {
            Proficiencia p;
            using (var context = new HealthBDContainer())
            {
                p = context.Proficiencias.First(i => i.Nome == nomeProficiencia);
            }

            return p;
        }

        public static List<String> listarProficienciasNome()
        {
            List<String> proficiencias = new List<string>();
            using (var context = new HealthBDContainer())
            {
                try
                {
                    var query = from proficiencia in context.Proficiencias
                                select new
                                {
                                    nome = proficiencia.Nome
                                };

                    foreach (var categoryInfo in query)
                    {
                        proficiencias.Add(categoryInfo.nome);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } return proficiencias;

        }

        public static LogIn PesquisarLogin(String username)
        {
            LogIn login;
            using (var context = new HealthBDContainer())
            {
                login = context.LogIns.First(i => i.Username == username);
            }

            return login;
        }

        public static string AtualizarProficiencia(String nomeP, String descricao, string nome)
        {
            Proficiencia p;
            String res = String.Empty;
            try
            {
                using (var context = new HealthBDContainer())
                {
                    p = context.Proficiencias.First(i => i.Nome == nomeP);
                    p.Nome = nome;
                    p.Descricao = descricao;
                    context.SaveChanges();
                    res = "Proficiencia atualizada com sucesso!";
                }
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }
            return res;

        }

        public void RegistarUtt(UtenteClass ut)
        {
            Utente u = new Utente();
            u.BICC = ut.BICC1;
            u.Nome = ut.Nome;
            u.Sns = ut.Sns;
            u.Telefone = ut.Telefone;
            u.Morada = ut.Morada;
            u.CodigoPostal = ut.Cp;

            model.Utentes.Add(u);
            model.SaveChanges();
        }

        public void AdicionarConsulta(Consulta consulta)
        {
            Consulta c = new Consulta();
            consulta.Utente.Nome = c.Utente.Nome;
            consulta.Utente.Sns = c.Utente.Sns;
            consulta.Medico.Nome = c.Medico.Nome;
            consulta.Medico.Proficiencia = c.Medico.Proficiencia;

            model.Consultas.Add(c);
            model.SaveChanges();

        }
    }
}
