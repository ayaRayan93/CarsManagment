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
        Cars cars;
        public Car_Update(DataGridViewRow row1,Cars cars)
        {
            try
            {
                InitializeComponent();
                dbconnection = new MySqlConnection(connection.connectionString);
                this.cars = cars;
                this.row1 = row1;
                SetData(row1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        private void btnCarUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                dbconnection.Open();

                if (txtCarNumber.Text != "")
                {
                    string qeury = "update  cars set Car_Number=@Car_Number,Car_Capacity=@Car_Capacity,meter_reading=@meter_reading,Openning_Account=@Openning_Account,Car_Value=@Car_Value,DepreciationPeriod=@DepreciationPeriod,PremiumDepreciation=@PremiumDepreciation where Car_ID=" + row1.Cells["car_id"].Value.ToString();
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
                    cars.DisplayCars(dbconnection);
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

        private void txtBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    TextBox t = (TextBox)sender;
                    switch (t.Name)
                    {
                        case "txtCarNumber":
                            txtCarValue.Focus();
                            txtCarValue.SelectAll();
                            break;
                        case "txtCarValue":
                            txtDepreciationPeriod.Focus();
                            txtDepreciationPeriod.SelectAll();
                            break;
                        case "txtDepreciationPeriod":
                            txtCarCapacity.Focus();
                            txtCarCapacity.SelectAll();
                            break;
                        case "txtCarCapacity":
                            txtMeterReading.Focus();
                            txtMeterReading.SelectAll();
                            break;
                        case "txtMeterReading":
                            txtOpenning_Account.Focus();
                            txtOpenning_Account.SelectAll();
                            break;
                        case "txtOpenning_Account":
                            txtPremiumDepreciation.Focus();
                            txtPremiumDepreciation.SelectAll();
                            break;
                        case "txtPremiumDepreciation":
                            btnCarUpdate.Focus();

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
                cars.carUpdate = null;
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
            txtCarCapacity.Text = row.Cells[1].Value.ToString();
            txtMeterReading.Text = row.Cells[2].Value.ToString();
            txtOpenning_Account.Text = row.Cells[3].Value.ToString();
            txtCarValue.Text = row.Cells[4].Value.ToString();
            txtDepreciationPeriod.Text = row.Cells[5].Value.ToString();
            txtPremiumDepreciation.Text = row.Cells[6].Value.ToString();
        }
     

        
    }
   
}
