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
    public partial class Asiakkaat : Form
    {
        MainMenu mainform;
        public Asiakkaat(MainMenu f1)
        {
            InitializeComponent();
            mainform = f1;
        }

        private void Asiakkaat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'villageNewbiesDataSet.asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter.Fill(this.villageNewbiesDataSet.asiakas);

        }

        private void Asiakkaat_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainform.Show();
            //Avataan päävalikko uudelleen
        }
    }
}
