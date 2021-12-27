using iTextSharp.text.pdf;
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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Data.Linq;

namespace SportCenter.Forms
{
    public partial class ÜyeListesi : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        Classes.DbCommands db = new Classes.DbCommands();
        string sexFilter = "", isActiveFilter = "";
        private void Login_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public ÜyeListesi()
        {
            InitializeComponent();
            memberdgv.DataSource = db.getmemberTableWithFilters("", "").Tables[0].DefaultView;
        }

        private void close_Click_1(object sender, EventArgs e)
        {
            this.Hide();
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
            if (cinsiyet.selectedIndex == 0)
            {
                sexFilter = "";
            }
            else if (cinsiyet.selectedIndex == 1)
            {
                sexFilter = "1";
            }
            else if (cinsiyet.selectedIndex == 2)
            {
                sexFilter = "0";
            }
        }

        private void filtrele_Click(object sender, EventArgs e)
        {

            memberdgv.DataSource = db.getmemberTableWithFilters(sexFilter, isActiveFilter).Tables[0].DefaultView;
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(memberdgv.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in memberdgv.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in memberdgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }

            //Exporting to PDF
            string folderPath = "C:\\PDFs\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "DataGridViewExport.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
          
        }

        private void minimize_Click_1(object sender, EventArgs e)
        {
            WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }
    }
}
