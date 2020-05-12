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
            // Tuodaan tiedot datagridiin
            this.asiakasTableAdapter.Fill(this.villageNewbiesDataSet.asiakas);

        }

        OdbcConnection connection = new OdbcConnection(@"DSN=Village Newbies;MultipleActiveResultSets=True");
        OdbcCommand command;

        public void OpenConnection() //Tietokantayhteys auki
        {
            //Tietokantayhteys auki
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection() 
        {
            //Tietokantayhteys kiinni
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }



        public void ExecuteMyQuery(string query)
        {
            //sql-komentojen suoritus
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
    


        private void btnAsLisaa_Click(object sender, EventArgs e)
        {
            //datan lisäys tauluun, datagrid päivitys
            string asiakasAdd =
                "insert into asiakas(postinro, etunimi, sukunimi, lahiosoite, email, puhelinnro) values('"+ tbAsPostinro.Text+ "','"+tbAsEtunimi.Text+"','"+tbAsSukunimi.Text+ "','"+tbAsLOsoite.Text+ "','"+tbAsEmail.Text+ "','"+tbAsPuhNro.Text+ "')";
            ExecuteMyQuery(asiakasAdd);
            this.asiakasTableAdapter.Fill(this.villageNewbiesDataSet.asiakas);

        }

        private void btnAsMuokkaa_Click(object sender, EventArgs e)
        {
            //päivitetään taulun data ja datagrid
            string asiakasUpdate =
                "UPDATE asiakas SET postinro='" +tbAsPostinro.Text+ "',etunimi='"+tbAsEtunimi.Text+ "',sukunimi='" +tbAsSukunimi.Text+"',lahiosoite='" +tbAsLOsoite.Text+"',email='" +tbAsEmail.Text+"',puhelinnro="+tbAsPuhNro.Text+" WHERE asiakas_id="+int.Parse(tbAsID.Text);
            ExecuteMyQuery(asiakasUpdate);
            this.asiakasTableAdapter.Fill(this.villageNewbiesDataSet.asiakas);
        }

        private void dgAsiakas_MouseClick(object sender, MouseEventArgs e)
        {
            //Tuodaan tiedot taulukosta textboxeihin
            tbAsID.Text = dgAsiakas.CurrentRow.Cells[0].Value.ToString();
            tbAsPostinro.Text = dgAsiakas.CurrentRow.Cells[1].Value.ToString();
            tbAsEtunimi.Text = dgAsiakas.CurrentRow.Cells[2].Value.ToString();
            tbAsSukunimi.Text = dgAsiakas.CurrentRow.Cells[3].Value.ToString();
            tbAsLOsoite.Text = dgAsiakas.CurrentRow.Cells[4].Value.ToString();
            tbAsEmail.Text = dgAsiakas.CurrentRow.Cells[5].Value.ToString();
            tbAsPuhNro.Text = dgAsiakas.CurrentRow.Cells[6].Value.ToString();
        }

        private void Asiakkaat_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainform.Show();
            //Avataan päävalikko uudelleen
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
