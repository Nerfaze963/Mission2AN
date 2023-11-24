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
        List<traversee> lt = new List<traversee>();




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
            afficheL();
            afficheS();
        }
        public void afficheL()
        {
            listBoxLiaisons.DataSource = null;
            listBoxLiaisons.DataSource = ll;
            listBoxLiaisons.DisplayMember = "Description2";


        }
        public void afficheS()
        {

            listBoxSecteurs.DataSource = null;
            listBoxSecteurs.DataSource = ls;
            listBoxSecteurs.DisplayMember = "Description";

            labelLiaisons.Text = null;
            labelLiaisons.Text = Convert.ToString(ll.Count);
        }
        public void affiche()

        {


            try
            {



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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Récuperer l'indice de la liaison selectionnée dans la listBox
                /* int i = listBoxLiaisons.SelectedIndex;
                 * 
                 * Récupérer la liaison selectionnée à partir de la collection "ll"
                 * liaison emp = ll[i];
                 */

                // Récupérer directement l'employé selectionné

                liaison emp = (liaison)listBoxLiaisons.SelectedItem;

                emp.Duree = TimeSpan.Parse(tbDuree.Text);

                monManager.updateLiaison(emp);

                // ll = monManager.chargementLiaBD();


                afficheL();

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
                // Récuperer l'indice de la liaison selectionnée dans la listBox
                /* int i = listBoxLiaisons.SelectedIndex;
                 * 
                 * Récupérer la liaison selectionnée à partir de la collection "ll"
                 * liaison emp = ll[i];
                 */

                // Récupérer directement l'employé selectionné

                liaison emp = (liaison)listBoxLiaisons.SelectedItem;

                monManager.deleteLiaison(emp);

                ll = monManager.chargementLiaBD();

                afficheS();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int portDepartId = ((port)comboBoxPort1.SelectedItem).Id;
                int portArriveId = ((port)comboBoxPort2.SelectedItem).Id;
                string duree = tbAddDuree.Text;

                secteur sec = (secteur)listBoxSecteurs.SelectedItem;
                liaison l = new liaison(15, sec.Id, portArriveId, portDepartId, TimeSpan.Parse(duree));
                monManager.ajoutLiaison(l);
                ll = monManager.chargementLiaisonSecteur(sec);
                afficheLiaisonSecteur();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            if (sec != null)
            {
                ll = monManager.chargementLiaisonSecteur(sec);
                afficheLiaisonSecteur();

            }


        }
        public void afficheTraversees()
        {
            try
            {
                listBoxTraversees.DataSource = null;
                listBoxTraversees.DataSource = lt;
                listBoxTraversees.DisplayMember = "DescriptionT";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void listBoxTraversees_SelectedIndexChanged(object sender, EventArgs e)
        {
            liaison lia = (liaison)listBoxTraversees.SelectedItem;
            if (lia != null)
            {
                lt = monManager.chargementTraverseeLiaison(lia);
                afficheTraverseeLiaison();

            }
        }
        public void afficheTraverseeLiaison()
        {
            try
            {
                listBoxLiaisons.DataSource = null;
                listBoxLiaisons.DataSource = lt;
                listBoxLiaisons.DisplayMember = "DescriptionT";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}