namespace AracKiralama
{
    partial class AracGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracGiris));
            this.btnAracKaydet = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtAracPlaka = new System.Windows.Forms.TextBox();
            this.btGeriDon = new System.Windows.Forms.Button();
            this.groupBoxAracKayıt = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.labelDurum = new System.Windows.Forms.Label();
            this.cmbmodel = new System.Windows.Forms.ComboBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.cmbmarka = new System.Windows.Forms.ComboBox();
            this.labelMarka = new System.Windows.Forms.Label();
            this.labelPlaka = new System.Windows.Forms.Label();
            this.AracDataGridView = new System.Windows.Forms.DataGridView();
            this.aracIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.araclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aracKiralamaDataSet7 = new AracKiralama.AracKiralamaDataSet7();
            this.araclarTableAdapter = new AracKiralama.AracKiralamaDataSet7TableAdapters.AraclarTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAracID = new System.Windows.Forms.TextBox();
            this.labelKayitliArac = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxAracKayıt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AracDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araclarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracKiralamaDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAracKaydet
            // 
            this.btnAracKaydet.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAracKaydet.FlatAppearance.BorderSize = 0;
            this.btnAracKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAracKaydet.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracKaydet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAracKaydet.ImageKey = "icons8-save-48.png";
            this.btnAracKaydet.ImageList = this.ımageList1;
            this.btnAracKaydet.Location = new System.Drawing.Point(1, 355);
            this.btnAracKaydet.Name = "btnAracKaydet";
            this.btnAracKaydet.Size = new System.Drawing.Size(136, 101);
            this.btnAracKaydet.TabIndex = 0;
            this.btnAracKaydet.Text = "Kaydet";
            this.btnAracKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAracKaydet.UseVisualStyleBackColor = false;
            this.btnAracKaydet.Click += new System.EventHandler(this.btnAracKayit_Click);
            this.btnAracKaydet.MouseLeave += new System.EventHandler(this.btnAracKaydet_MouseLeave);
            this.btnAracKaydet.MouseHover += new System.EventHandler(this.btnAracKaydet_MouseHover);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icons8-save-48.png");
            this.ımageList1.Images.SetKeyName(1, "icons8-go-back-30.png");
            this.ımageList1.Images.SetKeyName(2, "Button-Close-icon.png");
            // 
            // txtAracPlaka
            // 
            this.txtAracPlaka.Location = new System.Drawing.Point(122, 76);
            this.txtAracPlaka.Name = "txtAracPlaka";
            this.txtAracPlaka.Size = new System.Drawing.Size(121, 20);
            this.txtAracPlaka.TabIndex = 1;
            this.txtAracPlaka.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btGeriDon
            // 
            this.btGeriDon.BackColor = System.Drawing.Color.PowderBlue;
            this.btGeriDon.FlatAppearance.BorderSize = 0;
            this.btGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGeriDon.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btGeriDon.ImageKey = "icons8-go-back-30.png";
            this.btGeriDon.ImageList = this.ımageList1;
            this.btGeriDon.Location = new System.Drawing.Point(143, 355);
            this.btGeriDon.Name = "btGeriDon";
            this.btGeriDon.Size = new System.Drawing.Size(132, 101);
            this.btGeriDon.TabIndex = 2;
            this.btGeriDon.Text = "Geri Dön";
            this.btGeriDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btGeriDon.UseVisualStyleBackColor = false;
            this.btGeriDon.Click += new System.EventHandler(this.btGeriDon_Click);
            this.btGeriDon.MouseLeave += new System.EventHandler(this.btGeriDon_MouseLeave);
            this.btGeriDon.MouseHover += new System.EventHandler(this.btGeriDon_MouseHover);
            // 
            // groupBoxAracKayıt
            // 
            this.groupBoxAracKayıt.Controls.Add(this.label1);
            this.groupBoxAracKayıt.Controls.Add(this.txtDurum);
            this.groupBoxAracKayıt.Controls.Add(this.labelDurum);
            this.groupBoxAracKayıt.Controls.Add(this.cmbmodel);
            this.groupBoxAracKayıt.Controls.Add(this.labelModel);
            this.groupBoxAracKayıt.Controls.Add(this.cmbmarka);
            this.groupBoxAracKayıt.Controls.Add(this.labelMarka);
            this.groupBoxAracKayıt.Controls.Add(this.labelPlaka);
            this.groupBoxAracKayıt.Controls.Add(this.txtAracPlaka);
            this.groupBoxAracKayıt.Location = new System.Drawing.Point(21, 28);
            this.groupBoxAracKayıt.Name = "groupBoxAracKayıt";
            this.groupBoxAracKayıt.Size = new System.Drawing.Size(270, 270);
            this.groupBoxAracKayıt.TabIndex = 3;
            this.groupBoxAracKayıt.TabStop = false;
            this.groupBoxAracKayıt.Enter += new System.EventHandler(this.groupBoxAracKayıt_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(83, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Araç Kayıt";
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(122, 198);
            this.txtDurum.Multiline = true;
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(121, 23);
            this.txtDurum.TabIndex = 8;
            this.txtDurum.TextChanged += new System.EventHandler(this.txtDurum_TextChanged);
            // 
            // labelDurum
            // 
            this.labelDurum.AutoSize = true;
            this.labelDurum.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDurum.Location = new System.Drawing.Point(30, 198);
            this.labelDurum.Name = "labelDurum";
            this.labelDurum.Size = new System.Drawing.Size(75, 23);
            this.labelDurum.TabIndex = 5;
            this.labelDurum.Text = "Durum:";
            this.labelDurum.Click += new System.EventHandler(this.labelDurum_Click);
            // 
            // cmbmodel
            // 
            this.cmbmodel.FormattingEnabled = true;
            this.cmbmodel.Location = new System.Drawing.Point(122, 155);
            this.cmbmodel.Name = "cmbmodel";
            this.cmbmodel.Size = new System.Drawing.Size(121, 21);
            this.cmbmodel.TabIndex = 12;
            this.cmbmodel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelModel.Location = new System.Drawing.Point(30, 155);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(67, 23);
            this.labelModel.TabIndex = 4;
            this.labelModel.Text = "Model:";
            this.labelModel.Click += new System.EventHandler(this.labelModel_Click);
            // 
            // cmbmarka
            // 
            this.cmbmarka.FormattingEnabled = true;
            this.cmbmarka.Location = new System.Drawing.Point(122, 115);
            this.cmbmarka.Name = "cmbmarka";
            this.cmbmarka.Size = new System.Drawing.Size(121, 21);
            this.cmbmarka.TabIndex = 11;
            this.cmbmarka.SelectedIndexChanged += new System.EventHandler(this.cmbmarka_SelectedIndexChanged);
            // 
            // labelMarka
            // 
            this.labelMarka.AutoSize = true;
            this.labelMarka.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMarka.Location = new System.Drawing.Point(29, 113);
            this.labelMarka.Name = "labelMarka";
            this.labelMarka.Size = new System.Drawing.Size(68, 23);
            this.labelMarka.TabIndex = 3;
            this.labelMarka.Text = "Marka:";
            this.labelMarka.Click += new System.EventHandler(this.labelMarka_Click);
            // 
            // labelPlaka
            // 
            this.labelPlaka.AutoSize = true;
            this.labelPlaka.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPlaka.Location = new System.Drawing.Point(29, 76);
            this.labelPlaka.Name = "labelPlaka";
            this.labelPlaka.Size = new System.Drawing.Size(66, 23);
            this.labelPlaka.TabIndex = 2;
            this.labelPlaka.Text = "Plaka :";
            this.labelPlaka.Click += new System.EventHandler(this.labelPlaka_Click);
            // 
            // AracDataGridView
            // 
            this.AracDataGridView.AutoGenerateColumns = false;
            this.AracDataGridView.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.AracDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AracDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aracIDDataGridViewTextBoxColumn,
            this.plakaDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.durumDataGridViewCheckBoxColumn});
            this.AracDataGridView.DataSource = this.araclarBindingSource;
            this.AracDataGridView.Location = new System.Drawing.Point(346, 337);
            this.AracDataGridView.Name = "AracDataGridView";
            this.AracDataGridView.Size = new System.Drawing.Size(540, 195);
            this.AracDataGridView.TabIndex = 10;
            // 
            // aracIDDataGridViewTextBoxColumn
            // 
            this.aracIDDataGridViewTextBoxColumn.DataPropertyName = "aracID";
            this.aracIDDataGridViewTextBoxColumn.HeaderText = "aracID";
            this.aracIDDataGridViewTextBoxColumn.Name = "aracIDDataGridViewTextBoxColumn";
            this.aracIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plakaDataGridViewTextBoxColumn
            // 
            this.plakaDataGridViewTextBoxColumn.DataPropertyName = "plaka";
            this.plakaDataGridViewTextBoxColumn.HeaderText = "plaka";
            this.plakaDataGridViewTextBoxColumn.Name = "plakaDataGridViewTextBoxColumn";
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "marka";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // durumDataGridViewCheckBoxColumn
            // 
            this.durumDataGridViewCheckBoxColumn.DataPropertyName = "durum";
            this.durumDataGridViewCheckBoxColumn.HeaderText = "durum";
            this.durumDataGridViewCheckBoxColumn.Name = "durumDataGridViewCheckBoxColumn";
            // 
            // araclarBindingSource
            // 
            this.araclarBindingSource.DataMember = "Araclar";
            this.araclarBindingSource.DataSource = this.aracKiralamaDataSet7;
            // 
            // aracKiralamaDataSet7
            // 
            this.aracKiralamaDataSet7.DataSetName = "AracKiralamaDataSet7";
            this.aracKiralamaDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // araclarTableAdapter
            // 
            this.araclarTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AracKiralama.Properties.Resources.Ekran_görüntüsü_2022_12_25_145238;
            this.pictureBox1.Location = new System.Drawing.Point(335, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(540, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // txtAracID
            // 
            this.txtAracID.BackColor = System.Drawing.Color.PowderBlue;
            this.txtAracID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAracID.Location = new System.Drawing.Point(542, 217);
            this.txtAracID.Name = "txtAracID";
            this.txtAracID.Size = new System.Drawing.Size(10, 20);
            this.txtAracID.TabIndex = 13;
            this.txtAracID.Visible = false;
            this.txtAracID.TextChanged += new System.EventHandler(this.txtAracID_SelectedIndexChanged);
            // 
            // labelKayitliArac
            // 
            this.labelKayitliArac.AutoSize = true;
            this.labelKayitliArac.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKayitliArac.Location = new System.Drawing.Point(537, 293);
            this.labelKayitliArac.Name = "labelKayitliArac";
            this.labelKayitliArac.Size = new System.Drawing.Size(184, 25);
            this.labelKayitliArac.TabIndex = 15;
            this.labelKayitliArac.Text = "Kayıtlı Araçlarımız:";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageKey = "Button-Close-icon.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(542, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 101);
            this.button1.TabIndex = 16;
            this.button1.Text = "Kayıt Sil";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AracGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1003, 672);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelKayitliArac);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AracDataGridView);
            this.Controls.Add(this.groupBoxAracKayıt);
            this.Controls.Add(this.btGeriDon);
            this.Controls.Add(this.btnAracKaydet);
            this.Controls.Add(this.txtAracID);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "AracGiris";
            this.Text = "AracGiris";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxAracKayıt.ResumeLayout(false);
            this.groupBoxAracKayıt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AracDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araclarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracKiralamaDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAracKaydet;
        private System.Windows.Forms.TextBox txtAracPlaka;
        private System.Windows.Forms.Button btGeriDon;
        private System.Windows.Forms.GroupBox groupBoxAracKayıt;
        private System.Windows.Forms.Label labelPlaka;
        private System.Windows.Forms.Label labelDurum;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelMarka;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.DataGridView AracDataGridView;
        private AracKiralamaDataSet7 aracKiralamaDataSet7;
        private System.Windows.Forms.BindingSource araclarBindingSource;
        private AracKiralamaDataSet7TableAdapters.AraclarTableAdapter araclarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn durumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ComboBox cmbmarka;
        private System.Windows.Forms.ComboBox cmbmodel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAracID;
        private System.Windows.Forms.Label labelKayitliArac;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button1;
    }
}

