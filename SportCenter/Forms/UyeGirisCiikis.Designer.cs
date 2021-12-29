
namespace SportCenter.Forms
{
    partial class UyeGirisCiikis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeGirisCiikis));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.memberdgv = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.adsoyadRadio = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tcRadio = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.searchBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.logButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logtoutButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.activitiesBox = new Bunifu.Framework.UI.BunifuDropdown();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // minimize
            // 
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.ImageActive = null;
            this.minimize.Location = new System.Drawing.Point(983, 13);
            this.minimize.Margin = new System.Windows.Forms.Padding(4);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(57, 47);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 37;
            this.minimize.TabStop = false;
            this.minimize.Zoom = 10;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Enabled = false;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-3, 64);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1120, 10);
            this.bunifuSeparator1.TabIndex = 36;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1048, 13);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(57, 47);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 35;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 50);
            this.label1.TabIndex = 34;
            this.label1.Text = "Üye Giriş Çıkış";
            // 
            // memberdgv
            // 
            this.memberdgv.AllowCustomTheming = false;
            this.memberdgv.AllowUserToAddRows = false;
            this.memberdgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.memberdgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.memberdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.memberdgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.memberdgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.memberdgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.memberdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.memberdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.memberdgv.ColumnHeadersHeight = 40;
            this.memberdgv.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.memberdgv.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.memberdgv.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.memberdgv.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.memberdgv.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.memberdgv.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.memberdgv.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.memberdgv.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.memberdgv.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.memberdgv.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.memberdgv.CurrentTheme.Name = null;
            this.memberdgv.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.memberdgv.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.memberdgv.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.memberdgv.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.memberdgv.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.memberdgv.DefaultCellStyle = dataGridViewCellStyle15;
            this.memberdgv.EnableHeadersVisualStyles = false;
            this.memberdgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.memberdgv.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.memberdgv.HeaderBgColor = System.Drawing.Color.Empty;
            this.memberdgv.HeaderForeColor = System.Drawing.Color.White;
            this.memberdgv.Location = new System.Drawing.Point(-3, 180);
            this.memberdgv.Name = "memberdgv";
            this.memberdgv.ReadOnly = true;
            this.memberdgv.RowHeadersVisible = false;
            this.memberdgv.RowHeadersWidth = 51;
            this.memberdgv.RowTemplate.Height = 40;
            this.memberdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.memberdgv.Size = new System.Drawing.Size(1120, 414);
            this.memberdgv.TabIndex = 58;
            this.memberdgv.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.memberdgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.memberdgv_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.label5.Location = new System.Drawing.Point(5, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 71;
            this.label5.Text = "Ad Soyad";
            // 
            // adsoyadRadio
            // 
            this.adsoyadRadio.Checked = false;
            this.adsoyadRadio.Location = new System.Drawing.Point(158, 112);
            this.adsoyadRadio.Name = "adsoyadRadio";
            this.adsoyadRadio.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.adsoyadRadio.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.adsoyadRadio.Size = new System.Drawing.Size(25, 25);
            this.adsoyadRadio.TabIndex = 70;
            this.adsoyadRadio.Text = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.label4.Location = new System.Drawing.Point(5, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 69;
            this.label4.Text = "TC Kimlik No";
            // 
            // tcRadio
            // 
            this.tcRadio.Checked = true;
            this.tcRadio.Location = new System.Drawing.Point(158, 77);
            this.tcRadio.Name = "tcRadio";
            this.tcRadio.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.tcRadio.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.tcRadio.Size = new System.Drawing.Size(25, 25);
            this.tcRadio.TabIndex = 68;
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
            this.searchBox.Location = new System.Drawing.Point(190, 83);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchBox.MaxLength = 32767;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(283, 33);
            this.searchBox.TabIndex = 67;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchBox.OnValueChanged += new System.EventHandler(this.searchBox_OnValueChanged);
            // 
            // logButton
            // 
            this.logButton.Active = false;
            this.logButton.Activecolor = System.Drawing.Color.Green;
            this.logButton.BackColor = System.Drawing.Color.Green;
            this.logButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logButton.BorderRadius = 0;
            this.logButton.ButtonText = "Giriş Yap";
            this.logButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logButton.DisabledColor = System.Drawing.Color.Gray;
            this.logButton.Iconcolor = System.Drawing.Color.Transparent;
            this.logButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("logButton.Iconimage")));
            this.logButton.Iconimage_right = null;
            this.logButton.Iconimage_right_Selected = null;
            this.logButton.Iconimage_Selected = null;
            this.logButton.IconMarginLeft = 0;
            this.logButton.IconMarginRight = 0;
            this.logButton.IconRightVisible = true;
            this.logButton.IconRightZoom = 0D;
            this.logButton.IconVisible = true;
            this.logButton.IconZoom = 90D;
            this.logButton.IsTab = false;
            this.logButton.Location = new System.Drawing.Point(840, 78);
            this.logButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logButton.Name = "logButton";
            this.logButton.Normalcolor = System.Drawing.Color.Green;
            this.logButton.OnHovercolor = System.Drawing.Color.Green;
            this.logButton.OnHoverTextColor = System.Drawing.Color.White;
            this.logButton.selected = false;
            this.logButton.Size = new System.Drawing.Size(265, 33);
            this.logButton.TabIndex = 73;
            this.logButton.Text = "Giriş Yap";
            this.logButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logButton.Textcolor = System.Drawing.Color.White;
            this.logButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // logtoutButton
            // 
            this.logtoutButton.Active = false;
            this.logtoutButton.Activecolor = System.Drawing.Color.Firebrick;
            this.logtoutButton.BackColor = System.Drawing.Color.Firebrick;
            this.logtoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logtoutButton.BorderRadius = 0;
            this.logtoutButton.ButtonText = "Çıkış Yap";
            this.logtoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logtoutButton.DisabledColor = System.Drawing.Color.Gray;
            this.logtoutButton.Iconcolor = System.Drawing.Color.Transparent;
            this.logtoutButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("logtoutButton.Iconimage")));
            this.logtoutButton.Iconimage_right = null;
            this.logtoutButton.Iconimage_right_Selected = null;
            this.logtoutButton.Iconimage_Selected = null;
            this.logtoutButton.IconMarginLeft = 0;
            this.logtoutButton.IconMarginRight = 0;
            this.logtoutButton.IconRightVisible = true;
            this.logtoutButton.IconRightZoom = 0D;
            this.logtoutButton.IconVisible = true;
            this.logtoutButton.IconZoom = 60D;
            this.logtoutButton.IsTab = false;
            this.logtoutButton.Location = new System.Drawing.Point(840, 119);
            this.logtoutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logtoutButton.Name = "logtoutButton";
            this.logtoutButton.Normalcolor = System.Drawing.Color.Firebrick;
            this.logtoutButton.OnHovercolor = System.Drawing.Color.Firebrick;
            this.logtoutButton.OnHoverTextColor = System.Drawing.Color.White;
            this.logtoutButton.selected = false;
            this.logtoutButton.Size = new System.Drawing.Size(265, 33);
            this.logtoutButton.TabIndex = 72;
            this.logtoutButton.Text = "Çıkış Yap";
            this.logtoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logtoutButton.Textcolor = System.Drawing.Color.White;
            this.logtoutButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logtoutButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // activitiesBox
            // 
            this.activitiesBox.BackColor = System.Drawing.Color.Transparent;
            this.activitiesBox.BorderRadius = 3;
            this.activitiesBox.DisabledColor = System.Drawing.Color.Gray;
            this.activitiesBox.ForeColor = System.Drawing.Color.White;
            this.activitiesBox.items = new string[] {
        "Aktivite Seçiniz"};
            this.activitiesBox.Location = new System.Drawing.Point(516, 83);
            this.activitiesBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activitiesBox.Name = "activitiesBox";
            this.activitiesBox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.activitiesBox.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.activitiesBox.selectedIndex = 0;
            this.activitiesBox.Size = new System.Drawing.Size(289, 43);
            this.activitiesBox.TabIndex = 74;
            this.activitiesBox.onItemSelected += new System.EventHandler(this.activitiesBox_onItemSelected);
            // 
            // UyeGirisCiikis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1122, 591);
            this.Controls.Add(this.activitiesBox);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.logtoutButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.adsoyadRadio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tcRadio);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.memberdgv);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UyeGirisCiikis";
            this.Text = "UyeGirisCiikis";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton minimize;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDataGridView memberdgv;
        private System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuRadioButton adsoyadRadio;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuRadioButton tcRadio;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchBox;
        private Bunifu.Framework.UI.BunifuFlatButton logButton;
        private Bunifu.Framework.UI.BunifuFlatButton logtoutButton;
        private Bunifu.Framework.UI.BunifuDropdown activitiesBox;
    }
}