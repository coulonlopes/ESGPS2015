//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Utente
    {
        public Utente()
        {
            this.Consultas = new HashSet<Consulta>();
        }
    
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Morada { get; set; }
        public System.DateTime DataNasc { get; set; }
        public int Sns { get; set; }
        public int MedicoId { get; set; }
        public int BICC { get; set; }
        public int CodigoPostal { get; set; }
        public int Telefone { get; set; }
    
        public virtual Medico Medico { get; set; }
        public virtual ICollection<Consulta> Consultas { get; set; }
    }
}
