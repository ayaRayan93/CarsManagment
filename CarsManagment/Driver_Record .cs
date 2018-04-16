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
    public partial class Driver_Record : Form
    {
        MySqlConnection dbconnection;
        Drivers drivers;
        public Driver_Record(Drivers drivers)
        {
            try
            {
                InitializeComponent();
                dbconnection = new MySqlConnection(connection.connectionString);
                this.drivers = drivers;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }


        private void btnAddDriver_Click(object sender, EventArgs e)
        {
           
            try
            {
                dbconnection.Open();
                string query = "select Driver_Name from drivers where Driver_Name='" + txtDriverName.Text + "'";
                MySqlCommand com = new MySqlCommand(query, dbconnection);


                if (com.ExecuteScalar() == null)
                {
                    if (txtDriverName.Text != "")
                    {
                        string qeury = "insert into drivers (Driver_Name,Driver_Phone,Driver_Address,Driver_BairthDate,Driver_License,Driver_NationalID,Driver_StartWorkDate)values(@Driver_Name,@Driver_Phone,@Driver_Address,@Driver_BairthDate,@Driver_License,@Driver_NationalID,@Driver_StartWorkDate)";
                        com = new MySqlCommand(qeury, dbconnection);
                        com.Parameters.Add("@Driver_Name", MySqlDbType.VarChar, 255);
                        com.Parameters["@Driver_Name"].Value = txtDriverName.Text;
                        com.Parameters.Add("@Driver_Phone", MySqlDbType.VarChar, 255);
                        com.Parameters["@Driver_Phone"].Value = txtPhone.Text;
                        com.Parameters.Add("@Driver_Address", MySqlDbType.VarChar,255);
                        com.Parameters["@Driver_Address"].Value =txtAddress.Text;


                        com.Parameters.Add("@Driver_BairthDate", MySqlDbType.Date);
                        com.Parameters["@Driver_BairthDate"].Value = dTPBirthDate.Value.Date;
                        com.Parameters.Add("@Driver_License", MySqlDbType.VarChar, 255);
                        com.Parameters["@Driver_License"].Value = txtLicese.Text;
                        com.Parameters.Add("@Driver_NationalID", MySqlDbType.VarChar, 255);
                        com.Parameters["@Driver_NationalID"].Value = txtNationalID.Text;
                        com.Parameters.Add("@Driver_StartWorkDate", MySqlDbType.Date);
                        com.Parameters["@Driver_StartWorkDate"].Value = dTPWorkStartDate.Value.Date;

                        com.ExecuteNonQuery();
                        MessageBox.Show("add success");
                        drivers.displayDrivers(dbconnection);
                        clear();
                    }
                    else
                        {
                        MessageBox.Show("enter Name");
                    }
                }
                else
                {
                    MessageBox.Show("This Store already exist");
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            dbconnection.Close();
        }

        private void txtBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    TextBox t = (TextBox)sender;
                    switch (t.Name)
                    {
                        case "txtDriverName":
                            txtPhone.Focus();
                            break;
                        case "txtPhone":
                            txtAddress.Focus();
                            break;
                        case "txtAddress":
                            txtDriverName.Focus();
                            break;
                      
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panClose_Click(object sender, EventArgs e)
        {
            try
            {
                drivers.driverRecord = null;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //function
        public void clear()
        {
            foreach (Control item in this.Controls["panContent"].Controls)
            {
                if (item is TextBox)
                    item.Text = "";
            }
        }

       
    }
   
}
