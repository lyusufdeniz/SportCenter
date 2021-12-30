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

    public partial class PersonelBilgiDuzenle : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        Classes.DbCommands db = new Classes.DbCommands();
        string ad, soyad, tc, dogumtar, eposta, uid, pw;

        private void üyedüzenle_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is Bunifu.Framework.UI.BunifuMaterialTextbox && String.IsNullOrEmpty(x.Text))
                {
                    MessageBox.Show("Boş Alan Bırakmayın!");
                    return;
                }

            }
            if(tcTextbox.Text.Length!=11)
            {
                MessageBox.Show("TC 11 HANEDEN OLUŞMALIDIR");
                return;
            }
            ad = adtextbox.Text;
            soyad = soyadTextbox.Text;
            tc = tcTextbox.Text;
            dogumtar= dogumtarihiBox.Value.ToString("yyyy-MM-dd");
            eposta = eposstaTextbox.Text;
            uid = uidBox.Text;
            pw = pwBox.Text;
            if(db.updateStaff(ad,soyad,tc,eposta,dogumtar,uid,pw,staffID))
            {
                MessageBox.Show("Personel Güncellendi!");
                this.Close();
            }
            else MessageBox.Show("Güncelleme Başarısız");


        }

        private void dogumtarihiBox_onValueChanged(object sender, EventArgs e)
        {
            dogumtar = dogumtarihiBox.Value.ToString("yyyy-MM-dd");
        }

        private void eposstaTextbox_OnValueChanged(object sender, EventArgs e)
        {

        }

        int staffID;

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            if (db.deleteStaff(staffID))
            {
                MessageBox.Show("Kayıt Silindi!");
                this.Close();
            }
            else MessageBox.Show("Kayıt Silinemedi");
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Login_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        public PersonelBilgiDuzenle(int staffID)
        {
            InitializeComponent();
            this.staffID = staffID;
            adtextbox.Text = db.getstaffInfo("staffName", staffID);
            soyadTextbox.Text = db.getstaffInfo("staffSurname", staffID);
            tcTextbox.Text = db.getstaffInfo("staffTc", staffID);
            eposstaTextbox.Text = db.getstaffInfo("staffeMail", staffID);
            uidBox.Text = db.getstaffInfo("staffuserName", staffID);
            pwBox.Text = db.getstaffInfo("staffPassword", staffID);
            dogumtarihiBox.Value = DateTime.Parse(db.getstaffInfo("staffbirthDate", staffID));
            staffIDTxtBox.Text = staffID.ToString();


        }
    }
}
