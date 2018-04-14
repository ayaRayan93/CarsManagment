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
    public partial class Car_Update : Form
    {
        MySqlConnection dbconnection;
        DataGridViewRow row1=null;
        int driverID = -1;
        public Car_Update(DataGridViewRow row1)
        {
            try
            {
                InitializeComponent();
                dbconnection = new MySqlConnection(connection.connectionString);
                this.row1 = row1;
                SetData(row1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Car_Update_Load(object sender, EventArgs e)
        {
            try
            {
                dbconnection.Open();
                string query = "select Driver_ID,Driver_Name from drivers";
                MySqlDataAdapter da = new MySqlDataAdapter(query, dbconnection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comDriver.DataSource = dt;
                comDriver.DisplayMember = dt.Columns["Driver_Name"].ToString();
                comDriver.ValueMember = dt.Columns["Driver_ID"].ToString();
                comDriver.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dbconnection.Close();
        }
        private void btnCarUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                dbconnection.Open();

                if (txtCarNumber.Text != "")
                {
                    string qeury = "update  cars set Car_Number=@Car_Number,Car_Capacity=@Car_Capacity,meter_reading=@meter_reading,Openning_Account=@Openning_Account,Car_Value=@Car_Value,DepreciationPeriod=@DepreciationPeriod,PremiumDepreciation=@PremiumDepreciation where Car_Number=" + txtCarNumber.Text;
                    MySqlCommand com = new MySqlCommand(qeury, dbconnection);
                    com.Parameters.Add("@Car_Number", MySqlDbType.VarChar, 255);
                    com.Parameters["@Car_Number"].Value = txtCarNumber.Text;
                    com.Parameters.Add("@Car_Capacity", MySqlDbType.VarChar, 255);
                    com.Parameters["@Car_Capacity"].Value = txtCarCapacity.Text;
                    com.Parameters.Add("@meter_reading", MySqlDbType.Int32);
                    com.Parameters["@meter_reading"].Value = Convert.ToInt32(txtMeterReading.Text);
                    com.Parameters.Add("@Openning_Account", MySqlDbType.Double);
                    com.Parameters["@Openning_Account"].Value = Convert.ToDouble(txtOpenning_Account.Text);
                    com.Parameters.Add("@Car_Value", MySqlDbType.Double);
                    com.Parameters["@Car_Value"].Value = Convert.ToDouble(txtCarValue.Text);
                    com.Parameters.Add("@DepreciationPeriod", MySqlDbType.Double);
                    com.Parameters["@DepreciationPeriod"].Value = Convert.ToDouble(txtDepreciationPeriod.Text);
                    com.Parameters.Add("@PremiumDepreciation", MySqlDbType.Double);
                    com.Parameters["@PremiumDepreciation"].Value = Convert.ToDouble(txtPremiumDepreciation.Text);

                    com.ExecuteNonQuery();
                    MessageBox.Show("update success");
                    clear();
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

        }

        private void comDriver_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (row1 != null)
                {
                    driverID = Convert.ToInt16(comDriver.SelectedValue);
                    string query = "update driver_car set Driver_ID=" + driverID + " where Driver_ID=" + row1.Cells[8].Value + " and Car_ID=" + row1.Cells[9].Value;
                    MySqlCommand com = new MySqlCommand(query, dbconnection);
                    com.ExecuteNonQuery();
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
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //function

        public void SetData(DataGridViewRow row)
        {
            txtCarNumber.Text = row.Cells[0].Value.ToString();
            comDriver.Text = row.Cells[1].Value.ToString();
            txtCarCapacity.Text = row.Cells[3].Value.ToString();
            txtMeterReading.Text = row.Cells[4].Value.ToString();
            txtOpenning_Account.Text = row.Cells[5].Value.ToString();
            txtCarValue.Text = row.Cells[6].Value.ToString();
            txtDepreciationPeriod.Text = row.Cells[7].Value.ToString();
            txtPremiumDepreciation.Text = row.Cells[8].Value.ToString();
            driverID =Convert.ToInt16(row.Cells[8].Value.ToString());
        }
        public void clear()
        {
            txtMeterReading.Text = txtCarCapacity.Text = txtDepreciationPeriod.Text = txtCarValue.Text = txtCarNumber.Text = txtPremiumDepreciation.Text = "";
        }

        
    }
   
}
