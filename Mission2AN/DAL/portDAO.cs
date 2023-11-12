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


        public static List<port> GetPort()
        {
            List<port> lc = new List<port>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();

                com = maConnexionSql.reqExec("Select * from port");



                MySqlDataReader reader = com.ExecuteReader();


                port p;


                while (reader.Read())
                {


                    int id = (int)reader.GetValue(0);
                    string nom = (string)reader.GetValue(1);


                    p = new port(id, nom);


                    lc.Add(p);


                }


                reader.Close();


                maConnexionSql.closeConnection();






            }

            catch (Exception emp)
            {

                throw emp;

            }

            return lc;

        }
    }
}