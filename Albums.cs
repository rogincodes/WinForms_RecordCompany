using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsFinal
{
    public partial class albumsForm : Form
    {
        private const string consString = "Server=localhost;Database=record_company;User ID=root;Password=WellPlayed101";
        public static int[] IDs;

        public albumsForm()
        {
            InitializeComponent();
        }

        private void albumsForm_Load(object sender, EventArgs e)
        {
            LoadAlbumsDataGridView();
            lblAlbumID.Text = string.Empty;
            GetBandsID();
        }

        private void btnAddAlbum_Click(object sender, EventArgs e)
        {
            AddAlbumsData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAlbumsData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteAlbumsData();
        }

        public void LoadAlbumsDataGridView()
        {
            dataGridAlbums.Rows.Clear();
            dataGridAlbums.Refresh();

            dataGridAlbums.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            string query = "select * from albums";
            MySqlConnection con = new MySqlConnection(consString);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader myReader;

            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    int albumID = myReader.GetInt32(0);
                    string albumName = myReader.GetString(1);
                    string releaseYear = myReader.IsDBNull(2) ? string.Empty : myReader.GetString(2);
                    int bandID = myReader.GetInt32(3);

                    dataGridAlbums.Rows.Add(albumID, albumName, releaseYear, bandID);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Connection: " + ex, "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            con.Close();
            lblAlbumID.Text = string.Empty;

        }        

        public void GetBandsID()
        {
            string query = "select id from bands";
            MySqlConnection con = new MySqlConnection(consString);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader myReader;

            // Create a list to store the results
            List<int> bandIDsValues = new List<int>();

            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    int bandID = myReader.GetInt32(0);

                    bandIDsValues.Add(bandID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Connection: " + ex, "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            // Convert the list to an array if needed
            int[] bandIDsArray = bandIDsValues.ToArray();
            IDs = bandIDsArray;

            con.Close();
        }

        public void AddAlbumsData()
        {
            if (String.IsNullOrEmpty(txtAlbumName.Text) || String.IsNullOrEmpty(txtBandID.Text))
            {
                MessageBox.Show("Value is required in Album Name, and Band ID!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (int.TryParse(txtReleaseYear.Text, out int intValue1) && int.TryParse(txtBandID.Text, out int intValue2))
                {
                    int bandIDValue = Convert.ToInt32(txtBandID.Text);
                    if (!IDs.Any(item => item == bandIDValue))
                    {
                        MessageBox.Show("Band ID doesn't exist!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        try
                        {
                            string query = "insert into albums (name, release_year, band_id) VALUES (@Value1, @Value2, @Value3);";
                            MySqlConnection con = new MySqlConnection(consString);
                            MySqlCommand cmd = new MySqlCommand(query, con);
                            MySqlDataReader myReader;

                            con.Open();

                            cmd.Parameters.AddWithValue("@Value1", (object)txtAlbumName.Text);
                            cmd.Parameters.AddWithValue("@Value2", string.IsNullOrEmpty(txtReleaseYear.Text) ? DBNull.Value : (object)txtReleaseYear.Text);
                            cmd.Parameters.AddWithValue("@Value3", (object)txtBandID.Text);

                            myReader = cmd.ExecuteReader();

                            con.Close();

                            txtAlbumName.Clear();
                            txtReleaseYear.Clear();
                            txtBandID.Clear();

                            MessageBox.Show("Album successfully added!", "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAlbumsDataGridView();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error Connection: " + ex, "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Release Year and Band ID needs to be a valid integers!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridAlbums_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridAlbums.SelectedRows)
            {
                string idValue = row.Cells[0].Value.ToString();
                string nameValue = row.Cells[1].Value.ToString();
                string releaseYearValue = row.Cells[2].Value.ToString();
                string bandIDValue = row.Cells[3].Value.ToString();

                lblAlbumID.Text = idValue;
                txtAlbumName.Text = nameValue;
                txtReleaseYear.Text = releaseYearValue;
                txtBandID.Text = bandIDValue;
            }
        } 

        private void UpdateAlbumsData()
        {
            if (dataGridAlbums.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select first the data you want to update.", "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (String.IsNullOrEmpty(txtAlbumName.Text) || String.IsNullOrEmpty(txtBandID.Text))
                {
                    MessageBox.Show("Value is required in Album Name, and Band ID!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (int.TryParse(txtReleaseYear.Text, out int intValue1) && int.TryParse(txtBandID.Text, out int intValue2))
                    {
                        int bandIDValue = Convert.ToInt32(txtBandID.Text);
                        if (!IDs.Any(item => item == bandIDValue))
                        {
                            MessageBox.Show("Band ID doesn't exist!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            try
                            {
                                string query = $"update albums set name = '{txtAlbumName.Text}', release_year = @ryValue, band_id = '{txtBandID.Text}' where id = {lblAlbumID.Text};";
                                MySqlConnection con = new MySqlConnection(consString);
                                MySqlCommand cmd = new MySqlCommand(query, con);
                                MySqlDataReader myReader;

                                con.Open();

                                cmd.Parameters.AddWithValue("@ryValue", string.IsNullOrEmpty(txtReleaseYear.Text) ? DBNull.Value : (object)txtReleaseYear.Text);

                                myReader = cmd.ExecuteReader();
                                con.Close();

                                txtAlbumName.Clear();
                                txtReleaseYear.Clear();
                                txtBandID.Clear();
                                lblAlbumID.Text = string.Empty;

                                MessageBox.Show("Data successfully updated!", "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadAlbumsDataGridView();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error Connection: " + ex, "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Release Year and Band ID needs to be a valid integers!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }                  
            }

      
        }

        private void DeleteAlbumsData()
        {
            if (String.IsNullOrEmpty(lblAlbumID.Text))
            {
                MessageBox.Show("Please select first the data you want to delete.", "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this album?", "Message Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        string query = $"delete from albums where id = {lblAlbumID.Text};";
                        MySqlConnection con = new MySqlConnection(consString);
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        MySqlDataReader myReader;

                        con.Open();
                        myReader = cmd.ExecuteReader();
                        con.Close();

                        txtAlbumName.Clear();
                        txtReleaseYear.Clear();
                        txtBandID.Clear();
                        lblAlbumID.Text = string.Empty;

                        MessageBox.Show("Deleted successfully!", "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAlbumsDataGridView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connection: " + ex, "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    //do nothing
                }
            }
        }
    }
}
