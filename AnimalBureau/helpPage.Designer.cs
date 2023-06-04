namespace AnimalBureau
{
    partial class helpPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(helpPage));
            pictureBox1 = new PictureBox();
            exitBtt = new PictureBox();
            backButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitBtt).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // exitBtt
            // 
            exitBtt.Image = (Image)resources.GetObject("exitBtt.Image");
            exitBtt.Location = new Point(1028, 12);
            exitBtt.Name = "exitBtt";
            exitBtt.Size = new Size(44, 44);
            exitBtt.SizeMode = PictureBoxSizeMode.Zoom;
            exitBtt.TabIndex = 25;
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
            backButton.TabIndex = 26;
            backButton.Text = "back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 162);
            label1.Name = "label1";
            label1.Size = new Size(470, 21);
            label1.TabIndex = 27;
            label1.Text = "1. add button adds all entered information from the text boxes ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 196);
            label2.Name = "label2";
            label2.Size = new Size(364, 21);
            label2.TabIndex = 28;
            label2.Text = "2. update button refreshes the database window";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 233);
            label3.Name = "label3";
            label3.Size = new Size(827, 21);
            label3.TabIndex = 29;
            label3.Text = "3. delete button deletes all data from the database for species (only entered species has to be written to delete)";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 273);
            label4.Name = "label4";
            label4.Size = new Size(355, 21);
            label4.TabIndex = 30;
            label4.Text = "4. clear button deletes user input from all fields";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 311);
            label5.Name = "label5";
            label5.Size = new Size(522, 21);
            label5.TabIndex = 31;
            label5.Text = "6. only species has to be entered in the search field to search correctly";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 350);
            label6.Name = "label6";
            label6.Size = new Size(815, 21);
            label6.TabIndex = 32;
            label6.Text = "7. after clicking on the row in the database window, its contents will be shown in user input fields (species, etc.)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 390);
            label7.Name = "label7";
            label7.Size = new Size(761, 21);
            label7.TabIndex = 33;
            label7.Text = "8. to cancel searching for specific species user has to click update button, this will show all entires again";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(12, 432);
            label8.Name = "label8";
            label8.Size = new Size(460, 21);
            label8.TabIndex = 34;
            label8.Text = "9. user can sort entries in database by clicking on top columns";
            // 
            // helpPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 561);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(backButton);
            Controls.Add(exitBtt);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "helpPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "helpPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitBtt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox exitBtt;
        private Button backButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}