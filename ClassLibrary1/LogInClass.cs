using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
  public  class LogInClass
    {
        
      private  string user;
      private string pass;
        private string tipo;

        
        public LogInClass (string username, string psw, string tipo)
        {
            this.user = username;
            this.pass = psw;
            this.tipo= tipo;
            

        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

    }
}
