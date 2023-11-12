using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2AN.Models
{
    public class secteur
    {
        private int id;
        private string nom;

        public secteur(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
        }
        public string afficheSecteur
        {
            get => this.nom;
        }
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }


        public override String ToString()
        {
            return (this.id + "  " + this.nom);
        }

        // pour afficher la liste par la suite
        public string Description
        {
            get => "Id : " + this.id + " Nom :" + this.nom;
        }
    }
}
