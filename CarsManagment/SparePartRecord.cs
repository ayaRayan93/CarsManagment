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
    public partial class SparePartRecord : Form
    {
        MySqlConnection conn;
        public SparePartRecord()
        {
            InitializeComponent();
            
            string constr= connection.connectionString;
            conn = new MySqlConnection(constr);
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                conn.Open();
                string query = "select SparePart_ID from sparepart where SparePart_Name='" + txtName.Text + "'";
                MySqlCommand com = new MySqlCommand(query, conn);


                if (com.ExecuteScalar() == null)
                {
                    if (txtName.Text != "")
                    {
                        string qeury = "insert into sparepart (SparePart_Name,SparePart_Info)values(@Name,@info)";
                        com = new MySqlCommand(qeury, conn);
                        com.Parameters.Add("@Name", MySqlDbType.VarChar, 255);
                        com.Parameters["@Name"].Value = txtName.Text;
                        com.Parameters.Add("@info", MySqlDbType.VarChar, 255);
                        com.Parameters["@info"].Value = txtInfo.Text;

                        com.ExecuteNonQuery();
                        MessageBox.Show("add success");
                        clear();
                        txtName.Focus();
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
            conn.Close();
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

       
        //function
        public void clear()
        {
            txtName.Text = txtInfo.Text = "";
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
    }
   
}
