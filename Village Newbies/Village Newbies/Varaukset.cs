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
    public partial class Varaukset : Form
    {
        public Varaukset()
        {
            InitializeComponent();
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
            this.varausTableAdapter.Fill(this.villageNewbiesDataSet.varaus);

            CustomTimeFormat();

        }

        OdbcConnection connection = new OdbcConnection("DSN=Village Newbies;MultipleActiveResultSets=True");


        
    



    private void btnUusi_Click(object sender, EventArgs e)
        {
            Validate();
            varausBindingSource.EndEdit();
            varausTableAdapter.Update(villageNewbiesDataSet);
            varausTableAdapter.Insert(int.Parse(txtasiakasid.Text), int.Parse(txtmokkiid.Text),dtpvarattu.Value, dtpvahvistus.Value, dtpalku.Value,dtploppu.Value);
            varausTableAdapter.Fill(this.villageNewbiesDataSet.varaus);
            //varausTableAdapter.Update(villageNewbiesDataSet);
        }

        private void btnVarausAsiakasLisays_Click(object sender, EventArgs e)
        {
            txtasiakasid.Text = tbAsiakasIdVarausValinta.Text;
            tabVarausNakyma.SelectedTab = tabPageVaraus;
        }

        private void btnasiakas_Click(object sender, EventArgs e)
        {
            tabVarausNakyma.SelectedTab = tabPageAsiakas;
        }

        private void btnmokki_Click(object sender, EventArgs e)
        {
            tabVarausNakyma.SelectedTab = tabPageMokki;
        }

        private void btnLisaaVarauksenMokki_Click(object sender, EventArgs e)
        {
            txtmokkiid.Text=tbVarausMokki.Text;
            tabVarausNakyma.SelectedTab = tabPageVaraus;
        }

        private void VarausPalveluTauluPaivitys()
        {
            try//Näyttää varaukseen liittyvät palvelut taulukossa
            {
                //string strCon = "DSN=Village Newbies;MultipleActiveResultSets=True";
                string strSql = "SELECT v.varaus_id, v.palvelu_id, v.lkm, p.nimi FROM varauksen_palvelut v JOIN palvelu p ON p.palvelu_id = v.palvelu_id WHERE varaus_id =";

                using (connection)
                using (OdbcDataAdapter dadapter = new OdbcDataAdapter(strSql + int.Parse(txtvarausid.Text), connection))
                {
                    DataTable table = new DataTable();
                    dadapter.Fill(table);

                    dtgVarauksenPalvelut.DataSource = table;
                }

            }
            catch
            {

            }
        }


        private void cmbVarausPalveluValinta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            VarausPalveluTauluPaivitys();
            /*try//Näyttää varaukseen liittyvät palvelut taulukossa
            {
                string strCon = "DSN=Village Newbies;MultipleActiveResultSets=True";
                string strSql = "SELECT v.varaus_id, v.palvelu_id, v.lkm, p.nimi FROM varauksen_palvelut v JOIN palvelu p ON p.palvelu_id = v.palvelu_id WHERE varaus_id =";

                using (OdbcConnection con = new OdbcConnection(strCon))
                using (OdbcDataAdapter dadapter = new OdbcDataAdapter(strSql+int.Parse(txtvarausid.Text), con))
                {
                    DataTable table = new DataTable();
                    dadapter.Fill(table);

                    dtgVarauksenPalvelut.DataSource = table;
                }

            }
            catch
            {

            }*/
        }

        

        private void cmbVarausToimialue_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string varaustoimialue = cmbVarausToimialue.SelectedValue.ToString();
            string strCon = "DSN=Village Newbies;MultipleActiveResultSets=True";

            try//tämä osio hakee toimialueen mökit taulukkoon
            {
                //string varaustoimialue = cmbVarausToimialue.SelectedValue.ToString();
                //string strCon = "DSN=Village Newbies;MultipleActiveResultSets=True";
                string strSql = "SELECT * FROM mokki WHERE toimintaalue_id = "+varaustoimialue;

                using (OdbcConnection con = new OdbcConnection(strCon))
                using (OdbcDataAdapter dadapter = new OdbcDataAdapter(strSql, con))
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

                using (OdbcConnection con = new OdbcConnection(strCon))
                using (OdbcDataAdapter dadapter = new OdbcDataAdapter(strSqlb, con))
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
            string varausid = txtvarausid.Text;
            string palveluid = cmbVarausPalveluValinta.SelectedValue.ToString();
            string palvelulkm = tbVarausPalveluLkm.Text;
            try
            {
                string strCon = "DSN=Village Newbies;MultipleActiveResultSets=True";
                using (OdbcConnection con = new OdbcConnection(strCon))
                {
                    
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection= con;
                    cmd.CommandText = "INSERT INTO varauksen_palvelut VALUES (" + int.Parse(txtvarausid.Text) + ", " + cmbVarausPalveluValinta.SelectedValue + ", " + int.Parse(tbVarausPalveluLkm.Text) + ")";
                    cmd.CommandType = CommandType.Text;


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Palvelu lisätty", "Ilmoitus");
                    con.Close();

                }
            }
            catch
            {

            }
            
            

        }

        private void CustomTimeFormat()
        {
            dtpvarattu.Format = DateTimePickerFormat.Custom;
            dtpvarattu.CustomFormat = "ddd dd/MM/yyyy  HH:mm";
            dtpvahvistus.Format = DateTimePickerFormat.Custom;
            dtpvahvistus.CustomFormat = "ddd dd/MM/yyyy  HH:mm";
            dtpalku.Format = DateTimePickerFormat.Custom;
            dtpalku.CustomFormat = "ddd dd/MM/yyyy  HH:mm";
            dtploppu.Format = DateTimePickerFormat.Custom;
            dtploppu.CustomFormat = "ddd dd/MM/yyyy  HH:mm";
        }

        

        private void dtgVarausTaulu_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgVarausTaulu.CurrentRow.Index;
            if (dtgVarausTaulu.ColumnCount>0)//Jos datagridistä valitaan varaus sen id menee tekstikenttään
            {
                txtvarausid.Text = dtgVarausTaulu.Rows[index].Cells[0].Value.ToString();
                txtasiakasid.Text = dtgVarausTaulu.Rows[index].Cells[1].Value.ToString();
                txtmokkiid.Text = dtgVarausTaulu.Rows[index].Cells[2].Value.ToString();
                dtpvarattu.Value = Convert.ToDateTime(dtgVarausTaulu.Rows[index].Cells[3].Value);
                dtpvahvistus.Value = Convert.ToDateTime(dtgVarausTaulu.Rows[index].Cells[4].Value);
                dtpalku.Value = Convert.ToDateTime(dtgVarausTaulu.Rows[index].Cells[5].Value);
                dtploppu.Value = Convert.ToDateTime(dtgVarausTaulu.Rows[index].Cells[6].Value);

                //VarausPalveluTauluPaivitys();
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

        private void btnMuuta_Click(object sender, EventArgs e)
        {
            Validate();
            varausBindingSource.EndEdit();
            varausTableAdapter.Update(villageNewbiesDataSet);
            varausTableAdapter.Insert(int.Parse(txtasiakasid.Text), int.Parse(txtmokkiid.Text), dtpvarattu.Value, dtpvahvistus.Value, dtpalku.Value, dtploppu.Value);
        }
    }
}
