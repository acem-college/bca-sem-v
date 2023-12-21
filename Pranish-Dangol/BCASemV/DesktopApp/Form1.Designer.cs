namespace DesktopApp
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
            txtX = new TextBox();
            label1 = new Label();
            txtY = new TextBox();
            label2 = new Label();
            button1 = new Button();
            lblResult = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtX
            // 
            txtX.Location = new Point(78, 112);
            txtX.Name = "txtX";
            txtX.Size = new Size(150, 27);
            txtX.TabIndex = 0;
            txtX.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 89);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter the value of x\r\n";
            // 
            // txtY
            // 
            txtY.Location = new Point(444, 112);
            txtY.Name = "txtY";
            txtY.Size = new Size(160, 27);
            txtY.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(444, 89);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 3;
            label2.Text = "Enter value of y\r\n";
            // 
            // button1
            // 
            button1.Location = new Point(92, 184);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(92, 235);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(49, 20);
            lblResult.TabIndex = 5;
            lblResult.Text = "Result";
            // 
            // button2
            // 
            button2.Location = new Point(92, 315);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "subtract";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(lblResult);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtY);
            Controls.Add(label1);
            Controls.Add(txtX);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtX;
        private Label label1;
        private TextBox txtY;
        private Label label2;
        private Button button1;
        private Label lblResult;
        private Button button2;
    }
}
