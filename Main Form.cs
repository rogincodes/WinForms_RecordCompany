using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsFinal
{
    public partial class mainForm : Form
    {
        private const string consString = "Server=localhost;Database=record_company;User ID=root;Password=WellPlayed101";

        public mainForm()
        {
            InitializeComponent();         
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            LoadRecordsDataGridView();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            LoadRecordsDataGridView();
        }

        private void btnBands_Click(object sender, EventArgs e)
        {
            bandsForm bands = new bandsForm();
            bands.Show();
        }

        private void btnAlbums_Click(object sender, EventArgs e)
        {
            albumsForm albums = new albumsForm();
            albums.Show();
        }

        public void LoadRecordsDataGridView()
        {
            dataGridRecords.Rows.Clear();
            dataGridRecords.Refresh();

            //for the custom sizes of individual columns 
            //DataGridViewColumn column = dataGridRecords.Columns[0];
            //column.Width = 60; 

            //for all the columns autoresize
            dataGridRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            string query = "select b.id as 'Band ID', b.name as 'Band Name', a.id as 'Album ID', a.name as 'Album Name', a.release_year as 'Release Year' from bands as b left join albums as a on b.id = a.band_id;";
            MySqlConnection con = new MySqlConnection(consString);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader myReader;

            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();


                while (myReader.Read())
                {
                    int bID = myReader.GetInt32("Band ID");
                    string bName = myReader.GetString("Band Name");
                    string aID = myReader.IsDBNull(2) ? string.Empty : myReader.GetString(2);
                    string aName = myReader.IsDBNull(3) ? string.Empty : myReader.GetString(3);
                    string releaseYear = myReader.IsDBNull(4) ? string.Empty : myReader.GetString(4);

                    dataGridRecords.Rows.Add(bID, bName, aID, aName, releaseYear);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Connection: " + ex, "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }
    }
}
