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
using Village_Newbies.VillageNewbiesDataSetTableAdapters;

namespace Village_Newbies
{
    public partial class Varaukset : Form
    {
        MainMenu mainform;
        public Varaukset(MainMenu f1)
        {
            InitializeComponent();
            mainform = f1;
        }

        private void Varaukset_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'villageNewbiesDataSet.palvelu' table. You can move, or remove it, as needed.
            this.palveluTableAdapter.Fill(this.villageNewbiesDataSet.palvelu);
            // TODO: This line of code loads data into the 'villageNewbiesDataSet.toimintaalue' table. You can move, or remove it, as needed.
            this.toimintaalueTableAdapter.Fill(this.villageNewbiesDataSet.toimintaalue);
            // TODO: This line of code loads data into the 'villageNewbiesDataSet.asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter.Fill(this.villageNewbiesDataSet.asiakas);
            // TODO: This line of code loads data into the 'villageNewbiesDataSet.varaus' table. You can move, or remove it, as needed.
            //this.varausTableAdapter.Fill(this.villageNewbiesDataSet.varaus);
            cmbVarausHakuEhto.SelectedIndex = 1;

            paivitaDGV();
            CustomTimeFormat();
        }

        OdbcConnection connection = new OdbcConnection(@"DSN=Village Newbies;MultipleActiveResultSets=True");
        OdbcCommand command;
        string conString = "DSN=Village Newbies;MultipleActiveResultSets=True";

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
            string selectQuery = "SELECT * FROM varaus";
            DataTable table = new DataTable();
            connection.ConnectionString = conString;
            OdbcDataAdapter adapter = new OdbcDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dtgVarausTaulu.DataSource = table;
        }

        public void executeMyQuery(string query)
        {
            try
            {
                openConnection();
                using(connection)
                {
                    command = connection.CreateCommand();
                    command.CommandText = query;

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Onnistui");
                    }
                    else
                    {
                        MessageBox.Show("Virhe syötteessä");
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

        private void btnUusi_Click(object sender, EventArgs e)
        {
            string varattu = dtpvarattu.Value.ToString("yyyy-MM-dd hh:mm:ss");
            string vahvistus = dtpvahvistus.Value.ToString("yyyy-MM-dd hh:mm:ss");
            string alku = dtpalku.Value.ToString("yyyy-MM-dd hh:mm:ss");
            string loppu = dtploppu.Value.ToString("yyyy-MM-dd hh:mm:ss");
            string insertQuery;
            if (chbvarausvahvista.CheckState == CheckState.Checked)//Vahvistamattomaan varaukseen ei tule mukaan vahvistuspäivämäärää
            {
                insertQuery = "INSERT INTO varaus (asiakas_id, mokki_mokki_id, varattu_pvm, varattu_alkupvm, varattu_loppupvm) VALUES (" + int.Parse(txtasiakasid.Text) + " ," + int.Parse(txtmokkiid.Text) + " ,'" + varattu + "' ,'" + alku + "' ,'" + loppu + "')";
            }
            else
            {
                insertQuery = "INSERT INTO varaus (asiakas_id, mokki_mokki_id, varattu_pvm, vahvistus_pvm, varattu_alkupvm, varattu_loppupvm) VALUES (" + int.Parse(txtasiakasid.Text) + " ," + int.Parse(txtmokkiid.Text) + " ,'" + varattu + "' ,'" + vahvistus + "' ,'" + alku + "' ,'" + loppu + "')";
            }

            executeMyQuery(insertQuery);
            paivitaDGV();
        }

        private void btnVarausAsiakasLisays_Click(object sender, EventArgs e)//Lisää asiakasID:n tekstilaatikkoon
        {
            txtasiakasid.Text = tbAsiakasIdVarausValinta.Text;
            tabVarausNakyma.SelectedTab = tabPageVaraus;
        }

        private void btnasiakas_Click(object sender, EventArgs e)//Avaa asiakasvalinnan
        {
            tabVarausNakyma.SelectedTab = tabPageAsiakas;
        }

        private void btnmokki_Click(object sender, EventArgs e)//Avaa mökkivalinnan
        {
            tabVarausNakyma.SelectedTab = tabPageMokki;
            //VarausToimiAlueet();
        }

        private void btnLisaaVarauksenMokki_Click(object sender, EventArgs e)//Lisää mökkiID:n tekstilaatikkoon
        {
            txtmokkiid.Text=tbVarausMokki.Text;
            tabVarausNakyma.SelectedTab = tabPageVaraus;
        }

        private void btnTabVarausPalvelut_Click(object sender, EventArgs e)//Avaa palveluvalinnan
        {
            tabVarausNakyma.SelectedTab = tabPagePalvelut;
        }

        private void VarausPalveluTauluPaivitys()//Näyttää varaukseen liittyvät palvelut taulukossa
        {
            try
            {
                string strSql = "SELECT v.varaus_id, v.palvelu_id, v.lkm, p.nimi FROM varauksen_palvelut v JOIN palvelu p ON p.palvelu_id = v.palvelu_id WHERE varaus_id =";

                connection.ConnectionString = conString;
                using (connection)
                using (OdbcDataAdapter dadapter = new OdbcDataAdapter(strSql + int.Parse(txtvarausid.Text), connection))
                {
                    DataTable table = new DataTable();
                    dadapter.Fill(table);
                    dtgVarauksenPalvelut.DataSource = table;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbPalvelulkm.Text = dtgVarauksenPalvelut.Rows.Count.ToString();
            }
        }

        private void cmbVarausPalveluValinta_SelectionChangeCommitted(object sender, EventArgs e)//Päivitetään palvelutaulua kun palvelu on valittu
        {
            VarausPalveluTauluPaivitys();
        }

        private void cmbVarausToimialue_SelectionChangeCommitted(object sender, EventArgs e)//Toimialueen valinta
        {
            string varaustoimialue = cmbVarausToimialue.SelectedValue.ToString();
            string strCon = "DSN=Village Newbies;MultipleActiveResultSets=True";

            try//tämä osio hakee toimialueen mökit taulukkoon
            {
                string strSql = "SELECT * FROM mokki WHERE toimintaalue_id = "+varaustoimialue;
                connection.ConnectionString = conString;
                using (connection)
                using (OdbcDataAdapter dadapter = new OdbcDataAdapter(strSql, connection))
                {
                    DataTable table = new DataTable();
                    dadapter.Fill(table);
                    dtgVarausMokit.DataSource = table;
                }
            }
            catch
            {
                
            }

            try//tämä osio hakee varauksen mökin toimialueen palvelut comboboxiin
            {
                string strSqlb = "SELECT * FROM palvelu WHERE toimintaalue_id = " + varaustoimialue;
                connection.ConnectionString = conString;
                using (connection)
                using (OdbcDataAdapter dadapter = new OdbcDataAdapter(strSqlb, connection))
                {
                    DataTable table = new DataTable();
                    dadapter.Fill(table);
                    cmbVarausPalveluValinta.DataSource = table;
                    cmbVarausPalveluValinta.ValueMember = "palvelu_id";
                    cmbVarausPalveluValinta.DisplayMember = "nimi";
                }
            }
            catch
            {

            }
        }

        private void btnLisaaVarausPalvelu_Click(object sender, EventArgs e)//lisää varauksen palvelut tietokantaan
        {
            try
            {
                string insertQuery = "INSERT INTO varauksen_palvelut VALUES (" + int.Parse(txtvarausid.Text) + ", " + cmbVarausPalveluValinta.SelectedValue + ", " + int.Parse(tbVarausPalveluLkm.Text) + ")";
                executeMyQuery(insertQuery);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                VarausPalveluTauluPaivitys();
            }
        }

        private void CustomTimeFormat()//datetimepickerin aikamuodon säätöä
        {
            dtpvarattu.Format = DateTimePickerFormat.Custom;
            dtpvarattu.CustomFormat = "ddd dd/MM/yyyy  HH:mm";
            dtpvahvistus.Format = DateTimePickerFormat.Custom;
            dtpvahvistus.CustomFormat = "ddd dd/MM/yyyy  HH:mm";
            dtpalku.Format = DateTimePickerFormat.Custom;
            dtpalku.CustomFormat = "ddd dd/MM/yyyy  HH:mm";
            dtploppu.Format = DateTimePickerFormat.Custom;
            dtploppu.CustomFormat = "ddd dd/MM/yyyy  HH:mm";
            dtphakualku.Format = DateTimePickerFormat.Custom;
            dtphakualku.CustomFormat = "ddd dd/MM/yyyy";
            dtphakupaattyy.Format = DateTimePickerFormat.Custom;
            dtphakupaattyy.CustomFormat = "ddd dd/MM/yyyy";
        }

        private void dtgVarausTaulu_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgVarausTaulu.CurrentRow.Index;
            if (dtgVarausTaulu.RowCount>0)//Jos datagridistä valitaan varaus sen id menee tekstikenttään
            {
                txtvarausid.Text = dtgVarausTaulu.Rows[index].Cells[0].Value.ToString();
                txtasiakasid.Text = dtgVarausTaulu.Rows[index].Cells[1].Value.ToString();
                txtmokkiid.Text = dtgVarausTaulu.Rows[index].Cells[2].Value.ToString();
                dtpvarattu.Value = Convert.ToDateTime(dtgVarausTaulu.Rows[index].Cells[3].Value);
                try//jos varaus on vahvistettu (ei ole NULL), pävitetään datetimepicker ja poistetaan ruudusta rasti
                {
                    dtpvahvistus.Value = Convert.ToDateTime(dtgVarausTaulu.Rows[index].Cells[4].Value);
                    chbvarausvahvista.CheckState = CheckState.Unchecked;
                }
                catch
                {
                    dtpvahvistus.Value = DateTime.Today;
                    chbvarausvahvista.CheckState = CheckState.Checked;
                }
                dtpalku.Value = Convert.ToDateTime(dtgVarausTaulu.Rows[index].Cells[5].Value);
                dtploppu.Value = Convert.ToDateTime(dtgVarausTaulu.Rows[index].Cells[6].Value);

                tbAsiakasIdVarausValinta.Text = dtgVarausTaulu.Rows[index].Cells[1].Value.ToString();
                tbVarausMokki.Text = dtgVarausTaulu.Rows[index].Cells[2].Value.ToString();

                VarausPalveluTauluPaivitys();
            }
        }

        private void dtgVarausMokit_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgVarausMokit.CurrentRow.Index;
            if (dtgVarausMokit.Rows[index].Cells[1].Value != null)//Jos datagridistä valitaan mökki sen id menee tekstikenttään
            {
                tbVarausMokki.Text = dtgVarausMokit.Rows[index].Cells[1].Value.ToString();
            }
        }

        private void btnMuuta_Click(object sender, EventArgs e)//muuttaa valitun varauksen tietoja
        {
            if (dtgVarausTaulu.RowCount > 0)
            {
                int index = dtgVarausTaulu.CurrentRow.Index;
                string varattu = dtpvarattu.Value.ToString("yyyy-MM-dd hh:mm:ss");
                string vahvistus = dtpvahvistus.Value.ToString("yyyy-MM-dd hh:mm:ss");
                string alku = dtpalku.Value.ToString("yyyy-MM-dd hh:mm:ss");
                string loppu = dtploppu.Value.ToString("yyyy-MM-dd hh:mm:ss");

                string updateQuery = "UPDATE varaus SET asiakas_id = " + int.Parse(txtasiakasid.Text) + ", mokki_mokki_id = " + int.Parse(txtmokkiid.Text) + ", varattu_pvm = '" + varattu + "', vahvistus_pvm = '" + vahvistus + "', varattu_alkupvm = '" + alku + "', varattu_loppupvm = '" + loppu + "' WHERE varaus_id = " + txtvarausid.Text;
                executeMyQuery(updateQuery);
                paivitaDGV();
            } 
        }

        private void btnVarausPoista_Click(object sender, EventArgs e)//poistaa varauksen JA siihen liittyvät palvelut
        {
            if (dtgVarausTaulu.RowCount > 0)
            {
                
                string query = "DELETE FROM varauksen_palvelut WHERE varaus_id =" + int.Parse(txtvarausid.Text);
                executeMyQuery(query);

                string deleteQuery = "DELETE FROM varaus WHERE varaus_id = " + int.Parse(txtvarausid.Text);
                executeMyQuery(deleteQuery);
                paivitaDGV();
            }     
        }

        private void btnPoistaVarausPalvelu_Click(object sender, EventArgs e)//poistaa valitun palvelun varauksesta
        {
            if (dtgVarauksenPalvelut.RowCount > 0)
            {
                int index = dtgVarauksenPalvelut.CurrentRow.Index;
                try
                {
                    string query = "DELETE FROM varauksen_palvelut WHERE varaus_id =" + Convert.ToInt32(dtgVarauksenPalvelut.Rows[index].Cells[0].Value) + " AND palvelu_id = " + Convert.ToInt32(dtgVarauksenPalvelut.Rows[index].Cells[1].Value);
                    executeMyQuery(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    VarausPalveluTauluPaivitys();
                }
            }
        }

        private void Varaukset_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainform.Show();
            //Avataan päävalikko uudelleen
        }

        private void VarausToimiAlueet()//Hakee toimialueet comboboxiin
        {
            string strSqlb = "SELECT * FROM toimintaalue";

            connection.ConnectionString = conString;
            using (connection)
            using (OdbcDataAdapter dadapter = new OdbcDataAdapter(strSqlb, connection))
            {
                DataTable table = new DataTable();
                dadapter.Fill(table);
                cmbVarausToimialue.DataSource = table;
                cmbVarausToimialue.ValueMember = "toimintaalue_id";
                cmbVarausToimialue.DisplayMember = "nimi";
            }
        }

        private void btnHaku_Click(object sender, EventArgs e)//Hakee varaukset annetuilla hakuehdoilla
        {
            string alku = dtphakualku.Value.ToString("yyyy-MM-dd hh:mm:ss");
            string loppu = dtphakupaattyy.Value.ToString("yyyy-MM-dd hh:mm:ss");
            string hakusana;

            if (cmbVarausHakuEhto.Text == "Voimassaolevat varaukset")
            {
                if (chbvarausvahvistetut.CheckState == CheckState.Checked)
                {
                    hakusana = @"SELECT * FROM varaus WHERE ((varattu_alkupvm BETWEEN '" + alku + "' AND '" + loppu + "') OR (varattu_loppupvm BETWEEN '" + alku + "' AND '" + loppu + "')) AND (vahvistus_pvm IS NOT NULL)";
                }
                else
                {
                    hakusana = @"SELECT * FROM varaus WHERE (varattu_alkupvm BETWEEN '" + alku + "' AND '" + loppu + "') OR (varattu_loppupvm BETWEEN '" + alku + "' AND '" + loppu + "')";
                }
            }
            else
            {
                if (chbvarausvahvistetut.CheckState == CheckState.Checked)
                {
                    hakusana = @"SELECT * FROM varaus WHERE (varattu_pvm BETWEEN '" + alku + "' AND '" + loppu + "') AND (vahvistus_pvm IS NOT NULL)";
                }
                else
                {
                    hakusana = @"SELECT * FROM varaus WHERE (varattu_pvm BETWEEN '" + alku + "' AND '" + loppu + "')";
                }
            }
                try
                {
                    connection.ConnectionString = conString;
                    DataTable table = new DataTable();
                    OdbcDataAdapter adapter = new OdbcDataAdapter(hakusana, connection);
                    adapter.Fill(table);
                    dtgVarausTaulu.DataSource = table;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 
        }

        private void btnvVarausNaytaKaikki_Click(object sender, EventArgs e)//Näyttää kaikki varaukset
        {
            paivitaDGV();
        }

        private void chbvarausvahvista_CheckStateChanged(object sender, EventArgs e)//Poistaa datetimepickerin käytöstä jos varaus on vahvistamaton
        {
            if(chbvarausvahvista.CheckState == CheckState.Checked)
            {
                dtpvahvistus.Enabled = false;
            }
            else
            {
                dtpvahvistus.Enabled = true;
            }
        }
    }
}
