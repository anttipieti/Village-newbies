using Ohjelmistotuotanto_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Village_Newbies
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnMenuVaraukset_Click(object sender, EventArgs e)
        {
            //Avaa varaukset-lomake
            Varaukset newform = new Varaukset(this);
            newform.Show();
            this.Hide();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnMenuAs_Click(object sender, EventArgs e)
        {
            //Avaa asiakkaat-lomake
            Asiakkaat newform = new Asiakkaat(this);
            newform.Show();
            this.Hide();
        }

        private void btnMenuAlueet_Click(object sender, EventArgs e)
        {
            //Avaa Toiminta-alueet-lomake
            Toiminta_alueet newform = new Toiminta_alueet(this);
            newform.Show();
            this.Hide();
        }

        private void btnMenuPalvelut_Click(object sender, EventArgs e)
        {
            //Avaa Palvelut-lomake
            Palvelut newform = new Palvelut(this);
            newform.Show();
            this.Hide();
        }

        private void btnMenuLaskut_Click(object sender, EventArgs e)
        {
            //Avaa Palvelut-lomake
            LaskuForm newform = new LaskuForm(this);
            newform.Show();
            this.Hide();
        }
    }
}
