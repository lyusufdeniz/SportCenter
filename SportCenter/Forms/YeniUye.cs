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
    public partial class YeniUye : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //üye bilgileri
        string ad, soyad, tc, eposta, dtarihi, kayittarihi,kangrubu;
        int cinsiyet = 0, kilo = -1, boy = -1,planid=1;

        private void kiloBox_onItemSelected(object sender, EventArgs e)
        {
            kilo = int.Parse(kiloBox.selectedValue.ToString());
        }

        private void kangrubuBox_onItemSelected(object sender, EventArgs e)
        {
            kangrubu = kangrubuBox.selectedValue;
        }

        private void tcTextbox_OnValueChanged(object sender, EventArgs e)
        {
         
        }

        private void boyBox_onItemSelected(object sender, EventArgs e)
        {
            boy =Int16.Parse(boyBox.selectedValue.ToString());
        }

        private void uyetipiBox_onItemSelected(object sender, EventArgs e)
        {
            planid = db.getMembershipID(uyetipiBox.selectedValue);
            
        }

        private void cinsiyetBox_onItemSelected(object sender, EventArgs e)
        {
            cinsiyet = cinsiyetBox.selectedIndex;
        }

        private void üyeekle_Click(object sender, EventArgs e)
        {
            cinsiyet = cinsiyetBox.selectedIndex;
            kilo = Int16.Parse(kiloBox.selectedValue);
            boy = Int16.Parse(boyBox.selectedValue);
            foreach (Control x in this.Controls)
                {
                    if (x is Bunifu.Framework.UI.BunifuMaterialTextbox && String.IsNullOrEmpty(x.Text))
                    {
                        MessageBox.Show("Boş Alan Bırakmayın!");
                         return;
                    }
                    else
                    {
                        ad = adtextbox.Text;
                        soyad = soyadTextbox.Text;
                        tc = tcTextbox.Text;
                        eposta = eposstaTextbox.Text;
                        dtarihi = dogumtarihiBox.Value.ToString("yyyy-MM-dd");
                        kayittarihi = baslangictarihiBox.Value.ToString("yyyy-MM-dd");
                    }
                   
                }
                if (db.insertMember(ad, soyad, tc, eposta, dtarihi, kangrubu, kayittarihi, cinsiyet, kilo, boy, planid))
                {
                    MessageBox.Show("Üye Kaydedildi!");
                }
                else MessageBox.Show("Kayıt Başarısız");





            }

        

    
        private void Login_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        Classes.DbCommands db = new Classes.DbCommands();
        public YeniUye()
        {
            InitializeComponent();
            for (int i = 140; i <= 250; i++)
            {
                boyBox.AddItem(i.ToString());
            }
            for (int i = 40; i <= 140; i++)
            {
                kiloBox.AddItem(i.ToString());
            }
           for(int i=0;i<db.getMembershipPlans().Count();i++)
            {
                uyetipiBox.AddItem(db.getMembershipPlans()[i].ToString());
            }
            uyetipiBox.selectedIndex = 0;
            kiloBox.selectedIndex = 0;
            boyBox.selectedIndex = 0;
            cinsiyetBox.selectedIndex = 0;
            cinsiyet = cinsiyetBox.selectedIndex;
            kangrubu = kangrubuBox.selectedValue;
            kilo = Int32.Parse(kiloBox.selectedValue);
            boy = Int32.Parse(boyBox.selectedValue);
            
          

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = System.Windows.Forms.FormWindowState.Minimized;
      
        }
    }
}
