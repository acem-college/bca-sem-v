namespace DesktopApplication
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
            lable1 = new Label();
            label2 = new Label();
            txtY = new TextBox();
            txtX = new TextBox();
            add = new Button();
            multi = new Button();
            Result = new Label();
            SuspendLayout();
            // 
            // lable1
            // 
            lable1.AutoSize = true;
            lable1.Location = new Point(31, 37);
            lable1.Name = "lable1";
            lable1.Size = new Size(94, 15);
            lable1.TabIndex = 0;
            lable1.Text = "Enter first value :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 69);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter second value :";
            // 
            // txtY
            // 
            txtY.Location = new Point(149, 61);
            txtY.Name = "txtY";
            txtY.Size = new Size(60, 23);
            txtY.TabIndex = 2;
            // 
            // txtX
            // 
            txtX.Location = new Point(149, 29);
            txtX.Name = "txtX";
            txtX.Size = new Size(60, 23);
            txtX.TabIndex = 3;
            // 
            // add
            // 
            add.Location = new Point(149, 100);
            add.Name = "add";
            add.Size = new Size(60, 23);
            add.TabIndex = 4;
            add.Text = "Add";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // multi
            // 
            multi.Location = new Point(149, 129);
            multi.Name = "multi";
            multi.Size = new Size(60, 23);
            multi.TabIndex = 5;
            multi.Text = "Multiply";
            multi.UseVisualStyleBackColor = true;
            multi.Click += multi_Click;
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Location = new Point(148, 172);
            Result.Name = "Result";
            Result.Size = new Size(52, 15);
            Result.TabIndex = 6;
            Result.Text = "Answer :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Result);
            Controls.Add(multi);
            Controls.Add(add);
            Controls.Add(txtX);
            Controls.Add(txtY);
            Controls.Add(label2);
            Controls.Add(lable1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lable1;
        private Label label2;
        private TextBox txtY;
        private TextBox txtX;
        private Button add;
        private Button multi;
        private Label Result;
    }
}
