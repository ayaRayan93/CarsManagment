using Bunifu.Framework.UI;
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
        TabPage CarTP;
        bool flag = false;
        Panel panCarCoding;
    
        public MainCarForm()
        {
            try
            {
                InitializeComponent();
                intializeCarCodingPanel();

                CarTP = tabPageCar;
                tabControlMainContainer.TabPages.Remove(tabPageCar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
   
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

        //Design Function
        public Panel panStyle(Panel pan)
        {
            pan.Dock = DockStyle.Fill;
            pan.BackColor = Color.FromArgb(252,169, 41);
            return pan;
        }
        
        public Button btnStyle(Button btn)
        {
            btn.Dock = DockStyle.Top;
            btn.BackColor = Color.FromArgb(252, 169, 41);
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
                    btn.ForeColor = Color.FromArgb(252, 169, 41);
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
                        btn.BackColor = Color.FromArgb(252,169, 41);
                        btn.ForeColor = Color.FromArgb(34, 34, 34);
                    }
                }
            }
        }

       
    }
    public static class connection
    {
        // public static string connectionString = "SERVER=192.168.1.200;DATABASE=cccDB;user=Devccc;PASSWORD=rootroot;CHARSET=utf8";
        public static string connectionString = "SERVER=localhost;DATABASE=cccLocal;user=root;PASSWORD=root;CHARSET=utf8";

    }
}
