
namespace SportCenter.Forms
{
    partial class PersonelBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelBilgiDuzenle));
            this.label3 = new System.Windows.Forms.Label();
            this.staffIDTxtBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.üyedüzenle = new Bunifu.Framework.UI.BunifuTileButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dogumtarihiBox = new Bunifu.Framework.UI.BunifuDatepicker();
            this.eposstaTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tcTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.soyadTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.adtextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.close = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pwBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.uidBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 45);
            this.label3.TabIndex = 100;
            this.label3.Text = "Personel No";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // staffIDTxtBox
            // 
            this.staffIDTxtBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.staffIDTxtBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.staffIDTxtBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.staffIDTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.staffIDTxtBox.Enabled = false;
            this.staffIDTxtBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffIDTxtBox.ForeColor = System.Drawing.Color.White;
            this.staffIDTxtBox.HintForeColor = System.Drawing.Color.White;
            this.staffIDTxtBox.HintText = "Üye No";
            this.staffIDTxtBox.isPassword = false;
            this.staffIDTxtBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.staffIDTxtBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(59)))));
            this.staffIDTxtBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.staffIDTxtBox.LineThickness = 3;
            this.staffIDTxtBox.Location = new System.Drawing.Point(103, 190);
            this.staffIDTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.staffIDTxtBox.MaxLength = 32767;
            this.staffIDTxtBox.Name = "staffIDTxtBox";
            this.staffIDTxtBox.Size = new System.Drawing.Size(336, 45);
            this.staffIDTxtBox.TabIndex = 99;
            this.staffIDTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // üyedüzenle
            // 
            this.üyedüzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.üyedüzenle.color = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.üyedüzenle.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(59)))));
            this.üyedüzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.üyedüzenle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.üyedüzenle.ForeColor = System.Drawing.Color.White;
            this.üyedüzenle.Image = ((System.Drawing.Image)(resources.GetObject("üyedüzenle.Image")));
            this.üyedüzenle.ImagePosition = 14;
            this.üyedüzenle.ImageZoom = 50;
            this.üyedüzenle.LabelPosition = 29;
            this.üyedüzenle.LabelText = "Personel Düzenle";
            this.üyedüzenle.Location = new System.Drawing.Point(947, 109);
            this.üyedüzenle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.üyedüzenle.Name = "üyedüzenle";
            this.üyedüzenle.Size = new System.Drawing.Size(205, 171);
            this.üyedüzenle.TabIndex = 98;
            this.üyedüzenle.Click += new System.EventHandler(this.üyedüzenle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 32);
            this.label2.TabIndex = 90;
            this.label2.Text = "Doğum Tarihi";
            // 
            // dogumtarihiBox
            // 
            this.dogumtarihiBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.dogumtarihiBox.BorderRadius = 0;
            this.dogumtarihiBox.ForeColor = System.Drawing.Color.White;
            this.dogumtarihiBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dogumtarihiBox.FormatCustom = "yyyy-MM-dd";
            this.dogumtarihiBox.Location = new System.Drawing.Point(21, 292);
            this.dogumtarihiBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dogumtarihiBox.Name = "dogumtarihiBox";
            this.dogumtarihiBox.Size = new System.Drawing.Size(379, 44);
            this.dogumtarihiBox.TabIndex = 88;
            this.dogumtarihiBox.Value = new System.DateTime(2021, 12, 25, 23, 9, 32, 37);
            this.dogumtarihiBox.onValueChanged += new System.EventHandler(this.dogumtarihiBox_onValueChanged);
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
            this.eposstaTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.eposstaTextbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(59)))));
            this.eposstaTextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.eposstaTextbox.LineThickness = 3;
            this.eposstaTextbox.Location = new System.Drawing.Point(484, 291);
            this.eposstaTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.eposstaTextbox.MaxLength = 32767;
            this.eposstaTextbox.Name = "eposstaTextbox";
            this.eposstaTextbox.Size = new System.Drawing.Size(417, 45);
            this.eposstaTextbox.TabIndex = 87;
            this.eposstaTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.eposstaTextbox.OnValueChanged += new System.EventHandler(this.eposstaTextbox_OnValueChanged);
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
            this.tcTextbox.HintText = "TC Kimlik No";
            this.tcTextbox.isPassword = false;
            this.tcTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.tcTextbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(59)))));
            this.tcTextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.tcTextbox.LineThickness = 3;
            this.tcTextbox.Location = new System.Drawing.Point(484, 190);
            this.tcTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.tcTextbox.MaxLength = 11;
            this.tcTextbox.Name = "tcTextbox";
            this.tcTextbox.Size = new System.Drawing.Size(417, 45);
            this.tcTextbox.TabIndex = 86;
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
            this.soyadTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.soyadTextbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(59)))));
            this.soyadTextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.soyadTextbox.LineThickness = 3;
            this.soyadTextbox.Location = new System.Drawing.Point(484, 109);
            this.soyadTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.soyadTextbox.MaxLength = 32767;
            this.soyadTextbox.Name = "soyadTextbox";
            this.soyadTextbox.Size = new System.Drawing.Size(417, 45);
            this.soyadTextbox.TabIndex = 85;
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
            this.adtextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.adtextbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(59)))));
            this.adtextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.adtextbox.LineThickness = 3;
            this.adtextbox.Location = new System.Drawing.Point(22, 109);
            this.adtextbox.Margin = new System.Windows.Forms.Padding(4);
            this.adtextbox.MaxLength = 32767;
            this.adtextbox.Name = "adtextbox";
            this.adtextbox.Size = new System.Drawing.Size(417, 45);
            this.adtextbox.TabIndex = 84;
            this.adtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Enabled = false;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-221, 68);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1385, 21);
            this.bunifuSeparator1.TabIndex = 83;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // minimize
            // 
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.ImageActive = null;
            this.minimize.Location = new System.Drawing.Point(1050, 12);
            this.minimize.Margin = new System.Windows.Forms.Padding(4);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(57, 47);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 82;
            this.minimize.TabStop = false;
            this.minimize.Zoom = 10;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.ImageActive = null;
            this.close.Location = new System.Drawing.Point(1115, 13);
            this.close.Margin = new System.Windows.Forms.Padding(4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(57, 47);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 81;
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
            this.label1.Size = new System.Drawing.Size(342, 50);
            this.label1.TabIndex = 80;
            this.label1.Text = "Bilgileri Güncelle";
            // 
            // pwBox
            // 
            this.pwBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.pwBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.pwBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.pwBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pwBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwBox.ForeColor = System.Drawing.Color.White;
            this.pwBox.HintForeColor = System.Drawing.Color.White;
            this.pwBox.HintText = "Şifre";
            this.pwBox.isPassword = false;
            this.pwBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.pwBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(59)))));
            this.pwBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.pwBox.LineThickness = 3;
            this.pwBox.Location = new System.Drawing.Point(484, 379);
            this.pwBox.Margin = new System.Windows.Forms.Padding(4);
            this.pwBox.MaxLength = 32767;
            this.pwBox.Name = "pwBox";
            this.pwBox.Size = new System.Drawing.Size(417, 45);
            this.pwBox.TabIndex = 102;
            this.pwBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // uidBox
            // 
            this.uidBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.uidBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.uidBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.uidBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uidBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uidBox.ForeColor = System.Drawing.Color.White;
            this.uidBox.HintForeColor = System.Drawing.Color.White;
            this.uidBox.HintText = "Kullanıcı Adı";
            this.uidBox.isPassword = false;
            this.uidBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.uidBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(59)))));
            this.uidBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.uidBox.LineThickness = 3;
            this.uidBox.Location = new System.Drawing.Point(22, 379);
            this.uidBox.Margin = new System.Windows.Forms.Padding(4);
            this.uidBox.MaxLength = 32767;
            this.uidBox.Name = "uidBox";
            this.uidBox.Size = new System.Drawing.Size(417, 45);
            this.uidBox.TabIndex = 101;
            this.uidBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.Firebrick;
            this.bunifuTileButton1.color = System.Drawing.Color.Firebrick;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.Firebrick;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 14;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 29;
            this.bunifuTileButton1.LabelText = "Personeli Sil";
            this.bunifuTileButton1.Location = new System.Drawing.Point(947, 291);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(205, 171);
            this.bunifuTileButton1.TabIndex = 103;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // PersonelBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1178, 496);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.pwBox);
            this.Controls.Add(this.uidBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.staffIDTxtBox);
            this.Controls.Add(this.üyedüzenle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dogumtarihiBox);
            this.Controls.Add(this.eposstaTextbox);
            this.Controls.Add(this.tcTextbox);
            this.Controls.Add(this.soyadTextbox);
            this.Controls.Add(this.adtextbox);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonelBilgiDuzenle";
            this.Text = "Bilgi Düzenle";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox staffIDTxtBox;
        private Bunifu.Framework.UI.BunifuTileButton üyedüzenle;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDatepicker dogumtarihiBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox eposstaTextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tcTextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox soyadTextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox adtextbox;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuImageButton minimize;
        private Bunifu.Framework.UI.BunifuImageButton close;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pwBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox uidBox;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
    }
}