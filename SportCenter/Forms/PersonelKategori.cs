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
    public partial class PersonelKategori : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        Classes.DbCommands db = new Classes.DbCommands();
        int insertpermission = 2;
        string insertname="";
        string updatenewname,updateselectedcategoryname;
        int updatepermission;
        private void Login_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public PersonelKategori()
        {
            InitializeComponent();
           selectForEdit.Clear();
            selectForEdit.AddItem("Düzenlenecek Grup Seçiniz");
            for (int i = 0; i < db.getStaffCategories().Count; i++)
            {
                selectForEdit.AddItem(db.getStaffCategories()[i]);
            }
        }

        private void insertnoaccesradio_Click(object sender, EventArgs e)
        {
            insertpermission = 2;
        }

        private void insertpersonelradio_Click(object sender, EventArgs e)
        {
            insertpermission = 1;
        }

        private void insertfullacces_Click(object sender, EventArgs e)
        {
            insertpermission = 0;
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void insert_Click(object sender, EventArgs e)
        {
            insertname = insertgroupnameBox.Text;
            if (insertname=="")
            {
                MessageBox.Show("Ad Alanı boş olamaz!");
                return;
            }

            if (db.insertnewStaffGroup(insertname,insertpermission))
                {
                MessageBox.Show("Grup Eklendi");
            }
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectForEdit_onItemSelected(object sender, EventArgs e)
        {
            if(selectForEdit.selectedIndex!=0)
            {
                updateselectedcategoryname = selectForEdit.selectedValue;
                updateNewNameBox.Text = db.getstaffcategoryInfo("categoryName", updateselectedcategoryname);
                if(db.getstaffcategoryInfo("categoryPermission", updateselectedcategoryname)=="0")
                {
                    updatePersonelAcces.Checked = false;
                    updateNoAcces.Checked = false;
                    updateFullAcces.Checked = true;
                }
                if (db.getstaffcategoryInfo("categoryPermission", updateselectedcategoryname) == "1")
                {
                    updateNoAcces.Checked = false; 
                    updateFullAcces.Checked = false;
                    updatePersonelAcces.Checked = true;
                }
                if (db.getstaffcategoryInfo("categoryPermission", updateselectedcategoryname) == "2")
                {
                    updateFullAcces.Checked = false;
                    updatePersonelAcces.Checked = false;
                    updateNoAcces.Checked = true;
                }
            }
        }

        private void updatePersonelAcces_Click(object sender, EventArgs e)
        {
            updatepermission = 1;
        }

        private void updateNoAcces_Click(object sender, EventArgs e)
        {
            updatepermission = 2;
        }

        private void updateFullAcces_Click(object sender, EventArgs e)
        {
            updatepermission = 0;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            selectForEdit.Clear();
            selectForEdit.AddItem("Düzenlenecek Grup Seçiniz");
            selectForEdit.SelectedItem("Düzenlenecek Grup Seçiniz");
            for (int i = 0; i < db.getStaffCategories().Count; i++)
            {
                selectForEdit.AddItem(db.getStaffCategories()[i]);
            }
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            updatenewname = updateNewNameBox.Text;
            if(updatenewname=="")
            {
                MessageBox.Show("Ad Alanı Boş Olamaz"); return;
            }
            if(db.updateStaffGroup(updateselectedcategoryname,updatenewname,updatepermission))
            {
                MessageBox.Show("Kayıt Düzenlendi");
            }
        }
    }
}
