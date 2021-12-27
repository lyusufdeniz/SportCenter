
namespace SportCenter.Forms
{
    partial class ÜyeDüzenle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÜyeDüzenle));
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.memberdgv = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.sadeceaktifcheckbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label2 = new System.Windows.Forms.Label();
            this.cinsiyet = new Bunifu.Framework.UI.BunifuDropdown();
            this.label3 = new System.Windows.Forms.Label();
            this.searchBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tcRadio = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.adsoyadRadio = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.filtrele = new Bunifu.Framework.UI.BunifuImageButton();
            this.minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.close = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.memberdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtrele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Enabled = false;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-71, 65);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1563, 18);
            this.bunifuSeparator1.TabIndex = 40;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 50);
            this.label1.TabIndex = 37;
            this.label1.Text = "Düzenlenecek Üye Seçiniz";
            // 
            // memberdgv
            // 
            this.memberdgv.AllowCustomTheming = false;
            this.memberdgv.AllowUserToAddRows = false;
            this.memberdgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.memberdgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.memberdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.memberdgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.memberdgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.memberdgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.memberdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.memberdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.memberdgv.ColumnHeadersHeight = 50;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.memberdgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.memberdgv.EnableHeadersVisualStyles = false;
            this.memberdgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.memberdgv.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.memberdgv.HeaderBgColor = System.Drawing.Color.Empty;
            this.memberdgv.HeaderForeColor = System.Drawing.Color.White;
            this.memberdgv.Location = new System.Drawing.Point(0, 161);
            this.memberdgv.Name = "memberdgv";
            this.memberdgv.ReadOnly = true;
            this.memberdgv.RowHeadersVisible = false;
            this.memberdgv.RowHeadersWidth = 51;
            this.memberdgv.RowTemplate.Height = 40;
            this.memberdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.memberdgv.Size = new System.Drawing.Size(1492, 608);
            this.memberdgv.TabIndex = 41;
            this.memberdgv.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.memberdgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.memberdgv_CellDoubleClick);
            // 
            // sadeceaktifcheckbox
            // 
            this.sadeceaktifcheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.sadeceaktifcheckbox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.sadeceaktifcheckbox.Checked = false;
            this.sadeceaktifcheckbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.sadeceaktifcheckbox.ForeColor = System.Drawing.Color.White;
            this.sadeceaktifcheckbox.Location = new System.Drawing.Point(333, 87);
            this.sadeceaktifcheckbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sadeceaktifcheckbox.Name = "sadeceaktifcheckbox";
            this.sadeceaktifcheckbox.Size = new System.Drawing.Size(20, 20);
            this.sadeceaktifcheckbox.TabIndex = 42;
            this.sadeceaktifcheckbox.OnChange += new System.EventHandler(this.sadeceaktifcheckbox_OnChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 24);
            this.label2.TabIndex = 43;
            this.label2.Text = "Sadece Aktif Üyeleri Göster";
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
            this.cinsiyet.Location = new System.Drawing.Point(215, 115);
            this.cinsiyet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cinsiyet.Name = "cinsiyet";
            this.cinsiyet.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.cinsiyet.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.cinsiyet.selectedIndex = 0;
            this.cinsiyet.Size = new System.Drawing.Size(150, 24);
            this.cinsiyet.TabIndex = 44;
            this.cinsiyet.onItemSelected += new System.EventHandler(this.cinsiyet_onItemSelected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 24);
            this.label3.TabIndex = 45;
            this.label3.Text = "Cinsiyete Göre Filtrele";
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
            this.searchBox.Location = new System.Drawing.Point(775, 106);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchBox.MaxLength = 32767;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(436, 33);
            this.searchBox.TabIndex = 46;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchBox.OnValueChanged += new System.EventHandler(this.searchBox_OnValueChanged);
            // 
            // tcRadio
            // 
            this.tcRadio.Checked = true;
            this.tcRadio.Location = new System.Drawing.Point(739, 88);
            this.tcRadio.Name = "tcRadio";
            this.tcRadio.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.tcRadio.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.tcRadio.Size = new System.Drawing.Size(25, 25);
            this.tcRadio.TabIndex = 47;
            this.tcRadio.Text = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.label4.Location = new System.Drawing.Point(586, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 48;
            this.label4.Text = "TC Kimlik No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.label5.Location = new System.Drawing.Point(586, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 50;
            this.label5.Text = "Ad Soyad";
            // 
            // adsoyadRadio
            // 
            this.adsoyadRadio.Checked = false;
            this.adsoyadRadio.Location = new System.Drawing.Point(739, 123);
            this.adsoyadRadio.Name = "adsoyadRadio";
            this.adsoyadRadio.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.adsoyadRadio.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.adsoyadRadio.Size = new System.Drawing.Size(25, 25);
            this.adsoyadRadio.TabIndex = 49;
            this.adsoyadRadio.Text = null;
            // 
            // filtrele
            // 
            this.filtrele.Image = ((System.Drawing.Image)(resources.GetObject("filtrele.Image")));
            this.filtrele.ImageActive = null;
            this.filtrele.Location = new System.Drawing.Point(387, 92);
            this.filtrele.Margin = new System.Windows.Forms.Padding(4);
            this.filtrele.Name = "filtrele";
            this.filtrele.Size = new System.Drawing.Size(57, 47);
            this.filtrele.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.filtrele.TabIndex = 52;
            this.filtrele.TabStop = false;
            this.filtrele.Zoom = 10;
            this.filtrele.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // minimize
            // 
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.ImageActive = null;
            this.minimize.Location = new System.Drawing.Point(1357, 13);
            this.minimize.Margin = new System.Windows.Forms.Padding(4);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(57, 47);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 39;
            this.minimize.TabStop = false;
            this.minimize.Zoom = 10;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.ImageActive = null;
            this.close.Location = new System.Drawing.Point(1422, 14);
            this.close.Margin = new System.Windows.Forms.Padding(4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(57, 47);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 38;
            this.close.TabStop = false;
            this.close.Zoom = 10;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // ÜyeDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1492, 772);
            this.Controls.Add(this.filtrele);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.adsoyadRadio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tcRadio);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cinsiyet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sadeceaktifcheckbox);
            this.Controls.Add(this.memberdgv);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ÜyeDüzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Seç";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.memberdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtrele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuImageButton minimize;
        private Bunifu.Framework.UI.BunifuImageButton close;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDataGridView memberdgv;
        private Bunifu.Framework.UI.BunifuCheckbox sadeceaktifcheckbox;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDropdown cinsiyet;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchBox;
        private Bunifu.UI.WinForms.BunifuRadioButton tcRadio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuRadioButton adsoyadRadio;
        private Bunifu.Framework.UI.BunifuImageButton filtrele;
    }
}