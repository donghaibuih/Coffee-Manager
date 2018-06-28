namespace GUI
{
    partial class TinhTien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.txt_tienNhanVao = new MetroFramework.Controls.MetroTextBox();
            this.txt_tienPhaiThanhToan = new System.Windows.Forms.Label();
            this.txt_tienThoiLai = new System.Windows.Forms.Label();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhận Vào";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phải Thanh Toán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thối Lại";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(72, 207);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(111, 42);
            this.metroTile1.TabIndex = 3;
            this.metroTile1.Text = "Thanh Toán";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // txt_tienNhanVao
            // 
            // 
            // 
            // 
            this.txt_tienNhanVao.CustomButton.Image = null;
            this.txt_tienNhanVao.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.txt_tienNhanVao.CustomButton.Name = "";
            this.txt_tienNhanVao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_tienNhanVao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_tienNhanVao.CustomButton.TabIndex = 1;
            this.txt_tienNhanVao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_tienNhanVao.CustomButton.UseSelectable = true;
            this.txt_tienNhanVao.CustomButton.Visible = false;
            this.txt_tienNhanVao.Lines = new string[0];
            this.txt_tienNhanVao.Location = new System.Drawing.Point(218, 74);
            this.txt_tienNhanVao.MaxLength = 32767;
            this.txt_tienNhanVao.Name = "txt_tienNhanVao";
            this.txt_tienNhanVao.PasswordChar = '\0';
            this.txt_tienNhanVao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_tienNhanVao.SelectedText = "";
            this.txt_tienNhanVao.SelectionLength = 0;
            this.txt_tienNhanVao.SelectionStart = 0;
            this.txt_tienNhanVao.ShortcutsEnabled = true;
            this.txt_tienNhanVao.Size = new System.Drawing.Size(159, 23);
            this.txt_tienNhanVao.TabIndex = 4;
            this.txt_tienNhanVao.UseSelectable = true;
            this.txt_tienNhanVao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_tienNhanVao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_tienPhaiThanhToan
            // 
            this.txt_tienPhaiThanhToan.AutoSize = true;
            this.txt_tienPhaiThanhToan.Location = new System.Drawing.Point(215, 120);
            this.txt_tienPhaiThanhToan.Name = "txt_tienPhaiThanhToan";
            this.txt_tienPhaiThanhToan.Size = new System.Drawing.Size(90, 13);
            this.txt_tienPhaiThanhToan.TabIndex = 5;
            this.txt_tienPhaiThanhToan.Text = "Phải Thanh Toán";
            // 
            // txt_tienThoiLai
            // 
            this.txt_tienThoiLai.AutoSize = true;
            this.txt_tienThoiLai.Location = new System.Drawing.Point(215, 158);
            this.txt_tienThoiLai.Name = "txt_tienThoiLai";
            this.txt_tienThoiLai.Size = new System.Drawing.Size(45, 13);
            this.txt_tienThoiLai.TabIndex = 6;
            this.txt_tienThoiLai.Text = "Thối Lại";
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(218, 207);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(111, 42);
            this.metroTile2.TabIndex = 7;
            this.metroTile2.Text = "Đóng";
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // TinhTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 296);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.txt_tienThoiLai);
            this.Controls.Add(this.txt_tienPhaiThanhToan);
            this.Controls.Add(this.txt_tienNhanVao);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TinhTien";
            this.Text = "TinhTien";
            this.Load += new System.EventHandler(this.TinhTien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTextBox txt_tienNhanVao;
        private System.Windows.Forms.Label txt_tienPhaiThanhToan;
        private System.Windows.Forms.Label txt_tienThoiLai;
        private MetroFramework.Controls.MetroTile metroTile2;
    }
}