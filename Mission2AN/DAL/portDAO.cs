using Mission2AN.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2AN.DAL
{
    public class portDAO
    {

        private static string provider = "localhost";

        private static string dataBase = "bdd_an";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand com;


        public static List<port> GetPortArrivee()
        {
            List<port> lp = new List<port>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();

                com = maConnexionSql.reqExec("SELECT * FROM port WHERE id IN (2, 3, 4, 7, 8, 9, 10);s");



                MySqlDataReader reader = com.ExecuteReader();


                port p;


                while (reader.Read())
                {


                    int id = Int32.Parse(reader.GetValue(0).ToString());
                    string nom = (string)reader.GetValue(1);


                    p = new port(id, nom);


                    lp.Add(p);


                }


                reader.Close();


                maConnexionSql.closeConnection();






            }

            catch (Exception emp)
            {

                throw emp;

            }

            return lp;

        }
    }
}