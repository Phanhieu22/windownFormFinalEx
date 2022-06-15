
namespace QL_thuoc
{
    partial class TK_khach_hang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.rbt_ma_kh = new System.Windows.Forms.RadioButton();
            this.rbt_ten_kh = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_ma_kh = new System.Windows.Forms.TextBox();
            this.txt_ten_kh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(35, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(731, 164);
            this.dataGridView1.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maKhachHang";
            this.Column1.HeaderText = "Mã khách hàng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenKhachHang";
            this.Column2.HeaderText = "Tên khách hàng";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "diaChi";
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SoDienThoai";
            this.Column4.HeaderText = "Số điện thoại";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.iconPictureBox1);
            this.groupBox1.Controls.Add(this.rbt_ma_kh);
            this.groupBox1.Controls.Add(this.rbt_ten_kh);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_ma_kh);
            this.groupBox1.Controls.Add(this.txt_ten_kh);
            this.groupBox1.Location = new System.Drawing.Point(161, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 161);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 23;
            this.iconPictureBox1.Location = new System.Drawing.Point(306, 48);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Padding = new System.Windows.Forms.Padding(2, 1, 0, 0);
            this.iconPictureBox1.Size = new System.Drawing.Size(23, 24);
            this.iconPictureBox1.TabIndex = 8;
            this.iconPictureBox1.TabStop = false;
            // 
            // rbt_ma_kh
            // 
            this.rbt_ma_kh.AutoSize = true;
            this.rbt_ma_kh.Location = new System.Drawing.Point(65, 100);
            this.rbt_ma_kh.Name = "rbt_ma_kh";
            this.rbt_ma_kh.Size = new System.Drawing.Size(168, 17);
            this.rbt_ma_kh.TabIndex = 7;
            this.rbt_ma_kh.TabStop = true;
            this.rbt_ma_kh.Text = "Tìm kiếm theo mã khách hàng";
            this.rbt_ma_kh.UseVisualStyleBackColor = true;
            this.rbt_ma_kh.CheckedChanged += new System.EventHandler(this.rbt_ma_kh_CheckedChanged);
            // 
            // rbt_ten_kh
            // 
            this.rbt_ten_kh.AutoSize = true;
            this.rbt_ten_kh.Location = new System.Drawing.Point(65, 19);
            this.rbt_ten_kh.Name = "rbt_ten_kh";
            this.rbt_ten_kh.Size = new System.Drawing.Size(169, 17);
            this.rbt_ten_kh.TabIndex = 2;
            this.rbt_ten_kh.TabStop = true;
            this.rbt_ten_kh.Text = "Tìm kiếm theo tên khách hàng";
            this.rbt_ten_kh.UseVisualStyleBackColor = true;
            this.rbt_ten_kh.CheckedChanged += new System.EventHandler(this.rbt_ten_kh_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(306, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "Chọn tất cả";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_ma_kh
            // 
            this.txt_ma_kh.Location = new System.Drawing.Point(65, 123);
            this.txt_ma_kh.Name = "txt_ma_kh";
            this.txt_ma_kh.Size = new System.Drawing.Size(155, 20);
            this.txt_ma_kh.TabIndex = 4;
            // 
            // txt_ten_kh
            // 
            this.txt_ten_kh.Location = new System.Drawing.Point(65, 48);
            this.txt_ten_kh.Name = "txt_ten_kh";
            this.txt_ten_kh.Size = new System.Drawing.Size(155, 20);
            this.txt_ten_kh.TabIndex = 3;
            // 
            // TK_khach_hang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "TK_khach_hang";
            this.Text = "TK_khach_hang";
            this.Load += new System.EventHandler(this.TK_khach_hang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.RadioButton rbt_ma_kh;
        private System.Windows.Forms.RadioButton rbt_ten_kh;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_ma_kh;
        private System.Windows.Forms.TextBox txt_ten_kh;
    }
}