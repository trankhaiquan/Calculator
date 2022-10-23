namespace Calculator
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btCong = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.Label();
            this.btTru = new System.Windows.Forms.Button();
            this.btNhan = new System.Windows.Forms.Button();
            this.btChia = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số A";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(167, 57);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(183, 20);
            this.txtA.TabIndex = 1;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(167, 100);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(183, 20);
            this.txtB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số B";
            // 
            // btCong
            // 
            this.btCong.Location = new System.Drawing.Point(224, 344);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(75, 23);
            this.btCong.TabIndex = 4;
            this.btCong.Text = "+";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 20);
            this.textBox1.TabIndex = 6;
            // 
            // txtKQ
            // 
            this.txtKQ.AutoSize = true;
            this.txtKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKQ.Location = new System.Drawing.Point(36, 146);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(97, 25);
            this.txtKQ.TabIndex = 5;
            this.txtKQ.Text = "Kết Quả";
            // 
            // btTru
            // 
            this.btTru.Location = new System.Drawing.Point(332, 344);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(75, 23);
            this.btTru.TabIndex = 7;
            this.btTru.Text = "-";
            this.btTru.UseVisualStyleBackColor = true;
            this.btTru.Click += new System.EventHandler(this.btTru_Click);
            // 
            // btNhan
            // 
            this.btNhan.Location = new System.Drawing.Point(425, 344);
            this.btNhan.Name = "btNhan";
            this.btNhan.Size = new System.Drawing.Size(75, 23);
            this.btNhan.TabIndex = 8;
            this.btNhan.Text = "x";
            this.btNhan.UseVisualStyleBackColor = true;
            // 
            // btChia
            // 
            this.btChia.Location = new System.Drawing.Point(522, 344);
            this.btChia.Name = "btChia";
            this.btChia.Size = new System.Drawing.Size(75, 23);
            this.btChia.TabIndex = 9;
            this.btChia.Text = "/";
            this.btChia.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(344, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Chương trình tính toán đơn giản";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtKQ);
            this.groupBox1.Location = new System.Drawing.Point(129, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 257);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tính toán đơn giản";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btChia);
            this.Controls.Add(this.btNhan);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.btTru);
            this.Name = "Form1";
            this.Text = "la";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtKQ;
        private System.Windows.Forms.Button btTru;
        private System.Windows.Forms.Button btNhan;
        private System.Windows.Forms.Button btChia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

