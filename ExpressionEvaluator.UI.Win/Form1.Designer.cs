namespace ExpressionEvaluator.UI.Win
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
            button0 = new Button();
            buttonEqual = new Button();
            button1 = new Button();
            button4 = new Button();
            button7 = new Button();
            button8 = new Button();
            button5 = new Button();
            button2 = new Button();
            button9 = new Button();
            button6 = new Button();
            button3 = new Button();
            buttonOpenparentesis = new Button();
            buttonMultiply = new Button();
            buttonPlus = new Button();
            buttonDelete = new Button();
            buttonClear = new Button();
            buttonPow = new Button();
            buttonDot = new Button();
            txtDisplay = new TextBox();
            buttonCloseParentesis = new Button();
            buttonDivide = new Button();
            buttonMinus = new Button();
            SuspendLayout();
            // 
            // button0
            // 
            button0.Location = new Point(7, 196);
            button0.Name = "button0";
            button0.Size = new Size(94, 41);
            button0.TabIndex = 0;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.BackColor = Color.FromArgb(255, 128, 0);
            buttonEqual.Location = new Point(157, 196);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(164, 41);
            buttonEqual.TabIndex = 1;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = false;
            buttonEqual.Click += buttonEqual_Click;
            // 
            // button1
            // 
            button1.Location = new Point(7, 149);
            button1.Name = "button1";
            button1.Size = new Size(44, 41);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(7, 100);
            button4.Name = "button4";
            button4.Size = new Size(44, 41);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button7
            // 
            button7.Location = new Point(7, 53);
            button7.Name = "button7";
            button7.Size = new Size(44, 41);
            button7.TabIndex = 4;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(57, 53);
            button8.Name = "button8";
            button8.Size = new Size(44, 41);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button5
            // 
            button5.Location = new Point(57, 100);
            button5.Name = "button5";
            button5.Size = new Size(44, 41);
            button5.TabIndex = 6;
            button5.Text = "5\r\n";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.Location = new Point(57, 149);
            button2.Name = "button2";
            button2.Size = new Size(44, 41);
            button2.TabIndex = 5;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button9
            // 
            button9.Location = new Point(107, 53);
            button9.Name = "button9";
            button9.Size = new Size(44, 41);
            button9.TabIndex = 10;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button6
            // 
            button6.Location = new Point(107, 100);
            button6.Name = "button6";
            button6.Size = new Size(44, 41);
            button6.TabIndex = 9;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.Location = new Point(107, 149);
            button3.Name = "button3";
            button3.Size = new Size(44, 41);
            button3.TabIndex = 8;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // buttonOpenparentesis
            // 
            buttonOpenparentesis.BackColor = Color.FromArgb(255, 128, 0);
            buttonOpenparentesis.Location = new Point(157, 53);
            buttonOpenparentesis.Name = "buttonOpenparentesis";
            buttonOpenparentesis.Size = new Size(44, 41);
            buttonOpenparentesis.TabIndex = 13;
            buttonOpenparentesis.Text = "(";
            buttonOpenparentesis.UseVisualStyleBackColor = false;
            buttonOpenparentesis.Click += buttonOpenparentesis_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.BackColor = Color.FromArgb(255, 128, 0);
            buttonMultiply.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonMultiply.Location = new Point(157, 100);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(44, 41);
            buttonMultiply.TabIndex = 12;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = false;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.BackColor = Color.FromArgb(255, 128, 0);
            buttonPlus.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPlus.Location = new Point(157, 149);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(44, 41);
            buttonPlus.TabIndex = 11;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = false;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(255, 128, 0);
            buttonDelete.Location = new Point(259, 53);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(62, 41);
            buttonDelete.TabIndex = 16;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.FromArgb(255, 128, 0);
            buttonClear.Location = new Point(259, 100);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(62, 41);
            buttonClear.TabIndex = 15;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonPow
            // 
            buttonPow.BackColor = Color.FromArgb(255, 128, 0);
            buttonPow.Location = new Point(259, 149);
            buttonPow.Name = "buttonPow";
            buttonPow.Size = new Size(62, 41);
            buttonPow.TabIndex = 14;
            buttonPow.Text = "^";
            buttonPow.UseVisualStyleBackColor = false;
            buttonPow.Click += buttonPow_Click;
            // 
            // buttonDot
            // 
            buttonDot.Location = new Point(107, 196);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(44, 41);
            buttonDot.TabIndex = 17;
            buttonDot.Text = ".";
            buttonDot.UseVisualStyleBackColor = true;
            buttonDot.Click += buttonDot_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = Color.Green;
            txtDisplay.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.ForeColor = Color.White;
            txtDisplay.Location = new Point(7, 10);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(314, 27);
            txtDisplay.TabIndex = 18;
            // 
            // buttonCloseParentesis
            // 
            buttonCloseParentesis.BackColor = Color.FromArgb(255, 128, 0);
            buttonCloseParentesis.Location = new Point(207, 53);
            buttonCloseParentesis.Name = "buttonCloseParentesis";
            buttonCloseParentesis.Size = new Size(44, 41);
            buttonCloseParentesis.TabIndex = 22;
            buttonCloseParentesis.Text = ")";
            buttonCloseParentesis.UseVisualStyleBackColor = false;
            buttonCloseParentesis.Click += buttonCloseParentesis_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.BackColor = Color.FromArgb(255, 128, 0);
            buttonDivide.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDivide.Location = new Point(207, 100);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(44, 41);
            buttonDivide.TabIndex = 21;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = false;
            buttonDivide.Click += buttonDivide_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.BackColor = Color.FromArgb(255, 128, 0);
            buttonMinus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonMinus.Location = new Point(207, 149);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(44, 41);
            buttonMinus.TabIndex = 20;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = false;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(330, 249);
            Controls.Add(buttonCloseParentesis);
            Controls.Add(buttonDivide);
            Controls.Add(buttonMinus);
            Controls.Add(txtDisplay);
            Controls.Add(buttonDot);
            Controls.Add(buttonDelete);
            Controls.Add(buttonClear);
            Controls.Add(buttonPow);
            Controls.Add(buttonOpenparentesis);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonPlus);
            Controls.Add(button9);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(buttonEqual);
            Controls.Add(button0);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button0;
        private Button buttonEqual;
        private Button button1;
        private Button button4;
        private Button button7;
        private Button button8;
        private Button button5;
        private Button button2;
        private Button button9;
        private Button button6;
        private Button button3;
        private Button buttonOpenparentesis;
        private Button buttonMultiply;
        private Button buttonPlus;
        private Button buttonDelete;
        private Button buttonClear;
        private Button buttonPow;
        private Button buttonDot;
        private TextBox txtDisplay;
        private Button buttonCloseParentesis;
        private Button buttonDivide;
        private Button buttonMinus;
    }
}
