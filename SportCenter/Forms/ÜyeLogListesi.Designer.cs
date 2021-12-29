
namespace SportCenter.Forms
{
    partial class ÜyeLogListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÜyeLogListesi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.saveExcel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.savePDF = new Bunifu.Framework.UI.BunifuFlatButton();
            this.filtrele = new Bunifu.Framework.UI.BunifuImageButton();
            this.label5 = new System.Windows.Forms.Label();
            this.adsoyadRadio = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tcRadio = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.searchBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.activityBox = new Bunifu.Framework.UI.BunifuDropdown();
            this.logdgv = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.close = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cinsiyet = new Bunifu.Framework.UI.BunifuDropdown();
            ((System.ComponentModel.ISupportInitialize)(this.filtrele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logdgv)).BeginInit();
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
            this.saveExcel.Location = new System.Drawing.Point(1048, 121);
            this.saveExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveExcel.Name = "saveExcel";
            this.saveExcel.Normalcolor = System.Drawing.Color.Green;
            this.saveExcel.OnHovercolor = System.Drawing.Color.Green;
            this.saveExcel.OnHoverTextColor = System.Drawing.Color.White;
            this.saveExcel.selected = false;
            this.saveExcel.Size = new System.Drawing.Size(321, 33);
            this.saveExcel.TabIndex = 103;
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
            this.savePDF.TabIndex = 92;
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
            this.filtrele.TabIndex = 102;
            this.filtrele.TabStop = false;
            this.filtrele.Zoom = 10;
            this.filtrele.Click += new System.EventHandler(this.filtrele_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.label5.Location = new System.Drawing.Point(553, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 101;
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
            this.adsoyadRadio.TabIndex = 100;
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
            this.label4.TabIndex = 99;
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
            this.tcRadio.TabIndex = 98;
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
            this.searchBox.TabIndex = 97;
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
            this.label3.Size = new System.Drawing.Size(206, 24);
            this.label3.TabIndex = 96;
            this.label3.Text = "Aktiviteye Göre Filtrele";
            // 
            // activityBox
            // 
            this.activityBox.BackColor = System.Drawing.Color.Transparent;
            this.activityBox.BorderRadius = 3;
            this.activityBox.DisabledColor = System.Drawing.Color.Gray;
            this.activityBox.ForeColor = System.Drawing.Color.White;
            this.activityBox.items = new string[] {
        "Filtre Yok"};
            this.activityBox.Location = new System.Drawing.Point(296, 112);
            this.activityBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activityBox.Name = "activityBox";
            this.activityBox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.activityBox.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.activityBox.selectedIndex = 0;
            this.activityBox.Size = new System.Drawing.Size(150, 24);
            this.activityBox.TabIndex = 95;
            this.activityBox.onItemSelected += new System.EventHandler(this.activityBox_onItemSelected);
            // 
            // logdgv
            // 
            this.logdgv.AllowCustomTheming = false;
            this.logdgv.AllowUserToAddRows = false;
            this.logdgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.logdgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.logdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.logdgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.logdgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logdgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.logdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.logdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.logdgv.ColumnHeadersHeight = 40;
            this.logdgv.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.logdgv.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.logdgv.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.logdgv.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.logdgv.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.logdgv.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.logdgv.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.logdgv.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.logdgv.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.logdgv.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.logdgv.CurrentTheme.Name = null;
            this.logdgv.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.logdgv.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.logdgv.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.logdgv.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.logdgv.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.logdgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.logdgv.EnableHeadersVisualStyles = false;
            this.logdgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.logdgv.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.logdgv.HeaderBgColor = System.Drawing.Color.Empty;
            this.logdgv.HeaderForeColor = System.Drawing.Color.White;
            this.logdgv.Location = new System.Drawing.Point(2, 161);
            this.logdgv.Name = "logdgv";
            this.logdgv.ReadOnly = true;
            this.logdgv.RowHeadersVisible = false;
            this.logdgv.RowHeadersWidth = 51;
            this.logdgv.RowTemplate.Height = 40;
            this.logdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.logdgv.Size = new System.Drawing.Size(1367, 599);
            this.logdgv.TabIndex = 91;
            this.logdgv.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
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
            this.bunifuSeparator1.TabIndex = 90;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // minimize
            // 
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.ImageActive = null;
            this.minimize.Location = new System.Drawing.Point(1247, 9);
            this.minimize.Margin = new System.Windows.Forms.Padding(4);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(57, 47);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 89;
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
            this.close.TabIndex = 88;
            this.close.TabStop = false;
            this.close.Zoom = 10;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 50);
            this.label1.TabIndex = 87;
            this.label1.Text = "Giriş/Çıkış Kayıtları";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 24);
            this.label2.TabIndex = 105;
            this.label2.Text = "Cinsiyete Göre Filtrele";
            // 
            // cinsiyet
            // 
            this.cinsiyet.BackColor = System.Drawing.Color.Transparent;
            this.cinsiyet.BorderRadius = 3;
            this.cinsiyet.DisabledColor = System.Drawing.Color.Gray;
            this.cinsiyet.ForeColor = System.Drawing.Color.White;
            this.cinsiyet.items = new string[] {
        "Filtre Yok",
        "Erkek",
        "Kadın"};
            this.cinsiyet.Location = new System.Drawing.Point(296, 85);
            this.cinsiyet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cinsiyet.Name = "cinsiyet";
            this.cinsiyet.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.cinsiyet.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.cinsiyet.selectedIndex = 0;
            this.cinsiyet.Size = new System.Drawing.Size(150, 24);
            this.cinsiyet.TabIndex = 104;
            this.cinsiyet.onItemSelected += new System.EventHandler(this.bunifuDropdown1_onItemSelected);
            // 
            // ÜyeLogListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1366, 763);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cinsiyet);
            this.Controls.Add(this.saveExcel);
            this.Controls.Add(this.savePDF);
            this.Controls.Add(this.filtrele);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.adsoyadRadio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tcRadio);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.activityBox);
            this.Controls.Add(this.logdgv);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ÜyeLogListesi";
            this.Text = "ÜyeLogListesi";
            this.Load += new System.EventHandler(this.ÜyeLogListesi_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.filtrele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logdgv)).EndInit();
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
        private Bunifu.Framework.UI.BunifuDropdown activityBox;
        private Bunifu.UI.WinForms.BunifuDataGridView logdgv;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuImageButton minimize;
        private Bunifu.Framework.UI.BunifuImageButton close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDropdown cinsiyet;
    }
}