namespace AracKiralama
{
    partial class MüsteriGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MüsteriGiris));
            this.txtMusKaydet = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btGeriDon = new System.Windows.Forms.Button();
            this.labelMusteriAdi = new System.Windows.Forms.Label();
            this.labelMusteriSoyadi = new System.Windows.Forms.Label();
            this.labelMusteriKimlik = new System.Windows.Forms.Label();
            this.txtMusteriSoyad = new System.Windows.Forms.TextBox();
            this.txtMusteriAdi = new System.Windows.Forms.TextBox();
            this.groupBoxMusteri = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaskedKimlik = new System.Windows.Forms.MaskedTextBox();
            this.MusteriDataGridView = new System.Windows.Forms.DataGridView();
            this.musteriIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aracKiralamaDataSet8 = new AracKiralama.AracKiralamaDataSet8();
            this.musteriTableAdapter = new AracKiralama.AracKiralamaDataSet8TableAdapters.MusteriTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxMusteri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracKiralamaDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMusKaydet
            // 
            this.txtMusKaydet.BackColor = System.Drawing.Color.PowderBlue;
            this.txtMusKaydet.FlatAppearance.BorderSize = 0;
            this.txtMusKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtMusKaydet.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusKaydet.ImageKey = "icons8-save-48.png";
            this.txtMusKaydet.ImageList = this.ımageList1;
            this.txtMusKaydet.Location = new System.Drawing.Point(23, 284);
            this.txtMusKaydet.Name = "txtMusKaydet";
            this.txtMusKaydet.Size = new System.Drawing.Size(121, 114);
            this.txtMusKaydet.TabIndex = 0;
            this.txtMusKaydet.Text = "Kaydet";
            this.txtMusKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.txtMusKaydet.UseVisualStyleBackColor = false;
            this.txtMusKaydet.Click += new System.EventHandler(this.btMusteriKayit_Click);
            this.txtMusKaydet.MouseLeave += new System.EventHandler(this.txtMusKaydet_MouseLeave);
            this.txtMusKaydet.MouseHover += new System.EventHandler(this.txtMusKaydet_MouseHover);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icons8-save-48.png");
            this.ımageList1.Images.SetKeyName(1, "icons8-go-back-30.png");
            this.ımageList1.Images.SetKeyName(2, "Button-Close-icon.png");
            // 
            // btGeriDon
            // 
            this.btGeriDon.BackColor = System.Drawing.Color.PowderBlue;
            this.btGeriDon.FlatAppearance.BorderSize = 0;
            this.btGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGeriDon.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btGeriDon.ImageKey = "icons8-go-back-30.png";
            this.btGeriDon.ImageList = this.ımageList1;
            this.btGeriDon.Location = new System.Drawing.Point(183, 284);
            this.btGeriDon.Name = "btGeriDon";
            this.btGeriDon.Size = new System.Drawing.Size(116, 114);
            this.btGeriDon.TabIndex = 1;
            this.btGeriDon.Text = "Geri Dön";
            this.btGeriDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btGeriDon.UseVisualStyleBackColor = false;
            this.btGeriDon.Click += new System.EventHandler(this.btGeriDon_Click);
            this.btGeriDon.MouseLeave += new System.EventHandler(this.btGeriDon_MouseLeave);
            this.btGeriDon.MouseHover += new System.EventHandler(this.btGeriDon_MouseHover);
            // 
            // labelMusteriAdi
            // 
            this.labelMusteriAdi.AutoSize = true;
            this.labelMusteriAdi.BackColor = System.Drawing.Color.PowderBlue;
            this.labelMusteriAdi.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMusteriAdi.Location = new System.Drawing.Point(0, 73);
            this.labelMusteriAdi.Name = "labelMusteriAdi";
            this.labelMusteriAdi.Size = new System.Drawing.Size(110, 23);
            this.labelMusteriAdi.TabIndex = 2;
            this.labelMusteriAdi.Text = "Müşteri Adı:";
            // 
            // labelMusteriSoyadi
            // 
            this.labelMusteriSoyadi.AutoSize = true;
            this.labelMusteriSoyadi.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMusteriSoyadi.Location = new System.Drawing.Point(0, 117);
            this.labelMusteriSoyadi.Name = "labelMusteriSoyadi";
            this.labelMusteriSoyadi.Size = new System.Drawing.Size(139, 23);
            this.labelMusteriSoyadi.TabIndex = 3;
            this.labelMusteriSoyadi.Text = "Müşteri Soyadı:";
            // 
            // labelMusteriKimlik
            // 
            this.labelMusteriKimlik.AutoSize = true;
            this.labelMusteriKimlik.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMusteriKimlik.Location = new System.Drawing.Point(0, 165);
            this.labelMusteriKimlik.Name = "labelMusteriKimlik";
            this.labelMusteriKimlik.Size = new System.Drawing.Size(132, 23);
            this.labelMusteriKimlik.TabIndex = 4;
            this.labelMusteriKimlik.Text = "Müşteri Kimlik:";
            // 
            // txtMusteriSoyad
            // 
            this.txtMusteriSoyad.Location = new System.Drawing.Point(159, 117);
            this.txtMusteriSoyad.Name = "txtMusteriSoyad";
            this.txtMusteriSoyad.Size = new System.Drawing.Size(188, 20);
            this.txtMusteriSoyad.TabIndex = 5;
            this.txtMusteriSoyad.TextChanged += new System.EventHandler(this.txtMusteriSoyad_TextChanged);
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Location = new System.Drawing.Point(159, 73);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Size = new System.Drawing.Size(188, 20);
            this.txtMusteriAdi.TabIndex = 6;
            this.txtMusteriAdi.TextChanged += new System.EventHandler(this.txtMusteriAd_TextChanged);
            // 
            // groupBoxMusteri
            // 
            this.groupBoxMusteri.Controls.Add(this.label1);
            this.groupBoxMusteri.Controls.Add(this.txtMaskedKimlik);
            this.groupBoxMusteri.Controls.Add(this.txtMusteriAdi);
            this.groupBoxMusteri.Controls.Add(this.txtMusteriSoyad);
            this.groupBoxMusteri.Controls.Add(this.labelMusteriAdi);
            this.groupBoxMusteri.Controls.Add(this.labelMusteriKimlik);
            this.groupBoxMusteri.Controls.Add(this.labelMusteriSoyadi);
            this.groupBoxMusteri.Location = new System.Drawing.Point(12, 32);
            this.groupBoxMusteri.Name = "groupBoxMusteri";
            this.groupBoxMusteri.Size = new System.Drawing.Size(353, 226);
            this.groupBoxMusteri.TabIndex = 7;
            this.groupBoxMusteri.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(96, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Müşteri Kaydı";
            // 
            // txtMaskedKimlik
            // 
            this.txtMaskedKimlik.BeepOnError = true;
            this.txtMaskedKimlik.Location = new System.Drawing.Point(159, 165);
            this.txtMaskedKimlik.Mask = "00000000000";
            this.txtMaskedKimlik.Name = "txtMaskedKimlik";
            this.txtMaskedKimlik.Size = new System.Drawing.Size(188, 20);
            this.txtMaskedKimlik.TabIndex = 9;
            this.txtMaskedKimlik.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // MusteriDataGridView
            // 
            this.MusteriDataGridView.AutoGenerateColumns = false;
            this.MusteriDataGridView.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.MusteriDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MusteriDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriIDDataGridViewTextBoxColumn,
            this.tcDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn});
            this.MusteriDataGridView.DataSource = this.musteriBindingSource;
            this.MusteriDataGridView.GridColor = System.Drawing.Color.SlateGray;
            this.MusteriDataGridView.Location = new System.Drawing.Point(425, 424);
            this.MusteriDataGridView.Name = "MusteriDataGridView";
            this.MusteriDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MusteriDataGridView.Size = new System.Drawing.Size(572, 150);
            this.MusteriDataGridView.TabIndex = 10;
            // 
            // musteriIDDataGridViewTextBoxColumn
            // 
            this.musteriIDDataGridViewTextBoxColumn.DataPropertyName = "musteriID";
            this.musteriIDDataGridViewTextBoxColumn.HeaderText = "musteriID";
            this.musteriIDDataGridViewTextBoxColumn.Name = "musteriIDDataGridViewTextBoxColumn";
            this.musteriIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tcDataGridViewTextBoxColumn
            // 
            this.tcDataGridViewTextBoxColumn.DataPropertyName = "tc";
            this.tcDataGridViewTextBoxColumn.HeaderText = "tc";
            this.tcDataGridViewTextBoxColumn.Name = "tcDataGridViewTextBoxColumn";
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // musteriBindingSource
            // 
            this.musteriBindingSource.DataMember = "Musteri";
            this.musteriBindingSource.DataSource = this.aracKiralamaDataSet8;
            // 
            // aracKiralamaDataSet8
            // 
            this.aracKiralamaDataSet8.DataSetName = "AracKiralamaDataSet8";
            this.aracKiralamaDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteriTableAdapter
            // 
            this.musteriTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AracKiralama.Properties.Resources._9;
            this.pictureBox1.Location = new System.Drawing.Point(412, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(558, 329);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(639, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Müşteri Listesi:";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageKey = "Button-Close-icon.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(607, 580);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 110);
            this.button1.TabIndex = 12;
            this.button1.Text = "Kayıt Sil";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MüsteriGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1130, 702);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MusteriDataGridView);
            this.Controls.Add(this.groupBoxMusteri);
            this.Controls.Add(this.txtMusKaydet);
            this.Controls.Add(this.btGeriDon);
            this.Name = "MüsteriGiris";
            this.Text = "MüsteriGiris";
            this.Load += new System.EventHandler(this.MüsteriGiris_Load);
            this.groupBoxMusteri.ResumeLayout(false);
            this.groupBoxMusteri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracKiralamaDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtMusKaydet;
        private System.Windows.Forms.Button btGeriDon;
        private System.Windows.Forms.Label labelMusteriAdi;
        private System.Windows.Forms.Label labelMusteriSoyadi;
        private System.Windows.Forms.Label labelMusteriKimlik;
        private System.Windows.Forms.TextBox txtMusteriSoyad;
        private System.Windows.Forms.TextBox txtMusteriAdi;
        private System.Windows.Forms.GroupBox groupBoxMusteri;
        private System.Windows.Forms.MaskedTextBox txtMaskedKimlik;
        private System.Windows.Forms.DataGridView MusteriDataGridView;
        private AracKiralamaDataSet8 aracKiralamaDataSet8;
        private System.Windows.Forms.BindingSource musteriBindingSource;
        private AracKiralamaDataSet8TableAdapters.MusteriTableAdapter musteriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList2;
    }
}