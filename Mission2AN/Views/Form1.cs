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
            ll = monManager.chargementSecBD();


            affiche();
        }

        public void affiche()

        {


            try
            {


                listBoxSecteurs.DataSource = null;
                listBoxSecteurs.DataSource = ls;
                listBoxSecteurs.DisplayMember = "Description";


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
    }
}