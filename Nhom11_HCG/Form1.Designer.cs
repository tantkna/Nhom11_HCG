
namespace Nhom11_HCG
{
    partial class Form1
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
            this.txtNhietDo = new System.Windows.Forms.TextBox();
            this.txtDoAm = new System.Windows.Forms.TextBox();
            this.txtThoiGianTuoi = new System.Windows.Forms.TextBox();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhiệt độ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Độ ẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thời gian tưới:";
            // 
            // txtNhietDo
            // 
            this.txtNhietDo.Location = new System.Drawing.Point(302, 132);
            this.txtNhietDo.Name = "txtNhietDo";
            this.txtNhietDo.Size = new System.Drawing.Size(443, 22);
            this.txtNhietDo.TabIndex = 1;
            // 
            // txtDoAm
            // 
            this.txtDoAm.Location = new System.Drawing.Point(302, 199);
            this.txtDoAm.Name = "txtDoAm";
            this.txtDoAm.Size = new System.Drawing.Size(443, 22);
            this.txtDoAm.TabIndex = 2;
            // 
            // txtThoiGianTuoi
            // 
            this.txtThoiGianTuoi.Enabled = false;
            this.txtThoiGianTuoi.Location = new System.Drawing.Point(302, 324);
            this.txtThoiGianTuoi.Name = "txtThoiGianTuoi";
            this.txtThoiGianTuoi.Size = new System.Drawing.Size(443, 22);
            this.txtThoiGianTuoi.TabIndex = 1;
            // 
            // btnKetQua
            // 
            this.btnKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetQua.Location = new System.Drawing.Point(450, 251);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(150, 33);
            this.btnKetQua.TabIndex = 3;
            this.btnKetQua.Text = "Kết quả";
            this.btnKetQua.UseVisualStyleBackColor = true;
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(790, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "HỆ CHUYÊN GIA HỖ TRỢ ĐIỀU KHIỂN LƯỢNG NƯỚC TƯỚI CHO CÂY TRỒNG";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.txtThoiGianTuoi);
            this.Controls.Add(this.txtDoAm);
            this.Controls.Add(this.txtNhietDo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ chuyên gia hỗ trợ điều khiển lượng nước tưới cho cây trồng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNhietDo;
        private System.Windows.Forms.TextBox txtDoAm;
        private System.Windows.Forms.TextBox txtThoiGianTuoi;
        private System.Windows.Forms.Button btnKetQua;
        private System.Windows.Forms.Label label4;
    }
}

