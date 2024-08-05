namespace Tinhtoantrendayso
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SoDauTxt = new TextBox();
            SoCuoiTxt = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            TongTxt = new TextBox();
            TichTxt = new TextBox();
            TongchanTxt = new TextBox();
            TongleTxt = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(89, 35);
            label1.Name = "label1";
            label1.Size = new Size(331, 30);
            label1.TabIndex = 0;
            label1.Text = "TÍNH TOÁN TRÊN DÃY SỐ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 15F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(68, 93);
            label2.Name = "label2";
            label2.Size = new Size(262, 30);
            label2.TabIndex = 1;
            label2.Text = "Giới hạn của dãy số ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 15F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(340, 93);
            label3.Name = "label3";
            label3.Size = new Size(146, 30);
            label3.TabIndex = 1;
            label3.Text = "Số bắt đầu";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 15F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(613, 93);
            label4.Name = "label4";
            label4.Size = new Size(153, 30);
            label4.TabIndex = 1;
            label4.Text = "Số kết thúc";
            // 
            // SoDauTxt
            // 
            SoDauTxt.Font = new Font("Tahoma", 15F);
            SoDauTxt.Location = new Point(488, 88);
            SoDauTxt.Name = "SoDauTxt";
            SoDauTxt.Size = new Size(125, 38);
            SoDauTxt.TabIndex = 2;
            // 
            // SoCuoiTxt
            // 
            SoCuoiTxt.Font = new Font("Tahoma", 15F);
            SoCuoiTxt.Location = new Point(765, 86);
            SoCuoiTxt.Name = "SoCuoiTxt";
            SoCuoiTxt.Size = new Size(125, 38);
            SoCuoiTxt.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 15F);
            label5.ForeColor = Color.DarkOrange;
            label5.Location = new Point(68, 135);
            label5.Name = "label5";
            label5.Size = new Size(98, 30);
            label5.TabIndex = 1;
            label5.Text = "Kết quả";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 15F);
            label6.Location = new Point(68, 181);
            label6.Name = "label6";
            label6.Size = new Size(148, 30);
            label6.TabIndex = 1;
            label6.Text = "Tổng các số";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 15F);
            label7.Location = new Point(68, 237);
            label7.Name = "label7";
            label7.Size = new Size(138, 30);
            label7.TabIndex = 1;
            label7.Text = "Tích các số";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 15F);
            label8.Location = new Point(68, 288);
            label8.Name = "label8";
            label8.Size = new Size(209, 30);
            label8.TabIndex = 1;
            label8.Text = "Tổng các số chẵn";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 15F);
            label9.Location = new Point(68, 341);
            label9.Name = "label9";
            label9.Size = new Size(175, 30);
            label9.TabIndex = 1;
            label9.Text = "Tổng các số lẻ";
            label9.Click += label8_Click;
            // 
            // TongTxt
            // 
            TongTxt.Font = new Font("Tahoma", 15F);
            TongTxt.Location = new Point(351, 173);
            TongTxt.Name = "TongTxt";
            TongTxt.Size = new Size(262, 38);
            TongTxt.TabIndex = 3;
            // 
            // TichTxt
            // 
            TichTxt.Font = new Font("Tahoma", 15F);
            TichTxt.Location = new Point(351, 229);
            TichTxt.Name = "TichTxt";
            TichTxt.Size = new Size(262, 38);
            TichTxt.TabIndex = 3;
            // 
            // TongchanTxt
            // 
            TongchanTxt.Font = new Font("Tahoma", 15F);
            TongchanTxt.Location = new Point(351, 280);
            TongchanTxt.Name = "TongchanTxt";
            TongchanTxt.Size = new Size(262, 38);
            TongchanTxt.TabIndex = 3;
            // 
            // TongleTxt
            // 
            TongleTxt.Font = new Font("Tahoma", 15F);
            TongleTxt.Location = new Point(351, 333);
            TongleTxt.Name = "TongleTxt";
            TongleTxt.Size = new Size(262, 38);
            TongleTxt.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 20F);
            button1.Location = new Point(351, 400);
            button1.Name = "button1";
            button1.Size = new Size(211, 105);
            button1.TabIndex = 4;
            button1.Text = "Tính toán";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 543);
            Controls.Add(button1);
            Controls.Add(TongleTxt);
            Controls.Add(TongchanTxt);
            Controls.Add(TichTxt);
            Controls.Add(TongTxt);
            Controls.Add(SoCuoiTxt);
            Controls.Add(SoDauTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 10F);
            Name = "Form1";
            Text = "Tổng các số chẵn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox SoDauTxt;
        private TextBox SoCuoiTxt;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox TongTxt;
        private TextBox TichTxt;
        private TextBox TongchanTxt;
        private TextBox TongleTxt;
        private Button button1;
    }
}
