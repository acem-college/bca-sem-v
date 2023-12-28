namespace WinFormsApp1
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
            txtx = new TextBox();
            txty = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtx
            // 
            txtx.Location = new Point(99, 105);
            txtx.Name = "txtx";
            txtx.Size = new Size(125, 27);
            txtx.TabIndex = 0;
            txtx.Text = "1";
            txtx.TextChanged += textBox1_TextChanged;
            // 
            // txty
            // 
            txty.Location = new Point(330, 105);
            txty.Name = "txty";
            txty.Size = new Size(125, 27);
            txty.TabIndex = 1;
            txty.Text = "2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 57);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 2;
            label1.Text = "Enter value of x";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(344, 57);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 3;
            label2.Text = "Enter value of y";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(235, 207);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(252, 301);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(49, 20);
            lblResult.TabIndex = 5;
            lblResult.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txty);
            Controls.Add(txtx);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtx;
        private TextBox txty;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label lblResult;
    }
}
