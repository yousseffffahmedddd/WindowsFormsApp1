namespace WindowsFormsApp1
{
    partial class payments
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
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.methodComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.ticketsNumTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.paymentRefTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.deletePanel = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.paymentDeleteComboBox = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.updatePanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.paymentUpdateComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.fieldComboBox = new System.Windows.Forms.ComboBox();
            this.updateValueTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.viewPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label18 = new System.Windows.Forms.Label();
            this.viewByComboBox = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.insertionPanel.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.deletePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.updatePanel.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
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
            this.label1.Text = "Add Payment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // insertionPanel
            // 
            this.insertionPanel.AllowDrop = true;
            this.insertionPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.insertionPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.insertionPanel.ColumnCount = 1;
            this.insertionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.insertionPanel.Controls.Add(this.tableLayoutPanel7, 0, 6);
            this.insertionPanel.Controls.Add(this.tableLayoutPanel6, 0, 5);
            this.insertionPanel.Controls.Add(this.tableLayoutPanel5, 0, 4);
            this.insertionPanel.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.insertionPanel.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.insertionPanel.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.insertionPanel.Controls.Add(this.insertButton, 0, 7);
            this.insertionPanel.Controls.Add(this.label1, 0, 0);
            this.insertionPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.insertionPanel.Location = new System.Drawing.Point(39, 108);
            this.insertionPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertionPanel.Name = "insertionPanel";
            this.insertionPanel.Padding = new System.Windows.Forms.Padding(15);
            this.insertionPanel.RowCount = 8;
            this.insertionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.insertionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.insertionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.insertionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.insertionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.insertionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.insertionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.insertionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.insertionPanel.Size = new System.Drawing.Size(441, 490);
            this.insertionPanel.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.75159F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.24841F));
            this.tableLayoutPanel7.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.statusComboBox, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(18, 379);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(405, 54);
            this.tableLayoutPanel7.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 54);
            this.label8.TabIndex = 4;
            this.label8.Text = "Status";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.UseCompatibleTextRendering = true;
            // 
            // statusComboBox
            // 
            this.statusComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(111, 23);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(291, 37);
            this.statusComboBox.TabIndex = 5;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.75159F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.24841F));
            this.tableLayoutPanel6.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.methodComboBox, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(18, 319);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(405, 54);
            this.tableLayoutPanel6.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 54);
            this.label7.TabIndex = 4;
            this.label7.Text = "Method";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.UseCompatibleTextRendering = true;
            // 
            // methodComboBox
            // 
            this.methodComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.methodComboBox.FormattingEnabled = true;
            this.methodComboBox.Location = new System.Drawing.Point(111, 23);
            this.methodComboBox.Name = "methodComboBox";
            this.methodComboBox.Size = new System.Drawing.Size(291, 37);
            this.methodComboBox.TabIndex = 5;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.75159F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.24841F));
            this.tableLayoutPanel5.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.customerComboBox, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(18, 259);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(405, 54);
            this.tableLayoutPanel5.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 54);
            this.label6.TabIndex = 4;
            this.label6.Text = "Customer";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.UseCompatibleTextRendering = true;
            // 
            // customerComboBox
            // 
            this.customerComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(111, 23);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(291, 37);
            this.customerComboBox.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.75159F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.24841F));
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.ticketsNumTextBox, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(18, 199);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(405, 54);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 54);
            this.label5.TabIndex = 4;
            this.label5.Text = "# Tickets";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.UseCompatibleTextRendering = true;
            // 
            // ticketsNumTextBox
            // 
            this.ticketsNumTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ticketsNumTextBox.Location = new System.Drawing.Point(111, 17);
            this.ticketsNumTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ticketsNumTextBox.Name = "ticketsNumTextBox";
            this.ticketsNumTextBox.Size = new System.Drawing.Size(291, 35);
            this.ticketsNumTextBox.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.75159F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.24841F));
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.paymentRefTextBox, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(18, 139);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(405, 54);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 54);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ref. #";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseCompatibleTextRendering = true;
            // 
            // paymentRefTextBox
            // 
            this.paymentRefTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paymentRefTextBox.Location = new System.Drawing.Point(111, 17);
            this.paymentRefTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paymentRefTextBox.Name = "paymentRefTextBox";
            this.paymentRefTextBox.Size = new System.Drawing.Size(291, 35);
            this.paymentRefTextBox.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.75159F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.24841F));
            this.tableLayoutPanel2.Controls.Add(this.datePicker, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(18, 79);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(405, 54);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // datePicker
            // 
            this.datePicker.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datePicker.Location = new System.Drawing.Point(111, 16);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(291, 35);
            this.datePicker.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 54);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(18, 437);
            this.insertButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(405, 50);
            this.insertButton.TabIndex = 18;
            this.insertButton.Text = "Add Payment";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label2.Location = new System.Drawing.Point(29, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(533, 55);
            this.label2.TabIndex = 2;
            this.label2.Text = "Payments Management";
            // 
            // deletePanel
            // 
            this.deletePanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.deletePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deletePanel.ColumnCount = 1;
            this.deletePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.62012F));
            this.deletePanel.Controls.Add(this.label9, 0, 0);
            this.deletePanel.Controls.Add(this.label10, 0, 1);
            this.deletePanel.Controls.Add(this.paymentDeleteComboBox, 0, 2);
            this.deletePanel.Controls.Add(this.deleteButton, 0, 3);
            this.deletePanel.Controls.Add(this.label11, 0, 4);
            this.deletePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.deletePanel.Location = new System.Drawing.Point(501, 448);
            this.deletePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deletePanel.Name = "deletePanel";
            this.deletePanel.Padding = new System.Windows.Forms.Padding(15);
            this.deletePanel.RowCount = 5;
            this.deletePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.deletePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.deletePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.deletePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.deletePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.deletePanel.Size = new System.Drawing.Size(436, 299);
            this.deletePanel.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Crimson;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label9.Location = new System.Drawing.Point(18, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(400, 49);
            this.label9.TabIndex = 0;
            this.label9.Text = "Delete Payment";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label10.Location = new System.Drawing.Point(18, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(400, 32);
            this.label10.TabIndex = 4;
            this.label10.Text = "Select a Payment";
            // 
            // paymentDeleteComboBox
            // 
            this.paymentDeleteComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.paymentDeleteComboBox.FormattingEnabled = true;
            this.paymentDeleteComboBox.Location = new System.Drawing.Point(18, 104);
            this.paymentDeleteComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paymentDeleteComboBox.Name = "paymentDeleteComboBox";
            this.paymentDeleteComboBox.Size = new System.Drawing.Size(400, 40);
            this.paymentDeleteComboBox.TabIndex = 5;
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteButton.Location = new System.Drawing.Point(18, 166);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(400, 66);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.ForeColor = System.Drawing.Color.Firebrick;
            this.label11.Location = new System.Drawing.Point(18, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(360, 29);
            this.label11.TabIndex = 9;
            this.label11.Text = "Once deleted You cannot REDO";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.updatePanel.Controls.Add(this.tableLayoutPanel9, 0, 1);
            this.updatePanel.Controls.Add(this.tableLayoutPanel10, 0, 2);
            this.updatePanel.Controls.Add(this.updateValueTextBox, 0, 4);
            this.updatePanel.Controls.Add(this.updateButton, 0, 5);
            this.updatePanel.Controls.Add(this.label12, 0, 0);
            this.updatePanel.Controls.Add(this.label16, 0, 3);
            this.updatePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.updatePanel.Location = new System.Drawing.Point(501, 108);
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
            this.updatePanel.Size = new System.Drawing.Size(436, 325);
            this.updatePanel.TabIndex = 11;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.16773F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.83227F));
            this.tableLayoutPanel9.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.paymentUpdateComboBox, 1, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(18, 66);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(400, 62);
            this.tableLayoutPanel9.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(198, 62);
            this.label14.TabIndex = 4;
            this.label14.Text = "Select Payment";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.UseCompatibleTextRendering = true;
            // 
            // paymentUpdateComboBox
            // 
            this.paymentUpdateComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentUpdateComboBox.FormattingEnabled = true;
            this.paymentUpdateComboBox.Location = new System.Drawing.Point(207, 2);
            this.paymentUpdateComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paymentUpdateComboBox.Name = "paymentUpdateComboBox";
            this.paymentUpdateComboBox.Size = new System.Drawing.Size(190, 40);
            this.paymentUpdateComboBox.TabIndex = 5;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.16773F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.83227F));
            this.tableLayoutPanel10.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.fieldComboBox, 1, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(18, 132);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(400, 57);
            this.tableLayoutPanel10.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(198, 57);
            this.label15.TabIndex = 4;
            this.label15.Text = "Select field to update";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.UseCompatibleTextRendering = true;
            // 
            // fieldComboBox
            // 
            this.fieldComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fieldComboBox.FormattingEnabled = true;
            this.fieldComboBox.Items.AddRange(new object[] {
            "Date",
            "Payment Reference",
            "Tickets Number",
            "Method",
            "Status"});
            this.fieldComboBox.Location = new System.Drawing.Point(207, 2);
            this.fieldComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fieldComboBox.Name = "fieldComboBox";
            this.fieldComboBox.Size = new System.Drawing.Size(190, 40);
            this.fieldComboBox.TabIndex = 5;
            // 
            // updateValueTextBox
            // 
            this.updateValueTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.updateValueTextBox.Location = new System.Drawing.Point(18, 242);
            this.updateValueTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateValueTextBox.Name = "updateValueTextBox";
            this.updateValueTextBox.Size = new System.Drawing.Size(400, 39);
            this.updateValueTextBox.TabIndex = 21;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.updateButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.updateButton.Location = new System.Drawing.Point(18, 283);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(400, 49);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.CadetBlue;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label12.Location = new System.Drawing.Point(18, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(400, 49);
            this.label12.TabIndex = 0;
            this.label12.Text = "Update Payment";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label16.Location = new System.Drawing.Point(18, 208);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(400, 32);
            this.label16.TabIndex = 23;
            this.label16.Text = "New value";
            // 
            // viewPanel
            // 
            this.viewPanel.ColumnCount = 2;
            this.viewPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.59292F));
            this.viewPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.40708F));
            this.viewPanel.Controls.Add(this.label18, 0, 0);
            this.viewPanel.Controls.Add(this.viewByComboBox, 1, 0);
            this.viewPanel.Location = new System.Drawing.Point(1189, 768);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.RowCount = 1;
            this.viewPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.viewPanel.Size = new System.Drawing.Size(565, 61);
            this.viewPanel.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label18.Location = new System.Drawing.Point(3, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(228, 61);
            this.label18.TabIndex = 16;
            this.label18.Text = "Show Payments by:";
            // 
            // viewByComboBox
            // 
            this.viewByComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.viewByComboBox.FormattingEnabled = true;
            this.viewByComboBox.Items.AddRange(new object[] {
            "All",
            "Date",
            "Status",
            "Method",
            "Customer"});
            this.viewByComboBox.Location = new System.Drawing.Point(237, 30);
            this.viewByComboBox.Name = "viewByComboBox";
            this.viewByComboBox.Size = new System.Drawing.Size(325, 28);
            this.viewByComboBox.TabIndex = 15;
            this.viewByComboBox.SelectedIndexChanged += new System.EventHandler(this.viewByComboBox_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label17.Location = new System.Drawing.Point(1003, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(246, 32);
            this.label17.TabIndex = 18;
            this.label17.Text = "Payment Records:";
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.refreshButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refreshButton.Location = new System.Drawing.Point(501, 768);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(436, 60);
            this.refreshButton.TabIndex = 19;
            this.refreshButton.Text = "Refresh Data";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1898, 874);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.viewPanel);
            this.Controls.Add(this.updatePanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deletePanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.insertionPanel);
            this.Name = "payments";
            this.Text = "Payment Management";
            this.Load += new System.EventHandler(this.payments_Load);
            this.insertionPanel.ResumeLayout(false);
            this.insertionPanel.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
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
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.viewPanel.ResumeLayout(false);
            this.viewPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel insertionPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel deletePanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox methodComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ticketsNumTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox paymentRefTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox paymentDeleteComboBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel updatePanel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox paymentUpdateComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox fieldComboBox;
        private System.Windows.Forms.TextBox updateValueTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TableLayoutPanel viewPanel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox viewByComboBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button refreshButton;
    }
}
