using MySql.Data.MySqlClient;
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

namespace CarsManagment
{
    public partial class Cars : Form
    {
        MySqlConnection dbconnection;
        DataGridViewRow row1 = null;
        Car_Record carRecord = null;
        Car_Update carUpdate = null;
        CarDrivers carDrivers = null;
        public Cars()
        {
            InitializeComponent();
            dbconnection = new MySqlConnection(connection.connectionString);
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            try
            {
                dbconnection.Open();
                DisplayCars();
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
                if (carRecord == null)
                {
                    carRecord = new Car_Record();
                    carRecord.Show();
                    carRecord.Focus();
                }
                else
                {
                    carRecord.Show();
                    carRecord.Focus();
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
                if (carUpdate == null)
                {
                    if (row1 != null)
                    {
                        carUpdate = new Car_Update(row1);
                        carUpdate.Show();
                        carUpdate.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Select row");
                    }
                }
                else
                {
                    carUpdate.Show();
                    carUpdate.Focus();
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
                    string query = "delete from cars where Car_Number=" + row1.Cells[0].Value;
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

        private void CarDraivers_Click(object sender, EventArgs e)
        {
            try
            {
                if (carUpdate == null)
                {
                    if (row1 != null)
                    {
                        carDrivers = new CarDrivers(row1);
                        carDrivers.Show();
                        carDrivers.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Select row");
                    }
                }
                else
                {
                    carDrivers.Show();
                    carDrivers.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //functions
        public void DisplayCars()
        {
            dataGridView1.Rows.Clear();
            string qeury = "select Car_Number,Car_Capacity,meter_reading,Openning_Account,Car_Value,DepreciationPeriod,PremiumDepreciation,cars.Car_ID from cars ";
            MySqlCommand com = new MySqlCommand(qeury, dbconnection);
            MySqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["Car_Number"].Value = dr[0].ToString();
                dataGridView1.Rows[n].Cells["Car_Capacity"].Value = dr[1].ToString();
                dataGridView1.Rows[n].Cells["meter_reading"].Value = dr[2].ToString();
                dataGridView1.Rows[n].Cells["Openning_Account"].Value = dr[3].ToString();
                dataGridView1.Rows[n].Cells["Car_Value"].Value = dr[4].ToString();
                dataGridView1.Rows[n].Cells["DepreciationPeriod"].Value = dr[5].ToString();
                dataGridView1.Rows[n].Cells["PremiumDepreciation"].Value = dr[6].ToString();
                dataGridView1.Rows[n].Cells["car_id"].Value = dr[7].ToString();
            }
            dr.Close();
        }

       
    }
}
