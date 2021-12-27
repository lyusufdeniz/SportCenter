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
    public partial class ControlPanel : Form
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
        public ControlPanel()
        {
            InitializeComponent();
            toplamuyelabel.Text = db.countMembers().ToString();
            toplampersomellabel.Text= db.countStaff().ToString();

            toplamgelirlabel.Text = db.totalIncome()+ "\n ₺";
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {

        }

        private void toplamgelirlabel_Click(object sender, EventArgs e)
        {

        }

        private void toplamgelir_Click(object sender, EventArgs e)
        {

        }

        private void toplamuye_Click(object sender, EventArgs e)
        {

        }

        private void toplampersomellabel_Click(object sender, EventArgs e)
        {

        }

        private void toplampersonel_Click(object sender, EventArgs e)
        {

        }

        private void toplamuyelabel_Click(object sender, EventArgs e)
        {

        }

        private void vtgeriyükle_Click(object sender, EventArgs e)
        {

        }

        private void vtyedekle_Click(object sender, EventArgs e)
        {
            saveBackupDialog.Title="Yedek Alınacak Konum Girin";
            saveBackupDialog.Filter = "Backup Files | *.bak";
            saveBackupDialog.DefaultExt = ".bak";
            saveBackupDialog.ShowDialog();
            
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton13_Click(object sender, EventArgs e)
        {

        }

        private void personelduzenle_Click(object sender, EventArgs e)
        {

        }

        private void personelkategorileri_Click(object sender, EventArgs e)
        {

        }

        private void aktiviteekle_Click(object sender, EventArgs e)
        {

        }

        private void personellistesi_Click(object sender, EventArgs e)
        {

        }

        private void yenipersonel_Click(object sender, EventArgs e)
        {

        }

        private void üyelistesi_Click(object sender, EventArgs e)
        {
            ÜyeListesi üye = new ÜyeListesi();
            üye.Show();
        }

        private void üyedüzenle_Click(object sender, EventArgs e)
        {
            ÜyeDüzenle üyeDüzenle = new ÜyeDüzenle();
            üyeDüzenle.Show();
        }

        private void üyeekle_Click(object sender, EventArgs e)
        {
            YeniUye yeniUye = new YeniUye();
            yeniUye.Show();
        }

        private void saveBackupDialog_FileOk(object sender, CancelEventArgs e)
        {

           if( db.backup(saveBackupDialog.FileName))
            {
                MessageBox.Show(saveBackupDialog.FileName+" VERİTABANI YEDEKLENDİ ");
            }

        }
    }
}
