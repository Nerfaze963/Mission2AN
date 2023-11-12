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
        List<secteur> maListeSecteur;

        public Mgr()
        {

            maListeSecteur = new List<secteur>();
        }



        // Récupération de la liste des secteurs à partir du DAL
        public List<secteur> chargementSecBD()
        {

            maListeSecteur = secteurDAO.GetSecteur();

            return (maListeSecteur);
        }


    }
}
