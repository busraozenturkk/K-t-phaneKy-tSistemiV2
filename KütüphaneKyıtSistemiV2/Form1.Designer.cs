namespace KütüphaneKyıtSistemiV2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            kitapBindingSource = new BindingSource(components);
            adDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yazarDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yayıneviDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fiyatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adFiyatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kitapBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 153);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(35, 25);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(170, 148);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 31);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(170, 215);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 31);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 220);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 2;
            label2.Text = "Yazar";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(170, 288);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(175, 31);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 293);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 4;
            label3.Text = "Yayınevi";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(170, 358);
            textBox4.Margin = new Padding(4, 5, 4, 5);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(175, 31);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 363);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 6;
            label4.Text = "Fiyat";
            // 
            // button1
            // 
            button1.Location = new Point(170, 440);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 8;
            button1.Text = "KAYDET";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 73);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(98, 25);
            label5.TabIndex = 9;
            label5.Text = "KİTAP EKLE";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { adDataGridViewTextBoxColumn, yazarDataGridViewTextBoxColumn, yayıneviDataGridViewTextBoxColumn, fiyatDataGridViewTextBoxColumn, adFiyatDataGridViewTextBoxColumn });
            dataGridView1.DataSource = kitapBindingSource;
            dataGridView1.Location = new Point(377, 147);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(476, 250);
            dataGridView1.TabIndex = 10;
            // 
            // kitapBindingSource
            // 
            kitapBindingSource.DataSource = typeof(Model.Kitap);
            // 
            // adDataGridViewTextBoxColumn
            // 
            adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            adDataGridViewTextBoxColumn.HeaderText = "Ad";
            adDataGridViewTextBoxColumn.MinimumWidth = 8;
            adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            adDataGridViewTextBoxColumn.Width = 150;
            // 
            // yazarDataGridViewTextBoxColumn
            // 
            yazarDataGridViewTextBoxColumn.DataPropertyName = "Yazar";
            yazarDataGridViewTextBoxColumn.HeaderText = "Yazar";
            yazarDataGridViewTextBoxColumn.MinimumWidth = 8;
            yazarDataGridViewTextBoxColumn.Name = "yazarDataGridViewTextBoxColumn";
            yazarDataGridViewTextBoxColumn.Width = 150;
            // 
            // yayıneviDataGridViewTextBoxColumn
            // 
            yayıneviDataGridViewTextBoxColumn.DataPropertyName = "Yayınevi";
            yayıneviDataGridViewTextBoxColumn.HeaderText = "Yayınevi";
            yayıneviDataGridViewTextBoxColumn.MinimumWidth = 8;
            yayıneviDataGridViewTextBoxColumn.Name = "yayıneviDataGridViewTextBoxColumn";
            yayıneviDataGridViewTextBoxColumn.Width = 150;
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            fiyatDataGridViewTextBoxColumn.MinimumWidth = 8;
            fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            fiyatDataGridViewTextBoxColumn.Width = 150;
            // 
            // adFiyatDataGridViewTextBoxColumn
            // 
            adFiyatDataGridViewTextBoxColumn.DataPropertyName = "AdFiyat";
            adFiyatDataGridViewTextBoxColumn.HeaderText = "AdFiyat";
            adFiyatDataGridViewTextBoxColumn.MinimumWidth = 8;
            adFiyatDataGridViewTextBoxColumn.Name = "adFiyatDataGridViewTextBoxColumn";
            adFiyatDataGridViewTextBoxColumn.ReadOnly = true;
            adFiyatDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 647);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kitapBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Button button1;
        private Label label5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yazarDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yayıneviDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adFiyatDataGridViewTextBoxColumn;
        private BindingSource kitapBindingSource;
    }
}