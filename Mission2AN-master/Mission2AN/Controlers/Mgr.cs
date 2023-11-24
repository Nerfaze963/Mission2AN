using MySqlConnector;
using Mission2AN.Models;
using Mission2AN.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Connecte.Controlers
{
    public class Mgr
    {

        List<secteur> maListeSecteur;
        List<liaison> maListeLiaison;
        List<port> maListePort;
        List<traversee> maListeTraversee;
        public Mgr()
        {

            maListeSecteur = new List<secteur>();
            maListeLiaison = new List<liaison>();
            maListePort = new List<port>();
            maListeTraversee = new List<traversee>();
        }
     

        public List<traversee> chargementTraBD()
        {
            maListeTraversee = traverseeDAO.GetTraversee();
            return (maListeTraversee);
        }
        // Récupération de la liste des secteurs à partir du DAL
        public List<secteur> chargementSecBD()
        {

            maListeSecteur = secteurDAO.GetSecteur();

            return (maListeSecteur);
        }
        // Récupération de la liste des liaisons à partir du DAL
        public List<liaison> chargementLiaBD()
        {

            maListeLiaison = liaisonDAO.GetLiaison();

            return (maListeLiaison);
        }
        // Récupération de la liste des ports à partir du DAL
        public List<port> chargementPortArriveeBD()
        {

            maListePort = portDAO.GetPortArrivee();

            return (maListePort);
        }
        public List<port> chargementPortDepartBD()
        {

            maListePort = portDAO.GetPortDepart();

            return (maListePort);
        }

        // Suppression d'une liaison dans le DAL
        public void deleteLiaison(liaison e)
        {
            liaisonDAO.deleteLiaison(e);
        }

        // Modification d'une liaison dans le DAL
        public void updateLiaison(liaison e)
        {
            liaisonDAO.updateLiaison(e);
        }

        public void ajoutLiaison(liaison e)
        {
            liaisonDAO.ajoutLiaison(e);
        }


        public List<liaison> chargementLiaisonSecteur(secteur sec)
        {

            maListeLiaison = liaisonDAO.GetLiaisonSecteur(sec);

            return (maListeLiaison);       
        }
        public List<traversee> chargementTraverseeLiaison(liaison lia)
        {

            maListeTraversee = traverseeDAO.GetTraverseeLiaison(lia);

            return (maListeTraversee);
        }
    }
}
