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
    public partial class LblMokkihakuID : Form
    {
        MainMenu mainform;

        OdbcConnection connection = new OdbcConnection(@"DSN=Village Newbies;MultipleActiveResultSets=True");
        OdbcCommand command;
        string conString = "DSN=Village Newbies;MultipleActiveResultSets=True";
        private List<string> hakulista;

        public LblMokkihakuID(MainMenu f1)
        {
            InitializeComponent();
            mainform = f1;

            
        }

        private void Toiminta_alueet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'villageNewbiesDataSet.mokki' table. You can move, or remove it, as needed.
            this.mokkiTableAdapter.Fill(this.villageNewbiesDataSet.mokki);
            // TODO: This line of code loads data into the 'villageNewbiesDataSet.toimintaalue' table. You can move, or remove it, as needed.
            this.toimintaalueTableAdapter.Fill(this.villageNewbiesDataSet.toimintaalue);
            paivitaDGV();

            hakulista = new List<string>();
            hakulista.Add(this.tbMokkihakuID.Text);
            hakulista.Add(this.tbMokkihakuNimi.Text);
            hakulista.Add(this.tbMokkihakuKOsoite.Text);
            hakulista.Add(this.tbMokkihakuPostiNro.Text);
            hakulista.Add(this.tbMokkihakuHlomaara.Text);
            hakulista.Add(this.tbMokkihakuVarustelu.Text);
            hakulista.Add(this.cbMokkihakuAlue.Text);
            hakulista.Add(this.cbMokkihakuHinta.Text);

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
            if (dgvToimiAlue.RowCount > 0)//Jos datagridistä valitaan joku niin sen nimi menee tekstikenttään
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
                updateQuery = "UPDATE mokki SET toimintaalue_id = " + cmbMokkiToimialue.SelectedValue + ", postinro = '" + tbPostinro.Text + "', mokkinimi = '" + tbMokkiNimi.Text + "', katuosoite ='" + tbKatuosoite.Text + "', kuvaus = '" + tbKuvaus.Text + "', henkilomaara = " + int.Parse(tbHloMaara.Text) + ", varustelu = '" + tbVarustelu.Text + "', hinta = " + Double.Parse(tbHinta.Text) + " WHERE (mokki_id = " + int.Parse(tbMokkiID.Text) + ")";
                executeMyQuery(updateQuery);
                paivitaDGV();
            }
        }

        private void btnPoistaMokki_Click(object sender, EventArgs e)
        {
            if (dgvMokit.RowCount > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Poistetaanko mökki?", "Varmistus", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string deleteQuery = "DELETE FROM mokki WHERE mokki_id = " + int.Parse(tbMokkiID.Text);
                    executeMyQuery(deleteQuery);
                    paivitaDGV();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        private void BtnMokkiHae_Click(object sender, EventArgs e)
        {
            string haku = luoHakustring();

            try
            {
                connection.ConnectionString = conString;
                using (connection)
                using (OdbcDataAdapter dadapter = new OdbcDataAdapter(haku, connection))
                {
                    DataTable table = new DataTable();
                    dadapter.Fill(table);
                    dgvMokit.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private string luoHakustring()
        {
            //Mitä haetaan
            //ToDO: ilmoitus sille, jos mitään ei löydy

            bool k = false;
            string valitut = "SELECT * FROM mokki WHERE ";

            for (int i = 0; i < hakulista.Count; ++i)
            {
                if (hakulista[i] != "")
                {

                    switch (i)
                    {
                        case 0:
                            if (k == true)
                            {
                                valitut = valitut + " OR ";
                            }
                            else k = true;
                            valitut = valitut + "mokki_id like '%" + tbMokkihakuID.Text + "%'";
                            break;
                        case 1:
                            if (k == true)
                            {
                                valitut = valitut + " OR ";
                            }
                            else k = true;
                            valitut = valitut + "mokkinimi like '%" + tbMokkihakuNimi.Text + "%'";
                            break;
                        case 2:
                            if (k == true)
                            {
                                valitut = valitut + " OR ";
                            }
                            else k = true;
                            valitut = valitut + "katuosoite like '%" + tbMokkihakuKOsoite.Text + "%'";
                            break;
                        case 3:
                            if (k == true)
                            {
                                valitut = valitut + " OR ";
                            }
                            else k = true;
                            valitut = valitut + "postinro like '%" + tbMokkihakuPostiNro.Text + "%'";
                            break;
                        case 4:
                            if (k == true)
                            {
                                valitut = valitut + " OR ";
                            }
                            else k = true;
                            valitut = valitut + "henkilomaara like '" + tbMokkihakuHlomaara.Text + "'";
                            break;
                        case 5:
                            if (k == true)
                            {
                                valitut = valitut + " OR ";
                            }
                            else k = true;
                            valitut = valitut + "varustelu like '%" + tbMokkihakuVarustelu.Text + "%'";
                            break;
                        case 6:
                            if (k == true)
                            {
                                valitut = valitut + " OR ";
                            }
                            else k = true;
                            valitut = valitut + "toimintaalue_id like '%" + cbMokkihakuAlue.Text + "%'";
                            break;
                        /*case 7:
                            if (k == true)
                            {
                                valitut = valitut + " OR ";
                            }
                            else k = true;
                            valitut = valitut + "hinta like '%" + cbMokkihakuAlue.Text + "%'";
                            break;*/



                    }
                }
            }

            return valitut;
        }

        private void selvitaHinta()
        {
            //ToDo textbocin luokat tekstiksi/sql-lausekkeeksi
        }
    }
}
