namespace ASRFLY.Desktop.GUI.GuiHome
{
    partial class HomeUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            gbAdd = new GroupBox();
            btnAddCategory = new Button();
            btnAddCustomer = new Button();
            btnAddSupplier = new Button();
            btnAddProject = new Button();
            btnAddUser = new Button();
            btnAddOutput = new Button();
            btnAddIncome = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pbLogo = new PictureBox();
            lblCompanyName = new Label();
            lblWelcome = new Label();
            panel1.SuspendLayout();
            gbAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(gbAdd);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 365);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 236);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cairo", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(536, 15);
            label1.Name = "label1";
            label1.Size = new Size(224, 56);
            label1.TabIndex = 0;
            label1.Text = "الوصول السريع";
            // 
            // gbAdd
            // 
            gbAdd.Anchor = AnchorStyles.None;
            gbAdd.Controls.Add(btnAddIncome);
            gbAdd.Controls.Add(btnAddOutput);
            gbAdd.Controls.Add(btnAddUser);
            gbAdd.Controls.Add(btnAddProject);
            gbAdd.Controls.Add(btnAddSupplier);
            gbAdd.Controls.Add(btnAddCustomer);
            gbAdd.Controls.Add(btnAddCategory);
            gbAdd.FlatStyle = FlatStyle.Flat;
            gbAdd.Font = new Font("Cairo", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbAdd.ForeColor = Color.FromArgb(128, 255, 128);
            gbAdd.Location = new Point(157, 74);
            gbAdd.Name = "gbAdd";
            gbAdd.Size = new Size(982, 113);
            gbAdd.TabIndex = 3;
            gbAdd.TabStop = false;
            gbAdd.Text = "اضافة";
            // 
            // btnAddCategory
            // 
            btnAddCategory.BackColor = Color.White;
            btnAddCategory.ForeColor = SystemColors.Desktop;
            btnAddCategory.Image = Properties.Resources.Categorize;
            btnAddCategory.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddCategory.Location = new Point(831, 46);
            btnAddCategory.Margin = new Padding(5);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(125, 55);
            btnAddCategory.TabIndex = 8;
            btnAddCategory.Text = "      صنف";
            btnAddCategory.UseVisualStyleBackColor = false;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = Color.White;
            btnAddCustomer.ForeColor = SystemColors.Desktop;
            btnAddCustomer.Image = Properties.Resources.Customers_32px;
            btnAddCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddCustomer.Location = new Point(697, 46);
            btnAddCustomer.Margin = new Padding(5);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(125, 55);
            btnAddCustomer.TabIndex = 9;
            btnAddCustomer.Text = "      عميل";
            btnAddCustomer.UseVisualStyleBackColor = false;
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.BackColor = Color.White;
            btnAddSupplier.ForeColor = SystemColors.Desktop;
            btnAddSupplier.Image = Properties.Resources.Supplier;
            btnAddSupplier.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddSupplier.Location = new Point(563, 46);
            btnAddSupplier.Margin = new Padding(5);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(125, 55);
            btnAddSupplier.TabIndex = 10;
            btnAddSupplier.Text = "      مورد";
            btnAddSupplier.UseVisualStyleBackColor = false;
            // 
            // btnAddProject
            // 
            btnAddProject.BackColor = Color.White;
            btnAddProject.ForeColor = SystemColors.Desktop;
            btnAddProject.Image = Properties.Resources.Project;
            btnAddProject.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddProject.Location = new Point(429, 46);
            btnAddProject.Margin = new Padding(5);
            btnAddProject.Name = "btnAddProject";
            btnAddProject.Size = new Size(125, 55);
            btnAddProject.TabIndex = 11;
            btnAddProject.Text = "      مشروع";
            btnAddProject.UseVisualStyleBackColor = false;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.White;
            btnAddUser.ForeColor = SystemColors.Desktop;
            btnAddUser.Image = Properties.Resources.Add_User_Male;
            btnAddUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddUser.Location = new Point(289, 46);
            btnAddUser.Margin = new Padding(5);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(131, 55);
            btnAddUser.TabIndex = 12;
            btnAddUser.Text = "      مسنخدم";
            btnAddUser.UseVisualStyleBackColor = false;
            // 
            // btnAddOutput
            // 
            btnAddOutput.BackColor = Color.White;
            btnAddOutput.ForeColor = SystemColors.Desktop;
            btnAddOutput.Image = Properties.Resources.Withdrawal_Limit;
            btnAddOutput.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddOutput.Location = new Point(155, 46);
            btnAddOutput.Margin = new Padding(5);
            btnAddOutput.Name = "btnAddOutput";
            btnAddOutput.Size = new Size(125, 55);
            btnAddOutput.TabIndex = 13;
            btnAddOutput.Text = "      صرف";
            btnAddOutput.UseVisualStyleBackColor = false;
            // 
            // btnAddIncome
            // 
            btnAddIncome.BackColor = Color.White;
            btnAddIncome.ForeColor = SystemColors.Desktop;
            btnAddIncome.Image = Properties.Resources.Deposit;
            btnAddIncome.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddIncome.Location = new Point(21, 46);
            btnAddIncome.Margin = new Padding(5);
            btnAddIncome.Name = "btnAddIncome";
            btnAddIncome.Size = new Size(125, 55);
            btnAddIncome.TabIndex = 14;
            btnAddIncome.Text = "      قبض";
            btnAddIncome.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImage = Properties.Resources.Fast_Forward1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.Fast_Forward1;
            pictureBox1.Location = new Point(438, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(lblCompanyName);
            panel2.Controls.Add(pbLogo);
            panel2.Location = new Point(588, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(588, 138);
            panel2.TabIndex = 1;
            // 
            // pbLogo
            // 
            pbLogo.BackgroundImage = Properties.Resources.logo_no_background;
            pbLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pbLogo.Dock = DockStyle.Right;
            pbLogo.Location = new Point(471, 0);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(117, 138);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 5;
            pbLogo.TabStop = false;
            // 
            // lblCompanyName
            // 
            lblCompanyName.Font = new Font("Cairo", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCompanyName.Location = new Point(12, 7);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(453, 122);
            lblCompanyName.TabIndex = 6;
            lblCompanyName.Text = "بن فارس";
            lblCompanyName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Cairo", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(3, 10);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(336, 145);
            lblWelcome.TabIndex = 7;
            lblWelcome.Text = "مرحبا بك مجددا، محمد";
            lblWelcome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // HomeUserControl
            // 
            AutoScaleDimensions = new SizeF(11F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblWelcome);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 6, 4, 6);
            Name = "HomeUserControl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1262, 601);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gbAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox gbAdd;
        private Button btnAddCategory;
        private Button btnAddIncome;
        private Button btnAddOutput;
        private Button btnAddUser;
        private Button btnAddProject;
        private Button btnAddSupplier;
        private Button btnAddCustomer;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label lblCompanyName;
        private PictureBox pbLogo;
        private Label lblWelcome;
    }
}
