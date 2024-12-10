namespace Petrol_Otomasyon
{
    partial class Kasa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.petrol_otomasyonDataSet1 = new Petrol_Otomasyon.petrol_otomasyonDataSet1();
            this.kasaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kasaTableAdapter = new Petrol_Otomasyon.petrol_otomasyonDataSet1TableAdapters.KasaTableAdapter();
            this.kasaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pompaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satilanYakitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odemeTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıslemTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıslemYapanPersonelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrol_otomasyonDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kasaIDDataGridViewTextBoxColumn,
            this.pompaIDDataGridViewTextBoxColumn,
            this.satilanYakitDataGridViewTextBoxColumn,
            this.odemeTuruDataGridViewTextBoxColumn,
            this.tutarDataGridViewTextBoxColumn,
            this.ıslemTarihiDataGridViewTextBoxColumn,
            this.ıslemYapanPersonelIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kasaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 212);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(86, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "KULLANICI ADI :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(181, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "ŞİFRE :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(296, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "KASA GİRİŞİ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(313, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 30);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(313, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 30);
            this.textBox2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(555, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 65);
            this.button1.TabIndex = 6;
            this.button1.Text = "GİRİŞ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // petrol_otomasyonDataSet1
            // 
            this.petrol_otomasyonDataSet1.DataSetName = "petrol_otomasyonDataSet1";
            this.petrol_otomasyonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kasaBindingSource
            // 
            this.kasaBindingSource.DataMember = "Kasa";
            this.kasaBindingSource.DataSource = this.petrol_otomasyonDataSet1;
            // 
            // kasaTableAdapter
            // 
            this.kasaTableAdapter.ClearBeforeFill = true;
            // 
            // kasaIDDataGridViewTextBoxColumn
            // 
            this.kasaIDDataGridViewTextBoxColumn.DataPropertyName = "KasaID";
            this.kasaIDDataGridViewTextBoxColumn.HeaderText = "KasaID";
            this.kasaIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kasaIDDataGridViewTextBoxColumn.Name = "kasaIDDataGridViewTextBoxColumn";
            this.kasaIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // pompaIDDataGridViewTextBoxColumn
            // 
            this.pompaIDDataGridViewTextBoxColumn.DataPropertyName = "PompaID";
            this.pompaIDDataGridViewTextBoxColumn.HeaderText = "PompaID";
            this.pompaIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pompaIDDataGridViewTextBoxColumn.Name = "pompaIDDataGridViewTextBoxColumn";
            this.pompaIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // satilanYakitDataGridViewTextBoxColumn
            // 
            this.satilanYakitDataGridViewTextBoxColumn.DataPropertyName = "SatilanYakit";
            this.satilanYakitDataGridViewTextBoxColumn.HeaderText = "SatilanYakit";
            this.satilanYakitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.satilanYakitDataGridViewTextBoxColumn.Name = "satilanYakitDataGridViewTextBoxColumn";
            this.satilanYakitDataGridViewTextBoxColumn.Width = 125;
            // 
            // odemeTuruDataGridViewTextBoxColumn
            // 
            this.odemeTuruDataGridViewTextBoxColumn.DataPropertyName = "OdemeTuru";
            this.odemeTuruDataGridViewTextBoxColumn.HeaderText = "OdemeTuru";
            this.odemeTuruDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odemeTuruDataGridViewTextBoxColumn.Name = "odemeTuruDataGridViewTextBoxColumn";
            this.odemeTuruDataGridViewTextBoxColumn.Width = 125;
            // 
            // tutarDataGridViewTextBoxColumn
            // 
            this.tutarDataGridViewTextBoxColumn.DataPropertyName = "Tutar";
            this.tutarDataGridViewTextBoxColumn.HeaderText = "Tutar";
            this.tutarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tutarDataGridViewTextBoxColumn.Name = "tutarDataGridViewTextBoxColumn";
            this.tutarDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıslemTarihiDataGridViewTextBoxColumn
            // 
            this.ıslemTarihiDataGridViewTextBoxColumn.DataPropertyName = "IslemTarihi";
            this.ıslemTarihiDataGridViewTextBoxColumn.HeaderText = "IslemTarihi";
            this.ıslemTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıslemTarihiDataGridViewTextBoxColumn.Name = "ıslemTarihiDataGridViewTextBoxColumn";
            this.ıslemTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıslemYapanPersonelIDDataGridViewTextBoxColumn
            // 
            this.ıslemYapanPersonelIDDataGridViewTextBoxColumn.DataPropertyName = "IslemYapanPersonelID";
            this.ıslemYapanPersonelIDDataGridViewTextBoxColumn.HeaderText = "IslemYapanPersonelID";
            this.ıslemYapanPersonelIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıslemYapanPersonelIDDataGridViewTextBoxColumn.Name = "ıslemYapanPersonelIDDataGridViewTextBoxColumn";
            this.ıslemYapanPersonelIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // Kasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Kasa";
            this.Text = "Kasa";
            this.Load += new System.EventHandler(this.Kasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrol_otomasyonDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private petrol_otomasyonDataSet1 petrol_otomasyonDataSet1;
        private System.Windows.Forms.BindingSource kasaBindingSource;
        private petrol_otomasyonDataSet1TableAdapters.KasaTableAdapter kasaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kasaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pompaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satilanYakitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemeTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıslemTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıslemYapanPersonelIDDataGridViewTextBoxColumn;
    }
}