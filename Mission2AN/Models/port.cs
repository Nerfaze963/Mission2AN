    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2AN.Models
{
    public class port
    {
        protected int id;
        protected string nom;

        public port(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }

        public string affichePort
        {
            get => "(id: "+this.id+") "+this.nom;
        }

        public override string ToString()

        {
            return(this.nom);
        }
    }
}
