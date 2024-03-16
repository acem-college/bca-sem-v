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
            textX = new TextBox();
            textY = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            Result = new Label();
            SuspendLayout();
            // 
            // textX
            // 
            textX.AccessibleName = "";
            textX.Location = new Point(22, 91);
            textX.Name = "textX";
            textX.Size = new Size(109, 23);
            textX.TabIndex = 0;
            textX.TextChanged += textBox1_TextChanged;
            // 
            // textY
            // 
            textY.AccessibleName = "";
            textY.Location = new Point(22, 37);
            textY.Name = "textY";
            textY.Size = new Size(109, 23);
            textY.TabIndex = 1;
            textY.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 73);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 2;
            label1.Text = "Enter the value of X";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 19);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 3;
            label2.Text = "Enter the value of Y";
            // 
            // button1
            // 
            button1.Location = new Point(22, 133);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Location = new Point(22, 181);
            Result.Name = "Result";
            Result.Size = new Size(39, 15);
            Result.TabIndex = 5;
            Result.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Result);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textY);
            Controls.Add(textX);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textX;
        private TextBox textY;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label Result;
    }
}
