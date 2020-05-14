using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Village_Newbies
{
    public partial class Palvelut : Form
    {
        MainMenu mainform;
        public Palvelut(MainMenu f1)
        {
            InitializeComponent();
            mainform = f1;
        }



        private void Palvelut_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainform.Show();

        }

        private void Palvelut_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'villageNewbiesDataSet.palvelu' table. You can move, or remove it, as needed.
            this.palveluTableAdapter.Fill(this.villageNewbiesDataSet.palvelu);

        }

        OdbcConnection connection = new OdbcConnection(@"DSN=Village Newbies;MultipleActiveResultSets=True");
        OdbcCommand command;
        string conString = "DSN=Village Newbies;MultipleActiveResultSets=True";


        public void OpenConnection()
        {

            if (connection.State == ConnectionState.Closed)
            {
                connection.ConnectionString = conString;
                connection.Open();
            }
        }

        public void CloseConnection()
        {

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }



        public void ExecuteMyQuery(string query)
        {

            try
            {
                OpenConnection();
                command = connection.CreateCommand();
                command.CommandText = query;

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kysely suoritettu");
                }
                else
                {
                    MessageBox.Show("Kyselyä ei suoritettu");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {

            string asiakasAdd =
                "insert into palvelu (palvelu_id, toimintaalue_id, nimi, tyyppi, kuvaus, hinta, alv) values('" + tbPalveluID.Text + "','" + tbToimintaalueID.Text + "','" + tbNimi.Text + "','" + tbTyyppi.Text + "','" + tbKuvaus.Text + "'," + double.Parse(tbHinta.Text) + "," + double.Parse(tbAlv.Text) + ")";
            ExecuteMyQuery(asiakasAdd);
            this.palveluTableAdapter.Fill(this.villageNewbiesDataSet.palvelu);

        }

        private void btnMuokkaa_Click(object sender, EventArgs e)
        {

            string asiakasUpdate =
                "UPDATE palvelu SET toimintaalue_id='" + tbToimintaalueID.Text + "',nimi='" + tbNimi.Text + "',tyyppi='" + tbTyyppi.Text + "',kuvaus='" + tbKuvaus.Text + "',hinta='" + tbHinta.Text + "',alv=" + tbAlv.Text + " WHERE palvelu_id=" + int.Parse(tbPalveluID.Text);
            ExecuteMyQuery(asiakasUpdate);
            this.palveluTableAdapter.Fill(this.villageNewbiesDataSet.palvelu);
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {

            string asiakasPoista =
                "DELETE FROM palvelu WHERE palvelu_id= " + int.Parse(tbPalveluID.Text);
            ExecuteMyQuery(asiakasPoista);
            this.palveluTableAdapter.Fill(this.villageNewbiesDataSet.palvelu);
        }

        private void btnTyhjenna_Click(object sender, EventArgs e)
        {
            //Tyhjennetään sivu
            tbPalveluID.Text = "";
            tbToimintaalueID.Text = "";
            tbNimi.Text = "";
            tbTyyppi.Text = "";
            tbKuvaus.Text = "";
            tbHinta.Text = "";
            tbAlv.Text = "";
        }

        private void dgPalvelu_MouseClick(object sender, MouseEventArgs e)
        {
            //Tuodaan tiedot taulukosta textboxeihin
            tbPalveluID.Text = dataPalvelut.CurrentRow.Cells[0].Value.ToString();
            tbToimintaalueID.Text = dataPalvelut.CurrentRow.Cells[1].Value.ToString();
            tbNimi.Text = dataPalvelut.CurrentRow.Cells[2].Value.ToString();
            tbTyyppi.Text = dataPalvelut.CurrentRow.Cells[3].Value.ToString();
            tbKuvaus.Text = dataPalvelut.CurrentRow.Cells[4].Value.ToString();
            tbHinta.Text = dataPalvelut.CurrentRow.Cells[5].Value.ToString();
            tbAlv.Text = dataPalvelut.CurrentRow.Cells[6].Value.ToString();
        }


        private void Palvelu_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainform.Show();

        }
    }
}
