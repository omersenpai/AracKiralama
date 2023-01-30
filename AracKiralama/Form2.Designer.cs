namespace AracKiralama
{
    partial class Rapor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rapor));
            this.buttonToplamKazancGoster = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AracKiralamaDataGridView = new System.Windows.Forms.DataGridView();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.labelKazanc = new System.Windows.Forms.Label();
            this.btAracSayisi = new System.Windows.Forms.Button();
            this.labelAracSayisi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AracKiralamaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonToplamKazancGoster
            // 
            this.buttonToplamKazancGoster.BackColor = System.Drawing.Color.Turquoise;
            this.buttonToplamKazancGoster.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonToplamKazancGoster.FlatAppearance.BorderSize = 3;
            this.buttonToplamKazancGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToplamKazancGoster.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonToplamKazancGoster.Location = new System.Drawing.Point(455, 135);
            this.buttonToplamKazancGoster.Name = "buttonToplamKazancGoster";
            this.buttonToplamKazancGoster.Size = new System.Drawing.Size(152, 84);
            this.buttonToplamKazancGoster.TabIndex = 9;
            this.buttonToplamKazancGoster.Text = "Toplam Kazancı Görüntüle";
            this.buttonToplamKazancGoster.UseVisualStyleBackColor = false;
            this.buttonToplamKazancGoster.Click += new System.EventHandler(this.buttonToplamKazancGoster_Click);
            this.buttonToplamKazancGoster.MouseLeave += new System.EventHandler(this.buttonToplamKazancGoster_MouseLeave);
            this.buttonToplamKazancGoster.MouseHover += new System.EventHandler(this.buttonToplamKazancGoster_MouseHover);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(455, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 82);
            this.button1.TabIndex = 7;
            this.button1.Text = "Geri dön";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btGeriDon_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // AracKiralamaDataGridView
            // 
            this.AracKiralamaDataGridView.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.AracKiralamaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AracKiralamaDataGridView.Location = new System.Drawing.Point(38, 392);
            this.AracKiralamaDataGridView.Name = "AracKiralamaDataGridView";
            this.AracKiralamaDataGridView.Size = new System.Drawing.Size(852, 177);
            this.AracKiralamaDataGridView.TabIndex = 8;
            this.AracKiralamaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AracKiralamaDataGridView_CellContentClick);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Button-Close-icon.png");
            // 
            // labelKazanc
            // 
            this.labelKazanc.AutoSize = true;
            this.labelKazanc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelKazanc.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKazanc.Location = new System.Drawing.Point(643, 135);
            this.labelKazanc.Name = "labelKazanc";
            this.labelKazanc.Size = new System.Drawing.Size(54, 25);
            this.labelKazanc.TabIndex = 10;
            this.labelKazanc.Text = "------";
            this.labelKazanc.Click += new System.EventHandler(this.label1_Click);
            // 
            // btAracSayisi
            // 
            this.btAracSayisi.BackColor = System.Drawing.Color.Turquoise;
            this.btAracSayisi.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btAracSayisi.FlatAppearance.BorderSize = 3;
            this.btAracSayisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAracSayisi.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btAracSayisi.Location = new System.Drawing.Point(455, 24);
            this.btAracSayisi.Name = "btAracSayisi";
            this.btAracSayisi.Size = new System.Drawing.Size(152, 92);
            this.btAracSayisi.TabIndex = 11;
            this.btAracSayisi.Text = "Kiralanan Araç Sayısını Görüntüle ";
            this.btAracSayisi.UseVisualStyleBackColor = false;
            this.btAracSayisi.Click += new System.EventHandler(this.btAracSayisi_Click);
            this.btAracSayisi.MouseLeave += new System.EventHandler(this.btAracSayisi_MouseLeave);
            this.btAracSayisi.MouseHover += new System.EventHandler(this.btAracSayisi_MouseHover);
            // 
            // labelAracSayisi
            // 
            this.labelAracSayisi.AutoSize = true;
            this.labelAracSayisi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAracSayisi.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAracSayisi.Location = new System.Drawing.Point(643, 46);
            this.labelAracSayisi.Name = "labelAracSayisi";
            this.labelAracSayisi.Size = new System.Drawing.Size(54, 25);
            this.labelAracSayisi.TabIndex = 12;
            this.labelAracSayisi.Text = "------";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AracKiralama.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(52, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ImageKey = "Button-Close-icon.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(937, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 130);
            this.button2.TabIndex = 14;
            this.button2.Text = "Kayıt Sil";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1104, 613);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelAracSayisi);
            this.Controls.Add(this.btAracSayisi);
            this.Controls.Add(this.labelKazanc);
            this.Controls.Add(this.buttonToplamKazancGoster);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AracKiralamaDataGridView);
            this.Name = "Rapor";
            this.Text = "Rapor";
            this.Load += new System.EventHandler(this.Rapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AracKiralamaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView AracKiralamaDataGridView;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button buttonToplamKazancGoster;
        private System.Windows.Forms.Label labelKazanc;
        private System.Windows.Forms.Button btAracSayisi;
        private System.Windows.Forms.Label labelAracSayisi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}