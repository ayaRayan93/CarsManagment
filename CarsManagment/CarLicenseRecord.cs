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
    public partial class CarLicenseRecord : Form
    {
        MySqlConnection dbconnection;
        DataGridViewRow CarRow = null;
        int CarId;
        public CarLicenseRecord(DataGridViewRow CarRow)
        {
            InitializeComponent();
            dbconnection = new MySqlConnection(connection.connectionString);
            this.CarRow = CarRow;
            txtCarNumber.Text = CarRow.Cells[0].Value.ToString();
            CarId = Convert.ToInt16(CarRow.Cells["car_id"].Value.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                dbconnection.Open();
                string query = "select Car_License_ID from car_license where Car_ID=" + CarId + "";
                MySqlCommand com = new MySqlCommand(query, dbconnection);


                if (com.ExecuteScalar() == null)
                {
                    if (txtCarNumber.Text != "")
                    {
                        string qeury = "insert into car_license (Car_ID,Car_License_Number,Car_Shaza_Number,Car_Model,Car_Company,Start_License_Date,End_License_Date)values(@Car_ID,@Car_License_Number,@Car_Shaza_Number,@Car_Model,@Car_Company,@Start_License_Date,@End_License_Date)";
                        com = new MySqlCommand(qeury, dbconnection);
                        com.Parameters.Add("@Car_ID", MySqlDbType.Int16);
                        com.Parameters["@Car_ID"].Value = txtCarNumber.Text;
                        com.Parameters.Add("@Car_License_Number", MySqlDbType.VarChar,255);
                        com.Parameters["@Car_License_Number"].Value = txtLicenseNumber.Text;
                        com.Parameters.Add("@Car_Shaza_Number", MySqlDbType.VarChar,255);
                        com.Parameters["@Car_Shaza_Number"].Value =txtShaza.Text;
                        com.Parameters.Add("@Car_Model", MySqlDbType.VarChar,255);
                        com.Parameters["@Car_Model"].Value = txtModel.Text;
                        com.Parameters.Add("@Car_Company", MySqlDbType.VarChar);
                        com.Parameters["@Car_Company"].Value = txtCarCampany.Text;
                        com.Parameters.Add("@Start_License_Date", MySqlDbType.Date);
                        com.Parameters["@Start_License_Date"].Value = dateTimePicker1.Value.Date;
                        com.Parameters.Add("@End_License_Date", MySqlDbType.Date);
                        com.Parameters["@End_License_Date"].Value = dateTimePicker2.Value.Date;

                        com.ExecuteNonQuery();
                        
                        MessageBox.Show("add success");
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("enter Car Number");
                    }
                }
                else
                {
                    MessageBox.Show("This Car already exist");
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
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //function

        private void clear()
        {
            foreach (Control item in this.Controls["panContent"].Controls)
            {
                if (item is TextBox)
                    item.Text = "";
                else if (item is DateTimePicker)
                    item.Refresh();
            }
        }

       
    }
}
