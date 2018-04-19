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
    public partial class CarIncomes : Form
    {
        MySqlConnection dbconnection;
        public CarIncomes()
        {
            InitializeComponent();
            dbconnection = new MySqlConnection(connection.connectionString);
        }

        private void CarIncomes_Load(object sender, EventArgs e)
        {
            try
            {
                dbconnection.Open();
                string query = "select * from cars";
                MySqlDataAdapter da = new MySqlDataAdapter(query, dbconnection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comCarNumber.DataSource = dt;
                comCarNumber.DisplayMember = dt.Columns["Car_Number"].ToString();
                comCarNumber.ValueMember = dt.Columns["Car_ID"].ToString();
                comCarNumber.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dbconnection.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dbconnection.Open();
                string str = "";
                if (comCarNumber.Text != "")
                {
                    str = "car_Income.Car_ID='" + comCarNumber.SelectedValue + "' and";
                }
                
                DateTime date = dateTimePicker1.Value.Date;
                string d = date.ToString("yyyy-MM-dd");
                DateTime date2 = dateTimePicker2.Value.Date;
                string d2 = date2.ToString("yyyy-MM-dd");
                string query = "select Car_Income_ID as 'الرقم المسلسل', Address as 'العنوان',NoCarton as 'عدد الكراتين',NoSets as 'عدد الاطقم',NoDocks as 'عدد الاحواض',NoColumns as 'عدد العواميد',NoCompinations as 'عدد الكوبينشن',NoPanio as 'عدد البانيوهات',Nolon as 'النولون',Gate as 'البوابة',Taateg as 'التعتيق',Safay as 'الصافي',Car_Number as 'رقم العربيه',Date as 'التاريخ',Note as'ملاحظات' from car_income inner join cars on cars.Car_ID=car_income.Car_ID where " + str + "  Date >='" + d + "' and Date <='" + d2 + "' ";
                MySqlDataAdapter da = new MySqlDataAdapter(query, dbconnection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                query = "select sum(Gate),sum(Taateg),sum(Nolon),sum(Safay) from car_Income  where " + str + "  Date >='" + d + "' and Date <='" + d2 + "' ";
                MySqlCommand com = new MySqlCommand(query, dbconnection);
                MySqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    labTotalGate.Text = dr["sum(Gate)"].ToString();
                    labTotalNolone.Text = dr["sum(Nolon)"].ToString();
                    labTotalTaateg.Text = dr["sum(Taateg)"].ToString();
                    labTotalSafay.Text = dr["sum(Safay)"].ToString();
                }

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
                DataGridViewRow row = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];

                string value = row.Cells[0].Value.ToString();
                int id = Convert.ToInt16(value);
                dbconnection.Open();
                string query = "select Permission_Number as 'رقم الاذن' from car_permission where Car_Income_ID=" + id + "";
                MySqlDataAdapter da = new MySqlDataAdapter(query, dbconnection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dbconnection.Close();
        }
    }
}
