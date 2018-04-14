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

namespace CarsManagment
{
    public partial class SparePart : Form
    {
        MySqlConnection dbconnection;
        DataGridViewRow row = null;
        SparePartRecord sparePartRecord = null;
        SparePartUpdate sparePartUpdate = null;
        public SparePart()
        {
            InitializeComponent();
            dbconnection = new MySqlConnection(connection.connectionString);
        }
        private void Stores_Load(object sender, EventArgs e)
        {
            try
            {
                dbconnection.Open();
                DisplaySparePart();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            dbconnection.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (sparePartRecord == null)
                {
                    sparePartRecord = new SparePartRecord();
                    sparePartRecord.Show();
                    sparePartRecord.Focus();
                }
                else
                {
                    sparePartRecord.Show();
                    sparePartRecord.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (sparePartUpdate == null)
                {
                    if (row != null)
                    {
                        sparePartUpdate = new SparePartUpdate(row);
                        sparePartUpdate.Show();
                        sparePartUpdate.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Select row");
                    }
                }
                else
                {
                    sparePartUpdate.Show();
                    sparePartUpdate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (row != null)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the item?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dbconnection.Open();
                        string Query = "delete from sparepart where SparePart_ID=" + row.Cells[0].Value;
                        MySqlCommand MyCommand = new MySqlCommand(Query, dbconnection);
                        MyCommand.ExecuteNonQuery();
                        // MessageBox.Show("Delete Done");
                        DisplaySparePart();
                    }
                    else if (dialogResult == DialogResult.No)
                    { }
                }
                else
                {
                    MessageBox.Show("Select Row");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            dbconnection.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                row = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
                row.Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

        //functions
        //display stores
        public void DisplaySparePart()
        {
            dataGridView1.Rows.Clear();
            string qeury = "select * from sparepart";
            MySqlCommand com = new MySqlCommand(qeury, dbconnection);
            MySqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["SparePart_ID"].Value = dr[0].ToString();
                dataGridView1.Rows[n].Cells["SparePart_Name"].Value = dr[1].ToString();
                dataGridView1.Rows[n].Cells["SparePart_Info"].Value = dr[2].ToString();
            }
            dr.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dbconnection.Open();
                dataGridView1.Rows.Clear();
                String query = "select * from sparepart where SparePart_Name like'" + txtSearch.Text + "%'";
                MySqlCommand com = new MySqlCommand(query, dbconnection);
                MySqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells["SparePart_ID"].Value = dr[0].ToString();
                    dataGridView1.Rows[n].Cells["SparePart_Name"].Value = dr[1].ToString();
                    dataGridView1.Rows[n].Cells["SparePart_Info"].Value = dr[2].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dbconnection.Close();
        }

        
    }
}
