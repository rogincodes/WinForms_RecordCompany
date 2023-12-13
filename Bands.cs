using MySql.Data.MySqlClient;
using System;
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
    public partial class bandsForm : Form
    {
        private const string consString = "Server=localhost;Database=record_company;User ID=root;Password=WellPlayed101";

        public bandsForm()
        {
            InitializeComponent();
        }

        private void Bands_Load(object sender, EventArgs e)
        {
            LoadBandsDataGridView();
        }

        private void btnAddBand_Click(object sender, EventArgs e)
        {
            AddBandsData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateBand();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteBandData();
        }

        public void LoadBandsDataGridView()
        {
            dataGridBands.Rows.Clear();
            dataGridBands.Refresh();

            DataGridViewColumn column0 = dataGridBands.Columns[0];
            DataGridViewColumn column1 = dataGridBands.Columns[1];
            column0.Width = 60;
            column1.Width = 200;

            string query = "select * from bands";
            MySqlConnection con = new MySqlConnection(consString);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader myReader;

            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    int bandID = myReader.GetInt32(0);
                    string bandName = myReader.GetString(1);

                    dataGridBands.Rows.Add(bandID, bandName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Connection: " + ex, "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            con.Close();
            lblBandID.Text = string.Empty;
        }

        public void AddBandsData()
        {
            if (String.IsNullOrEmpty(txtBandName.Text))
            {
                MessageBox.Show("Value is required!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string query = $"insert into bands (name) values ('{txtBandName.Text}');";
                    MySqlConnection con = new MySqlConnection(consString);
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader myReader;

                    con.Open();
                    myReader = cmd.ExecuteReader();
                    con.Close();

                    txtBandName.Clear();

                    MessageBox.Show("Band successfully added!", "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBandsDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Connection: " + ex, "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
        
        private void dataGridBands_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridBands.SelectedRows)
            {
                string idValue = row.Cells[0].Value.ToString();
                string nameValue = row.Cells[1].Value.ToString();

                lblBandID.Text = idValue;
                txtBandName.Text = nameValue;
            }
        }

        private void UpdateBand()
        {
            if (String.IsNullOrEmpty(lblBandID.Text))
            {
                MessageBox.Show("Please select first the data you want to update.", "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (String.IsNullOrEmpty(txtBandName.Text))
                {
                    MessageBox.Show("Value is required!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        string query = $"update bands set name = '{txtBandName.Text}' where id = {lblBandID.Text};";
                        MySqlConnection con = new MySqlConnection(consString);
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        MySqlDataReader myReader;

                        con.Open();
                        myReader = cmd.ExecuteReader();
                        con.Close();

                        txtBandName.Clear();

                        MessageBox.Show("Data successfully updated!", "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadBandsDataGridView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connection: " + ex, "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }   
        }

        private void DeleteBandData()
        {
            if (String.IsNullOrEmpty(lblBandID.Text))
            {
                MessageBox.Show("Please select first the data you want to delete.", "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this band?", "Message Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        string query = $"delete from bands where id = {lblBandID.Text};";
                        MySqlConnection con = new MySqlConnection(consString);
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        MySqlDataReader myReader;

                        con.Open();
                        myReader = cmd.ExecuteReader();
                        con.Close();

                        txtBandName.Clear();
                        lblBandID.Text = string.Empty;

                        MessageBox.Show("Deleted successfully!", "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadBandsDataGridView();
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
