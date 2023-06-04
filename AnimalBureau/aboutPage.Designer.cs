namespace AnimalBureau
{
    partial class aboutPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutPage));
            pictureBox1 = new PictureBox();
            exitBtt = new PictureBox();
            backButton = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitBtt).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // exitBtt
            // 
            exitBtt.Image = (Image)resources.GetObject("exitBtt.Image");
            exitBtt.Location = new Point(1028, 12);
            exitBtt.Name = "exitBtt";
            exitBtt.Size = new Size(44, 44);
            exitBtt.SizeMode = PictureBoxSizeMode.Zoom;
            exitBtt.TabIndex = 26;
            exitBtt.TabStop = false;
            exitBtt.Click += exitBtt_Click;
            // 
            // backButton
            // 
            backButton.BackColor = Color.IndianRed;
            backButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.ForeColor = SystemColors.Window;
            backButton.Location = new Point(486, 498);
            backButton.Name = "backButton";
            backButton.Size = new Size(109, 51);
            backButton.TabIndex = 27;
            backButton.Text = "back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(356, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 284);
            panel1.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(151, 130);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 0;
            label1.Text = "2023";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(83, 35);
            label4.Name = "label4";
            label4.Size = new Size(197, 40);
            label4.TabIndex = 31;
            label4.Text = "Developed by";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(52, 75);
            label3.Name = "label3";
            label3.Size = new Size(270, 45);
            label3.TabIndex = 32;
            label3.Text = "Nikita Katerinich";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.IndianRed;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(393, 286);
            label2.Name = "label2";
            label2.Size = new Size(294, 32);
            label2.TabIndex = 31;
            label2.Text = "email: arminian@pm.me";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.IndianRed;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(400, 327);
            label5.Name = "label5";
            label5.Size = new Size(278, 32);
            label5.TabIndex = 32;
            label5.Text = "phone: +371 20441714";
            // 
            // aboutPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 561);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(backButton);
            Controls.Add(exitBtt);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "aboutPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "aboutPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitBtt).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox exitBtt;
        private Button backButton;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label5;
    }
}