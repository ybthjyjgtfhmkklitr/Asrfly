namespace Asrfly
{
    partial class Main
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
            buttonHome = new Button();
            buttonCategory = new Button();
            buttonCustomers = new Button();
            buttonSuppliers = new Button();
            buttonProjucts = new Button();
            buttonUsers = new Button();
            buttonSettings = new Button();
            buttonLogout = new Button();
            buttonHelp = new Button();
            buttonAbout = new Button();
            panelContainer = new Panel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(buttonHome);
            flowLayoutPanel1.Controls.Add(buttonCategory);
            flowLayoutPanel1.Controls.Add(buttonCustomers);
            flowLayoutPanel1.Controls.Add(buttonSuppliers);
            flowLayoutPanel1.Controls.Add(buttonProjucts);
            flowLayoutPanel1.Controls.Add(buttonUsers);
            flowLayoutPanel1.Controls.Add(buttonSettings);
            flowLayoutPanel1.Controls.Add(buttonLogout);
            flowLayoutPanel1.Controls.Add(buttonHelp);
            flowLayoutPanel1.Controls.Add(buttonAbout);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 615);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1264, 66);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonHome
            // 
            buttonHome.Image = Properties.Resources.icons8_home_32px_2;
            buttonHome.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHome.Location = new Point(1074, 5);
            buttonHome.Margin = new Padding(5);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(168, 54);
            buttonHome.TabIndex = 0;
            buttonHome.Text = "    الصفحة الرئيسة";
            buttonHome.UseVisualStyleBackColor = true;
            buttonHome.Click += buttonHome_Click;
            // 
            // buttonCategory
            // 
            buttonCategory.Image = Properties.Resources.icons8_categorize_32px;
            buttonCategory.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCategory.Location = new Point(896, 5);
            buttonCategory.Margin = new Padding(5);
            buttonCategory.Name = "buttonCategory";
            buttonCategory.Size = new Size(168, 54);
            buttonCategory.TabIndex = 1;
            buttonCategory.Text = "    الاصناف";
            buttonCategory.UseVisualStyleBackColor = true;
            // 
            // buttonCustomers
            // 
            buttonCustomers.Image = Properties.Resources.icons8_customer_32px;
            buttonCustomers.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCustomers.Location = new Point(718, 5);
            buttonCustomers.Margin = new Padding(5);
            buttonCustomers.Name = "buttonCustomers";
            buttonCustomers.Size = new Size(168, 54);
            buttonCustomers.TabIndex = 2;
            buttonCustomers.Text = "    العملاء";
            buttonCustomers.UseVisualStyleBackColor = true;
            // 
            // buttonSuppliers
            // 
            buttonSuppliers.Image = Properties.Resources.icons8_customer_32px_1;
            buttonSuppliers.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSuppliers.Location = new Point(540, 5);
            buttonSuppliers.Margin = new Padding(5);
            buttonSuppliers.Name = "buttonSuppliers";
            buttonSuppliers.Size = new Size(168, 54);
            buttonSuppliers.TabIndex = 3;
            buttonSuppliers.Text = "    الموردين";
            buttonSuppliers.UseVisualStyleBackColor = true;
            // 
            // buttonProjucts
            // 
            buttonProjucts.Image = Properties.Resources.icons8_view_quilt_32px_1;
            buttonProjucts.ImageAlign = ContentAlignment.MiddleLeft;
            buttonProjucts.Location = new Point(362, 5);
            buttonProjucts.Margin = new Padding(5);
            buttonProjucts.Name = "buttonProjucts";
            buttonProjucts.Size = new Size(168, 54);
            buttonProjucts.TabIndex = 4;
            buttonProjucts.Text = "    المشاريع";
            buttonProjucts.UseVisualStyleBackColor = true;
            // 
            // buttonUsers
            // 
            buttonUsers.Image = Properties.Resources.icons8_staff_32px;
            buttonUsers.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUsers.Location = new Point(184, 5);
            buttonUsers.Margin = new Padding(5);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Size = new Size(168, 54);
            buttonUsers.TabIndex = 5;
            buttonUsers.Text = "    المستخدمين";
            buttonUsers.UseVisualStyleBackColor = true;
            // 
            // buttonSettings
            // 
            buttonSettings.Image = Properties.Resources.icons8_settings_32px;
            buttonSettings.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSettings.Location = new Point(6, 5);
            buttonSettings.Margin = new Padding(5);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(168, 54);
            buttonSettings.TabIndex = 6;
            buttonSettings.Text = "    الاعدادات";
            buttonSettings.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            buttonLogout.Image = Properties.Resources.icons8_open_pane_32px;
            buttonLogout.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogout.Location = new Point(1074, 69);
            buttonLogout.Margin = new Padding(5);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(168, 54);
            buttonLogout.TabIndex = 7;
            buttonLogout.Text = "    الخروج";
            buttonLogout.UseVisualStyleBackColor = true;
            // 
            // buttonHelp
            // 
            buttonHelp.Image = Properties.Resources.icons8_help_32px;
            buttonHelp.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHelp.Location = new Point(896, 69);
            buttonHelp.Margin = new Padding(5);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(168, 54);
            buttonHelp.TabIndex = 8;
            buttonHelp.Text = "    المساعدة";
            buttonHelp.UseVisualStyleBackColor = true;
            // 
            // buttonAbout
            // 
            buttonAbout.Image = Properties.Resources.icons8_about_32px;
            buttonAbout.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAbout.Location = new Point(718, 69);
            buttonAbout.Margin = new Padding(5);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(168, 54);
            buttonAbout.TabIndex = 9;
            buttonAbout.Text = "    حول النضام";
            buttonAbout.UseVisualStyleBackColor = true;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.White;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1264, 615);
            panelContainer.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelContainer);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Main";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Asrfly";
            WindowState = FormWindowState.Maximized;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonHome;
        private Button buttonCategory;
        private Button buttonCustomers;
        private Button buttonSuppliers;
        private Button buttonProjucts;
        private Button buttonUsers;
        private Button buttonSettings;
        private Button buttonLogout;
        private Button buttonHelp;
        private Button buttonAbout;
        public Panel panelContainer;
    }
}