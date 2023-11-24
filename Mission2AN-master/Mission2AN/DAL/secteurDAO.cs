using Mission2AN.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2AN.DAL
{
    public class secteurDAO
    {

        private static string provider = "localhost";

        private static string dataBase = "bdd_an";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand com;


        public static List<secteur> GetSecteur()
        {
            List<secteur> ls = new List<secteur>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();

                com = maConnexionSql.reqExec("Select * from secteur");



                MySqlDataReader reader = com.ExecuteReader();


                secteur s;


                while (reader.Read())
                {

                    int id = Int32.Parse(reader.GetValue(0).ToString());
                    string nom = (string)reader.GetValue(1);


                    s = new secteur(id, nom);


                    ls.Add(s);


                }


                reader.Close();


                maConnexionSql.closeConnection();






            }

            catch (Exception emp)
            {

                throw emp;

            }

            return ls;

        }
    }
}