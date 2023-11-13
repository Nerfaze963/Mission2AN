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
        List<secteur> maListeSecteur;
        List<liaison> maListeLiaison;
        public Mgr()
        {

            maListeSecteur = new List<secteur>();
            maListeLiaison = new List<liaison>();
        }
     


        // Récupération de la liste des secteurs à partir du DAL
        public List<secteur> chargementSecBD()
        {

            maListeSecteur = secteurDAO.GetSecteur();

            return (maListeSecteur);
        }
        public List<liaison> chargementLiaBD()
        {

            maListeLiaison = liaisonDAO.GetLiaison();

            return (maListeLiaison);
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

    }
}
