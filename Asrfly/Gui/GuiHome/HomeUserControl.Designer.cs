namespace Asrfly.Gui.GuiHome
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
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            buttonAddInput = new Button();
            buttonAddOutput = new Button();
            buttonAddUsers = new Button();
            buttonAddProject = new Button();
            buttonSupplier = new Button();
            buttonAddCustomer = new Button();
            buttonAddCategory = new Button();
            label1 = new Label();
            panel2 = new Panel();
            labelCompanyName = new Label();
            pictureBoxLogo = new PictureBox();
            labelWellcom = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 407);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 208);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.icons8_smart_480px;
            pictureBox1.Location = new Point(550, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(buttonAddInput);
            groupBox1.Controls.Add(buttonAddOutput);
            groupBox1.Controls.Add(buttonAddUsers);
            groupBox1.Controls.Add(buttonAddProject);
            groupBox1.Controls.Add(buttonSupplier);
            groupBox1.Controls.Add(buttonAddCustomer);
            groupBox1.Controls.Add(buttonAddCategory);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(35, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1195, 119);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "أضافة ";
            // 
            // buttonAddInput
            // 
            buttonAddInput.Image = Properties.Resources.icons8_staff_32px;
            buttonAddInput.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddInput.Location = new Point(8, 34);
            buttonAddInput.Margin = new Padding(5);
            buttonAddInput.Name = "buttonAddInput";
            buttonAddInput.Size = new Size(160, 54);
            buttonAddInput.TabIndex = 7;
            buttonAddInput.Text = "    قبض";
            buttonAddInput.UseVisualStyleBackColor = true;
            // 
            // buttonAddOutput
            // 
            buttonAddOutput.Image = Properties.Resources.icons8_staff_32px;
            buttonAddOutput.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddOutput.Location = new Point(177, 34);
            buttonAddOutput.Margin = new Padding(5);
            buttonAddOutput.Name = "buttonAddOutput";
            buttonAddOutput.Size = new Size(160, 54);
            buttonAddOutput.TabIndex = 6;
            buttonAddOutput.Text = "    صرف";
            buttonAddOutput.UseVisualStyleBackColor = true;
            // 
            // buttonAddUsers
            // 
            buttonAddUsers.Image = Properties.Resources.icons8_staff_32px;
            buttonAddUsers.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddUsers.Location = new Point(346, 34);
            buttonAddUsers.Margin = new Padding(5);
            buttonAddUsers.Name = "buttonAddUsers";
            buttonAddUsers.Size = new Size(160, 54);
            buttonAddUsers.TabIndex = 5;
            buttonAddUsers.Text = "    مستخدم";
            buttonAddUsers.UseVisualStyleBackColor = true;
            // 
            // buttonAddProject
            // 
            buttonAddProject.Image = Properties.Resources.icons8_view_quilt_32px_1;
            buttonAddProject.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddProject.Location = new Point(515, 34);
            buttonAddProject.Margin = new Padding(5);
            buttonAddProject.Name = "buttonAddProject";
            buttonAddProject.Size = new Size(160, 54);
            buttonAddProject.TabIndex = 4;
            buttonAddProject.Text = "    مشورع";
            buttonAddProject.UseVisualStyleBackColor = true;
            // 
            // buttonSupplier
            // 
            buttonSupplier.Image = Properties.Resources.icons8_customer_32px_1;
            buttonSupplier.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSupplier.Location = new Point(684, 34);
            buttonSupplier.Margin = new Padding(5);
            buttonSupplier.Name = "buttonSupplier";
            buttonSupplier.Size = new Size(160, 54);
            buttonSupplier.TabIndex = 3;
            buttonSupplier.Text = "    مورد";
            buttonSupplier.UseVisualStyleBackColor = true;
            // 
            // buttonAddCustomer
            // 
            buttonAddCustomer.Image = Properties.Resources.icons8_customer_32px;
            buttonAddCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddCustomer.Location = new Point(853, 34);
            buttonAddCustomer.Margin = new Padding(5);
            buttonAddCustomer.Name = "buttonAddCustomer";
            buttonAddCustomer.Size = new Size(160, 54);
            buttonAddCustomer.TabIndex = 2;
            buttonAddCustomer.Text = "    عميل";
            buttonAddCustomer.UseVisualStyleBackColor = true;
            // 
            // buttonAddCategory
            // 
            buttonAddCategory.Image = Properties.Resources.icons8_categorize_32px;
            buttonAddCategory.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddCategory.Location = new Point(1022, 34);
            buttonAddCategory.Margin = new Padding(5);
            buttonAddCategory.Name = "buttonAddCategory";
            buttonAddCategory.Size = new Size(160, 54);
            buttonAddCategory.TabIndex = 1;
            buttonAddCategory.Text = "    صنف";
            buttonAddCategory.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(622, 12);
            label1.Name = "label1";
            label1.Size = new Size(165, 32);
            label1.TabIndex = 0;
            label1.Text = "الوصول السريع";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(labelCompanyName);
            panel2.Controls.Add(pictureBoxLogo);
            panel2.Location = new Point(661, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(396, 97);
            panel2.TabIndex = 1;
            // 
            // labelCompanyName
            // 
            labelCompanyName.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelCompanyName.Location = new Point(3, 1);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new Size(264, 85);
            labelCompanyName.TabIndex = 5;
            labelCompanyName.Text = "الوصول السريع";
            labelCompanyName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Dock = DockStyle.Right;
            pictureBoxLogo.Image = Properties.Resources.icons8_smart_480px;
            pictureBoxLogo.Location = new Point(273, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(123, 97);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 4;
            pictureBoxLogo.TabStop = false;
            // 
            // labelWellcom
            // 
            labelWellcom.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelWellcom.Location = new Point(70, 107);
            labelWellcom.Name = "labelWellcom";
            labelWellcom.Size = new Size(264, 85);
            labelWellcom.TabIndex = 6;
            labelWellcom.Text = "مرحبا بك";
            labelWellcom.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HomeUserControl
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(labelWellcom);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "HomeUserControl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1264, 615);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Button buttonAddCategory;
        private Button buttonAddCustomer;
        private Button buttonSupplier;
        private Button buttonAddProject;
        private Button buttonAddUsers;
        private Button buttonAddOutput;
        private Button buttonAddInput;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label labelCompanyName;
        private PictureBox pictureBoxLogo;
        private Label labelWellcom;
    }
}
