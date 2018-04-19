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
    public partial class CarLicenseUpdate : Form
    {
        MySqlConnection dbconnection;
        DataGridViewRow CarRow = null;
        int CarId;
        Cars cars=null;
        public CarLicenseUpdate(DataGridViewRow CarRow,Cars cars)
        {
            try
            {
               
                InitializeComponent();
                dbconnection = new MySqlConnection(connection.connectionString);
                dbconnection.Open();
                this.CarRow = CarRow;
                txtCarNumber.Text = CarRow.Cells[0].Value.ToString();
                CarId = Convert.ToInt16(CarRow.Cells["car_id"].Value.ToString());
                SetData(CarRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dbconnection.Close();
        }
        public CarLicenseUpdate(String carNum)
        {
            try
            {

                InitializeComponent();
                dbconnection = new MySqlConnection(connection.connectionString);
                dbconnection.Open();
                txtCarNumber.Text = carNum;
                SetData(carNum);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dbconnection.Close();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                dbconnection.Open();
               
                    if (txtCarNumber.Text != "")
                    {
                        string qeury = "update car_license set Car_License_Number=@Car_License_Number,Car_Shaza_Number=@Car_Shaza_Number,Car_Model=@Car_Model,Car_Company=@Car_Company,Start_License_Date=@Start_License_Date,End_License_Date=@End_License_Date where Car_ID="+CarId;
                        MySqlCommand com = new MySqlCommand(qeury, dbconnection);
                        
                        com.Parameters.Add("@Car_License_Number", MySqlDbType.VarChar, 255);
                        com.Parameters["@Car_License_Number"].Value = txtLicenseNumber.Text;
                        com.Parameters.Add("@Car_Shaza_Number", MySqlDbType.VarChar, 255);
                        com.Parameters["@Car_Shaza_Number"].Value = txtShaza.Text;
                        com.Parameters.Add("@Car_Model", MySqlDbType.VarChar, 255);
                        com.Parameters["@Car_Model"].Value = txtModel.Text;
                        com.Parameters.Add("@Car_Company", MySqlDbType.VarChar);
                        com.Parameters["@Car_Company"].Value = txtCarCampany.Text;
                        com.Parameters.Add("@Start_License_Date", MySqlDbType.Date);
                        com.Parameters["@Start_License_Date"].Value = dateTimePicker1.Value.Date;
                        com.Parameters.Add("@End_License_Date", MySqlDbType.Date);
                        com.Parameters["@End_License_Date"].Value = dateTimePicker2.Value.Date;

                        com.ExecuteNonQuery();

                        MessageBox.Show("update success");
                       
                    }
                    else
                    {
                        MessageBox.Show("enter Car Number");
                    }
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dbconnection.Close();
        }
        private void panClose_Click(object sender, EventArgs e)
        {
            try
            {
                if(cars!=null)
                cars.carLicenseUpdate = null;

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                calLicenseAvaliblePeriod();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                calLicenseAvaliblePeriod();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //function
        public void calLicenseAvaliblePeriod()
        {
            TimeSpan d = dateTimePicker2.Value.Date - DateTime.Now.Date;
            labLicenceRestPeriod.Text = d.Days.ToString();
        }
        public void SetData(DataGridViewRow row)
        {
            String query = "select Car_License_Number,Car_Shaza_Number,Car_Model,Car_Company,Start_License_Date,End_License_Date,Car_ID from car_license where Car_ID=" + row.Cells["car_id"].Value;
            MySqlCommand com = new MySqlCommand(query, dbconnection);
            MySqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                txtLicenseNumber.Text = dr["Car_License_Number"].ToString();
                txtShaza.Text = dr["Car_Shaza_Number"].ToString();
                txtModel.Text = dr["Car_Model"].ToString();
                txtCarCampany.Text = dr["Car_Company"].ToString();
                dateTimePicker1.Text = dr["Start_License_Date"].ToString();
                dateTimePicker2.Text = dr["End_License_Date"].ToString();
            }
            dr.Close();
        }
        public void SetData(String carNum)
        {
            String query = "select Car_License_Number,Car_Shaza_Number,Car_Model,Car_Company,Start_License_Date,End_License_Date from car_license inner join cars on cars.Car_ID=car_license.Car_ID where Car_Number=" + carNum;
            MySqlCommand com = new MySqlCommand(query, dbconnection);
            MySqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                txtLicenseNumber.Text = dr["Car_License_Number"].ToString();
                txtShaza.Text = dr["Car_Shaza_Number"].ToString();
                txtModel.Text = dr["Car_Model"].ToString();
                txtCarCampany.Text = dr["Car_Company"].ToString();
                dateTimePicker1.Text = dr["Start_License_Date"].ToString();
                dateTimePicker2.Text = dr["End_License_Date"].ToString();
            }
            dr.Close();
        }

    }
}
