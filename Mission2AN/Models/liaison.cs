using Mission2AN.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2AN.Models
{
    public class liaison
    {
        protected int idLiaison;
        protected int secteurId;
        protected int portDepartId;
        protected int portArriveeId;
        protected TimeSpan duree;

        public liaison(int idLiaison, int secteurId, int portDepartId, int portArriveeId, TimeSpan duree)
        {
            this.idLiaison = idLiaison;
            this.secteurId = secteurId;
            this.portDepartId = portDepartId;
            this.portArriveeId = portArriveeId;
            this.duree = duree;
        }

        public int IdLiaison { get => idLiaison; set => idLiaison = value; }
        public int SecteurId { get => secteurId; set => secteurId = value; }
        public int PortDepartId { get => portDepartId; set => portDepartId = value; }
        public int PortArriveeId { get => portArriveeId; set => portArriveeId = value; }
        public TimeSpan Duree { get => duree; set => duree = value; }

        public override string ToString()
        {
            
            string nomDepart = portDAO.GetPortArrivee()[this.portArriveeId - 1].affichePort;
           
            string nomArrive = portDAO.GetPortArrivee()[this.portDepartId - 1].affichePort;

            
            return nomArrive + " ; " + this.duree + " ; " + nomDepart;



            //return (this.idLiaison + "" + this.secteurId + "" + this.portDepartId + "" + this.portArriveeId + "" + this.duree);
        }
        
        
        /*
        public string Description2
        {
            get => "Id : " +this.idLiaison +"Départ : "+ "Arrivee :"+this.portArriveeId+ "Durée : "+this.Duree ;
        }*/
    }
}
