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
            domainLabel = new Label();
            kingdomLabel = new Label();
            phylumBox = new TextBox();
            phylumLabel = new Label();
            classBox = new TextBox();
            classLabel = new Label();
            orderBox = new TextBox();
            orderLabel = new Label();
            familyBox = new TextBox();
            familyLabel = new Label();
            genusBox = new TextBox();
            genusLabel = new Label();
            speciesBox = new TextBox();
            speciesLabel = new Label();
            domaibBox = new ComboBox();
            kingdomBox = new ComboBox();
            dataGrid = new DataGridView();
            addButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            clearButton = new Button();
            pictureBox2 = new PictureBox();
            seachLabel = new Label();
            searchBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // domainLabel
            // 
            domainLabel.AutoSize = true;
            domainLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            domainLabel.Location = new Point(16, 131);
            domainLabel.Name = "domainLabel";
            domainLabel.Size = new Size(65, 21);
            domainLabel.TabIndex = 1;
            domainLabel.Text = "Domain";
            // 
            // kingdomLabel
            // 
            kingdomLabel.AutoSize = true;
            kingdomLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kingdomLabel.Location = new Point(9, 183);
            kingdomLabel.Name = "kingdomLabel";
            kingdomLabel.Size = new Size(73, 21);
            kingdomLabel.TabIndex = 3;
            kingdomLabel.Text = "Kingdom";
            // 
            // phylumBox
            // 
            phylumBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phylumBox.Location = new Point(87, 231);
            phylumBox.Name = "phylumBox";
            phylumBox.Size = new Size(173, 29);
            phylumBox.TabIndex = 6;
            // 
            // phylumLabel
            // 
            phylumLabel.AutoSize = true;
            phylumLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phylumLabel.Location = new Point(18, 234);
            phylumLabel.Name = "phylumLabel";
            phylumLabel.Size = new Size(63, 21);
            phylumLabel.TabIndex = 5;
            phylumLabel.Text = "Phylum";
            // 
            // classBox
            // 
            classBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            classBox.Location = new Point(87, 282);
            classBox.Name = "classBox";
            classBox.Size = new Size(173, 29);
            classBox.TabIndex = 8;
            // 
            // classLabel
            // 
            classLabel.AutoSize = true;
            classLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            classLabel.Location = new Point(35, 285);
            classLabel.Name = "classLabel";
            classLabel.Size = new Size(46, 21);
            classLabel.TabIndex = 7;
            classLabel.Text = "Class";
            // 
            // orderBox
            // 
            orderBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            orderBox.Location = new Point(87, 335);
            orderBox.Name = "orderBox";
            orderBox.Size = new Size(173, 29);
            orderBox.TabIndex = 10;
            // 
            // orderLabel
            // 
            orderLabel.AutoSize = true;
            orderLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            orderLabel.Location = new Point(30, 338);
            orderLabel.Name = "orderLabel";
            orderLabel.Size = new Size(51, 21);
            orderLabel.TabIndex = 9;
            orderLabel.Text = "Order";
            // 
            // familyBox
            // 
            familyBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            familyBox.Location = new Point(87, 388);
            familyBox.Name = "familyBox";
            familyBox.Size = new Size(173, 29);
            familyBox.TabIndex = 12;
            // 
            // familyLabel
            // 
            familyLabel.AutoSize = true;
            familyLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            familyLabel.Location = new Point(26, 391);
            familyLabel.Name = "familyLabel";
            familyLabel.Size = new Size(55, 21);
            familyLabel.TabIndex = 11;
            familyLabel.Text = "Family";
            // 
            // genusBox
            // 
            genusBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            genusBox.Location = new Point(87, 441);
            genusBox.Name = "genusBox";
            genusBox.Size = new Size(173, 29);
            genusBox.TabIndex = 14;
            // 
            // genusLabel
            // 
            genusLabel.AutoSize = true;
            genusLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            genusLabel.Location = new Point(26, 444);
            genusLabel.Name = "genusLabel";
            genusLabel.Size = new Size(54, 21);
            genusLabel.TabIndex = 13;
            genusLabel.Text = "Genus";
            // 
            // speciesBox
            // 
            speciesBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            speciesBox.Location = new Point(87, 496);
            speciesBox.Name = "speciesBox";
            speciesBox.Size = new Size(173, 29);
            speciesBox.TabIndex = 16;
            // 
            // speciesLabel
            // 
            speciesLabel.AutoSize = true;
            speciesLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            speciesLabel.Location = new Point(19, 499);
            speciesLabel.Name = "speciesLabel";
            speciesLabel.Size = new Size(62, 21);
            speciesLabel.TabIndex = 15;
            speciesLabel.Text = "Species";
            // 
            // domaibBox
            // 
            domaibBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            domaibBox.FormattingEnabled = true;
            domaibBox.Items.AddRange(new object[] { "Bacteria", "Archaea", "Eukarya" });
            domaibBox.Location = new Point(87, 128);
            domaibBox.Name = "domaibBox";
            domaibBox.Size = new Size(173, 29);
            domaibBox.TabIndex = 17;
            // 
            // kingdomBox
            // 
            kingdomBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kingdomBox.FormattingEnabled = true;
            kingdomBox.Items.AddRange(new object[] { "Eubacteria", "Archaebacteria", "Protista", "Fungi", "Plantae", "Animalia" });
            kingdomBox.Location = new Point(87, 180);
            kingdomBox.Name = "kingdomBox";
            kingdomBox.Size = new Size(173, 29);
            kingdomBox.TabIndex = 18;
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(277, 168);
            dataGrid.Name = "dataGrid";
            dataGrid.RowTemplate.Height = 25;
            dataGrid.Size = new Size(601, 404);
            dataGrid.TabIndex = 19;
            // 
            // addButton
            // 
            addButton.BackColor = Color.IndianRed;
            addButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.ForeColor = SystemColors.Window;
            addButton.Location = new Point(277, 31);
            addButton.Name = "addButton";
            addButton.Size = new Size(109, 51);
            addButton.TabIndex = 20;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.IndianRed;
            updateButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            updateButton.ForeColor = SystemColors.WindowFrame;
            updateButton.Location = new Point(415, 31);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(109, 51);
            updateButton.TabIndex = 21;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.IndianRed;
            deleteButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deleteButton.ForeColor = SystemColors.Window;
            deleteButton.Location = new Point(553, 31);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(109, 51);
            deleteButton.TabIndex = 22;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.IndianRed;
            clearButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            clearButton.ForeColor = SystemColors.Window;
            clearButton.Location = new Point(689, 31);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(109, 51);
            clearButton.TabIndex = 23;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(821, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // seachLabel
            // 
            seachLabel.AutoSize = true;
            seachLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            seachLabel.Location = new Point(287, 131);
            seachLabel.Name = "seachLabel";
            seachLabel.Size = new Size(57, 21);
            seachLabel.TabIndex = 25;
            seachLabel.Text = "Search";
            // 
            // searchBox
            // 
            searchBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchBox.Location = new Point(350, 128);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(528, 29);
            searchBox.TabIndex = 26;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            Controls.Add(searchBox);
            Controls.Add(seachLabel);
            Controls.Add(pictureBox2);
            Controls.Add(clearButton);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(addButton);
            Controls.Add(dataGrid);
            Controls.Add(kingdomBox);
            Controls.Add(domaibBox);
            Controls.Add(speciesBox);
            Controls.Add(speciesLabel);
            Controls.Add(genusBox);
            Controls.Add(genusLabel);
            Controls.Add(familyBox);
            Controls.Add(familyLabel);
            Controls.Add(orderBox);
            Controls.Add(orderLabel);
            Controls.Add(classBox);
            Controls.Add(classLabel);
            Controls.Add(phylumBox);
            Controls.Add(phylumLabel);
            Controls.Add(kingdomLabel);
            Controls.Add(domainLabel);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainMenu";
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label domainLabel;
        private Label kingdomLabel;
        private TextBox phylumBox;
        private Label phylumLabel;
        private TextBox classBox;
        private Label classLabel;
        private TextBox orderBox;
        private Label orderLabel;
        private TextBox familyBox;
        private Label familyLabel;
        private TextBox genusBox;
        private Label genusLabel;
        private TextBox speciesBox;
        private Label speciesLabel;
        private ComboBox domaibBox;
        private ComboBox kingdomBox;
        private DataGridView dataGrid;
        private Button addButton;
        private Button updateButton;
        private Button deleteButton;
        private Button clearButton;
        private PictureBox pictureBox2;
        private Label seachLabel;
        private TextBox searchBox;
    }
}