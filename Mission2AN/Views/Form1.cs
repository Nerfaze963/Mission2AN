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



        public Form1()
        {
            InitializeComponent();

            monManager = new Mgr();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            ls = monManager.chargementSecBD();
            ll = monManager.chargementLiaBD();

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

            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

                ll = monManager.chargementLiaBD();


                affiche();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

                affiche();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}