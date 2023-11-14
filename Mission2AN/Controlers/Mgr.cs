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

        secteurDAO secDAO = new secteurDAO();
        liaisonDAO liaDAO = new liaisonDAO();
        portDAO portDAO = new portDAO();
        List<secteur> maListeSecteur;
        List<liaison> maListeLiaison;
        List<port> maListePort;
        public Mgr()
        {

            maListeSecteur = new List<secteur>();
            maListeLiaison = new List<liaison>();
            maListePort = new List<port>();
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
        public List<port> chargementPortBD()
        {

            maListePort = portDAO.GetPortArrivee();

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

    }
}
