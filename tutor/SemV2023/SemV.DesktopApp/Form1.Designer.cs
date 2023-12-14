namespace SemV.DesktopApp
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
            label2 = new Label();
            txtY = new TextBox();
            btnAdd = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtX
            // 
            txtX.Location = new Point(48, 84);
            txtX.Name = "txtX";
            txtX.Size = new Size(182, 27);
            txtX.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 50);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter Value of X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 50);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 3;
            label2.Text = "Enter Value of Y";
            // 
            // txtY
            // 
            txtY.Location = new Point(256, 84);
            txtY.Name = "txtY";
            txtY.Size = new Size(182, 27);
            txtY.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(50, 144);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(51, 196);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(58, 20);
            lblResult.TabIndex = 5;
            lblResult.Text = "RESULT";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 413);
            Controls.Add(lblResult);
            Controls.Add(btnAdd);
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
        private Label label2;
        private TextBox txtY;
        private Button btnAdd;
        private Label lblResult;
    }
}
