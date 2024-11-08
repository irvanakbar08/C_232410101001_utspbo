namespace _1012_Muhammad_Irvan_Akbar_UTS.Views
{
    partial class halDasboardAdmin
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnTambahBarang = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(274, 33);
            label1.Name = "label1";
            label1.Size = new Size(255, 34);
            label1.TabIndex = 0;
            label1.Text = "DAFTAR BARANG";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(744, 242);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnTambahBarang
            // 
            btnTambahBarang.BackColor = Color.SteelBlue;
            btnTambahBarang.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambahBarang.ForeColor = SystemColors.ButtonHighlight;
            btnTambahBarang.Location = new Point(594, 392);
            btnTambahBarang.Name = "btnTambahBarang";
            btnTambahBarang.Size = new Size(163, 34);
            btnTambahBarang.TabIndex = 0;
            btnTambahBarang.Text = "Tambah Barang";
            btnTambahBarang.UseVisualStyleBackColor = false;
            btnTambahBarang.Click += btnTambahBarang_Click_1;
            // 
            // halDasboardAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTambahBarang);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "halDasboardAdmin";
            Text = "halDasboardAdmin";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button btnTambahBarang;
    }
}