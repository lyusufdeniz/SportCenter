
namespace SportCenter.Forms
{
    partial class ÜyeBilgiDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÜyeBilgiDüzenle));
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.close = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.boyBox = new Bunifu.Framework.UI.BunifuDropdown();
            this.label6 = new System.Windows.Forms.Label();
            this.kiloBox = new Bunifu.Framework.UI.BunifuDropdown();
            this.label7 = new System.Windows.Forms.Label();
            this.cinsiyetBox = new Bunifu.Framework.UI.BunifuDropdown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kangrubuBox = new Bunifu.Framework.UI.BunifuDropdown();
            this.dogumtarihiBox = new Bunifu.Framework.UI.BunifuDatepicker();
            this.eposstaTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tcTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.soyadTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.adtextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.üyedüzenle = new Bunifu.Framework.UI.BunifuTileButton();
            this.uyeID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.bunifuSeparator1.Location = new System.Drawing.Point(-221, 70);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1385, 21);
            this.bunifuSeparator1.TabIndex = 44;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // minimize
            // 
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.ImageActive = null;
            this.minimize.Location = new System.Drawing.Point(1050, 14);
            this.minimize.Margin = new System.Windows.Forms.Padding(4);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(57, 47);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 43;
            this.minimize.TabStop = false;
            this.minimize.Zoom = 10;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.ImageActive = null;
            this.close.Location = new System.Drawing.Point(1115, 15);
            this.close.Margin = new System.Windows.Forms.Padding(4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(57, 47);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 42;
            this.close.TabStop = false;
            this.close.Zoom = 10;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 50);
            this.label1.TabIndex = 41;
            this.label1.Text = "Bilgileri Güncelle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(478, 443);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 32);
            this.label8.TabIndex = 76;
            this.label8.Text = "Boy";
            // 
            // boyBox
            // 
            this.boyBox.BackColor = System.Drawing.Color.Transparent;
            this.boyBox.BorderRadius = 3;
            this.boyBox.DisabledColor = System.Drawing.Color.Gray;
            this.boyBox.ForeColor = System.Drawing.Color.White;
            this.boyBox.items = new string[0];
            this.boyBox.Location = new System.Drawing.Point(484, 479);
            this.boyBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boyBox.Name = "boyBox";
            this.boyBox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(66)))));
            this.boyBox.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(66)))));
            this.boyBox.selectedIndex = -1;
            this.boyBox.Size = new System.Drawing.Size(141, 43);
            this.boyBox.TabIndex = 74;
            this.boyBox.onItemSelected += new System.EventHandler(this.boyBox_onItemSelected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(478, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 32);
            this.label6.TabIndex = 73;
            this.label6.Text = "Kilo";
            // 
            // kiloBox
            // 
            this.kiloBox.BackColor = System.Drawing.Color.Transparent;
            this.kiloBox.BorderRadius = 3;
            this.kiloBox.DisabledColor = System.Drawing.Color.Gray;
            this.kiloBox.ForeColor = System.Drawing.Color.White;
            this.kiloBox.items = new string[0];
            this.kiloBox.Location = new System.Drawing.Point(484, 368);
            this.kiloBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kiloBox.Name = "kiloBox";
            this.kiloBox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(66)))));
            this.kiloBox.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(66)))));
            this.kiloBox.selectedIndex = -1;
            this.kiloBox.Size = new System.Drawing.Size(141, 43);
            this.kiloBox.TabIndex = 72;
            this.kiloBox.onItemSelected += new System.EventHandler(this.kiloBox_onItemSelected);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(30, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 32);
            this.label7.TabIndex = 71;
            this.label7.Text = "Cinsiyet";
            // 
            // cinsiyetBox
            // 
            this.cinsiyetBox.BackColor = System.Drawing.Color.Transparent;
            this.cinsiyetBox.BorderRadius = 3;
            this.cinsiyetBox.DisabledColor = System.Drawing.Color.Gray;
            this.cinsiyetBox.ForeColor = System.Drawing.Color.White;
            this.cinsiyetBox.items = new string[] {
        "Kadın",
        "Erkek"};
            this.cinsiyetBox.Location = new System.Drawing.Point(36, 383);
            this.cinsiyetBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cinsiyetBox.Name = "cinsiyetBox";
            this.cinsiyetBox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(66)))));
            this.cinsiyetBox.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(66)))));
            this.cinsiyetBox.selectedIndex = -1;
            this.cinsiyetBox.Size = new System.Drawing.Size(235, 43);
            this.cinsiyetBox.TabIndex = 70;
            this.cinsiyetBox.onItemSelected += new System.EventHandler(this.cinsiyetBox_onItemSelected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 32);
            this.label4.TabIndex = 67;
            this.label4.Text = "Kan Grubu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 32);
            this.label2.TabIndex = 65;
            this.label2.Text = "Doğum Tarihi";
            // 
            // kangrubuBox
            // 
            this.kangrubuBox.BackColor = System.Drawing.Color.Transparent;
            this.kangrubuBox.BorderRadius = 3;
            this.kangrubuBox.DisabledColor = System.Drawing.Color.Gray;
            this.kangrubuBox.ForeColor = System.Drawing.Color.White;
            this.kangrubuBox.items = new string[] {
        "A+",
        "A-",
        "B+",
        "B-",
        "AB+",
        "AB-",
        "0+",
        "0-"};
            this.kangrubuBox.Location = new System.Drawing.Point(36, 489);
            this.kangrubuBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kangrubuBox.Name = "kangrubuBox";
            this.kangrubuBox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(66)))));
            this.kangrubuBox.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(66)))));
            this.kangrubuBox.selectedIndex = 0;
            this.kangrubuBox.Size = new System.Drawing.Size(235, 43);
            this.kangrubuBox.TabIndex = 64;
            this.kangrubuBox.onItemSelected += new System.EventHandler(this.kangrubuBox_onItemSelected);
            // 
            // dogumtarihiBox
            // 
            this.dogumtarihiBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(66)))));
            this.dogumtarihiBox.BorderRadius = 0;
            this.dogumtarihiBox.ForeColor = System.Drawing.Color.White;
            this.dogumtarihiBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dogumtarihiBox.FormatCustom = "yyyy-MM-dd";
            this.dogumtarihiBox.Location = new System.Drawing.Point(21, 294);
            this.dogumtarihiBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dogumtarihiBox.Name = "dogumtarihiBox";
            this.dogumtarihiBox.Size = new System.Drawing.Size(379, 44);
            this.dogumtarihiBox.TabIndex = 62;
            this.dogumtarihiBox.Value = new System.DateTime(2021, 12, 25, 23, 9, 32, 37);
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
            this.eposstaTextbox.LineFocusedColor = System.Drawing.Color.Brown;
            this.eposstaTextbox.LineIdleColor = System.Drawing.Color.IndianRed;
            this.eposstaTextbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.eposstaTextbox.LineThickness = 3;
            this.eposstaTextbox.Location = new System.Drawing.Point(484, 258);
            this.eposstaTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.eposstaTextbox.MaxLength = 32767;
            this.eposstaTextbox.Name = "eposstaTextbox";
            this.eposstaTextbox.Size = new System.Drawing.Size(417, 45);
            this.eposstaTextbox.TabIndex = 61;
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
            this.tcTextbox.HintText = "TC Kimlik No";
            this.tcTextbox.isPassword = false;
            this.tcTextbox.LineFocusedColor = System.Drawing.Color.Brown;
            this.tcTextbox.LineIdleColor = System.Drawing.Color.IndianRed;
            this.tcTextbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tcTextbox.LineThickness = 3;
            this.tcTextbox.Location = new System.Drawing.Point(484, 192);
            this.tcTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.tcTextbox.MaxLength = 11;
            this.tcTextbox.Name = "tcTextbox";
            this.tcTextbox.Size = new System.Drawing.Size(417, 45);
            this.tcTextbox.TabIndex = 60;
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
            this.soyadTextbox.LineFocusedColor = System.Drawing.Color.Brown;
            this.soyadTextbox.LineIdleColor = System.Drawing.Color.IndianRed;
            this.soyadTextbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.soyadTextbox.LineThickness = 3;
            this.soyadTextbox.Location = new System.Drawing.Point(484, 111);
            this.soyadTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.soyadTextbox.MaxLength = 32767;
            this.soyadTextbox.Name = "soyadTextbox";
            this.soyadTextbox.Size = new System.Drawing.Size(417, 45);
            this.soyadTextbox.TabIndex = 59;
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
            this.adtextbox.LineFocusedColor = System.Drawing.Color.Brown;
            this.adtextbox.LineIdleColor = System.Drawing.Color.IndianRed;
            this.adtextbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.adtextbox.LineThickness = 3;
            this.adtextbox.Location = new System.Drawing.Point(22, 111);
            this.adtextbox.Margin = new System.Windows.Forms.Padding(4);
            this.adtextbox.MaxLength = 32767;
            this.adtextbox.Name = "adtextbox";
            this.adtextbox.Size = new System.Drawing.Size(417, 45);
            this.adtextbox.TabIndex = 58;
            this.adtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // üyedüzenle
            // 
            this.üyedüzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(171)))), ((int)(((byte)(196)))));
            this.üyedüzenle.color = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(171)))), ((int)(((byte)(196)))));
            this.üyedüzenle.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(97)))), ((int)(((byte)(161)))));
            this.üyedüzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.üyedüzenle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.üyedüzenle.ForeColor = System.Drawing.Color.White;
            this.üyedüzenle.Image = ((System.Drawing.Image)(resources.GetObject("üyedüzenle.Image")));
            this.üyedüzenle.ImagePosition = 14;
            this.üyedüzenle.ImageZoom = 50;
            this.üyedüzenle.LabelPosition = 29;
            this.üyedüzenle.LabelText = "Üye Düzenle";
            this.üyedüzenle.Location = new System.Drawing.Point(947, 240);
            this.üyedüzenle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.üyedüzenle.Name = "üyedüzenle";
            this.üyedüzenle.Size = new System.Drawing.Size(205, 171);
            this.üyedüzenle.TabIndex = 77;
            this.üyedüzenle.Click += new System.EventHandler(this.üyedüzenle_Click);
            // 
            // uyeID
            // 
            this.uyeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.uyeID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.uyeID.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.uyeID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uyeID.Enabled = false;
            this.uyeID.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uyeID.ForeColor = System.Drawing.Color.White;
            this.uyeID.HintForeColor = System.Drawing.Color.White;
            this.uyeID.HintText = "Üye No";
            this.uyeID.isPassword = false;
            this.uyeID.LineFocusedColor = System.Drawing.Color.Brown;
            this.uyeID.LineIdleColor = System.Drawing.Color.IndianRed;
            this.uyeID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.uyeID.LineThickness = 3;
            this.uyeID.Location = new System.Drawing.Point(103, 192);
            this.uyeID.Margin = new System.Windows.Forms.Padding(4);
            this.uyeID.MaxLength = 32767;
            this.uyeID.Name = "uyeID";
            this.uyeID.Size = new System.Drawing.Size(336, 45);
            this.uyeID.TabIndex = 78;
            this.uyeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 45);
            this.label3.TabIndex = 79;
            this.label3.Text = "ÜYE ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ÜyeBilgiDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1178, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uyeID);
            this.Controls.Add(this.üyedüzenle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.boyBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.kiloBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cinsiyetBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kangrubuBox);
            this.Controls.Add(this.dogumtarihiBox);
            this.Controls.Add(this.eposstaTextbox);
            this.Controls.Add(this.tcTextbox);
            this.Controls.Add(this.soyadTextbox);
            this.Controls.Add(this.adtextbox);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ÜyeBilgiDüzenle";
            this.Text = "ÜyeBilgiDüzenle";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
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
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuDropdown boyBox;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuDropdown kiloBox;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuDropdown cinsiyetBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDropdown kangrubuBox;
        private Bunifu.Framework.UI.BunifuDatepicker dogumtarihiBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox eposstaTextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tcTextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox soyadTextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox adtextbox;
        private Bunifu.Framework.UI.BunifuTileButton üyedüzenle;
        private Bunifu.Framework.UI.BunifuMaterialTextbox uyeID;
        private System.Windows.Forms.Label label3;
    }
}