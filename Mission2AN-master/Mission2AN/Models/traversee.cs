using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2AN.Models
{
    public class traversee
    {
        protected int id;
        protected int liaison_id;
        protected int bateau_id;
        protected DateTime date;
        protected TimeSpan heure;

        public traversee(int id, int liaison_id, int bateau_id, DateTime date, TimeSpan heure)
        {
            this.id = id;
            this.liaison_id = liaison_id;
            this.bateau_id = bateau_id;
            this.date = date;
            this.heure = heure;
        }

        public int Id { get => id; set => id = value; }
        public int Liaison_id { get => liaison_id; set => liaison_id = value; }
        public int Bateau_id { get => bateau_id; set => bateau_id = value; }
        public DateTime Date { get => date; set => date = value; }
        public TimeSpan Heure { get => heure; set => heure = value; }


        // pour afficher la liste par la suite
        public string DescriptionT
        {
            get => "Id : " + this.id + " Id bateau :" + this.bateau_id;
        }
    }
}

