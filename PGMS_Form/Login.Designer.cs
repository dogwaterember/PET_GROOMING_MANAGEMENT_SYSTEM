namespace PGMS_Form
{
    partial class Login
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
            adminBtn = new Button();
            label1 = new Label();
            userBtn = new Button();
            SuspendLayout();
            // 
            // adminBtn
            // 
            adminBtn.Location = new Point(239, 136);
            adminBtn.Margin = new Padding(15);
            adminBtn.Name = "adminBtn";
            adminBtn.Size = new Size(112, 34);
            adminBtn.TabIndex = 0;
            adminBtn.Text = "Admin";
            adminBtn.UseVisualStyleBackColor = true;
            adminBtn.Click += adminBtn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(165, 10);
            label1.Margin = new Padding(15);
            label1.Name = "label1";
            label1.Size = new Size(265, 32);
            label1.TabIndex = 2;
            label1.Text = "Choose a login method";
            // 
            // userBtn
            // 
            userBtn.Location = new Point(239, 72);
            userBtn.Margin = new Padding(15);
            userBtn.Name = "userBtn";
            userBtn.Size = new Size(112, 34);
            userBtn.TabIndex = 3;
            userBtn.Text = "User";
            userBtn.UseVisualStyleBackColor = true;
            userBtn.Click += userBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 194);
            Controls.Add(userBtn);
            Controls.Add(label1);
            Controls.Add(adminBtn);
            Name = "Login";
            Text = "Pet Grooming Management System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button adminBtn;
        private Label label1;
        private Button userBtn;
    }
}
