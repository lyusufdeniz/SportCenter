
namespace SportCenter.Forms
{
    partial class YeniUye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniUye));
            this.label1 = new System.Windows.Forms.Label();
            this.minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.close = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.adtextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.soyadTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.eposstaTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tcTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dogumtarihiBox = new Bunifu.Framework.UI.BunifuDatepicker();
            this.baslangictarihiBox = new Bunifu.Framework.UI.BunifuDatepicker();
            this.kangrubuBox = new Bunifu.Framework.UI.BunifuDropdown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uyetipiBox = new Bunifu.Framework.UI.BunifuDropdown();
            this.label6 = new System.Windows.Forms.Label();
            this.kiloBox = new Bunifu.Framework.UI.BunifuDropdown();
            this.label7 = new System.Windows.Forms.Label();
            this.cinsiyetBox = new Bunifu.Framework.UI.BunifuDropdown();
            this.boyBox = new Bunifu.Framework.UI.BunifuDropdown();
            this.üyeekle = new Bunifu.Framework.UI.BunifuTileButton();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 50);
            this.label1.TabIndex = 33;
            this.label1.Text = "Yeni Üye Kayıt";
            // 
            // minimize
            // 
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.ImageActive = null;
            this.minimize.Location = new System.Drawing.Point(1045, 9);
            this.minimize.Margin = new System.Windows.Forms.Padding(4);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(57, 47);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 35;
            this.minimize.TabStop = false;
            this.minimize.Zoom = 10;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.ImageActive = null;
            this.close.Location = new System.Drawing.Point(1110, 10);
            this.close.Margin = new System.Windows.Forms.Padding(4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(57, 47);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 34;
            this.close.TabStop = false;
            this.close.Zoom = 10;
            this.close.Click += new System.EventHandler(this.close_Click);
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
            this.bunifuSeparator1.Size = new System.Drawing.Size(1308, 10);
            this.bunifuSeparator1.TabIndex = 36;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
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
            this.adtextbox.Location = new System.Drawing.Point(14, 115);
            this.adtextbox.Margin = new System.Windows.Forms.Padding(4);
            this.adtextbox.MaxLength = 32767;
            this.adtextbox.Name = "adtextbox";
            this.adtextbox.Size = new System.Drawing.Size(417, 45);
            this.adtextbox.TabIndex = 37;
            this.adtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.soyadTextbox.Location = new System.Drawing.Point(476, 115);
            this.soyadTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.soyadTextbox.MaxLength = 32767;
            this.soyadTextbox.Name = "soyadTextbox";
            this.soyadTextbox.Size = new System.Drawing.Size(417, 45);
            this.soyadTextbox.TabIndex = 38;
            this.soyadTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.eposstaTextbox.Location = new System.Drawing.Point(476, 195);
            this.eposstaTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.eposstaTextbox.MaxLength = 32767;
            this.eposstaTextbox.Name = "eposstaTextbox";
            this.eposstaTextbox.Size = new System.Drawing.Size(417, 45);
            this.eposstaTextbox.TabIndex = 40;
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
            this.tcTextbox.LineFocusedColor = System.Drawing.Color.Brown;
            this.tcTextbox.LineIdleColor = System.Drawing.Color.IndianRed;
            this.tcTextbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tcTextbox.LineThickness = 3;
            this.tcTextbox.Location = new System.Drawing.Point(14, 195);
            this.tcTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.tcTextbox.MaxLength = 11;
            this.tcTextbox.Name = "tcTextbox";
            this.tcTextbox.Size = new System.Drawing.Size(417, 45);
            this.tcTextbox.TabIndex = 39;
            this.tcTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tcTextbox.OnValueChanged += new System.EventHandler(this.tcTextbox_OnValueChanged);
            // 
            // dogumtarihiBox
            // 
            this.dogumtarihiBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(66)))));
            this.dogumtarihiBox.BorderRadius = 0;
            this.dogumtarihiBox.ForeColor = System.Drawing.Color.White;
            this.dogumtarihiBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dogumtarihiBox.FormatCustom = "yyyy-MM-dd";
            this.dogumtarihiBox.Location = new System.Drawing.Point(13, 298);
            this.dogumtarihiBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dogumtarihiBox.Name = "dogumtarihiBox";
            this.dogumtarihiBox.Size = new System.Drawing.Size(379, 44);
            this.dogumtarihiBox.TabIndex = 41;
            this.dogumtarihiBox.Value = new System.DateTime(2021, 12, 25, 23, 9, 32, 37);
            // 
            // baslangictarihiBox
            // 
            this.baslangictarihiBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(66)))));
            this.baslangictarihiBox.BorderRadius = 0;
            this.baslangictarihiBox.ForeColor = System.Drawing.Color.White;
            this.baslangictarihiBox.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.baslangictarihiBox.FormatCustom = null;
            this.baslangictarihiBox.Location = new System.Drawing.Point(476, 298);
            this.baslangictarihiBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.baslangictarihiBox.Name = "baslangictarihiBox";
            this.baslangictarihiBox.Size = new System.Drawing.Size(379, 44);
            this.baslangictarihiBox.TabIndex = 42;
            this.baslangictarihiBox.Value = new System.DateTime(2021, 12, 25, 23, 9, 32, 37);
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
            this.kangrubuBox.Location = new System.Drawing.Point(28, 493);
            this.kangrubuBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kangrubuBox.Name = "kangrubuBox";
            this.kangrubuBox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(66)))));
            this.kangrubuBox.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(66)))));
            this.kangrubuBox.selectedIndex = 0;
            this.kangrubuBox.Size = new System.Drawing.Size(235, 43);
            this.kangrubuBox.TabIndex = 45;
            this.kangrubuBox.onItemSelected += new System.EventHandler(this.kangrubuBox_onItemSelected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 32);
            this.label2.TabIndex = 46;
            this.label2.Text = "Doğum Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(470, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 32);
            this.label3.TabIndex = 47;
            this.label3.Text = "Üyelik Başlangıç Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 32);
            this.label4.TabIndex = 48;
            this.label4.Text = "Kan Grubu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(470, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 32);
            this.label5.TabIndex = 50;
            this.label5.Text = "Üyelik Tipi";
            // 
            // uyetipiBox
            // 
            this.uyetipiBox.BackColor = System.Drawing.Color.Transparent;
            this.uyetipiBox.BorderRadius = 3;
            this.uyetipiBox.DisabledColor = System.Drawing.Color.Gray;
            this.uyetipiBox.ForeColor = System.Drawing.Color.White;
            this.uyetipiBox.items = new string[0];
            this.uyetipiBox.Location = new System.Drawing.Point(476, 483);
            this.uyetipiBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uyetipiBox.Name = "uyetipiBox";
            this.uyetipiBox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(66)))));
            this.uyetipiBox.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(66)))));
            this.uyetipiBox.selectedIndex = -1;
            this.uyetipiBox.Size = new System.Drawing.Size(235, 43);
            this.uyetipiBox.TabIndex = 49;
            this.uyetipiBox.onItemSelected += new System.EventHandler(this.uyetipiBox_onItemSelected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(470, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 32);
            this.label6.TabIndex = 54;
            this.label6.Text = "Kilo";
            // 
            // kiloBox
            // 
            this.kiloBox.BackColor = System.Drawing.Color.Transparent;
            this.kiloBox.BorderRadius = 3;
            this.kiloBox.DisabledColor = System.Drawing.Color.Gray;
            this.kiloBox.ForeColor = System.Drawing.Color.White;
            this.kiloBox.items = new string[0];
            this.kiloBox.Location = new System.Drawing.Point(476, 387);
            this.kiloBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kiloBox.Name = "kiloBox";
            this.kiloBox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(66)))));
            this.kiloBox.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(66)))));
            this.kiloBox.selectedIndex = -1;
            this.kiloBox.Size = new System.Drawing.Size(141, 43);
            this.kiloBox.TabIndex = 53;
            this.kiloBox.onItemSelected += new System.EventHandler(this.kiloBox_onItemSelected);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(22, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 32);
            this.label7.TabIndex = 52;
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
            this.cinsiyetBox.Location = new System.Drawing.Point(28, 387);
            this.cinsiyetBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cinsiyetBox.Name = "cinsiyetBox";
            this.cinsiyetBox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(66)))));
            this.cinsiyetBox.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(66)))));
            this.cinsiyetBox.selectedIndex = -1;
            this.cinsiyetBox.Size = new System.Drawing.Size(235, 43);
            this.cinsiyetBox.TabIndex = 51;
            this.cinsiyetBox.onItemSelected += new System.EventHandler(this.cinsiyetBox_onItemSelected);
            // 
            // boyBox
            // 
            this.boyBox.BackColor = System.Drawing.Color.Transparent;
            this.boyBox.BorderRadius = 3;
            this.boyBox.DisabledColor = System.Drawing.Color.Gray;
            this.boyBox.ForeColor = System.Drawing.Color.White;
            this.boyBox.items = new string[0];
            this.boyBox.Location = new System.Drawing.Point(633, 387);
            this.boyBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boyBox.Name = "boyBox";
            this.boyBox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(66)))));
            this.boyBox.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(66)))));
            this.boyBox.selectedIndex = -1;
            this.boyBox.Size = new System.Drawing.Size(141, 43);
            this.boyBox.TabIndex = 55;
            this.boyBox.onItemSelected += new System.EventHandler(this.boyBox_onItemSelected);
            // 
            // üyeekle
            // 
            this.üyeekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.üyeekle.color = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.üyeekle.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(193)))), ((int)(((byte)(184)))));
            this.üyeekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.üyeekle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.üyeekle.ForeColor = System.Drawing.Color.White;
            this.üyeekle.Image = ((System.Drawing.Image)(resources.GetObject("üyeekle.Image")));
            this.üyeekle.ImagePosition = 14;
            this.üyeekle.ImageZoom = 50;
            this.üyeekle.LabelPosition = 29;
            this.üyeekle.LabelText = "Yeni Üye";
            this.üyeekle.Location = new System.Drawing.Point(934, 212);
            this.üyeekle.Margin = new System.Windows.Forms.Padding(6);
            this.üyeekle.Name = "üyeekle";
            this.üyeekle.Size = new System.Drawing.Size(203, 171);
            this.üyeekle.TabIndex = 56;
            this.üyeekle.Click += new System.EventHandler(this.üyeekle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(627, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 32);
            this.label8.TabIndex = 57;
            this.label8.Text = "Boy";
            // 
            // YeniUye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1178, 561);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.üyeekle);
            this.Controls.Add(this.boyBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.kiloBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cinsiyetBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uyetipiBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kangrubuBox);
            this.Controls.Add(this.baslangictarihiBox);
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
            this.Name = "YeniUye";
            this.Text = "Üye Kaydı";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton minimize;
        private Bunifu.Framework.UI.BunifuImageButton close;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox adtextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox soyadTextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox eposstaTextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tcTextbox;
        private Bunifu.Framework.UI.BunifuDatepicker dogumtarihiBox;
        private Bunifu.Framework.UI.BunifuDatepicker baslangictarihiBox;
        private Bunifu.Framework.UI.BunifuDropdown kangrubuBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuDropdown uyetipiBox;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuDropdown kiloBox;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuDropdown cinsiyetBox;
        private Bunifu.Framework.UI.BunifuDropdown boyBox;
        private Bunifu.Framework.UI.BunifuTileButton üyeekle;
        private System.Windows.Forms.Label label8;
    }
}