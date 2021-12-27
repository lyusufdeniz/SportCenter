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
    public partial class ÜyeDüzenle : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        Classes.DbCommands db = new Classes.DbCommands();
        string sexFilter="", isActiveFilter="";
        private void Login_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public ÜyeDüzenle()
        {
            InitializeComponent();
            memberdgv.DataSource = db.getmemberTableWithFilters("","").Tables[0].DefaultView;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void sadeceaktifcheckbox_OnChange(object sender, EventArgs e)
        {
            if (sadeceaktifcheckbox.Checked)
            {
                isActiveFilter = "1";

            }
            else isActiveFilter = "";
        }

        private void cinsiyet_onItemSelected(object sender, EventArgs e)
        {
            if(cinsiyet.selectedIndex==0)
            {
                sexFilter = "";
            }
            else if(cinsiyet.selectedIndex == 1)
            {
                sexFilter = "1";
            }
            else if (cinsiyet.selectedIndex == 2)
            {
                sexFilter = "0";
            }
        }

        private void ara_Click(object sender, EventArgs e)
        {
          
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
            if(tcRadio.Checked)
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = db.getmemberTableWithFilters("", "").Tables[0].DefaultView;
                bs.Filter = "[Üye TC] like '%" + searchBox.Text + "%' ";
                memberdgv.DataSource = bs;
            }
        }




        private void memberdgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int memberID = Int32.Parse(memberdgv.CurrentRow.Cells[0].Value.ToString());
            ÜyeBilgiDüzenle duzenle = new ÜyeBilgiDüzenle(memberID);
            duzenle.Show();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

            memberdgv.DataSource = db.getmemberTableWithFilters(sexFilter, isActiveFilter).Tables[0].DefaultView;
        }
    }
}
