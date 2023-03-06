namespace Activity_1
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
            textBox_FirstNumber = new TextBox();
            textBox_SecondNumber = new TextBox();
            textBox_Sum = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_AddNumbers = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox_FirstNumber
            // 
            textBox_FirstNumber.Location = new Point(118, 52);
            textBox_FirstNumber.Name = "textBox_FirstNumber";
            textBox_FirstNumber.Size = new Size(100, 23);
            textBox_FirstNumber.TabIndex = 0;
            // 
            // textBox_SecondNumber
            // 
            textBox_SecondNumber.Location = new Point(118, 78);
            textBox_SecondNumber.Name = "textBox_SecondNumber";
            textBox_SecondNumber.Size = new Size(100, 23);
            textBox_SecondNumber.TabIndex = 1;
            // 
            // textBox_Sum
            // 
            textBox_Sum.Enabled = false;
            textBox_Sum.Location = new Point(118, 123);
            textBox_Sum.Name = "textBox_Sum";
            textBox_Sum.Size = new Size(100, 23);
            textBox_Sum.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(29, 55);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 3;
            label1.Text = "First Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 4;
            label2.Text = "Second Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(77, 126);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 5;
            label3.Text = "Sum:";
            // 
            // btn_AddNumbers
            // 
            btn_AddNumbers.BackColor = SystemColors.ControlLightLight;
            btn_AddNumbers.ForeColor = SystemColors.HotTrack;
            btn_AddNumbers.Location = new Point(118, 152);
            btn_AddNumbers.Name = "btn_AddNumbers";
            btn_AddNumbers.Size = new Size(100, 23);
            btn_AddNumbers.TabIndex = 6;
            btn_AddNumbers.Text = "Add Numbers";
            btn_AddNumbers.UseVisualStyleBackColor = false;
            btn_AddNumbers.Click += btn_AddNumbers_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(29, 9);
            label4.Name = "label4";
            label4.Size = new Size(179, 21);
            label4.TabIndex = 7;
            label4.Text = "Jared's Number Adder";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(231, 187);
            Controls.Add(label4);
            Controls.Add(btn_AddNumbers);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_Sum);
            Controls.Add(textBox_SecondNumber);
            Controls.Add(textBox_FirstNumber);
            Name = "Form1";
            Text = "Adder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_FirstNumber;
        private TextBox textBox_SecondNumber;
        private TextBox textBox_Sum;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_AddNumbers;
        private Label label4;
    }
}