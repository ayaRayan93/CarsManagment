using Bunifu.Framework.UI;
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
    public partial class MainCarForm : Form
    {
        MySqlConnection dbconnection;
        TabPage CarTP;
        bool flag = false;
        Panel panCarCoding,panCarIncome,panAl3hta,panExpenses,panReadingMeter,panReport;
      

        public MainCarForm()
        {
            try
            {
                InitializeComponent();
                dbconnection = new MySqlConnection(connection.connectionString);
                intializeCarCodingPanel();
                intializeCarIncomePanel();
                intializeAl3htaPanel();
                intializeExpensesPanel();
                intializeReadingMeterPanel();

                intializeReportPanel();
                CarTP = tabPageCar;
                tabControlMainContainer.TabPages.Remove(tabPageCar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
   
        }
        private void MainCarForm_Load(object sender, EventArgs e)
        {
            try
            {
                dbconnection.Open();
                CkeckCarLicense();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dbconnection.Close();
        }
        private void btnCarManagment_Click(object sender, EventArgs e)
        {
            try
            {
                if (flag == false)
                {
                    tabControlMainContainer.TabPages.Insert(1, CarTP);
                    flag = true;
                }
                tabControlMainContainer.TabPages[0].Hide();
                tabControlMainContainer.TabPages[1].Show();
                tabControlMainContainer.TabPages[1].Select();
                tabControlMainContainer.SelectedTab = tabControlMainContainer.TabPages[1];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCarCoding_Click(object sender, EventArgs e)
        {
            try
            {
                resetButtonsStorePanelStyle();
                Button btn = (Button)sender;
                if (panCarDetailTabs.Visible == true && panCarDetailTabs.Controls.Contains(panCarCoding))
                {
                    panCarDetailTabs.Controls.Clear();
                    panCarDetailTabs.Visible = false;
                    btn.ForeColor = Color.FromArgb(252,169, 41);
                    btn.BackColor = Color.FromArgb(34, 34, 34);
                }
                else
                {
                    panCarDetailTabs.Visible = true;
                    panCarDetailTabs.Controls.Clear();
                    panCarDetailTabs.Controls.Add(panCarCoding);
                    btn.BackColor = Color.FromArgb(252,169, 41);
                    btn.ForeColor = Color.FromArgb(34, 34, 34);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCarIncome_Click(object sender, EventArgs e)
        {
            try
            {
                resetButtonsStorePanelStyle();
                Button btn = (Button)sender;
                if (panCarDetailTabs.Visible == true && panCarDetailTabs.Controls.Contains(panCarIncome))
                {
                    panCarDetailTabs.Controls.Clear();
                    panCarDetailTabs.Visible = false;
                    btn.ForeColor = Color.FromArgb(252, 169, 41);
                    btn.BackColor = Color.FromArgb(34, 34, 34);
                }
                else
                {
                    panCarDetailTabs.Visible = true;
                    panCarDetailTabs.Controls.Clear();
                    panCarDetailTabs.Controls.Add(panCarIncome);
                    btn.BackColor = Color.FromArgb(252, 169, 41);
                    btn.ForeColor = Color.FromArgb(34, 34, 34);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAl3hta_Click(object sender, EventArgs e)
        {

            try
            {
                resetButtonsStorePanelStyle();
                Button btn = (Button)sender;
                if (panCarDetailTabs.Visible == true && panCarDetailTabs.Controls.Contains(panAl3hta))
                {
                    panCarDetailTabs.Controls.Clear();
                    panCarDetailTabs.Visible = false;
                    btn.ForeColor = Color.FromArgb(252, 169, 41);
                    btn.BackColor = Color.FromArgb(34, 34, 34);
                }
                else
                {
                    panCarDetailTabs.Visible = true;
                    panCarDetailTabs.Controls.Clear();
                    panCarDetailTabs.Controls.Add(panAl3hta);
                    btn.BackColor = Color.FromArgb(252, 169, 41);
                    btn.ForeColor = Color.FromArgb(34, 34, 34);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnExpenses_Click(object sender, EventArgs e)
        {
            try
            {
                resetButtonsStorePanelStyle();
                Button btn = (Button)sender;
                if (panCarDetailTabs.Visible == true && panCarDetailTabs.Controls.Contains(panExpenses))
                {
                    panCarDetailTabs.Controls.Clear();
                    panCarDetailTabs.Visible = false;
                    btn.ForeColor = Color.FromArgb(252, 169, 41);
                    btn.BackColor = Color.FromArgb(34, 34, 34);
                }
                else
                {
                    panCarDetailTabs.Visible = true;
                    panCarDetailTabs.Controls.Clear();
                    panCarDetailTabs.Controls.Add(panExpenses);
                    btn.BackColor = Color.FromArgb(252, 169, 41);
                    btn.ForeColor = Color.FromArgb(34, 34, 34);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnReadingMeter_Click(object sender, EventArgs e)
        {
            try
            {
                resetButtonsStorePanelStyle();
                Button btn = (Button)sender;
                if (panCarDetailTabs.Visible == true && panCarDetailTabs.Controls.Contains(panReadingMeter))
                {
                    panCarDetailTabs.Controls.Clear();
                    panCarDetailTabs.Visible = false;
                    btn.ForeColor = Color.FromArgb(252, 169, 41);
                    btn.BackColor = Color.FromArgb(34, 34, 34);
                }
                else
                {
                    panCarDetailTabs.Visible = true;
                    panCarDetailTabs.Controls.Clear();
                    panCarDetailTabs.Controls.Add(panReadingMeter);
                    btn.BackColor = Color.FromArgb(252, 169, 41);
                    btn.ForeColor = Color.FromArgb(34, 34, 34);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                resetButtonsStorePanelStyle();
                Button btn = (Button)sender;
                if (panCarDetailTabs.Visible == true && panCarDetailTabs.Controls.Contains(panReport))
                {
                    panCarDetailTabs.Controls.Clear();
                    panCarDetailTabs.Visible = false;
                    btn.ForeColor = Color.FromArgb(252, 169, 41);
                    btn.BackColor = Color.FromArgb(34, 34, 34);
                }
                else
                {
                    panCarDetailTabs.Visible = true;
                    panCarDetailTabs.Controls.Clear();
                    panCarDetailTabs.Controls.Add(panReport);
                    btn.BackColor = Color.FromArgb(252, 169, 41);
                    btn.ForeColor = Color.FromArgb(34, 34, 34);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void MainCarForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        //notifycation      
        public void CkeckCarLicense()
        {
            DateTime date = DateTime.Now.Date;
            string d = date.ToString("yyyy-MM-dd");
            string query = "select Car_Number from car_license inner join cars on cars.Car_ID=car_license.Car_ID  where End_License_Date='"+d+"'";
            MySqlCommand com = new MySqlCommand(query, dbconnection);
            MySqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Displaynotify(dr[0].ToString());
            }
            dr.Close();
         
        }
        protected void Displaynotify(String carNum)
        {
            try
            {
                notifyIcon1.Text = carNum;
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = "The License Date of Car Number " + carNum + " is Expired";
                notifyIcon1.BalloonTipText = "Update License Date";
                notifyIcon1.ShowBalloonTip(100);
            }
            catch (Exception ex)
            {
            }
        }
        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            try
            {
                CarLicenseUpdate f = new CarLicenseUpdate(notifyIcon1.Text);
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        //function
        public void intializeCarCodingPanel()
        {
            panCarCoding = new Panel();
            panCarCoding = panStyle(panCarCoding);
            Button btn3 = new Button();
            btn3 = btnStyle(btn3);
            btn3.Text = "السائقين";
            btn3.Click += BtnRecordDriver_Click;

            Button btn = new Button();
            btn = btnStyle(btn);
            btn.Text = "السيارات";

            btn.Click += BtnCarRecord_Click;
          
            Button btn4 = new Button();
            btn4 = btnStyle(btn4);
            btn4.Text = "قطع الغيار";
            btn4.Click += Btn4_Click;
            panCarCoding.Controls.Add(btn4);
            panCarCoding.Controls.Add(btn);
            panCarCoding.Controls.Add(btn3);
        }
        private void Btn4_Click(object sender, EventArgs e)
        {
            try
            {
                tableLayoutPanelContent.Controls.Clear();
                resetButtonsStoreDetailsPanelStyle();
                Button btn = (Button)sender;
                btn.ForeColor = Color.Black;
                btn.BackColor = Color.White;
                SparePart objForm = new SparePart();
                objForm.TopLevel = false;
                tableLayoutPanelContent.Controls.Add(objForm);
                objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                objForm.Dock = DockStyle.Fill;
                objForm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnRecordDriver_Click(object sender, EventArgs e)
        {
            try
            {
                tableLayoutPanelContent.Controls.Clear();
                resetButtonsStoreDetailsPanelStyle();
                Button btn = (Button)sender;
                btn.ForeColor = Color.Black;
                btn.BackColor = Color.White;
                Drivers objForm = new Drivers();
                objForm.TopLevel = false;
                tableLayoutPanelContent.Controls.Add(objForm);
                objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                objForm.Dock = DockStyle.Fill;
                objForm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnCarRecord_Click(object sender, EventArgs e)
        {
            try
            {
                tableLayoutPanelContent.Controls.Clear();
                resetButtonsStoreDetailsPanelStyle();
                Button btn = (Button)sender;
                btn.ForeColor = Color.Black;
                btn.BackColor = Color.White;
                Cars objForm = new Cars();
                objForm.TopLevel = false;
                tableLayoutPanelContent.Controls.Add(objForm);
                objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                objForm.Dock = DockStyle.Fill;
                objForm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void intializeCarIncomePanel()
        {
            panCarIncome = new Panel();
            panCarIncome = panStyle(panCarIncome);
            Button btn1 = new Button();
            btn1 = btnStyle(btn1);
            btn1.Text = "الأجندة";

            Button btn2 = new Button();
            btn2 = btnStyle(btn2);
            btn2.Text = "الأرادات";

            panCarIncome.Controls.Add(btn2);
            panCarIncome.Controls.Add(btn1);

        }
        public void intializeAl3htaPanel()
        {
            panAl3hta = new Panel();
            panAl3hta = panStyle(panAl3hta);
            Button btn1 = new Button();
            btn1 = btnStyle(btn1);
            btn1.Text = "تكويد العهدة";

            Button btn2 = new Button();
            btn2 = btnStyle(btn2);
            btn2.Text = "تقرير العهدة";

            panAl3hta.Controls.Add(btn2);
            panAl3hta.Controls.Add(btn1);
        }
        public void intializeExpensesPanel()
        {
            panExpenses = new Panel();
            panExpenses = panStyle(panExpenses);
            Button btn1 = new Button();
            btn1 = btnStyle(btn1);
            btn1.Text = "تكويد مصروف";

            Button btn2 = new Button();
            btn2 = btnStyle(btn2);
            btn2.Text = "المصروفات";

            panExpenses.Controls.Add(btn2);
            panExpenses.Controls.Add(btn1);
        }
        public void intializeReadingMeterPanel()
        {
            panReadingMeter = new Panel();
            panReadingMeter = panStyle(panReadingMeter);
            Button btn1 = new Button();
            btn1 = btnStyle(btn1);
            btn1.Text = "قراية العدات";

            panReadingMeter.Controls.Add(btn1);
        }

        public void intializeReportPanel()
        {
            panReport = new Panel();
            panReport = panStyle(panReport);
            Button btn1 = new Button();
            btn1 = btnStyle(btn1);
            btn1.Text = "السيارات";
            Button btn2 = new Button();
            btn2 = btnStyle(btn2);
            btn2.Text = "السائقين";
            Button btn3 = new Button();
            btn3 = btnStyle(btn3);
            btn3.Text = "الأرادات";
            Button btn4 = new Button();
            btn4 = btnStyle(btn4);
            btn4.Text = "المصروفات";

            panReport.Controls.Add(btn1);
            panReport.Controls.Add(btn2);
            panReport.Controls.Add(btn3);
            panReport.Controls.Add(btn4);
        }


        //Design Function
        public Panel panStyle(Panel pan)
        {
            pan.Dock = DockStyle.Fill;
            pan.BackColor = Color.FromArgb(229, 229,229);
            return pan;
        }
        
        public Button btnStyle(Button btn)
        {
            btn.Dock = DockStyle.Top;
            btn.BackColor = Color.FromArgb(229, 229, 229);
            btn.Height= 47;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            return btn;
        }
        
        public void resetButtonsStorePanelStyle()
        {
            foreach (Control btn in panCarMainTabs.Controls)
            {
                if (btn is Button)
                {
                    btn.ForeColor = Color.FromArgb(252,169, 41);
                    btn.BackColor = Color.FromArgb(34, 34, 34);
                }
            }
        }
        public void resetButtonsStoreDetailsPanelStyle()
        {
            foreach (Control pan in panCarDetailTabs.Controls)
            {
                foreach (Control btn in pan.Controls)
                {
                    if (btn is Button)
                    {
                        btn.BackColor = Color.FromArgb(229, 229, 229);
                        btn.ForeColor = Color.FromArgb(34, 34, 34);
                    }
                }
            }
        }

       
    }
    public static class connection
    {
       // public static string connectionString = "SERVER=192.168.1.200;DATABASE=cccserver;user=Devccc;PASSWORD=rootroot;CHARSET=utf8";
        public static string connectionString = "SERVER=localhost;DATABASE=cccLocal;user=root;PASSWORD=root;CHARSET=utf8";

    }
}
