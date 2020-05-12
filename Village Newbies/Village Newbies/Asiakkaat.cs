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
        string conString = "DSN=Village Newbies;MultipleActiveResultSets=True";
        private List<CheckBox> valitutcb;

        public void OpenConnection() //Tietokantayhteys auki
        {
            //Tietokantayhteys auki
            if (connection.State == ConnectionState.Closed)
            {
                connection.ConnectionString = conString;
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

        private void btnAsPoista_Click(object sender, EventArgs e)
        {
            //poistetaan asiakas taulusta ja päivitetään datagrid
            string asiakasPoista =
                "DELETE FROM asiakas WHERE asiakas_id= "+int.Parse(tbAsID.Text);
            ExecuteMyQuery(asiakasPoista);
            this.asiakasTableAdapter.Fill(this.villageNewbiesDataSet.asiakas);
        }

        private void btnAsHae_Click(object sender, EventArgs e)
        {
            //Haetaan halutut tiedot

            if(cbAsPostinro.Checked != true && cbAsEtunimi.Checked != true && cbAsSukunimi.Checked != true && cbAsLOsoite.Checked != true && cbAsEmail.Checked != true && cbAsPuhNro.Checked != true)
            {
                MessageBox.Show("Valitse ainakin yksi hakualue");
            }
            else
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
                        dgAsiakas.DataSource = table;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAsNollaa_Click(object sender, EventArgs e)
        {
            dgAsiakas.DataSource = asiakasBindingSource;
            tbAsHaku.Text = "";
            cbAsPostinro.Checked = false;
            cbAsEtunimi.Checked = false;
            cbAsSukunimi.Checked = false;
            cbAsLOsoite.Checked = false;
            cbAsEmail.Checked = false;
            cbAsPuhNro.Checked = false;
        }

        private string luoHakustring()
        {
            //Mitä haetaan
            //ToDO: ilmoitus jos mitään ei löydy

            bool k = false;
            string valitut = "SELECT * FROM asiakas WHERE ";

            valitutcb = new List<CheckBox>();
            valitutcb.Add(this.cbAsPostinro);
            valitutcb.Add(this.cbAsEtunimi);
            valitutcb.Add(this.cbAsSukunimi);
            valitutcb.Add(this.cbAsLOsoite);
            valitutcb.Add(this.cbAsEmail);
            valitutcb.Add(this.cbAsPuhNro);

            

            for (int i = 0; i < valitutcb.Count; ++i)
            {
                if (valitutcb[i].Checked)
                {
                    
                    switch (i)
                    {
                        case 0:
                            if (k == true)
                            {
                                valitut = valitut + " OR ";
                            }
                            else k = true;
                            valitut = valitut + "postinro like '%" +tbAsHaku.Text+ "%'";
                            break;
                        case 1:
                            if (k == true)
                            {
                                valitut = valitut + " OR ";
                            } else k = true;
                            valitut = valitut + "etunimi like '%" + tbAsHaku.Text + "%'";
                            break;
                        case 2:
                            if (k == true)
                            {
                                valitut = valitut + " OR ";
                            } else k = true;
                            valitut = valitut + "sukunimi like '%" + tbAsHaku.Text + "%'";
                            break;
                        case 3:
                            if (k == true)
                            {
                                valitut = valitut + " OR ";
                            } else k = true;
                            valitut = valitut + "lahiosoite like '%" + tbAsHaku.Text + "%'";
                            break;
                        case 4:
                            if (k == true)
                            {
                                valitut = valitut + " OR ";
                            } else k = true;
                            valitut = valitut + "email like '%" + tbAsHaku.Text + "%'";
                            break;
                        case 5:
                            if (k == true)
                            {
                                valitut = valitut + " OR ";
                            } else k = true;
                            valitut = valitut + "puhelinnro like '%" + tbAsHaku.Text + "%'";
                            break;
                    }
                      
                }
            }

            return valitut;
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
    }
}
