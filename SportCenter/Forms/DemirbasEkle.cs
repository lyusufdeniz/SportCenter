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
    public partial class DemirbasEkle : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        Classes.DbCommands db = new Classes.DbCommands();
        string activityname="";
        private void Login_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public DemirbasEkle()
        {
            InitializeComponent();
            for(int i=0;i<db.getActivityList().Count;i++)
            {
                aktivitelerBox.AddItem(db.getActivityList()[i]);
            }
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is Bunifu.Framework.UI.BunifuMaterialTextbox && String.IsNullOrEmpty(x.Text))
                {
                    MessageBox.Show("Boş Alan Bırakmayın!");
                    return;
                }
            }
            if(activityname=="")
            {
                MessageBox.Show("Aktivite Seçin!");return;
            }
                if (db.insertInventory(ad.Text,tutar.Text,adet.Text, activityname))
                {
                MessageBox.Show("Başarıyla Kaydedildi");
            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aktivitelerBox_onItemSelected(object sender, EventArgs e)
        {
            if(aktivitelerBox.selectedIndex!=0)
            {
                activityname = aktivitelerBox.selectedValue;
            }
       
        }

        private void adet_OnValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
