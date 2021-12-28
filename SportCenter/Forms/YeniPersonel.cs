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
    public partial class YeniPersonel : Form
    {
        Classes.DbCommands db = new Classes.DbCommands();
        public YeniPersonel()
        {
            InitializeComponent();
            for (int i = 0; i < db.getStaffCategory().Count(); i++)
            {
                staffCategoryBox.AddItem(db.getStaffCategory()[i].ToString());
            }
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        string ad, soyad, tc, dogumtarihi="-1", email, uid, pw, gsmno;

        private void YeniPersonel_Load(object sender, EventArgs e)
        {

        }

        int categoryID =-1;

        private void cinsiyetBox_onItemSelected(object sender, EventArgs e)
        {
            categoryID = db.getStaffCategoryID(staffCategoryBox.selectedValue);
        }

        private void dogumtarihiBox_onValueChanged(object sender, EventArgs e)
        {
            dogumtarihi = dogumtarihiBox.Value.ToString("yyyy-MM-dd");
        }

        private void Login_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void personelekle_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is Bunifu.Framework.UI.BunifuMaterialTextbox && String.IsNullOrEmpty(x.Text))
                {
                    MessageBox.Show("Boş Alan Bırakmayın!");
                    return;
                }

            }
            if (tcTextbox.Text.Length !=11)
            {
                MessageBox.Show("TC 11 Hane olmalıdır.");
                return;
            }
            if (categoryID==-1)
            {
                MessageBox.Show("Personel Kategorisi Seçiniz");
                return;
            }
            if (gsmBox.Text.Length != 11)
            {
                MessageBox.Show("GSM 11 Hane olmalıdır");
                return;
            }
            if (dogumtarihi == "-1")
            {
                MessageBox.Show("Personel Doğum Tarihi Giriniz ");
                return;
            }
            else
            {
                ad = adtextbox.Text;
                soyad = soyadTextbox.Text;
                tc = tcTextbox.Text;
                email = eposstaTextbox.Text;
                uid = usernameTxtbox.Text;
                pw = pwTxtbox.Text;
                gsmno = gsmBox.Text;
            }
            if (db.insertStaffr(ad, soyad, tc,gsmno,email,dogumtarihi,categoryID,uid,pw))
            {
                MessageBox.Show("Personel Kaydedildi!");
            }
            else MessageBox.Show("Kayıt Başarısız");

        }
    }
}
