using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2AN.Models
{
    public class liaison
    {
        private int idLiaison;
        private int secteurId;
        private int portDepartId;
        private int portArriveeId;
        private string duree;

        public liaison(int idLiaison, int secteurId, int portDepartId, int portArriveeId, string duree)
        {
            this.idLiaison = idLiaison;
            this.secteurId = secteurId;
            this.portDepartId = portDepartId;
            this.portArriveeId = portArriveeId;
            this.duree = duree;
        }

        public int IdLaison { get => idLiaison; set => idLiaison = value; }
        public int SecteurId { get => secteurId; set => secteurId = value; }
        public int PortDepartId { get => portDepartId; set => portDepartId = value; }
        public int PortArriveeId { get => portArriveeId; set => portArriveeId = value; }
        public string Duree { get => duree; set => duree = value; }

        public override string ToString()
        {

            return(this.idLiaison + this.secteurId + this.portDepartId + this.portArriveeId + this.duree);
        }
    }
}
