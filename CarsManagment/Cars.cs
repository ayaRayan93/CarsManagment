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
        public Car_Record carRecord = null;
        public Car_Update carUpdate = null;

        public CarDrivers carDrivers = null;
        public Car_Papers carPaper = null;
        public CarLicenseRecord carLicenseRecord = null;
        public CarLicenseUpdate carLicenseUpdate = null;
        public CarSpareParts carSpareParts = null;

        public Cars()
        {
            try
            {
                InitializeComponent();
                dbconnection = new MySqlConnection(connection.connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            try
            {
                dbconnection.Open();
                DisplayCars(dbconnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            dbconnection.Close();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dbconnection.Open();
                dataGridView1.Rows.Clear();
                string qeury = "select Car_Number,Car_Capacity,meter_reading,Openning_Account,Car_Value,DepreciationPeriod,PremiumDepreciation,cars.Car_ID from cars where Car_Number like'" + txtSearch.Text + "%'";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dbconnection.Close();
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

        //main buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (carRecord == null)
                {
                    carRecord = new Car_Record(this);
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
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (carUpdate == null)
                {
                    if (row1 != null)
                    {
                        carUpdate = new Car_Update(row1,this);
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
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the item?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dbconnection.Open();
                        string query = "delete from cars where Car_Number=" + row1.Cells[0].Value;
                        MySqlCommand com = new MySqlCommand(query, dbconnection);
                        com.ExecuteNonQuery();
                        DisplayCars(dbconnection);
                    }
                    else if (dialogResult == DialogResult.No)
                    { }
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

        //second buttons 
        private void CarDraivers_Click(object sender, EventArgs e)
        {
            try
            {
                if (carUpdate == null)
                {
                    if (row1 != null)
                    {
                        carDrivers = new CarDrivers(row1,this);
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
        private void btnCarPaper_Click(object sender, EventArgs e)
        {
            try
            {
                if (carPaper == null)
                {
                    if (row1 != null)
                    {
                        carPaper = new Car_Papers(row1,this);
                        carPaper.Show();
                        carPaper.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Select row");
                    }
                }
                else
                {
                    carPaper.Show();
                    carPaper.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCarLicense_Click(object sender, EventArgs e)
        {
            try
            {
                if (row1 != null)
                {
                    dbconnection.Open();
                    String query = "select Car_License_ID from car_license where Car_ID=" + row1.Cells["car_id"].Value;
                    MySqlCommand com = new MySqlCommand(query, dbconnection);
                    if (com.ExecuteScalar() == null)
                    {
                        if (carLicenseRecord == null)
                        {
                            carLicenseRecord = new CarLicenseRecord(row1, this);
                            carLicenseRecord.Show();
                            carLicenseRecord.Focus();
                        }
                        else
                        {
                            carLicenseRecord.Show();
                            carLicenseRecord.Focus();
                        }
                    }
                    else
                    {
                        if (carLicenseUpdate == null)
                        {
                            carLicenseUpdate = new CarLicenseUpdate(row1, this);
                            carLicenseUpdate.Show();
                            carLicenseUpdate.Focus();
                        }
                        else
                        {
                            carLicenseUpdate.Show();
                            carLicenseUpdate.Focus();
                        }
                    }
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
        private void btnCarSparePart_Click(object sender, EventArgs e)
        {
            try
            {
                if (carSpareParts == null)
                {
                    if (row1 != null)
                    {
                        carSpareParts = new CarSpareParts(row1,this);
                        carSpareParts.Show();
                        carSpareParts.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Select row");
                    }
                }
                else
                {
                    carSpareParts.Show();
                    carSpareParts.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        //functions
        public void DisplayCars(MySqlConnection dbconnection)
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
