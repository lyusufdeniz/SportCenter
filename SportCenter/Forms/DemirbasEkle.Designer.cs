
namespace SportCenter.Forms
{
    partial class DemirbasEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemirbasEkle));
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.close = new Bunifu.Framework.UI.BunifuImageButton();
            this.aktivitelerBox = new Bunifu.Framework.UI.BunifuDropdown();
            this.ad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.adet = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.tutar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
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
            this.bunifuSeparator1.Location = new System.Drawing.Point(-4, 64);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1308, 14);
            this.bunifuSeparator1.TabIndex = 33;
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
            this.label1.Size = new System.Drawing.Size(292, 50);
            this.label1.TabIndex = 32;
            this.label1.Text = "Demirbaş Ekle";
            // 
            // minimize
            // 
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.ImageActive = null;
            this.minimize.Location = new System.Drawing.Point(399, 7);
            this.minimize.Margin = new System.Windows.Forms.Padding(4);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(57, 47);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 50;
            this.minimize.TabStop = false;
            this.minimize.Zoom = 10;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.ImageActive = null;
            this.close.Location = new System.Drawing.Point(464, 8);
            this.close.Margin = new System.Windows.Forms.Padding(4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(57, 47);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 49;
            this.close.TabStop = false;
            this.close.Zoom = 10;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // aktivitelerBox
            // 
            this.aktivitelerBox.BackColor = System.Drawing.Color.Transparent;
            this.aktivitelerBox.BorderRadius = 3;
            this.aktivitelerBox.DisabledColor = System.Drawing.Color.Gray;
            this.aktivitelerBox.ForeColor = System.Drawing.Color.White;
            this.aktivitelerBox.items = new string[] {
        "Aktivite Seçiniz"};
            this.aktivitelerBox.Location = new System.Drawing.Point(21, 114);
            this.aktivitelerBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aktivitelerBox.Name = "aktivitelerBox";
            this.aktivitelerBox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.aktivitelerBox.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.aktivitelerBox.selectedIndex = 0;
            this.aktivitelerBox.Size = new System.Drawing.Size(308, 43);
            this.aktivitelerBox.TabIndex = 51;
            this.aktivitelerBox.onItemSelected += new System.EventHandler(this.aktivitelerBox_onItemSelected);
            // 
            // ad
            // 
            this.ad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ad.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ad.ForeColor = System.Drawing.Color.White;
            this.ad.HintForeColor = System.Drawing.Color.White;
            this.ad.HintText = "Demirbaş İsmi Giriniz";
            this.ad.isPassword = false;
            this.ad.LineFocusedColor = System.Drawing.Color.Blue;
            this.ad.LineIdleColor = System.Drawing.Color.Gray;
            this.ad.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.ad.LineThickness = 3;
            this.ad.Location = new System.Drawing.Point(21, 188);
            this.ad.Margin = new System.Windows.Forms.Padding(4);
            this.ad.MaxLength = 32767;
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(379, 43);
            this.ad.TabIndex = 52;
            this.ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // adet
            // 
            this.adet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.adet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.adet.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.adet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adet.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.adet.ForeColor = System.Drawing.Color.White;
            this.adet.HintForeColor = System.Drawing.Color.White;
            this.adet.HintText = "Demirbaş Adet Giriniz";
            this.adet.isPassword = false;
            this.adet.LineFocusedColor = System.Drawing.Color.Blue;
            this.adet.LineIdleColor = System.Drawing.Color.Gray;
            this.adet.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.adet.LineThickness = 3;
            this.adet.Location = new System.Drawing.Point(21, 250);
            this.adet.Margin = new System.Windows.Forms.Padding(4);
            this.adet.MaxLength = 32767;
            this.adet.Name = "adet";
            this.adet.Size = new System.Drawing.Size(379, 43);
            this.adet.TabIndex = 53;
            this.adet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.adet.OnValueChanged += new System.EventHandler(this.adet_OnValueChanged);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(161)))));
            this.bunifuTileButton1.color = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(161)))));
            this.bunifuTileButton1.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(209)))), ((int)(((byte)(42)))));
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 14;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 29;
            this.bunifuTileButton1.LabelText = "Aktivite Ekle";
            this.bunifuTileButton1.Location = new System.Drawing.Point(373, 364);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(148, 118);
            this.bunifuTileButton1.TabIndex = 54;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // tutar
            // 
            this.tutar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tutar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tutar.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tutar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tutar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tutar.ForeColor = System.Drawing.Color.White;
            this.tutar.HintForeColor = System.Drawing.Color.White;
            this.tutar.HintText = "Demirbaş Tutar Giriniz";
            this.tutar.isPassword = false;
            this.tutar.LineFocusedColor = System.Drawing.Color.Blue;
            this.tutar.LineIdleColor = System.Drawing.Color.Gray;
            this.tutar.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tutar.LineThickness = 3;
            this.tutar.Location = new System.Drawing.Point(21, 313);
            this.tutar.Margin = new System.Windows.Forms.Padding(4);
            this.tutar.MaxLength = 32767;
            this.tutar.Name = "tutar";
            this.tutar.Size = new System.Drawing.Size(379, 43);
            this.tutar.TabIndex = 55;
            this.tutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DemirbasEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(551, 495);
            this.Controls.Add(this.tutar);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.adet);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.aktivitelerBox);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.close);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DemirbasEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AktiviteEkle";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton minimize;
        private Bunifu.Framework.UI.BunifuImageButton close;
        private Bunifu.Framework.UI.BunifuDropdown aktivitelerBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox adet;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tutar;
    }
}