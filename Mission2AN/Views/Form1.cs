using Mission2AN.Models;
using Mission2AN.DAL;
using Connecte.Controlers;

namespace Mission2AN
{
    public partial class Form1 : Form
    {
        Mgr monManager;

        List<secteur> ls = new List<secteur>();
        List<liaison> ll = new List<liaison>();
        List<port> lpa = new List<port>();
        List<port> lpd = new List<port>();





        public Form1()
        {
            InitializeComponent();

            monManager = new Mgr();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            ls = monManager.chargementSecBD();
            ll = monManager.chargementLiaBD();
            lpd = monManager.chargementPortDepartBD();
            lpa = monManager.chargementPortArriveeBD();

            affiche();
        }

        public void affiche()

        {


            try
            {


                listBoxSecteurs.DataSource = null;
                listBoxSecteurs.DataSource = ls;
                listBoxSecteurs.DisplayMember = "Description";

                listBoxLiaisons.DataSource = null;
                listBoxLiaisons.DataSource = ll;
                listBoxLiaisons.DisplayMember = "Description2";

                comboBoxPort1.DataSource = null;
                comboBoxPort1.DataSource = lpa;
                comboBoxPort1.DisplayMember = "affichePort";

                comboBoxPort2.DataSource = null;
                comboBoxPort2.DataSource = lpd;
                comboBoxPort2.DisplayMember = "affichePort";

            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // R�cuperer l'indice de la liaison selectionn�e dans la listBox
                /* int i = listBoxLiaisons.SelectedIndex;
                 * 
                 * R�cup�rer la liaison selectionn�e � partir de la collection "ll"
                 * liaison emp = ll[i];
                 */

                // R�cup�rer directement l'employ� selectionn�

                liaison emp = (liaison)listBoxLiaisons.SelectedItem;

                emp.Duree = TimeSpan.Parse(tbDuree.Text);

                monManager.updateLiaison(emp);

                ll = monManager.chargementLiaBD();


                affiche();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }



        private void buttonSuppLia_Click(object sender, EventArgs e)
        {
            try
            {
                // R�cuperer l'indice de la liaison selectionn�e dans la listBox
                /* int i = listBoxLiaisons.SelectedIndex;
                 * 
                 * R�cup�rer la liaison selectionn�e � partir de la collection "ll"
                 * liaison emp = ll[i];
                 */

                // R�cup�rer directement l'employ� selectionn�

                liaison emp = (liaison)listBoxLiaisons.SelectedItem;

                monManager.deleteLiaison(emp);

                ll = monManager.chargementLiaBD();

                affiche();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            secteur secteur = listBoxSecteurs.SelectedItem as secteur;

            // initier les valeur pour la creation de l'objet
            string add_duree = tdAddDuree.Text;
            port add_depart = comboBoxPort2.SelectedItem as port;
            port add_arrivee = comboBoxPort1.SelectedItem as port;

            liaisonDAO.ajoutLiaison(add_duree, add_depart.Id, add_arrivee.Id, secteur.Id);

            listBoxLiaisons.DataSource = null;
            listBoxLiaisons.DataSource = liaisonDAO.GetLiaison(secteur.Id);
        }
        public void afficheLiaisonSecteur()
        {
            try
            {
                listBoxLiaisons.DataSource = null;
                listBoxLiaisons.DataSource = ll;
                listBoxLiaisons.DisplayMember = "Description";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxSecteurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            secteur sec = (secteur)listBoxSecteurs.SelectedItem;
            ll = monManager.chargementLiaisonSecteur(sec);
            afficheLiaisonSecteur();


        }

        private void tbDuree_TextChanged(object sender, EventArgs e)
        {

        }
    }
}