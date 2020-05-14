using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
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

        OdbcConnection connection = new OdbcConnection(@"DSN=Village Newbies;MultipleActiveResultSets=True");
        OdbcCommand command;
        string conString = "DSN=Village Newbies;MultipleActiveResultSets=True";


        public Toiminta_alueet(MainMenu f1)
        {
            InitializeComponent();
            mainform = f1;
        }

        private void Toiminta_alueet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'villageNewbiesDataSet.toimintaalue' table. You can move, or remove it, as needed.
            this.toimintaalueTableAdapter.Fill(this.villageNewbiesDataSet.toimintaalue);
            paivitaDGV();

        }

        private void Toiminta_alueet_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainform.Show();
            //Avataan päävalikko uudelleen
        }


        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.ConnectionString = conString;
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void paivitaDGV()
        {
            //Tuo kaikki varaukset datagridiin
            string selectQuery = "SELECT * FROM mokki";
            DataTable table = new DataTable();
            connection.ConnectionString = conString;
            OdbcDataAdapter adapter = new OdbcDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dgvMokit.DataSource = table;
        }

        public void executeMyQuery(string query)
        {
            try
            {
                openConnection();
                using (connection)
                {
                    command = connection.CreateCommand();
                    command.CommandText = query;

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Suoritettu");
                    }
                    else
                    {
                        //MessageBox.Show("Virhe syötteessä");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        private void btnToimAluLisaa_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO toimintaalue (nimi) VALUES ('" + tbToimAlueNimi.Text + "')";
                executeMyQuery(insertQuery);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                toimintaalueTableAdapter.Fill(this.villageNewbiesDataSet.toimintaalue);
            }
        }

        private void dgvToimiAlue_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvToimiAlue.CurrentRow.Index;
            if (dgvToimiAlue.RowCount > 0)//Jos datagridistä valitaan varaus sen nimi menee tekstikenttään
            {
                tbToimAlueNimi.Text = dgvToimiAlue.Rows[index].Cells[1].Value.ToString();

            }
        }

        private void btnToimAluePoista_Click(object sender, EventArgs e)
        {
            if (dgvToimiAlue.RowCount > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Poistetaanko toiminta-alue ja sen mökit?", "Varmistus", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string query = "DELETE FROM mokki WHERE toimintaalue_id =" + int.Parse(tbToimiAlue.Text);
                    executeMyQuery(query);

                    string deleteQuery = "DELETE FROM toimintaalue WHERE toimintaalue_id = " + int.Parse(tbToimiAlue.Text);
                    executeMyQuery(deleteQuery);

                    toimintaalueTableAdapter.Fill(this.villageNewbiesDataSet.toimintaalue);
                    paivitaDGV();
                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
        }

        private void btnUusiMokki_Click(object sender, EventArgs e)
        {
            
            string insertQuery;
            insertQuery = "INSERT INTO mokki (toimintaalue_id, postinro, mokkinimi, katuosoite, kuvaus, henkilomaara, varustelu, hinta) VALUES (" + cmbMokkiToimialue.SelectedValue + " ,'" + tbPostinro.Text + "' ,'" + tbMokkiNimi.Text + "' ,'" + tbKatuosoite.Text + "' ,'" + tbKuvaus.Text + "' ," + int.Parse(tbHloMaara.Text) + " ,'" + tbVarustelu.Text + "'," + Double.Parse(tbHinta.Text) + ")";

            executeMyQuery(insertQuery);
            paivitaDGV();
        }

        private void btnMuutaMokkia_Click(object sender, EventArgs e)
        {
            if (dgvMokit.RowCount > 0)
            {
                int index = dgvMokit.CurrentRow.Index;
                
                string updateQuery;

                updateQuery = "UPDATE varaus SET toimintaalue_id = " + cmbMokkiToimialue.SelectedValue + ", postinro = '" + tbPostinro.Text + "', mokkinimi = '" + tbMokkiNimi.Text + "', katuosoite ='" + tbKatuosoite.Text + "', kuvaus = '" + tbKuvaus.Text + "', henkilomaara = " + int.Parse(tbHloMaara.Text) + ", varustelu = '" + tbVarustelu.Text + "', hinta = " + Double.Parse(tbHinta.Text) + " WHERE varaus_id = " + int.Parse(tbMokkiID.Text);

                executeMyQuery(updateQuery);
                paivitaDGV();
            }
        }
    }
}
