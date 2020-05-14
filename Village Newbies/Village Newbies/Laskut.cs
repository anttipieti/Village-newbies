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
    public partial class Laskut : Form
    {
        MainMenu mainform;
        public Laskut(MainMenu f1)
        {
            InitializeComponent();
            mainform = f1;
        }

        private void Laskut_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainform.Show();
            //Avataan päävalikko uudelleen
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

        private void Laskut_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'villageNewbiesDataSet.lasku' table. You can move, or remove it, as needed.
            this.laskuTableAdapter.Fill(this.villageNewbiesDataSet.lasku);

        }

        /*public void populateDGV()
        {
            //Tuo kaikki laskut datagridiin
            string selectQuery = "SELECT * FROM varaus";
            DataTable table = new DataTable();
            connection.ConnectionString = conString;
            OdbcDataAdapter adapter = new OdbcDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridViewLisää.DataSource = table;
            dataGridPoista.DataSource = table;
            dataGridViewMuokkaa.DataSource = table;
            dataGridViewHae.DataSource = table;
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

        public LaskuForm()
        {
            InitializeComponent();
        }

        private void TPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetLasku.lasku' table. You can move, or remove it, as needed.
            this.laskuTableAdapter.Fill(this.dataSetLasku.lasku);

        }

        private void BtnLisää_Click(object sender, EventArgs e)
        {
            Validate();
            laskuBindingSource.EndEdit();
            laskuTableAdapter.Update(dataSetLasku);
            laskuTableAdapter.Insert(int.Parse(TextBoxLaskuIDLisää.Text), int.Parse(TextBoxVarausIDLisää.Text), double.Parse(TextBoxSummaLisää.Text), double.Parse(TextBoxALVLisää.Text));
            laskuTableAdapter.Fill(this.dataSetLasku.lasku);
        }

        private void dataGridViewLisää_Click(object sender, EventArgs e)
        {
            TextBoxLaskuIDLisää.Text = dataGridViewLisää.CurrentRow.Cells[0].Value.ToString();
            TextBoxVarausIDLisää.Text = dataGridViewLisää.CurrentRow.Cells[1].Value.ToString();
            TextBoxSummaLisää.Text = dataGridViewLisää.CurrentRow.Cells[2].Value.ToString();
            TextBoxALVLisää.Text = dataGridViewLisää.CurrentRow.Cells[3].Value.ToString();
        }

        private void BtnPoista_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM lasku WHERE lasku_id = " + int.Parse(TextBoxPoista.Text);
            executeMyQuery(deleteQuery);
            populateDGV(); 
        }

        private void BtnMuokkaa_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE lasku SET lasku_id='" + TextBoxLaskuIDMuokkaa.Text + "',varaus_id='" + TextBoxVarausIDMuokkaa.Text + "',summa='" + TextBoxSummaMuokkaa.Text + "',alv=" 
                + TextBoxALVMuokkaa.Text + " WHERE lasku_id =" + int.Parse(TextBoxLaskuIDMuokkaa.Text);
            executeMyQuery(updateQuery);
            populateDGV();
        }

        private void BtnHae_Click(object sender, EventArgs e)
        {
            OdbcDataReader mdr;
            string select = "SELECT * FROM lasku WHERE lasku_id = " + TextBoxLaskuIDHae.Text;
            command = new OdbcCommand(select, connection);
            openConnection();
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                TextBoxVarausIDHae.Text = mdr.GetString(mdr.GetOrdinal("varaus_id"));
                TextBoxSummaHae.Text = mdr.GetString(mdr.GetOrdinal("summa"));
                TextBoxALVHae.Text = mdr.GetString(mdr.GetOrdinal("alv"));
            }
            else
            {
                MessageBox.Show("Laskua ei löytynyt.");
            }

            closeConnection();
        }*/

    }
}
