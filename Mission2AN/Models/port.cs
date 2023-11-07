using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2AN.Models
{
    public class port
    {
        private int id;
        private string nom;

        public port(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }

        public string afficheSecteur
        {
            get => this.nom;
        }

        public override string ToString()
        {
            return(this.nom);
        }
    }
}
