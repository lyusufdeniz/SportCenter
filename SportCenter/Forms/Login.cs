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

namespace SportCenter
{
    public partial class Login : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
      
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        Classes.DbCommands db = new Classes.DbCommands();

        private void Login_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public Login()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(uidBox.Text.Length==0||pwBox.Text.Length==0)
            {
                MessageBox.Show("Lütfen Kullanıcı Adı Ve Şifre Bölümlerini Doldurun!");
            }
            else
            {
                if(db.staffLogin(uidBox.Text,pwBox.Text))
                {
                    if(db.checkstaffPermission()==0)
                    {
                        MessageBox.Show("Sistem Yöneticisi Girişi Başarılı");
                        Forms.ControlPanel ap = new Forms.ControlPanel(0);
                        ap.Show();
                        WindowState = System.Windows.Forms.FormWindowState.Minimized;
                    }
                    if (db.checkstaffPermission() == 1)
                    {
                        MessageBox.Show(" Personel Girişi Başarılı");
                        Forms.ControlPanel ap = new Forms.ControlPanel(1);
                        ap.Show();
                        WindowState = System.Windows.Forms.FormWindowState.Minimized;
                    }
                    if (db.checkstaffPermission() == 2)
                    {
                        MessageBox.Show("Personelin Sisteme Giriş yetkisi bulunmuyor hata olduğunu düşünüyorsanız sistem yöneticisine başvurun");
                        WindowState = System.Windows.Forms.FormWindowState.Minimized;
                    }

                }
                else
                {
                    MessageBox.Show("Hatalı Giriş");
                }
            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }
    }
}
