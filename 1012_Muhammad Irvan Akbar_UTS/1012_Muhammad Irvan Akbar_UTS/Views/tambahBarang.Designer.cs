﻿namespace _1012_Muhammad_Irvan_Akbar_UTS.Views
{
    partial class tambahBarang
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
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(250, 40);
            label1.Name = "label1";
            label1.Size = new Size(402, 34);
            label1.TabIndex = 0;
            label1.Text = "MASUKKAN BARANG BARU ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(74, 132);
            label2.Name = "label2";
            label2.Size = new Size(131, 24);
            label2.TabIndex = 1;
            label2.Text = "Nama Barang";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(250, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(361, 32);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(74, 198);
            label3.Name = "label3";
            label3.Size = new Size(85, 24);
            label3.TabIndex = 3;
            label3.Text = "Kategori";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(250, 260);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(361, 32);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(74, 259);
            label4.Name = "label4";
            label4.Size = new Size(79, 24);
            label4.TabIndex = 5;
            label4.Text = "Jumlah ";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(250, 322);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(361, 32);
            textBox4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(74, 321);
            label5.Name = "label5";
            label5.Size = new Size(70, 24);
            label5.TabIndex = 7;
            label5.Text = "Harga ";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(250, 199);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(283, 32);
            comboBox1.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(499, 392);
            button1.Name = "button1";
            button1.Size = new Size(112, 35);
            button1.TabIndex = 10;
            button1.Text = "Tambah";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(313, 392);
            button2.Name = "button2";
            button2.Size = new Size(112, 35);
            button2.TabIndex = 11;
            button2.Text = "Batal";
            button2.UseVisualStyleBackColor = false;
            // 
            // tambahBarang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LimeGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "tambahBarang";
            Text = "tambahBarang";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
    }
}