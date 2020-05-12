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
    public partial class Toiminta_alueet : Form
    {
        MainMenu mainform;
        public Toiminta_alueet(MainMenu f1)
        {
            InitializeComponent();
            mainform = f1;
        }

        private void Toiminta_alueet_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainform.Show();
            //Avataan päävalikko uudelleen
        }
    }
}
