using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio5
{
    internal class Persona
    {
        public Persona(string nome, string cognome, DateTime dob)
        {
            Nome = nome;
            Cognome = cognome;
            Dob = dob;
        }

        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime Dob { get; set; }

        public int Eta()
        {
            return DateTime.Now.Year - Dob.Year;
        }
    }
}
