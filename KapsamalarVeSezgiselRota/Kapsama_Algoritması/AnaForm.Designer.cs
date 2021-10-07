namespace KapsamalarVeSezgiselRota
{
    partial class AnaForm
    {
       
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
      
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.btn_ilerle = new System.Windows.Forms.Button();
            this.btn_islem_basla = new System.Windows.Forms.Button();
            this.lbl_sutun = new System.Windows.Forms.Label();
            this.lbl_satir = new System.Windows.Forms.Label();
            this.txt_sutun = new System.Windows.Forms.TextBox();
            this.txt_satir = new System.Windows.Forms.TextBox();
            this.btn_olustur = new System.Windows.Forms.Button();
            this.grb_baslangic = new System.Windows.Forms.GroupBox();
            this.lbl_kapsamalar = new System.Windows.Forms.Label();
            this.matris1 = new System.Windows.Forms.DataGridView();
            this.anaFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grb_baslangic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matris1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anaFormBindingSource)).BeginInit();
            this.SuspendLayout();
           

            this.btn_ilerle.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_ilerle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ilerle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ilerle.Font = new System.Drawing.Font("Times New Roman", 5.5F, System.Drawing.FontStyle.Bold);
            this.btn_ilerle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_ilerle.Location = new System.Drawing.Point(345, 22);
            this.btn_ilerle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ilerle.Name = "btn_ilerle";
            this.btn_ilerle.Size = new System.Drawing.Size(56, 44);
            this.btn_ilerle.TabIndex = 14;
            this.btn_ilerle.Text = "SONRAKİ ADIM";
            this.btn_ilerle.UseVisualStyleBackColor = false;
            this.btn_ilerle.Click += new System.EventHandler(this.btn_ilerle_Click);
            

            this.btn_islem_basla.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_islem_basla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_islem_basla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_islem_basla.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_islem_basla.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_islem_basla.Location = new System.Drawing.Point(279, 20);
            this.btn_islem_basla.Margin = new System.Windows.Forms.Padding(2);
            this.btn_islem_basla.Name = "btn_islem_basla";
            this.btn_islem_basla.Size = new System.Drawing.Size(56, 44);
            this.btn_islem_basla.TabIndex = 13;
            this.btn_islem_basla.Text = "BAŞLAT";
            this.btn_islem_basla.UseVisualStyleBackColor = false;
            this.btn_islem_basla.Click += new System.EventHandler(this.btn_islem_basla_Click);
            
            
            this.lbl_sutun.AutoSize = true;
            this.lbl_sutun.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_sutun.Location = new System.Drawing.Point(86, 16);
            this.lbl_sutun.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_sutun.Name = "lbl_sutun";
            this.lbl_sutun.Size = new System.Drawing.Size(44, 14);
            this.lbl_sutun.TabIndex = 12;
            this.lbl_sutun.Text = "SÜTUN";
            
            
            this.lbl_satir.AutoSize = true;
            this.lbl_satir.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_satir.Location = new System.Drawing.Point(47, 16);
            this.lbl_satir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_satir.Name = "lbl_satir";
            this.lbl_satir.Size = new System.Drawing.Size(38, 14);
            this.lbl_satir.TabIndex = 11;
            this.lbl_satir.Text = "SATIR";
           
            
            this.txt_sutun.Location = new System.Drawing.Point(89, 32);
            this.txt_sutun.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sutun.Multiline = true;
            this.txt_sutun.Name = "txt_sutun";
            this.txt_sutun.Size = new System.Drawing.Size(38, 29);
            this.txt_sutun.TabIndex = 10;
            this.txt_sutun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_sutun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sutun_KeyPress);
            

            this.txt_satir.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txt_satir.Location = new System.Drawing.Point(47, 32);
            this.txt_satir.Margin = new System.Windows.Forms.Padding(2);
            this.txt_satir.Multiline = true;
            this.txt_satir.Name = "txt_satir";
            this.txt_satir.Size = new System.Drawing.Size(38, 29);
            this.txt_satir.TabIndex = 9;
            this.txt_satir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_satir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_satir_KeyPress);
            
            
            this.btn_olustur.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_olustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_olustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_olustur.Font = new System.Drawing.Font("Times New Roman", 6F, System.Drawing.FontStyle.Bold);
            this.btn_olustur.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_olustur.Location = new System.Drawing.Point(171, 20);
            this.btn_olustur.Margin = new System.Windows.Forms.Padding(2);
            this.btn_olustur.Name = "btn_olustur";
            this.btn_olustur.Size = new System.Drawing.Size(55, 44);
            this.btn_olustur.TabIndex = 8;
            this.btn_olustur.Text = "MATRİS OLUŞTUR";
            this.btn_olustur.UseVisualStyleBackColor = false;
            this.btn_olustur.Click += new System.EventHandler(this.btn_olustur_Click);
            
            
            this.grb_baslangic.Controls.Add(this.btn_olustur);
            this.grb_baslangic.Controls.Add(this.txt_sutun);
            this.grb_baslangic.Controls.Add(this.txt_satir);
            this.grb_baslangic.Controls.Add(this.lbl_satir);
            this.grb_baslangic.Controls.Add(this.lbl_sutun);            
            this.grb_baslangic.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grb_baslangic.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.grb_baslangic.Location = new System.Drawing.Point(13, 0);
            this.grb_baslangic.Margin = new System.Windows.Forms.Padding(2);
            this.grb_baslangic.Name = "grb_baslangic";
            this.grb_baslangic.Padding = new System.Windows.Forms.Padding(2);
            this.grb_baslangic.Size = new System.Drawing.Size(262, 86);
            this.grb_baslangic.TabIndex = 16;
            this.grb_baslangic.TabStop = false;
            this.grb_baslangic.Text = "Matrisin Boyutunu Belirleryiniz:";
          
            
            
            this.lbl_kapsamalar.AutoSize = true;
            this.lbl_kapsamalar.BackColor = System.Drawing.Color.IndianRed;
            this.lbl_kapsamalar.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.lbl_kapsamalar.ForeColor = System.Drawing.Color.White;
            this.lbl_kapsamalar.Location = new System.Drawing.Point(405, 50);
            this.lbl_kapsamalar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_kapsamalar.Name = "lbl_kapsamalar";
            this.lbl_kapsamalar.Size = new System.Drawing.Size(88, 14);
            this.lbl_kapsamalar.TabIndex = 17;
            this.lbl_kapsamalar.Text = "'KAPSAMLAR'  π-->";
            
            
            this.matris1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.matris1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matris1.Location = new System.Drawing.Point(13, 106);
            this.matris1.Margin = new System.Windows.Forms.Padding(2);
            this.matris1.Name = "matris1";
            this.matris1.RowHeadersWidth = 51;
            this.matris1.RowTemplate.Height = 24;
            this.matris1.Size = new System.Drawing.Size(180, 131);
            this.matris1.TabIndex = 18;
            this.matris1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.matris1_CellMouseDoubleClick);
            
            
            this.anaFormBindingSource.DataSource = typeof(KapsamalarVeSezgiselRota.AnaForm);
           
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(832, 613);
            this.Controls.Add(this.matris1);
            this.Controls.Add(this.lbl_kapsamalar);
            this.Controls.Add(this.grb_baslangic);
            this.Controls.Add(this.btn_ilerle);
            this.Controls.Add(this.btn_islem_basla);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kapsama Algoritması";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.grb_baslangic.ResumeLayout(false);
            this.grb_baslangic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matris1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anaFormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_ilerle;
        private System.Windows.Forms.Button btn_islem_basla;
        private System.Windows.Forms.Label lbl_sutun;
        private System.Windows.Forms.Label lbl_satir;
        private System.Windows.Forms.TextBox txt_sutun;
        private System.Windows.Forms.TextBox txt_satir;
        private System.Windows.Forms.Button btn_olustur;
        private System.Windows.Forms.GroupBox grb_baslangic;     
        private System.Windows.Forms.Label lbl_kapsamalar;
        private System.Windows.Forms.BindingSource anaFormBindingSource;
        private System.Windows.Forms.DataGridView matris1;
    }
}