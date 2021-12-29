using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportCenter.Forms
{
    public partial class UyeGirisCiikis : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        Classes.DbCommands db = new Classes.DbCommands();
        int memberID=-1, activityID=-0;
        private void Login_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void searchBox_OnValueChanged(object sender, EventArgs e)
        {
            if (adsoyadRadio.Checked)
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = db.getmemberTableWithFilters("", "").Tables[0].DefaultView;

                bs.Filter = "[Adı Soyadı] like '%" + searchBox.Text + "%' ";
                memberdgv.DataSource = bs;
            }
            if (tcRadio.Checked)
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = db.getmemberTableWithFilters("", "").Tables[0].DefaultView;
                bs.Filter = "[Üye TC] like '%" + searchBox.Text + "%' ";
                memberdgv.DataSource = bs;
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

        private void memberdgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Üye Seçildi! "+ memberdgv.CurrentRow.Cells[1].Value.ToString()+" "+ memberdgv.CurrentRow.Cells[2].Value.ToString());
            memberID = Int32.Parse(memberdgv.CurrentRow.Cells[0].Value.ToString());
            
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            if(memberID==-1)
            {
                MessageBox.Show("Üye Seçiniz!");
                return;
            }
            if(activityID==0)
            {
                MessageBox.Show("Aktivite Seçiniz");
                return;
            }
            if(db.memberLog(memberID,activityID))
            {
                MessageBox.Show("Üye Giriş/Çıkışı Loglandı!");
            }
        }

        private void activitiesBox_onItemSelected(object sender, EventArgs e)
        {
            activityID = db.getActivityID(activitiesBox.selectedValue);
        }

        public UyeGirisCiikis()
        {
            InitializeComponent();
            memberdgv.DataSource = db.getmemberTableWithFilters("", "").Tables[0].DefaultView;
            for (int i = 0; i < db.getActivityList().Count(); i++)
            {
                activitiesBox.AddItem(db.getActivityList()[i].ToString());
            }
        }
    }
}
