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
    public partial class ÜyeBilgiDüzenle : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        Classes.DbCommands db = new Classes.DbCommands();
        int memberID;
        string ad, soyad, tc, eposta, dtarihi, kangrubu;
        int cinsiyet = -1, kilo = -1, boy = -1;

        private void kangrubuBox_onItemSelected(object sender, EventArgs e)
        {
            kangrubu = kangrubuBox.selectedValue;
        }

        private void cinsiyetBox_onItemSelected(object sender, EventArgs e)
        {
            cinsiyet = cinsiyetBox.selectedIndex;
        }

        private void kiloBox_onItemSelected(object sender, EventArgs e)
        {
            kilo = int.Parse(kiloBox.selectedValue.ToString());
        }

        private void boyBox_onItemSelected(object sender, EventArgs e)
        {
            boy = Int16.Parse(boyBox.selectedValue.ToString());
        }



        private void Login_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public ÜyeBilgiDüzenle(int memberID)
        {
            this.memberID = memberID;
            InitializeComponent();
            for (int i = 140; i <= 250; i++)
            {
                boyBox.AddItem(i.ToString());
            }
            for (int i = 40; i <= 140; i++)
            {
                kiloBox.AddItem(i.ToString());
            }
            if(db.getMemberInfo("memberSex", memberID)=="1")
                cinsiyetBox.SelectedItem("Erkek");
            else
                cinsiyetBox.SelectedItem("Kadın");

            adtextbox.Text = db.getMemberInfo("memberName", memberID);
            soyadTextbox.Text = db.getMemberInfo("memberSurname", memberID);
            tcTextbox.Text = db.getMemberInfo("memberTC", memberID);
            eposstaTextbox.Text= db.getMemberInfo("membereMail", memberID);
            cinsiyetBox.SelectedItem(db.getMemberInfo("memberSex", memberID));
            boyBox.SelectedItem(db.getMemberInfo("memberHeight", memberID));
            kiloBox.SelectedItem(db.getMemberInfo("memberWeight", memberID));
            kangrubuBox.SelectedItem(db.getMemberInfo("memberBloodGroup", memberID));

           
            dogumtarihiBox.Value =DateTime.Parse( db.getMemberInfo("memberBirthDate", memberID));

            staffID.Text = memberID.ToString();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

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
            ad = adtextbox.Text;
            soyad = soyadTextbox.Text;
            tc = tcTextbox.Text;
            eposta = eposstaTextbox.Text;
            dtarihi = dogumtarihiBox.Value.ToString("yyyy-MM-dd");
            kangrubu = kangrubuBox.selectedValue;
            if (db.updateMember(ad,soyad,tc,eposta,dtarihi,kangrubu,cinsiyet,kilo,boy,memberID))
            {
                MessageBox.Show("Üye Kaydedildi!");
            }
            else MessageBox.Show("Kayıt Başarısız");
        }
    }
}
