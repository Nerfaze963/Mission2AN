using Mission2AN.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2AN.DAL
{
    public class liaisonDAO
    {

        private static string provider = "localhost";

        private static string dataBase = "bdd_an";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand com;


        public static List<liaison> GetLiaison()
        {
            List<liaison> ll = new List<liaison>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();

                com = maConnexionSql.reqExec("Select * from liaison");



                MySqlDataReader reader = com.ExecuteReader();


                liaison l;


                while (reader.Read())
                {


                    int idLiaison = Int32.Parse(reader.GetValue(0).ToString());
                    int secteurId = Int32.Parse(reader.GetValue(1).ToString());
                    int portDepartId = Int32.Parse(reader.GetValue(2).ToString());
                    int portArriveeId = Int32.Parse(reader.GetValue(3).ToString());
                    TimeSpan duree = (TimeSpan)reader.GetValue(4);


                    l = new liaison(idLiaison, secteurId, portDepartId, portArriveeId, duree);


                    ll.Add(l);


                }


                reader.Close();


                maConnexionSql.closeConnection();






            }

            catch (Exception emp)
            {

                throw emp;

            }

            return ll;

        }
    }
}