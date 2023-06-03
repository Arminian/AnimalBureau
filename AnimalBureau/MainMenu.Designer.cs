namespace AnimalBureau
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            pictureBox1 = new PictureBox();
            phylumBox = new TextBox();
            classBox = new TextBox();
            orderBox = new TextBox();
            familyBox = new TextBox();
            genusBox = new TextBox();
            speciesBox = new TextBox();
            addButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            clearButton = new Button();
            pictureBox2 = new PictureBox();
            seachLabel = new Label();
            searchBox = new TextBox();
            userGV = new DataGridView();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            searchButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userGV).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(332, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // phylumBox
            // 
            phylumBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phylumBox.Location = new Point(35, 183);
            phylumBox.Name = "phylumBox";
            phylumBox.PlaceholderText = "Phylum";
            phylumBox.Size = new Size(225, 29);
            phylumBox.TabIndex = 6;
            // 
            // classBox
            // 
            classBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            classBox.Location = new Point(35, 234);
            classBox.Name = "classBox";
            classBox.PlaceholderText = "Class";
            classBox.Size = new Size(225, 29);
            classBox.TabIndex = 8;
            // 
            // orderBox
            // 
            orderBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            orderBox.Location = new Point(35, 287);
            orderBox.Name = "orderBox";
            orderBox.PlaceholderText = "Order";
            orderBox.Size = new Size(225, 29);
            orderBox.TabIndex = 10;
            // 
            // familyBox
            // 
            familyBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            familyBox.Location = new Point(35, 340);
            familyBox.Name = "familyBox";
            familyBox.PlaceholderText = "Family";
            familyBox.Size = new Size(225, 29);
            familyBox.TabIndex = 12;
            // 
            // genusBox
            // 
            genusBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            genusBox.Location = new Point(35, 393);
            genusBox.Name = "genusBox";
            genusBox.PlaceholderText = "Genus";
            genusBox.Size = new Size(225, 29);
            genusBox.TabIndex = 14;
            // 
            // speciesBox
            // 
            speciesBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            speciesBox.Location = new Point(35, 448);
            speciesBox.Name = "speciesBox";
            speciesBox.PlaceholderText = "Species";
            speciesBox.Size = new Size(225, 29);
            speciesBox.TabIndex = 16;
            // 
            // addButton
            // 
            addButton.BackColor = Color.IndianRed;
            addButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.ForeColor = SystemColors.Window;
            addButton.Location = new Point(487, 31);
            addButton.Name = "addButton";
            addButton.Size = new Size(109, 51);
            addButton.TabIndex = 20;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.IndianRed;
            updateButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            updateButton.ForeColor = SystemColors.WindowFrame;
            updateButton.Location = new Point(625, 31);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(109, 51);
            updateButton.TabIndex = 21;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.IndianRed;
            deleteButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deleteButton.ForeColor = SystemColors.Window;
            deleteButton.Location = new Point(763, 31);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(109, 51);
            deleteButton.TabIndex = 22;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.IndianRed;
            clearButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            clearButton.ForeColor = SystemColors.Window;
            clearButton.Location = new Point(899, 31);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(109, 51);
            clearButton.TabIndex = 23;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1031, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // seachLabel
            // 
            seachLabel.AutoSize = true;
            seachLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            seachLabel.Location = new Point(287, 146);
            seachLabel.Name = "seachLabel";
            seachLabel.Size = new Size(57, 21);
            seachLabel.TabIndex = 25;
            seachLabel.Text = "Search";
            // 
            // searchBox
            // 
            searchBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchBox.Location = new Point(350, 143);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(603, 29);
            searchBox.TabIndex = 26;
            // 
            // userGV
            // 
            userGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userGV.Location = new Point(287, 183);
            userGV.Name = "userGV";
            userGV.RowTemplate.Height = 25;
            userGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userGV.Size = new Size(801, 405);
            userGV.TabIndex = 28;
            userGV.CellContentClick += userGV_CellContentClick;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1100, 24);
            menuStrip1.TabIndex = 29;
            menuStrip1.Text = "menuStrip1";
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.IndianRed;
            searchButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchButton.ForeColor = SystemColors.Window;
            searchButton.Location = new Point(959, 140);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(129, 37);
            searchButton.TabIndex = 30;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(searchButton);
            Controls.Add(userGV);
            Controls.Add(searchBox);
            Controls.Add(seachLabel);
            Controls.Add(pictureBox2);
            Controls.Add(clearButton);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(addButton);
            Controls.Add(speciesBox);
            Controls.Add(genusBox);
            Controls.Add(familyBox);
            Controls.Add(orderBox);
            Controls.Add(classBox);
            Controls.Add(phylumBox);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += MainMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)userGV).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox phylumBox;
        private TextBox classBox;
        private TextBox orderBox;
        private TextBox familyBox;
        private TextBox genusBox;
        private TextBox speciesBox;
        private Button addButton;
        private Button updateButton;
        private Button deleteButton;
        private Button clearButton;
        private PictureBox pictureBox2;
        private Label seachLabel;
        private TextBox searchBox;
        private DataGridView userGV;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Button searchButton;
    }
}