
namespace SportCenter.Forms
{
    partial class PersonelListesi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelListesi));
            this.label5 = new System.Windows.Forms.Label();
            this.adsoyadRadio = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tcRadio = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.searchBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.staffCategoryBox = new Bunifu.Framework.UI.BunifuDropdown();
            this.label2 = new System.Windows.Forms.Label();
            this.silinmislerigosterCheck = new Bunifu.Framework.UI.BunifuCheckbox();
            this.staffdgv = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.saveExcel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.savePDF = new Bunifu.Framework.UI.BunifuFlatButton();
            this.filtrele = new Bunifu.Framework.UI.BunifuImageButton();
            this.minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.close = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.staffdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtrele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.label5.Location = new System.Drawing.Point(553, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 83;
            this.label5.Text = "Ad Soyad";
            // 
            // adsoyadRadio
            // 
            this.adsoyadRadio.Checked = false;
            this.adsoyadRadio.Location = new System.Drawing.Point(706, 120);
            this.adsoyadRadio.Name = "adsoyadRadio";
            this.adsoyadRadio.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.adsoyadRadio.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.adsoyadRadio.Size = new System.Drawing.Size(25, 25);
            this.adsoyadRadio.TabIndex = 82;
            this.adsoyadRadio.Text = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.label4.Location = new System.Drawing.Point(553, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 81;
            this.label4.Text = "TC Kimlik No";
            // 
            // tcRadio
            // 
            this.tcRadio.Checked = true;
            this.tcRadio.Location = new System.Drawing.Point(706, 85);
            this.tcRadio.Name = "tcRadio";
            this.tcRadio.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.tcRadio.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.tcRadio.Size = new System.Drawing.Size(25, 25);
            this.tcRadio.TabIndex = 80;
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
            this.searchBox.Location = new System.Drawing.Point(742, 103);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchBox.MaxLength = 32767;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(283, 33);
            this.searchBox.TabIndex = 79;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchBox.OnValueChanged += new System.EventHandler(this.searchBox_OnValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 24);
            this.label3.TabIndex = 78;
            this.label3.Text = "Persomel Grubuna Göre Filtrele";
            // 
            // staffCategoryBox
            // 
            this.staffCategoryBox.BackColor = System.Drawing.Color.Transparent;
            this.staffCategoryBox.BorderRadius = 3;
            this.staffCategoryBox.DisabledColor = System.Drawing.Color.Gray;
            this.staffCategoryBox.ForeColor = System.Drawing.Color.White;
            this.staffCategoryBox.items = new string[] {
        "Filtre Yok"};
            this.staffCategoryBox.Location = new System.Drawing.Point(296, 112);
            this.staffCategoryBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.staffCategoryBox.Name = "staffCategoryBox";
            this.staffCategoryBox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.staffCategoryBox.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.staffCategoryBox.selectedIndex = -1;
            this.staffCategoryBox.Size = new System.Drawing.Size(150, 24);
            this.staffCategoryBox.TabIndex = 77;
            this.staffCategoryBox.onItemSelected += new System.EventHandler(this.staffCategoryBox_onItemSelected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 24);
            this.label2.TabIndex = 76;
            this.label2.Text = "Mevcut/Silinmiş Kayıtlar";
            // 
            // silinmislerigosterCheck
            // 
            this.silinmislerigosterCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.silinmislerigosterCheck.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.silinmislerigosterCheck.Checked = false;
            this.silinmislerigosterCheck.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.silinmislerigosterCheck.ForeColor = System.Drawing.Color.White;
            this.silinmislerigosterCheck.Location = new System.Drawing.Point(369, 84);
            this.silinmislerigosterCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.silinmislerigosterCheck.Name = "silinmislerigosterCheck";
            this.silinmislerigosterCheck.Size = new System.Drawing.Size(20, 20);
            this.silinmislerigosterCheck.TabIndex = 75;
            this.silinmislerigosterCheck.OnChange += new System.EventHandler(this.silinmislerigosterCheck_OnChange);
            // 
            // staffdgv
            // 
            this.staffdgv.AllowCustomTheming = false;
            this.staffdgv.AllowUserToAddRows = false;
            this.staffdgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.staffdgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.staffdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.staffdgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.staffdgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffdgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.staffdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.staffdgv.ColumnHeadersHeight = 40;
            this.staffdgv.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.staffdgv.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.staffdgv.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.staffdgv.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.staffdgv.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.staffdgv.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.staffdgv.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.staffdgv.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.staffdgv.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.staffdgv.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.staffdgv.CurrentTheme.Name = null;
            this.staffdgv.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.staffdgv.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.staffdgv.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.staffdgv.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.staffdgv.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.staffdgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.staffdgv.EnableHeadersVisualStyles = false;
            this.staffdgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.staffdgv.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.staffdgv.HeaderBgColor = System.Drawing.Color.Empty;
            this.staffdgv.HeaderForeColor = System.Drawing.Color.White;
            this.staffdgv.Location = new System.Drawing.Point(2, 161);
            this.staffdgv.Name = "staffdgv";
            this.staffdgv.ReadOnly = true;
            this.staffdgv.RowHeadersVisible = false;
            this.staffdgv.RowHeadersWidth = 51;
            this.staffdgv.RowTemplate.Height = 40;
            this.staffdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.staffdgv.Size = new System.Drawing.Size(1367, 599);
            this.staffdgv.TabIndex = 74;
            this.staffdgv.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.staffdgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffdgv_CellDoubleClick);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Enabled = false;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-35, 62);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1563, 18);
            this.bunifuSeparator1.TabIndex = 73;
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
            this.label1.Size = new System.Drawing.Size(317, 50);
            this.label1.TabIndex = 70;
            this.label1.Text = "Personel Listesi";
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
            this.saveExcel.Location = new System.Drawing.Point(1048, 121);
            this.saveExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveExcel.Name = "saveExcel";
            this.saveExcel.Normalcolor = System.Drawing.Color.Green;
            this.saveExcel.OnHovercolor = System.Drawing.Color.Green;
            this.saveExcel.OnHoverTextColor = System.Drawing.Color.White;
            this.saveExcel.selected = false;
            this.saveExcel.Size = new System.Drawing.Size(321, 33);
            this.saveExcel.TabIndex = 86;
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
            this.savePDF.IconZoom = 120D;
            this.savePDF.IsTab = false;
            this.savePDF.Location = new System.Drawing.Point(1048, 77);
            this.savePDF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.savePDF.Name = "savePDF";
            this.savePDF.Normalcolor = System.Drawing.Color.Firebrick;
            this.savePDF.OnHovercolor = System.Drawing.Color.Firebrick;
            this.savePDF.OnHoverTextColor = System.Drawing.Color.White;
            this.savePDF.selected = false;
            this.savePDF.Size = new System.Drawing.Size(321, 33);
            this.savePDF.TabIndex = 75;
            this.savePDF.Text = "PDF OLARAK DIŞA AKTAR";
            this.savePDF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savePDF.Textcolor = System.Drawing.Color.White;
            this.savePDF.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePDF.Click += new System.EventHandler(this.savePDF_Click);
            // 
            // filtrele
            // 
            this.filtrele.Image = ((System.Drawing.Image)(resources.GetObject("filtrele.Image")));
            this.filtrele.ImageActive = null;
            this.filtrele.Location = new System.Drawing.Point(484, 86);
            this.filtrele.Margin = new System.Windows.Forms.Padding(4);
            this.filtrele.Name = "filtrele";
            this.filtrele.Size = new System.Drawing.Size(57, 47);
            this.filtrele.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.filtrele.TabIndex = 84;
            this.filtrele.TabStop = false;
            this.filtrele.Zoom = 10;
            // 
            // minimize
            // 
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.ImageActive = null;
            this.minimize.Location = new System.Drawing.Point(1240, 9);
            this.minimize.Margin = new System.Windows.Forms.Padding(4);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(57, 47);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 72;
            this.minimize.TabStop = false;
            this.minimize.Zoom = 10;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.ImageActive = null;
            this.close.Location = new System.Drawing.Point(1312, 9);
            this.close.Margin = new System.Windows.Forms.Padding(4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(57, 47);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 71;
            this.close.TabStop = false;
            this.close.Zoom = 10;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // PersonelListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1366, 763);
            this.Controls.Add(this.saveExcel);
            this.Controls.Add(this.savePDF);
            this.Controls.Add(this.filtrele);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.adsoyadRadio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tcRadio);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.staffCategoryBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.silinmislerigosterCheck);
            this.Controls.Add(this.staffdgv);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonelListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelListesi";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PersonelListesi_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.staffdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtrele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton saveExcel;
        private Bunifu.Framework.UI.BunifuFlatButton savePDF;
        private Bunifu.Framework.UI.BunifuImageButton filtrele;
        private System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuRadioButton adsoyadRadio;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuRadioButton tcRadio;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchBox;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDropdown staffCategoryBox;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCheckbox silinmislerigosterCheck;
        private Bunifu.UI.WinForms.BunifuDataGridView staffdgv;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuImageButton minimize;
        private Bunifu.Framework.UI.BunifuImageButton close;
        private System.Windows.Forms.Label label1;
    }
}