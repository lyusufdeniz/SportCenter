using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Office.Interop.Excel;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;


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

        private void savePDF_Click(object sender, EventArgs e)
        {
            if (memberdgv.Rows.Count > 0)
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
                            PdfPTable pdfTable = new PdfPTable(memberdgv.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                          

                            foreach (DataGridViewColumn column in memberdgv.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in memberdgv.Rows)
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
                for (int i = 1; i < memberdgv.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = memberdgv.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < memberdgv.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < memberdgv.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = memberdgv.Rows[i].Cells[j].Value.ToString();
                    }
                }
                workbook.SaveAs(save.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();
            }
        }

        private void memberdgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int memberID = Int32.Parse(memberdgv.CurrentRow.Cells[0].Value.ToString());
            ÜyeBilgiDüzenle duzenle = new ÜyeBilgiDüzenle(memberID);
            duzenle.Show();
            duzenle.FormClosed += duzenle_FormClosed;
        }

        private void minimize_Click_1(object sender, EventArgs e)
        {
            WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }
        private void duzenle_FormClosed(object sender, FormClosedEventArgs e)
        {
            memberdgv.DataSource = db.getmemberTableWithFilters(sexFilter, isActiveFilter).Tables[0].DefaultView;
        }
    }
}
