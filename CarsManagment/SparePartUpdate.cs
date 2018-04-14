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
    public partial class SparePartUpdate : Form
    {
        MySqlConnection dbconnection;
        DataGridViewRow row1 = null;
        public SparePartUpdate(DataGridViewRow row1)
        {
            try
            {
                InitializeComponent();
                dbconnection = new MySqlConnection(connection.connectionString);
                this.row1 = row1;
                SetData(row1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            dbconnection.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text != "")
                {
                    dbconnection.Open();
                    String query = "update sparepart set SparePart_Name=@Name,SparePart_Info=@info where SparePart_ID='" + row1.Cells[0].Value + "'";
                    MySqlCommand com = new MySqlCommand(query, dbconnection);
                    
                    com.Parameters.Add("@Name", MySqlDbType.VarChar, 255).Value = txtName.Text;
                    com.Parameters.Add("@info", MySqlDbType.VarChar, 255).Value = txtInfo.Text;

                    com.ExecuteNonQuery();
                    MessageBox.Show("udpate success");
                    txtName.Focus();
                }
                else
                {
                    MessageBox.Show("enter name");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                dbconnection.Close();
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
                            txtName.Focus();
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

        //functions
        private void SetData(DataGridViewRow row)
        {
            txtName.Text = row.Cells[1].Value.ToString();
            txtInfo.Text = row.Cells[2].Value.ToString();
        }

    }
}
