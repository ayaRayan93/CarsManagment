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
    public partial class Car_Record : Form
    {
        MySqlConnection dbconnection;
        public Car_Record()
        {
            InitializeComponent();
            dbconnection = new MySqlConnection(connection.connectionString);
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                dbconnection.Open();
                string query = "select Car_Number from cars where Car_Number='" + txtCarNumber.Text + "'";
                MySqlCommand com = new MySqlCommand(query, dbconnection);


                if (com.ExecuteScalar() == null)
                {
                    if (txtCarNumber.Text != "")
                    {
                        string qeury = "insert into cars (Car_Number,Car_Capacity,meter_reading,Openning_Account,Car_Value,DepreciationPeriod,PremiumDepreciation)values(@Car_Number,@Car_Capacity,@meter_reading,@Openning_Account,@Car_Value,@DepreciationPeriod,@PremiumDepreciation)";
                        com = new MySqlCommand(qeury, dbconnection);
                        com.Parameters.Add("@Car_Number", MySqlDbType.VarChar, 255);
                        com.Parameters["@Car_Number"].Value = txtCarNumber.Text;
                        com.Parameters.Add("@Car_Capacity", MySqlDbType.Double);
                        com.Parameters["@Car_Capacity"].Value = Convert.ToDouble(txtCarCapacity.Text);
                        com.Parameters.Add("@meter_reading", MySqlDbType.Int32);
                        com.Parameters["@meter_reading"].Value =Convert.ToInt32(txtMeterReading.Text);
                        com.Parameters.Add("@Openning_Account", MySqlDbType.Double);
                        com.Parameters["@Openning_Account"].Value = Convert.ToDouble(txtOpenning_Account.Text);
                        com.Parameters.Add("@Car_Value", MySqlDbType.Double);
                        com.Parameters["@Car_Value"].Value = Convert.ToDouble(txtCarValue.Text);
                        com.Parameters.Add("@DepreciationPeriod", MySqlDbType.Double);
                        com.Parameters["@DepreciationPeriod"].Value = Convert.ToDouble(txtDepreciationPeriod.Text);
                        com.Parameters.Add("@PremiumDepreciation", MySqlDbType.Double);
                        com.Parameters["@PremiumDepreciation"].Value = Convert.ToDouble(txtPremiumDepreciation.Text);

                        com.ExecuteNonQuery();

                        string query1 = "select Car_ID from cars order by Car_ID desc limit 1";
                        com = new MySqlCommand(query1, dbconnection);
                        int id =Convert.ToInt32(com.ExecuteScalar());

                        string query2 = "insert into driver_car (Car_ID,Driver_ID) values (@Car_ID,@Driver_ID)";
                        MySqlCommand com1 = new MySqlCommand(query2, dbconnection);
                       
                        com1.Parameters.AddWithValue("@Car_ID", Convert.ToInt32(id));
                        com1.Parameters.AddWithValue("@Driver_ID", Convert.ToInt32(comDriver.SelectedValue));
                     
                        com1.ExecuteNonQuery();

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
                            comDriver.Focus();
                            break;
                        case "txtCarValue":
                            txtDepreciationPeriod.Focus();
                            break;
                        case "txtDepreciationPeriod":
                            txtCarCapacity.Focus();
                            break;
                        case "txtCarCapacity":
                            txtMeterReading.Focus();
                            break;
                        case "txtMeterReading":
                            txtOpenning_Account.Focus();
                            break;
                        case "txtOpenning_Account":
                            txtPremiumDepreciation.Focus();
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
            txtMeterReading.Text=txtCarCapacity.Text=txtDepreciationPeriod.Text=txtCarValue.Text=txtCarNumber.Text = txtPremiumDepreciation.Text = "";
        }

        private void Car_Record_Load(object sender, EventArgs e)
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
    }
   
}
