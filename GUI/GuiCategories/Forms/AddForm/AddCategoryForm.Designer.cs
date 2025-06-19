namespace ASRFLY.Desktop.GUI.GuiCategories.Forms.AddForm
{
    partial class AddCategoryForm
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
            panel1 = new Panel();
            btnClose = new Button();
            btnSave = new Button();
            gbDetails = new GroupBox();
            rtxtDetails = new RichTextBox();
            cbType = new ComboBox();
            textBox4 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            gbDetails.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnSave);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 643);
            panel1.Name = "panel1";
            panel1.Size = new Size(675, 90);
            panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.Close;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(18, 21);
            btnClose.Margin = new Padding(5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(179, 55);
            btnClose.TabIndex = 3;
            btnClose.Text = "غلق";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.Save;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(482, 21);
            btnSave.Margin = new Padding(5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(179, 55);
            btnSave.TabIndex = 3;
            btnSave.Text = "حفظ";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // gbDetails
            // 
            gbDetails.Controls.Add(rtxtDetails);
            gbDetails.Controls.Add(cbType);
            gbDetails.Controls.Add(textBox4);
            gbDetails.Controls.Add(label4);
            gbDetails.Controls.Add(label3);
            gbDetails.Controls.Add(label2);
            gbDetails.Controls.Add(txtName);
            gbDetails.Controls.Add(label1);
            gbDetails.Font = new Font("Cairo", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbDetails.ForeColor = Color.SteelBlue;
            gbDetails.Location = new Point(29, 12);
            gbDetails.Name = "gbDetails";
            gbDetails.Size = new Size(634, 587);
            gbDetails.TabIndex = 1;
            gbDetails.TabStop = false;
            gbDetails.Text = "معلومات الصنف";
            // 
            // rtxtDetails
            // 
            rtxtDetails.Location = new Point(6, 290);
            rtxtDetails.Name = "rtxtDetails";
            rtxtDetails.Size = new Size(622, 164);
            rtxtDetails.TabIndex = 5;
            rtxtDetails.Text = "";
            rtxtDetails.TextChanged += rtxtDetails_TextChanged;
            // 
            // cbType
            // 
            cbType.BackColor = Color.White;
            cbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "صرف", "قبض" });
            cbType.Location = new Point(6, 195);
            cbType.Name = "cbType";
            cbType.Size = new Size(622, 45);
            cbType.TabIndex = 4;
            cbType.SelectedIndexChanged += cbType_SelectedIndexChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(6, 532);
            textBox4.Name = "textBox4";
            textBox4.RightToLeft = RightToLeft.No;
            textBox4.Size = new Size(622, 45);
            textBox4.TabIndex = 3;
            textBox4.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(266, 492);
            label4.Name = "label4";
            label4.Size = new Size(77, 37);
            label4.TabIndex = 2;
            label4.Text = "الرصيد";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 250);
            label3.Name = "label3";
            label3.Size = new Size(99, 37);
            label3.TabIndex = 2;
            label3.Text = "التفاصيل";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 155);
            label2.Name = "label2";
            label2.Size = new Size(112, 37);
            label2.TabIndex = 2;
            label2.Text = "نوع الصنف";
            // 
            // txtName
            // 
            txtName.Location = new Point(6, 102);
            txtName.Name = "txtName";
            txtName.Size = new Size(622, 45);
            txtName.TabIndex = 3;
            txtName.TextAlign = HorizontalAlignment.Right;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(253, 62);
            label1.Name = "label1";
            label1.Size = new Size(118, 37);
            label1.TabIndex = 2;
            label1.Text = "اسم الصنف";
            // 
            // AddCategoryForm
            // 
            AutoScaleDimensions = new SizeF(11F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(675, 733);
            Controls.Add(gbDetails);
            Controls.Add(panel1);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddCategoryForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اضافة اصناف";
            TopMost = true;
            panel1.ResumeLayout(false);
            gbDetails.ResumeLayout(false);
            gbDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox gbDetails;
        private Label label3;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private ComboBox cbType;
        private TextBox textBox4;
        private Label label4;
        private RichTextBox rtxtDetails;
        private Button btnSave;
        private Button btnClose;
    }
}