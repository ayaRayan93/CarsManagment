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
    public partial class Drivers : Form
    {
        MySqlConnection dbconnection;
        DataGridViewRow row1 = null;
        Driver_Record driverRecord = null;
        Driver_Update driverUpdate = null;
        public Drivers()
        {
            InitializeComponent();
            dbconnection = new MySqlConnection(connection.connectionString);
        }
        private void Drivers_Load(object sender, EventArgs e)
        {
            try
            {
                dbconnection.Open();
                displayDrivers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dbconnection.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (driverRecord == null)
                {
                    driverRecord = new Driver_Record();
                    driverRecord.Show();
                    driverRecord.Focus();
                }
                else
                {
                    driverRecord.Show();
                    driverRecord.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                row1 = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
                row1.Selected = true;
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
                if (driverUpdate == null)
                {
                    if (row1 != null)
                    {
                        driverUpdate = new Driver_Update(row1);
                        driverUpdate.Show();
                        driverUpdate.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Select row");
                    }
                }
                else
                {
                    driverUpdate.Show();
                    driverUpdate.Focus();
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
                if (row1 != null)
                {
                    dbconnection.Open();
                    string query = "delete from drivers where Driver_ID=" + row1.Cells[0].Value;
                    MySqlCommand com = new MySqlCommand(query, dbconnection);
                    com.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Select row");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dbconnection.Close();
        }
        //function
        public void displayDrivers()
        {
            dataGridView1.Rows.Clear();
            string qeury = "select * from drivers";
            MySqlCommand com = new MySqlCommand(qeury, dbconnection);
            MySqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["Driver_ID"].Value = dr[0].ToString();
                dataGridView1.Rows[n].Cells["Driver_Name"].Value = dr[1].ToString();
                dataGridView1.Rows[n].Cells["Driver_Phone"].Value = dr[2].ToString();
                dataGridView1.Rows[n].Cells["Driver_Address"].Value = dr[3].ToString();
                dataGridView1.Rows[n].Cells["Driver_BairthDate"].Value = dr[4].ToString();
                dataGridView1.Rows[n].Cells["Driver_License"].Value = dr[5].ToString();
                dataGridView1.Rows[n].Cells["Driver_NationalID"].Value = dr[6].ToString();
                dataGridView1.Rows[n].Cells["Driver_StartWorkDate"].Value = dr[7].ToString();
            }
            dr.Close();
        }

        
    }
}
