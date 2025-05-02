namespace WindowsFormsApp1
{
    partial class admins
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
            this.label1 = new System.Windows.Forms.Label();
            this.insertionPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.roleTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.deletePanel = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.admin_delete_combobox = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.updatePanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.adminSelectComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.fieldComboBox = new System.Windows.Forms.ComboBox();
            this.updateTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.viewPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.viewByComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.insertionPanel.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.deletePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.updatePanel.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.viewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insertion";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // insertionPanel
            // 
            this.insertionPanel.AllowDrop = true;
            this.insertionPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.insertionPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.insertionPanel.ColumnCount = 1;
            this.insertionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.insertionPanel.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.insertionPanel.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.insertionPanel.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.insertionPanel.Controls.Add(this.insertButton, 0, 4);
            this.insertionPanel.Controls.Add(this.label1, 0, 0);
            this.insertionPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.insertionPanel.Location = new System.Drawing.Point(39, 108);
            this.insertionPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertionPanel.Name = "insertionPanel";
            this.insertionPanel.Padding = new System.Windows.Forms.Padding(15);
            this.insertionPanel.RowCount = 5;
            this.insertionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.insertionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.insertionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.insertionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.insertionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.insertionPanel.Size = new System.Drawing.Size(441, 325);
            this.insertionPanel.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.75159F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.24841F));
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.roleTextBox, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(18, 199);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(405, 54);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 54);
            this.label7.TabIndex = 4;
            this.label7.Text = "Role";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.UseCompatibleTextRendering = true;
            // 
            // roleTextBox
            // 
            this.roleTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.roleTextBox.Location = new System.Drawing.Point(111, 17);
            this.roleTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roleTextBox.Name = "roleTextBox";
            this.roleTextBox.Size = new System.Drawing.Size(291, 35);
            this.roleTextBox.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.75159F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.24841F));
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.passwordTextBox, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(18, 139);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(405, 54);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 54);
            this.label6.TabIndex = 4;
            this.label6.Text = "Password";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.UseCompatibleTextRendering = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.passwordTextBox.Location = new System.Drawing.Point(111, 17);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(291, 35);
            this.passwordTextBox.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.75159F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.24841F));
            this.tableLayoutPanel2.Controls.Add(this.nameTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(18, 79);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(405, 54);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nameTextBox.Location = new System.Drawing.Point(111, 17);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(291, 35);
            this.nameTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 54);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseCompatibleTextRendering = true;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(18, 257);
            this.insertButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(405, 50);
            this.insertButton.TabIndex = 18;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label5.Location = new System.Drawing.Point(29, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(455, 55);
            this.label5.TabIndex = 2;
            this.label5.Text = "Admin Management";
            // 
            // deletePanel
            // 
            this.deletePanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.deletePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deletePanel.ColumnCount = 1;
            this.deletePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.62012F));
            this.deletePanel.Controls.Add(this.label8, 0, 0);
            this.deletePanel.Controls.Add(this.label9, 0, 1);
            this.deletePanel.Controls.Add(this.admin_delete_combobox, 0, 2);
            this.deletePanel.Controls.Add(this.deleteButton, 0, 3);
            this.deletePanel.Controls.Add(this.label3, 0, 4);
            this.deletePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.deletePanel.Location = new System.Drawing.Point(39, 448);
            this.deletePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deletePanel.Name = "deletePanel";
            this.deletePanel.Padding = new System.Windows.Forms.Padding(15);
            this.deletePanel.RowCount = 5;
            this.deletePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.deletePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.deletePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.deletePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.deletePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.deletePanel.Size = new System.Drawing.Size(441, 299);
            this.deletePanel.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Crimson;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label8.Location = new System.Drawing.Point(18, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(405, 49);
            this.label8.TabIndex = 0;
            this.label8.Text = "Deletion";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label9.Location = new System.Drawing.Point(18, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(405, 32);
            this.label9.TabIndex = 4;
            this.label9.Text = "Select an Admin";
            // 
            // admin_delete_combobox
            // 
            this.admin_delete_combobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.admin_delete_combobox.FormattingEnabled = true;
            this.admin_delete_combobox.Location = new System.Drawing.Point(18, 104);
            this.admin_delete_combobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin_delete_combobox.Name = "admin_delete_combobox";
            this.admin_delete_combobox.Size = new System.Drawing.Size(405, 40);
            this.admin_delete_combobox.TabIndex = 5;
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteButton.Location = new System.Drawing.Point(18, 166);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(405, 66);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(18, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Once deleted You cannot REDO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.backButton.Location = new System.Drawing.Point(39, 768);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(441, 82);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back to dashboard";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1003, 108);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(881, 639);
            this.dataGridView1.TabIndex = 7;
            // 
            // updatePanel
            // 
            this.updatePanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.updatePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.updatePanel.ColumnCount = 1;
            this.updatePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.updatePanel.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.updatePanel.Controls.Add(this.tableLayoutPanel7, 0, 2);
            this.updatePanel.Controls.Add(this.updateTextBox, 0, 4);
            this.updatePanel.Controls.Add(this.updateButton, 0, 5);
            this.updatePanel.Controls.Add(this.label10, 0, 0);
            this.updatePanel.Controls.Add(this.label11, 0, 3);
            this.updatePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.updatePanel.Location = new System.Drawing.Point(503, 108);
            this.updatePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Padding = new System.Windows.Forms.Padding(15);
            this.updatePanel.RowCount = 6;
            this.updatePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.updatePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.updatePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.updatePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.updatePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.updatePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.updatePanel.Size = new System.Drawing.Size(436, 391);
            this.updatePanel.TabIndex = 11;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.16773F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.83227F));
            this.tableLayoutPanel6.Controls.Add(this.label16, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.adminSelectComboBox, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(18, 66);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(400, 62);
            this.tableLayoutPanel6.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(198, 62);
            this.label16.TabIndex = 4;
            this.label16.Text = "Select Admin";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.UseCompatibleTextRendering = true;
            // 
            // adminSelectComboBox
            // 
            this.adminSelectComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminSelectComboBox.FormattingEnabled = true;
            this.adminSelectComboBox.Location = new System.Drawing.Point(207, 2);
            this.adminSelectComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminSelectComboBox.Name = "adminSelectComboBox";
            this.adminSelectComboBox.Size = new System.Drawing.Size(190, 40);
            this.adminSelectComboBox.TabIndex = 5;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.16773F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.83227F));
            this.tableLayoutPanel7.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.fieldComboBox, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(18, 132);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(400, 57);
            this.tableLayoutPanel7.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 57);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select field to update";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // fieldComboBox
            // 
            this.fieldComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fieldComboBox.FormattingEnabled = true;
            this.fieldComboBox.Items.AddRange(new object[] {
            "name",
            "password",
            "role"});
            this.fieldComboBox.Location = new System.Drawing.Point(207, 2);
            this.fieldComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fieldComboBox.Name = "fieldComboBox";
            this.fieldComboBox.Size = new System.Drawing.Size(190, 40);
            this.fieldComboBox.TabIndex = 5;
            // 
            // updateTextBox
            // 
            this.updateTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.updateTextBox.Location = new System.Drawing.Point(18, 242);
            this.updateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateTextBox.Name = "updateTextBox";
            this.updateTextBox.Size = new System.Drawing.Size(400, 39);
            this.updateTextBox.TabIndex = 21;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.updateButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.updateButton.Location = new System.Drawing.Point(18, 325);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(400, 49);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.CadetBlue;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label10.Location = new System.Drawing.Point(18, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(400, 49);
            this.label10.TabIndex = 0;
            this.label10.Text = "Update";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label11.Location = new System.Drawing.Point(18, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(400, 32);
            this.label11.TabIndex = 23;
            this.label11.Text = "New value";
            // 
            // viewPanel
            // 
            this.viewPanel.ColumnCount = 2;
            this.viewPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.59292F));
            this.viewPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.40708F));
            this.viewPanel.Controls.Add(this.label13, 0, 0);
            this.viewPanel.Controls.Add(this.viewByComboBox, 1, 0);
            this.viewPanel.Location = new System.Drawing.Point(1189, 768);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.RowCount = 1;
            this.viewPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.viewPanel.Size = new System.Drawing.Size(565, 61);
            this.viewPanel.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(228, 61);
            this.label13.TabIndex = 16;
            this.label13.Text = "Show Admins by:";
            // 
            // viewByComboBox
            // 
            this.viewByComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.viewByComboBox.FormattingEnabled = true;
            this.viewByComboBox.Items.AddRange(new object[] {
            "All",
            "Role"});
            this.viewByComboBox.Location = new System.Drawing.Point(237, 30);
            this.viewByComboBox.Name = "viewByComboBox";
            this.viewByComboBox.Size = new System.Drawing.Size(325, 28);
            this.viewByComboBox.TabIndex = 15;
            this.viewByComboBox.SelectedIndexChanged += new System.EventHandler(this.viewByComboBox_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label12.Location = new System.Drawing.Point(1003, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(215, 32);
            this.label12.TabIndex = 18;
            this.label12.Text = "Admin Records:";
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.refreshButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refreshButton.Location = new System.Drawing.Point(503, 534);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(436, 60);
            this.refreshButton.TabIndex = 19;
            this.refreshButton.Text = "Refresh Data";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // admins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1898, 874);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.viewPanel);
            this.Controls.Add(this.updatePanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deletePanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.insertionPanel);
            this.Name = "admins";
            this.Text = "Admin Management";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.insertionPanel.ResumeLayout(false);
            this.insertionPanel.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.deletePanel.ResumeLayout(false);
            this.deletePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.viewPanel.ResumeLayout(false);
            this.viewPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel insertionPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel deletePanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox roleTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox admin_delete_combobox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel updatePanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox adminSelectComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox fieldComboBox;
        private System.Windows.Forms.TextBox updateTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel viewPanel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox viewByComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button refreshButton;
    }
}
