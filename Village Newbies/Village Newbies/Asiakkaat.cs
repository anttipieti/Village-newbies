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

            //Listat joita käytetään tarkistamaan, että käyttäjä ei vain painele mitä sattuu antamatta tietoja :)
            cblista = new List<CheckBox>();
            cblista.Add(this.cbAsPostinro);
            cblista.Add(this.cbAsEtunimi);
            cblista.Add(this.cbAsSukunimi);
            cblista.Add(this.cbAsLOsoite);
            cblista.Add(this.cbAsEmail);
            cblista.Add(this.cbAsPuhNro);

            tblista = new List<TextBox>();
            tblista.Add(this.tbAsPostinro);
            tblista.Add(this.tbAsEtunimi);
            tblista.Add(this.tbAsSukunimi);
            tblista.Add(this.tbAsLOsoite);
            tblista.Add(this.tbAsEmail);
            tblista.Add(this.tbAsPuhNro);
        }

        OdbcConnection connection = new OdbcConnection(@"DSN=Village Newbies;MultipleActiveResultSets=True");
        OdbcCommand command;
        string conString = "DSN=Village Newbies;MultipleActiveResultSets=True";
        private List<CheckBox> cblista;
        private List<TextBox> tblista;

        public void OpenConnection()//Tietokantayhteys auki
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.ConnectionString = conString;
                connection.Open();
            }
        }

        public void CloseConnection() //Tietokantayhteys kiinni
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void ExecuteMyQuery(string query)//sql-komentojen suoritus
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

        private void btnAsLisaa_Click(object sender, EventArgs e)
        {
            //datan lisäys tauluun, datagrid päivitys
            bool tarkistus = tbTarkistus();

            if (tarkistus == true)
            {
            string asiakasAdd =
                "insert into asiakas(postinro, etunimi, sukunimi, lahiosoite, email, puhelinnro) values('"+ tbAsPostinro.Text+ "','"+tbAsEtunimi.Text+"','"+tbAsSukunimi.Text+ "','"+tbAsLOsoite.Text+ "','"+tbAsEmail.Text+ "','"+tbAsPuhNro.Text+ "')";
            ExecuteMyQuery(asiakasAdd);
            this.asiakasTableAdapter.Fill(this.villageNewbiesDataSet.asiakas);
            } 
            else
            {
                MessageBox.Show("Kaikki kentät ovat pakollisia"); //oikeasti vaan postinumero on pakollinen
            }
            

        }

        private void btnAsMuokkaa_Click(object sender, EventArgs e)
        {
            //päivitetään taulun data ja datagrid
            bool tarkistus = tbTarkistus();

            if (tarkistus == true)
            {
            string asiakasUpdate =
                "UPDATE asiakas SET postinro='" +tbAsPostinro.Text+ "',etunimi='"+tbAsEtunimi.Text+ "',sukunimi='" +tbAsSukunimi.Text+"',lahiosoite='" +tbAsLOsoite.Text+"',email='" +tbAsEmail.Text+"',puhelinnro="+tbAsPuhNro.Text+" WHERE asiakas_id="+int.Parse(tbAsID.Text);
            ExecuteMyQuery(asiakasUpdate);
            this.asiakasTableAdapter.Fill(this.villageNewbiesDataSet.asiakas);
            }
            else
            {
                MessageBox.Show("Kaikki kentät ovat pakollisia"); //oikeasti vaan postinumero on pakollinen
            }


        }

        private void btnAsPoista_Click(object sender, EventArgs e)
        {
            //poistetaan asiakas taulusta ja päivitetään datagrid
            bool tarkistus = tbTarkistus();

            if (tbAsID.Text == "")
            {
                MessageBox.Show("Ei asiakasta valittuna");
            }
            else if (tarkistus == false)
            {
                /*Estetään vahinkopoistot jos teksti on pyyhitty manuaalisesti eikä käyttämällä nappia
                  Asiakasnumeroa ei nimittäin pysty poistamaan muuten kuin napilla + tätä kautta*/

                MessageBox.Show("Osa ruuduista on tyhjiä, valitse asiakas uudelleen");
                tyhjMuokkaa();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Haluatko varmasti poistaa asiakkaan " + tbAsEtunimi.Text + " " + tbAsSukunimi.Text + "?", "Varmistus", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string asiakasPoista =
                        "DELETE FROM asiakas WHERE asiakas_id= " + int.Parse(tbAsID.Text);
                    ExecuteMyQuery(asiakasPoista);
                    this.asiakasTableAdapter.Fill(this.villageNewbiesDataSet.asiakas);
                }
            }
            
        }

        private void btnAsHae_Click(object sender, EventArgs e)
        {
            //Haetaan halutut tiedot
            if (cbAsPostinro.Checked != true && cbAsEtunimi.Checked != true && cbAsSukunimi.Checked != true && cbAsLOsoite.Checked != true && cbAsEmail.Checked != true && cbAsPuhNro.Checked != true)
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
            tyhjHae();
        }
        private void btnAsTyhj_Click(object sender, EventArgs e)
        {
            tyhjMuokkaa();
        }

        private string luoHakustring()
        {
            //Mitä haetaan
            //ToDO: ilmoitus sille, jos mitään ei löydy

            bool k = false;
            string valitut = "SELECT * FROM asiakas WHERE ";

            for (int i = 0; i < cblista.Count; ++i)
            {
                if (cblista[i].Checked)
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


        private bool tbTarkistus()
        {
            //Tarkistetaan, että textboxit eivät ole tyhjiä
            for (int i = 0; i < tblista.Count; ++i)
            {
                if (tblista[i].Text == "")
                {
                    return false;
                }
            }
            return true;
        }

        private void tyhjMuokkaa ()
        {
            //Tyhjennetään Muokkaa-sivu
            tbAsID.Text = "";
            tbAsPostinro.Text = "";
            tbAsEtunimi.Text = "";
            tbAsSukunimi.Text = "";
            tbAsLOsoite.Text = "";
            tbAsEmail.Text = "";
            tbAsPuhNro.Text = "";
        }
        private void tyhjHae()
        {
            //Tyhjennetään Hae-sivu
            dgAsiakas.DataSource = asiakasBindingSource;
            tbAsHaku.Text = "";
            cbAsPostinro.Checked = false;
            cbAsEtunimi.Checked = false;
            cbAsSukunimi.Checked = false;
            cbAsLOsoite.Checked = false;
            cbAsEmail.Checked = false;
            cbAsPuhNro.Checked = false;
        }
        private void Asiakkaat_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainform.Show();
            //Avataan päävalikko uudelleen
        }
    }
}
