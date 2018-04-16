using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CarsManagment
{
    public partial class Car_Papers : Form
    {
        MySqlConnection dbconnection;
        byte[] mFile;
        DataGridViewRow CarRow = null, carSparePart = null;
        int CarId;
        Cars cars;
        public Car_Papers(DataGridViewRow CarRow, Cars cars)
        {
            try
            {
                InitializeComponent();
                dbconnection = new MySqlConnection(connection.connectionString);
                this.CarRow = CarRow;
                txtCarNumber.Text = CarRow.Cells[0].Value.ToString();
                CarId = Convert.ToInt16(CarRow.Cells["car_id"].Value.ToString());
                this.cars = cars;
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
               
                if (txtCarNumber.Text != "")
                {
                    string qeury = "insert into car_paper (Car_ID,Car_Paper_Info,Car_Paper)values(@Car_ID,@info,@Car_Paper)";
                    MySqlCommand com = new MySqlCommand(qeury, dbconnection);
                    com.Parameters.Add("@Car_ID", MySqlDbType.VarChar, 255);
                    com.Parameters["@Car_ID"].Value = CarId;
                    com.Parameters.Add("@info", MySqlDbType.VarChar, 255);
                    com.Parameters["@info"].Value = txtInfo.Text;
                    com.Parameters.AddWithValue("@Car_Paper", mFile);

                    com.ExecuteNonQuery();
                    MessageBox.Show("add success");
                    clear();
                    txtCarNumber.Focus();
                }
                else
                {
                    MessageBox.Show("enter Name");
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
                        case "txtName":
                            txtInfo.Focus();
                            break;
                        case "txtInfo":
                            txtCarNumber.Focus();
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

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = openFileDialog1.FileName;

                    picFile.Image = Image.FromFile(openFileDialog1.FileName);
                    mFile = File.ReadAllBytes(selectedFile);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //function
        public void clear()
        {
            txtCarNumber.Text = txtInfo.Text = "";
        }
        
    }
   
}
