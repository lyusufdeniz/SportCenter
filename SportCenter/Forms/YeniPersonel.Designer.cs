
namespace SportCenter.Forms
{
    partial class YeniPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniPersonel));
            this.minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.close = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.eposstaTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tcTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.soyadTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.adtextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.dogumtarihiBox = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label7 = new System.Windows.Forms.Label();
            this.staffCategoryBox = new Bunifu.Framework.UI.BunifuDropdown();
            this.pwTxtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.usernameTxtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gsmBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // minimize
            // 
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.ImageActive = null;
            this.minimize.Location = new System.Drawing.Point(903, 12);
            this.minimize.Margin = new System.Windows.Forms.Padding(4);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(57, 47);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 36;
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
            this.bunifuSeparator1.Location = new System.Drawing.Point(-122, 64);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1308, 10);
            this.bunifuSeparator1.TabIndex = 35;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.ImageActive = null;
            this.close.Location = new System.Drawing.Point(968, 13);
            this.close.Margin = new System.Windows.Forms.Padding(4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(57, 47);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 34;
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
            this.label1.Size = new System.Drawing.Size(281, 50);
            this.label1.TabIndex = 33;
            this.label1.Text = "Yeni Personel";
            // 
            // eposstaTextbox
            // 
            this.eposstaTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.eposstaTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.eposstaTextbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.eposstaTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.eposstaTextbox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eposstaTextbox.ForeColor = System.Drawing.Color.White;
            this.eposstaTextbox.HintForeColor = System.Drawing.Color.White;
            this.eposstaTextbox.HintText = "E POSTA";
            this.eposstaTextbox.isPassword = false;
            this.eposstaTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(124)))));
            this.eposstaTextbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(124)))), ((int)(((byte)(227)))));
            this.eposstaTextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(124)))));
            this.eposstaTextbox.LineThickness = 3;
            this.eposstaTextbox.Location = new System.Drawing.Point(483, 180);
            this.eposstaTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.eposstaTextbox.MaxLength = 32767;
            this.eposstaTextbox.Name = "eposstaTextbox";
            this.eposstaTextbox.Size = new System.Drawing.Size(417, 45);
            this.eposstaTextbox.TabIndex = 44;
            this.eposstaTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tcTextbox
            // 
            this.tcTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tcTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tcTextbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tcTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tcTextbox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcTextbox.ForeColor = System.Drawing.Color.White;
            this.tcTextbox.HintForeColor = System.Drawing.Color.White;
            this.tcTextbox.HintText = "T.C KİMLİK NO";
            this.tcTextbox.isPassword = false;
            this.tcTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(124)))));
            this.tcTextbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(124)))), ((int)(((byte)(227)))));
            this.tcTextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(124)))));
            this.tcTextbox.LineThickness = 3;
            this.tcTextbox.Location = new System.Drawing.Point(21, 180);
            this.tcTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.tcTextbox.MaxLength = 11;
            this.tcTextbox.Name = "tcTextbox";
            this.tcTextbox.Size = new System.Drawing.Size(417, 45);
            this.tcTextbox.TabIndex = 43;
            this.tcTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // soyadTextbox
            // 
            this.soyadTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.soyadTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.soyadTextbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.soyadTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.soyadTextbox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soyadTextbox.ForeColor = System.Drawing.Color.White;
            this.soyadTextbox.HintForeColor = System.Drawing.Color.White;
            this.soyadTextbox.HintText = "SOYAD";
            this.soyadTextbox.isPassword = false;
            this.soyadTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(124)))));
            this.soyadTextbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(124)))), ((int)(((byte)(227)))));
            this.soyadTextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(124)))));
            this.soyadTextbox.LineThickness = 3;
            this.soyadTextbox.Location = new System.Drawing.Point(483, 100);
            this.soyadTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.soyadTextbox.MaxLength = 32767;
            this.soyadTextbox.Name = "soyadTextbox";
            this.soyadTextbox.Size = new System.Drawing.Size(417, 45);
            this.soyadTextbox.TabIndex = 42;
            this.soyadTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // adtextbox
            // 
            this.adtextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.adtextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.adtextbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.adtextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adtextbox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adtextbox.ForeColor = System.Drawing.Color.White;
            this.adtextbox.HintForeColor = System.Drawing.Color.White;
            this.adtextbox.HintText = "AD";
            this.adtextbox.isPassword = false;
            this.adtextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(124)))));
            this.adtextbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(124)))), ((int)(((byte)(227)))));
            this.adtextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(124)))));
            this.adtextbox.LineThickness = 3;
            this.adtextbox.Location = new System.Drawing.Point(21, 100);
            this.adtextbox.Margin = new System.Windows.Forms.Padding(4);
            this.adtextbox.MaxLength = 32767;
            this.adtextbox.Name = "adtextbox";
            this.adtextbox.Size = new System.Drawing.Size(417, 45);
            this.adtextbox.TabIndex = 41;
            this.adtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 32);
            this.label2.TabIndex = 48;
            this.label2.Text = "Doğum Tarihi";
            // 
            // dogumtarihiBox
            // 
            this.dogumtarihiBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(124)))));
            this.dogumtarihiBox.BorderRadius = 0;
            this.dogumtarihiBox.ForeColor = System.Drawing.Color.White;
            this.dogumtarihiBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dogumtarihiBox.FormatCustom = "yyyy-MM-dd";
            this.dogumtarihiBox.Location = new System.Drawing.Point(21, 289);
            this.dogumtarihiBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dogumtarihiBox.Name = "dogumtarihiBox";
            this.dogumtarihiBox.Size = new System.Drawing.Size(379, 44);
            this.dogumtarihiBox.TabIndex = 47;
            this.dogumtarihiBox.Value = new System.DateTime(2021, 12, 25, 23, 9, 32, 37);
            this.dogumtarihiBox.onValueChanged += new System.EventHandler(this.dogumtarihiBox_onValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(477, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 32);
            this.label7.TabIndex = 54;
            this.label7.Text = "Personel Kategorisi";
            // 
            // staffCategoryBox
            // 
            this.staffCategoryBox.BackColor = System.Drawing.Color.Transparent;
            this.staffCategoryBox.BorderRadius = 3;
            this.staffCategoryBox.DisabledColor = System.Drawing.Color.Gray;
            this.staffCategoryBox.ForeColor = System.Drawing.Color.White;
            this.staffCategoryBox.items = new string[0];
            this.staffCategoryBox.Location = new System.Drawing.Point(483, 290);
            this.staffCategoryBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.staffCategoryBox.Name = "staffCategoryBox";
            this.staffCategoryBox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(124)))));
            this.staffCategoryBox.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(124)))));
            this.staffCategoryBox.selectedIndex = -1;
            this.staffCategoryBox.Size = new System.Drawing.Size(235, 43);
            this.staffCategoryBox.TabIndex = 53;
            this.staffCategoryBox.onItemSelected += new System.EventHandler(this.cinsiyetBox_onItemSelected);
            // 
            // pwTxtbox
            // 
            this.pwTxtbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.pwTxtbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.pwTxtbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.pwTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pwTxtbox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwTxtbox.ForeColor = System.Drawing.Color.White;
            this.pwTxtbox.HintForeColor = System.Drawing.Color.White;
            this.pwTxtbox.HintText = "Şifre";
            this.pwTxtbox.isPassword = false;
            this.pwTxtbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(124)))));
            this.pwTxtbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(124)))), ((int)(((byte)(227)))));
            this.pwTxtbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(124)))));
            this.pwTxtbox.LineThickness = 3;
            this.pwTxtbox.Location = new System.Drawing.Point(483, 357);
            this.pwTxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.pwTxtbox.MaxLength = 32767;
            this.pwTxtbox.Name = "pwTxtbox";
            this.pwTxtbox.Size = new System.Drawing.Size(417, 45);
            this.pwTxtbox.TabIndex = 56;
            this.pwTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // usernameTxtbox
            // 
            this.usernameTxtbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.usernameTxtbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.usernameTxtbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.usernameTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTxtbox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxtbox.ForeColor = System.Drawing.Color.White;
            this.usernameTxtbox.HintForeColor = System.Drawing.Color.White;
            this.usernameTxtbox.HintText = "Kullanıcı Adı";
            this.usernameTxtbox.isPassword = false;
            this.usernameTxtbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(124)))));
            this.usernameTxtbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(124)))), ((int)(((byte)(227)))));
            this.usernameTxtbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(124)))));
            this.usernameTxtbox.LineThickness = 3;
            this.usernameTxtbox.Location = new System.Drawing.Point(21, 357);
            this.usernameTxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTxtbox.MaxLength = 32767;
            this.usernameTxtbox.Name = "usernameTxtbox";
            this.usernameTxtbox.Size = new System.Drawing.Size(417, 45);
            this.usernameTxtbox.TabIndex = 55;
            this.usernameTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // gsmBox
            // 
            this.gsmBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.gsmBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.gsmBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.gsmBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gsmBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gsmBox.ForeColor = System.Drawing.Color.White;
            this.gsmBox.HintForeColor = System.Drawing.Color.White;
            this.gsmBox.HintText = "GSM No";
            this.gsmBox.isPassword = false;
            this.gsmBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(124)))));
            this.gsmBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(124)))), ((int)(((byte)(227)))));
            this.gsmBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(124)))));
            this.gsmBox.LineThickness = 3;
            this.gsmBox.Location = new System.Drawing.Point(21, 436);
            this.gsmBox.Margin = new System.Windows.Forms.Padding(4);
            this.gsmBox.MaxLength = 11;
            this.gsmBox.Name = "gsmBox";
            this.gsmBox.Size = new System.Drawing.Size(417, 45);
            this.gsmBox.TabIndex = 57;
            this.gsmBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(124)))), ((int)(((byte)(227)))));
            this.bunifuTileButton1.color = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(124)))), ((int)(((byte)(227)))));
            this.bunifuTileButton1.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(124)))));
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 14;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 29;
            this.bunifuTileButton1.LabelText = "Yeni Personel Kayıt";
            this.bunifuTileButton1.Location = new System.Drawing.Point(857, 424);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(159, 124);
            this.bunifuTileButton1.TabIndex = 59;
            this.bunifuTileButton1.Click += new System.EventHandler(this.personelekle_Click);
            // 
            // YeniPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1029, 561);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.gsmBox);
            this.Controls.Add(this.pwTxtbox);
            this.Controls.Add(this.usernameTxtbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.staffCategoryBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dogumtarihiBox);
            this.Controls.Add(this.eposstaTextbox);
            this.Controls.Add(this.tcTextbox);
            this.Controls.Add(this.soyadTextbox);
            this.Controls.Add(this.adtextbox);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YeniPersonel";
            this.Text = "YeniPersonel";
            this.Load += new System.EventHandler(this.YeniPersonel_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton minimize;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuImageButton close;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox eposstaTextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tcTextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox soyadTextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox adtextbox;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDatepicker dogumtarihiBox;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuDropdown staffCategoryBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pwTxtbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox usernameTxtbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox gsmBox;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
    }
}