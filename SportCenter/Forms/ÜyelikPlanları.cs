using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportCenter.Forms
{
    public partial class ÜyelikPlanları : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        Classes.DbCommands db = new Classes.DbCommands();
        string  updatednewName="",updatePlaneName = "", updatePlanCost = "", updateplanMonth = "";
        string insertPlanName = "", insertPlanCost="", insertPlanMonth = "";

        private void Login_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ekleButton_Click(object sender, EventArgs e)
        {
            if (ekleAdBox.Text == "")
            {
                MessageBox.Show("Ad Alanı Doldurulmalıdır"); return;
            }
            if (ekleAyBox.selectedIndex == 0)
            {
                MessageBox.Show("Ay Alanı Doldurulmalıdır"); return;
            }
            if (ekleUcretBox.Text == "")
            {
                MessageBox.Show("Ücret Alanı Doldurulmalıdır"); return;
            }
            insertPlanName = ekleAdBox.Text;
            insertPlanCost = ekleUcretBox.Text;
            insertPlanMonth = ekleAyBox.selectedValue;
            if(db.insertMembershipPlan(insertPlanName,insertPlanCost,insertPlanMonth))
            {
                MessageBox.Show("Plan Kaydedildi");
            }
        }

        private void guncelleUcret_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void ekleUcretBox_OnValueChanged(object sender, EventArgs e)
        {
         
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            guncelleSecPlanBox.Clear();
            guncelleSecPlanBox.AddItem("Plan Seçiniz");
            guncelleSecPlanBox.SelectedItem("Plan Seçiniz");
            for (int i = 0; i < db.getMembershipPlans().Count; i++)
            {
                guncelleSecPlanBox.AddItem(db.getMembershipPlans()[i]);
            }
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            if(guncelleSecPlanBox.selectedValue== "Plan Seçiniz" || updatePlaneName== "Plan Seçiniz")
            {
                MessageBox.Show("Plan Seçiniz"); return;
            }
            if(guncelleAdBox.Text=="")
            {
                MessageBox.Show("Ad Alanı Doldurulmalıdır"); return;
            }
            if (guncelleAyBox.selectedIndex == 0)
            {
                MessageBox.Show("Ay Alanı Doldurulmalıdır"); return;
            }
            if (guncelleUcret.Text == "")
            {
                MessageBox.Show("Ücret Alanı Doldurulmalıdır");return;
            }
           
            updatednewName = guncelleAdBox.Text;
            updatePlanCost = guncelleUcret.Text;
            updateplanMonth = guncelleAyBox.selectedValue;
            if(db.updateMembershipPlan(updatePlaneName,updatednewName,updatePlanCost,updateplanMonth))
            {
                MessageBox.Show("Plan Güncellendi");
            }

        }

        public ÜyelikPlanları()
        {
            InitializeComponent();
            for (int i = 1; i <= 24; i++)
            {
                guncelleAyBox.AddItem(i.ToString());
                ekleAyBox.AddItem(i.ToString());
            }
            for(int i=0;i<db.getMembershipPlans().Count;i++)
            {
                guncelleSecPlanBox.AddItem(db.getMembershipPlans()[i]);
            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guncelleSecPlanBox_onItemSelected(object sender, EventArgs e)
        {
            if (guncelleSecPlanBox.selectedIndex != 0)
            {
                guncelleAdBox.Text = db.getMemberhipInfo("planName", guncelleSecPlanBox.selectedValue);
                guncelleAyBox.SelectedItem(db.getMemberhipInfo("planMonth", guncelleSecPlanBox.selectedValue));
                guncelleUcret.Text = db.getMemberhipInfo("planCost", guncelleSecPlanBox.selectedValue);
                updatePlaneName = guncelleSecPlanBox.selectedValue;

            }
            else updatePlaneName = "";




        }
    }
}
