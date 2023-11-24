using Mission2AN.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Mission2AN.DAL
{
    public class traverseeDAO
    {
        private static string provider = "localhost";

        private static string dataBase = "bdd_an";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand com;

        public static List<traversee> GetTraversee()
        {
            List<traversee> lt = new List<traversee>();
            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();

                com = maConnexionSql.reqExec("Select * from traversee");



                MySqlDataReader reader = com.ExecuteReader();


                traversee t;


                while (reader.Read())
                {


                    int id = Int32.Parse(reader.GetValue(0).ToString());
                    int liaison_id = Int32.Parse(reader.GetValue(1).ToString());
                    int bateau_id = Int32.Parse(reader.GetValue(2).ToString());
                    DateTime date = (DateTime)reader.GetValue(3);
                    TimeSpan heure = (TimeSpan)reader.GetValue(4);


                    t = new traversee(id, liaison_id, bateau_id, date, heure);


                    lt.Add(t);


                }


                reader.Close();


                maConnexionSql.closeConnection();






            }

            catch (Exception emp)
            {

                throw emp;

            }

            return lt;

        }
        public static List<traversee> GetTraverseeLiaison(liaison lia)
        {
            List<traversee> ltl = new List<traversee>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                string requete = "Select * from traversee where liaison_id=" + lia.IdLiaison;
                com = maConnexionSql.reqExec(requete);



                MySqlDataReader reader = com.ExecuteReader();


                traversee TraverseeLiaison;


                while (reader.Read())
                {


                    int id = Int32.Parse(reader.GetValue(0).ToString());
                    int liaison_id = Int32.Parse(reader.GetValue(1).ToString());
                    int bateau_id = Int32.Parse(reader.GetValue(2).ToString());
                    DateTime date = (DateTime)reader.GetValue(3);
                    TimeSpan heure = (TimeSpan)reader.GetValue(4);


                    TraverseeLiaison = new traversee(id, liaison_id, bateau_id, date, heure);


                    ltl.Add(TraverseeLiaison);


                }


                reader.Close();


                maConnexionSql.closeConnection();






            }

            catch (Exception emp)
            {

                throw emp;

            }

            return ltl;
        }
    }
}
