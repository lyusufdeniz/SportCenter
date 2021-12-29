using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportCenter.Forms
{
    public partial class ÜyeLogListesi : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        Classes.DbCommands db = new Classes.DbCommands();
        string sexFilter="",activityFilter="";
        private void Login_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public ÜyeLogListesi()
        {
            InitializeComponent();
            for (int i = 0; i < db.getActivityList().Count(); i++)
            {
                activityBox.AddItem(db.getActivityList()[i].ToString());
            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ÜyeLogListesi_Load(object sender, EventArgs e)
        {
            logdgv.DataSource = db.getLogTable(activityFilter, sexFilter).Tables[0].DefaultView;

        }

        private void searchBox_OnValueChanged(object sender, EventArgs e)
        {
            if (adsoyadRadio.Checked)
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = db.getmemberTableWithFilters("", "").Tables[0].DefaultView;

                bs.Filter = "[Adı Soyadı] like '%" + searchBox.Text + "%' ";
                logdgv.DataSource = bs;
            }
            if (tcRadio.Checked)
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = db.getmemberTableWithFilters("", "").Tables[0].DefaultView;
                bs.Filter = "[Üye TC] like '%" + searchBox.Text + "%' ";
                logdgv.DataSource = bs;
            }
        }

        private void activityBox_onItemSelected(object sender, EventArgs e)
        {
            if (activityBox.selectedIndex != 0)
            {
                activityFilter = db.getActivityID(activityBox.selectedValue).ToString();
            }
            else activityFilter = "";
        }

        private void filtrele_Click(object sender, EventArgs e)
        {
            logdgv.DataSource = db.getLogTable(activityFilter,sexFilter).Tables[0].DefaultView;
        }

        private void savePDF_Click(object sender, EventArgs e)
        {
            if (logdgv.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(logdgv.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;


                            foreach (DataGridViewColumn column in logdgv.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in logdgv.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());

                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A3, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Pdf Olarak Dışarı Aktarıldı !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Dışa aktarılacak kayıt yok!", "Info");
            }
        }

        private void saveExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Title = "Excel Dosyaları";
            save.FileName = "output";
            save.DefaultExt = "xlsx";
            save.Filter = "xlsx Dosyaları (*.xlsx)|*.xlsx|Tüm Dosyalar(*.*)|*.*";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sayfa1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Excel Dışa Aktarım";
                for (int i = 1; i < logdgv.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = logdgv.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < logdgv.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < logdgv.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = logdgv.Rows[i].Cells[j].Value.ToString();
                    }
                }
                workbook.SaveAs(save.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();
            }
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
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
    }
}
