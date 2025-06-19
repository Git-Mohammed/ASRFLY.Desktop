namespace ASRFLY.Desktop
{
    partial class frmMain
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnHome = new Button();
            btnCategories = new Button();
            btnCustomers = new Button();
            btnSuppliers = new Button();
            btnProjects = new Button();
            btnUsers = new Button();
            btnSettings = new Button();
            btnLogout = new Button();
            btnHelp = new Button();
            btnAbout = new Button();
            pnlContainer = new Panel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(btnHome);
            flowLayoutPanel1.Controls.Add(btnCategories);
            flowLayoutPanel1.Controls.Add(btnCustomers);
            flowLayoutPanel1.Controls.Add(btnSuppliers);
            flowLayoutPanel1.Controls.Add(btnProjects);
            flowLayoutPanel1.Controls.Add(btnUsers);
            flowLayoutPanel1.Controls.Add(btnSettings);
            flowLayoutPanel1.Controls.Add(btnLogout);
            flowLayoutPanel1.Controls.Add(btnHelp);
            flowLayoutPanel1.Controls.Add(btnAbout);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 601);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(1262, 72);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Image = Properties.Resources.Home;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(1061, 10);
            btnHome.Margin = new Padding(5);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(165, 55);
            btnHome.TabIndex = 1;
            btnHome.Text = "      الرئيسية\r\n";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnCategories
            // 
            btnCategories.Image = Properties.Resources.Categorize;
            btnCategories.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategories.Location = new Point(886, 10);
            btnCategories.Margin = new Padding(5);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(165, 55);
            btnCategories.TabIndex = 3;
            btnCategories.Text = "      الاصناف\r\n";
            btnCategories.UseVisualStyleBackColor = true;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.Image = Properties.Resources.Customers_32px;
            btnCustomers.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomers.Location = new Point(711, 10);
            btnCustomers.Margin = new Padding(5);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(165, 55);
            btnCustomers.TabIndex = 6;
            btnCustomers.Text = "      العملاء\r\n";
            btnCustomers.UseVisualStyleBackColor = true;
            // 
            // btnSuppliers
            // 
            btnSuppliers.Image = Properties.Resources.Supplier;
            btnSuppliers.ImageAlign = ContentAlignment.MiddleLeft;
            btnSuppliers.Location = new Point(536, 10);
            btnSuppliers.Margin = new Padding(5);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(165, 55);
            btnSuppliers.TabIndex = 8;
            btnSuppliers.Text = "      الموردين\r\n";
            btnSuppliers.UseVisualStyleBackColor = true;
            // 
            // btnProjects
            // 
            btnProjects.Image = Properties.Resources.Group_of_Projects;
            btnProjects.ImageAlign = ContentAlignment.MiddleLeft;
            btnProjects.Location = new Point(361, 10);
            btnProjects.Margin = new Padding(5);
            btnProjects.Name = "btnProjects";
            btnProjects.Size = new Size(165, 55);
            btnProjects.TabIndex = 10;
            btnProjects.Text = "      المشاريع\r\n";
            btnProjects.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            btnUsers.Image = Properties.Resources.Users;
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(186, 10);
            btnUsers.Margin = new Padding(5);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(165, 55);
            btnUsers.TabIndex = 12;
            btnUsers.Text = "      المستخدمين\r\n";
            btnUsers.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            btnSettings.Image = Properties.Resources.Settings;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(11, 10);
            btnSettings.Margin = new Padding(5);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(165, 55);
            btnSettings.TabIndex = 14;
            btnSettings.Text = "      الاعدادات\r\n";
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Image = Properties.Resources.Logout;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(1061, 75);
            btnLogout.Margin = new Padding(5);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(165, 55);
            btnLogout.TabIndex = 16;
            btnLogout.Text = "      الخروج\r\n";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            btnHelp.Image = Properties.Resources.Help;
            btnHelp.ImageAlign = ContentAlignment.MiddleLeft;
            btnHelp.Location = new Point(886, 75);
            btnHelp.Margin = new Padding(5);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(165, 55);
            btnHelp.TabIndex = 18;
            btnHelp.Text = "      المساعدة\r\n";
            btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            btnAbout.Image = Properties.Resources.About;
            btnAbout.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbout.Location = new Point(711, 75);
            btnAbout.Margin = new Padding(5);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(165, 55);
            btnAbout.TabIndex = 20;
            btnAbout.Text = "      حول\r\n";
            btnAbout.UseVisualStyleBackColor = true;
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.White;
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1262, 601);
            pnlContainer.TabIndex = 1;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(11F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(pnlContainer);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 6, 4, 6);
            Name = "frmMain";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اصرفلي";
            WindowState = FormWindowState.Maximized;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnHome;
        private Button btnCategories;
        private Button btnCustomers;
        private Button btnSuppliers;
        private Button btnProjects;
        private Button btnUsers;
        private Button btnSettings;
        private Button btnLogout;
        private Button btnHelp;
        private Button btnAbout;
        public Panel pnlContainer;
    }
}
