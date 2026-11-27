namespace PGMS_Form
{
    partial class UserDashboard
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
            label1 = new Label();
            btnReservation = new Button();
            btnShop = new Button();
            btnAbout = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(221, 9);
            label1.Name = "label1";
            label1.Size = new Size(356, 38);
            label1.TabIndex = 0;
            label1.Text = "What would you like to do?";
            // 
            // btnReservation
            // 
            btnReservation.Location = new Point(202, 87);
            btnReservation.Margin = new Padding(10);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(390, 65);
            btnReservation.TabIndex = 1;
            btnReservation.Text = "Grooming Reservation";
            btnReservation.UseVisualStyleBackColor = true;
            btnReservation.Click += btnReservation_Click;
            // 
            // btnShop
            // 
            btnShop.Location = new Point(202, 172);
            btnShop.Margin = new Padding(10);
            btnShop.Name = "btnShop";
            btnShop.Size = new Size(390, 65);
            btnShop.TabIndex = 2;
            btnShop.Text = "Shop";
            btnShop.UseVisualStyleBackColor = true;
            btnShop.Click += btnShop_Click;
            // 
            // btnAbout
            // 
            btnAbout.Location = new Point(202, 257);
            btnAbout.Margin = new Padding(10);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(390, 65);
            btnAbout.TabIndex = 3;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(202, 342);
            btnExit.Margin = new Padding(10);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(390, 65);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnAbout);
            Controls.Add(btnShop);
            Controls.Add(btnReservation);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pet Grooming Management System - User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnReservation;
        private Button btnShop;
        private Button btnAbout;
        private Button btnExit;
    }
}