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
    public partial class Driver_Update : Form
    {
        MySqlConnection dbconnection;
        DataGridViewRow row1 = null;
        public Driver_Update(DataGridViewRow row1)
        {
            try
            {

                InitializeComponent();
                dbconnection = new MySqlConnection(connection.connectionString);
                SetData(row1);
                this.row1 = row1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                dbconnection.Open();
                string qeury = "update drivers Driver_Name=@Driver_Name,Driver_Phone=@Driver_Phone,Driver_Address=@Driver_Address ,Driver_BairthDate=@Driver_BairthDate,Driver_License=@Driver_License,Driver_NationalID=@Driver_NationalID,Driver_StartWorkDate=@Driver_StartWorkDate where Driver_ID="+row1.Cells[0].Value;
                MySqlCommand com = new MySqlCommand(qeury, dbconnection);
                com.Parameters.Add("@Driver_Name", MySqlDbType.VarChar, 255);
                com.Parameters["@Driver_Name"].Value = txtDriverName.Text;
                com.Parameters.Add("@Driver_Phone", MySqlDbType.VarChar, 255);
                com.Parameters["@Driver_Phone"].Value = txtPhone.Text;
                com.Parameters.Add("@Driver_Address", MySqlDbType.VarChar);
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
                MessageBox.Show("update success");
              
            
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
        public void clear()
        {
            txtDriverName.Text=txtPhone.Text=txtAddress.Text="";
        }
        public void SetData(DataGridViewRow row)
        {
            txtDriverName.Text = row.Cells[1].Value.ToString();
            txtPhone.Text = row.Cells[2].Value.ToString();
            txtAddress.Text = row.Cells[3].Value.ToString();

            dTPBirthDate.Text = row.Cells[4].Value.ToString();
            txtLicese.Text = row.Cells[5].Value.ToString();
            txtNationalID.Text = row.Cells[6].Value.ToString();
            dTPWorkStartDate.Text = row.Cells[7].Value.ToString();
        }
       
    }
   
}
