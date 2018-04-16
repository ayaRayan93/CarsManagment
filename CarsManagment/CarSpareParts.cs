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
    public partial class CarSpareParts : Form
    {

        MySqlConnection dbconnection;
        DataGridViewRow CarRow = null,carSparePart=null;
        int CarId;
        Cars cars;
        public CarSpareParts(DataGridViewRow CarRow,Cars cars)
        {
            try
            {
                InitializeComponent();
                dbconnection = new MySqlConnection(connection.connectionString);
                this.CarRow = CarRow;
                labStoreName.Text = CarRow.Cells[0].Value.ToString();
                CarId =Convert.ToInt16(CarRow.Cells["car_id"].Value.ToString());
                this.cars = cars;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CarDrivers_Load(object sender, EventArgs e)
        {
            try
            {
                dbconnection.Open();
                displayCarSpareParts();
                string query = "select SparePart_ID,SparePart_Name from sparepart";
                MySqlDataAdapter da = new MySqlDataAdapter(query, dbconnection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comSpareParts.DataSource = dt;
                comSpareParts.DisplayMember = dt.Columns["SparePart_Name"].ToString();
                comSpareParts.ValueMember = dt.Columns["SparePart_ID"].ToString();
                comSpareParts.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dbconnection.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                dbconnection.Open();
             
                if (comSpareParts.Text != "")
                {
                    string qeury = "insert into car_sparepart (Car_ID,SparePart_ID,Car_SparePart_Info,Car_SpareDate)values(@Car_ID,@SparePart_ID,@Car_SparePart_Info,@Car_SpareDate)";
                    MySqlCommand com = new MySqlCommand(qeury, dbconnection);
                    com.Parameters.Add("@Car_ID", MySqlDbType.Int32);
                    com.Parameters["@Car_ID"].Value = CarId;
                    com.Parameters.Add("@SparePart_ID", MySqlDbType.Int16);
                    com.Parameters["@SparePart_ID"].Value = comSpareParts.SelectedValue;
                    com.Parameters.Add("@Car_SparePart_Info", MySqlDbType.VarChar,255);
                    com.Parameters["@Car_SparePart_Info"].Value = txtInfo.Text;
                    com.Parameters.Add("@Car_SpareDate", MySqlDbType.Date);
                    com.Parameters["@Car_SpareDate"].Value = dateTimePicker1.Value.Date;

                    com.ExecuteNonQuery();

                    displayCarSpareParts();
                    comSpareParts.Focus();
                }
                else
                {
                    MessageBox.Show("enter Name");
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dbconnection.Close();
        }
        private void btnDeleteCarDriver_Click(object sender, EventArgs e)
        {
            try
            {
                dbconnection.Open();
                if (carSparePart != null)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the item?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        
                        string query = "delete from car_sparepart where SparePart_ID=" + carSparePart.Cells[0].Value.ToString()+" and Car_ID="+CarId;
                        MySqlCommand com = new MySqlCommand(query, dbconnection);
                        com.ExecuteNonQuery();
                        displayCarSpareParts();
                    }
                    else if (dialogResult == DialogResult.No)
                    { }
                }
                else
                {
                    MessageBox.Show("select row");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dbconnection.Close();
        }
     
        private void dataGridViewCarDrivers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                carSparePart = dataGridViewCarDrivers.Rows[dataGridViewCarDrivers.SelectedCells[0].RowIndex];
                carSparePart.Selected = true;

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
                cars.carSpareParts = null;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        //functions
        //display cars driver
        public void displayCarSpareParts()
        {
            String query = "select car_sparepart.SparePart_ID as 'الكود' ,sparepart.SparePart_Name as 'قطعة الغيار',car_sparepart.Car_SparePart_Info as 'البيان',car_sparepart.Car_SpareDate as 'التاريخ' from sparepart inner join car_sparepart on sparepart.SparePart_ID=car_sparepart.SparePart_ID where Car_ID=" + CarId;
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbconnection);
            DataTable dtaple = new DataTable();
            adapter.Fill(dtaple);
            dataGridViewCarDrivers.DataSource = dtaple;
        }
        
    }
}
