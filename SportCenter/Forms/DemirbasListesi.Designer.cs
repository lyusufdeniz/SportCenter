
namespace SportCenter.Forms
{
    partial class DemirbasListesi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemirbasListesi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.saveExcel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.savePDF = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tcRadio = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.searchBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.demirbasdgv = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.close = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // saveExcel
            // 
            this.saveExcel.Active = false;
            this.saveExcel.Activecolor = System.Drawing.Color.Green;
            this.saveExcel.BackColor = System.Drawing.Color.Green;
            this.saveExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveExcel.BorderRadius = 0;
            this.saveExcel.ButtonText = "EXCEL OLARAK DIŞARI AKTAR";
            this.saveExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveExcel.DisabledColor = System.Drawing.Color.Gray;
            this.saveExcel.Iconcolor = System.Drawing.Color.Transparent;
            this.saveExcel.Iconimage = ((System.Drawing.Image)(resources.GetObject("saveExcel.Iconimage")));
            this.saveExcel.Iconimage_right = null;
            this.saveExcel.Iconimage_right_Selected = null;
            this.saveExcel.Iconimage_Selected = null;
            this.saveExcel.IconMarginLeft = 0;
            this.saveExcel.IconMarginRight = 0;
            this.saveExcel.IconRightVisible = true;
            this.saveExcel.IconRightZoom = 0D;
            this.saveExcel.IconVisible = true;
            this.saveExcel.IconZoom = 90D;
            this.saveExcel.IsTab = false;
            this.saveExcel.Location = new System.Drawing.Point(897, 88);
            this.saveExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveExcel.Name = "saveExcel";
            this.saveExcel.Normalcolor = System.Drawing.Color.Green;
            this.saveExcel.OnHovercolor = System.Drawing.Color.Green;
            this.saveExcel.OnHoverTextColor = System.Drawing.Color.White;
            this.saveExcel.selected = false;
            this.saveExcel.Size = new System.Drawing.Size(321, 31);
            this.saveExcel.TabIndex = 75;
            this.saveExcel.Text = "EXCEL OLARAK DIŞARI AKTAR";
            this.saveExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveExcel.Textcolor = System.Drawing.Color.White;
            this.saveExcel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveExcel.Click += new System.EventHandler(this.saveExcel_Click);
            // 
            // savePDF
            // 
            this.savePDF.Active = false;
            this.savePDF.Activecolor = System.Drawing.Color.Firebrick;
            this.savePDF.BackColor = System.Drawing.Color.Firebrick;
            this.savePDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.savePDF.BorderRadius = 0;
            this.savePDF.ButtonText = "PDF OLARAK DIŞA AKTAR";
            this.savePDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savePDF.DisabledColor = System.Drawing.Color.Gray;
            this.savePDF.Iconcolor = System.Drawing.Color.Transparent;
            this.savePDF.Iconimage = ((System.Drawing.Image)(resources.GetObject("savePDF.Iconimage")));
            this.savePDF.Iconimage_right = null;
            this.savePDF.Iconimage_right_Selected = null;
            this.savePDF.Iconimage_Selected = null;
            this.savePDF.IconMarginLeft = 0;
            this.savePDF.IconMarginRight = 0;
            this.savePDF.IconRightVisible = true;
            this.savePDF.IconRightZoom = 0D;
            this.savePDF.IconVisible = true;
            this.savePDF.IconZoom = 90D;
            this.savePDF.IsTab = false;
            this.savePDF.Location = new System.Drawing.Point(897, 127);
            this.savePDF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.savePDF.Name = "savePDF";
            this.savePDF.Normalcolor = System.Drawing.Color.Firebrick;
            this.savePDF.OnHovercolor = System.Drawing.Color.Firebrick;
            this.savePDF.OnHoverTextColor = System.Drawing.Color.White;
            this.savePDF.selected = false;
            this.savePDF.Size = new System.Drawing.Size(321, 31);
            this.savePDF.TabIndex = 74;
            this.savePDF.Text = "PDF OLARAK DIŞA AKTAR";
            this.savePDF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savePDF.Textcolor = System.Drawing.Color.White;
            this.savePDF.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePDF.Click += new System.EventHandler(this.savePDF_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 24);
            this.label4.TabIndex = 73;
            this.label4.Text = "Aktivitiye Göre Ara";
            // 
            // tcRadio
            // 
            this.tcRadio.Checked = true;
            this.tcRadio.Location = new System.Drawing.Point(218, 106);
            this.tcRadio.Name = "tcRadio";
            this.tcRadio.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.tcRadio.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.tcRadio.Size = new System.Drawing.Size(25, 25);
            this.tcRadio.TabIndex = 72;
            this.tcRadio.Text = null;
            // 
            // searchBox
            // 
            this.searchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.searchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.searchBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.searchBox.ForeColor = System.Drawing.Color.White;
            this.searchBox.HintForeColor = System.Drawing.Color.White;
            this.searchBox.HintText = "Arana Kriteri Girin";
            this.searchBox.isPassword = false;
            this.searchBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.searchBox.LineIdleColor = System.Drawing.Color.Gray;
            this.searchBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.searchBox.LineThickness = 3;
            this.searchBox.Location = new System.Drawing.Point(294, 95);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchBox.MaxLength = 32767;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(461, 36);
            this.searchBox.TabIndex = 71;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchBox.OnValueChanged += new System.EventHandler(this.searchBox_OnValueChanged);
            // 
            // demirbasdgv
            // 
            this.demirbasdgv.AllowCustomTheming = false;
            this.demirbasdgv.AllowUserToAddRows = false;
            this.demirbasdgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.demirbasdgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.demirbasdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.demirbasdgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.demirbasdgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.demirbasdgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.demirbasdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.demirbasdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.demirbasdgv.ColumnHeadersHeight = 40;
            this.demirbasdgv.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.demirbasdgv.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.demirbasdgv.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.demirbasdgv.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.demirbasdgv.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.demirbasdgv.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.demirbasdgv.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.demirbasdgv.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.demirbasdgv.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.demirbasdgv.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.demirbasdgv.CurrentTheme.Name = null;
            this.demirbasdgv.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.demirbasdgv.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.demirbasdgv.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.demirbasdgv.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.demirbasdgv.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.demirbasdgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.demirbasdgv.EnableHeadersVisualStyles = false;
            this.demirbasdgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.demirbasdgv.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.demirbasdgv.HeaderBgColor = System.Drawing.Color.Empty;
            this.demirbasdgv.HeaderForeColor = System.Drawing.Color.White;
            this.demirbasdgv.Location = new System.Drawing.Point(2, 165);
            this.demirbasdgv.Name = "demirbasdgv";
            this.demirbasdgv.ReadOnly = true;
            this.demirbasdgv.RowHeadersVisible = false;
            this.demirbasdgv.RowHeadersWidth = 51;
            this.demirbasdgv.RowTemplate.Height = 40;
            this.demirbasdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.demirbasdgv.Size = new System.Drawing.Size(1225, 497);
            this.demirbasdgv.TabIndex = 70;
            this.demirbasdgv.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Enabled = false;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-1, 62);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1563, 18);
            this.bunifuSeparator1.TabIndex = 77;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 50);
            this.label1.TabIndex = 76;
            this.label1.Text = "Demirbaş Listesi";
            // 
            // minimize
            // 
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.ImageActive = null;
            this.minimize.Location = new System.Drawing.Point(1096, 12);
            this.minimize.Margin = new System.Windows.Forms.Padding(4);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(57, 47);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 79;
            this.minimize.TabStop = false;
            this.minimize.Zoom = 10;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.ImageActive = null;
            this.close.Location = new System.Drawing.Point(1161, 12);
            this.close.Margin = new System.Windows.Forms.Padding(4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(57, 47);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 78;
            this.close.TabStop = false;
            this.close.Zoom = 10;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // DemirbasListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1231, 659);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.close);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveExcel);
            this.Controls.Add(this.savePDF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tcRadio);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.demirbasdgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DemirbasListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demirbaş Listesi";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.demirbasdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton saveExcel;
        private Bunifu.Framework.UI.BunifuFlatButton savePDF;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuRadioButton tcRadio;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchBox;
        private Bunifu.UI.WinForms.BunifuDataGridView demirbasdgv;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton minimize;
        private Bunifu.Framework.UI.BunifuImageButton close;
    }
}