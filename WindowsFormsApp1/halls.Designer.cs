using System;

namespace WindowsFormsApp1
{
    partial class halls
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.hallIdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.deletePanel = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.hallDeleteComboBox = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.updatePanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.hallUpdateComboBox = new System.Windows.Forms.ComboBox();
            this.updateValueTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.seatsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.seatPlaceTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.seatHallComboBox = new System.Windows.Forms.ComboBox();
            this.addSeatButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.insertionPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.deletePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.updatePanel.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.seatsPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
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
            this.label1.Text = "Add Hall";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // insertionPanel
            // 
            this.insertionPanel.AllowDrop = true;
            this.insertionPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.insertionPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.insertionPanel.ColumnCount = 1;
            this.insertionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.insertionPanel.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.insertionPanel.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.insertionPanel.Controls.Add(this.insertButton, 0, 3);
            this.insertionPanel.Controls.Add(this.label1, 0, 0);
            this.insertionPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.insertionPanel.Location = new System.Drawing.Point(39, 108);
            this.insertionPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertionPanel.Name = "insertionPanel";
            this.insertionPanel.Padding = new System.Windows.Forms.Padding(15);
            this.insertionPanel.RowCount = 4;
            this.insertionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.insertionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.insertionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.insertionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.insertionPanel.Size = new System.Drawing.Size(441, 293);
            this.insertionPanel.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.capacityTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(18, 139);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(405, 54);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // capacityTextBox
            // 
            this.capacityTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.capacityTextBox.Location = new System.Drawing.Point(124, 17);
            this.capacityTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.Size = new System.Drawing.Size(278, 35);
            this.capacityTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 54);
            this.label4.TabIndex = 4;
            this.label4.Text = "Capacity";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseCompatibleTextRendering = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.hallIdTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 79);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(405, 54);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // hallIdTextBox
            // 
            this.hallIdTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hallIdTextBox.Location = new System.Drawing.Point(124, 17);
            this.hallIdTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hallIdTextBox.Name = "hallIdTextBox";
            this.hallIdTextBox.Size = new System.Drawing.Size(278, 35);
            this.hallIdTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 54);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hall ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // insertButton
            // 
            this.insertButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.insertButton.Location = new System.Drawing.Point(18, 231);
            this.insertButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(405, 45);
            this.insertButton.TabIndex = 18;
            this.insertButton.Text = "Add Hall";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label5.Location = new System.Drawing.Point(29, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(425, 55);
            this.label5.TabIndex = 2;
            this.label5.Text = "Halls Management";
            // 
            // deletePanel
            // 
            this.deletePanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.deletePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deletePanel.ColumnCount = 1;
            this.deletePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.62012F));
            this.deletePanel.Controls.Add(this.label8, 0, 0);
            this.deletePanel.Controls.Add(this.label9, 0, 1);
            this.deletePanel.Controls.Add(this.hallDeleteComboBox, 0, 2);
            this.deletePanel.Controls.Add(this.deleteButton, 0, 3);
            this.deletePanel.Controls.Add(this.label11, 0, 4);
            this.deletePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.deletePanel.Location = new System.Drawing.Point(39, 454);
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
            this.label8.Text = "Delete Hall";
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
            this.label9.Text = "Select a Hall";
            // 
            // hallDeleteComboBox
            // 
            this.hallDeleteComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.hallDeleteComboBox.FormattingEnabled = true;
            this.hallDeleteComboBox.Location = new System.Drawing.Point(18, 104);
            this.hallDeleteComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hallDeleteComboBox.Name = "hallDeleteComboBox";
            this.hallDeleteComboBox.Size = new System.Drawing.Size(405, 40);
            this.hallDeleteComboBox.TabIndex = 5;
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
            this.backButton.Location = new System.Drawing.Point(39, 809);
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
            this.dataGridView1.Size = new System.Drawing.Size(881, 719);
            this.dataGridView1.TabIndex = 7;
            // 
            // updatePanel
            // 
            this.updatePanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.updatePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.updatePanel.ColumnCount = 1;
            this.updatePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.updatePanel.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.updatePanel.Controls.Add(this.updateValueTextBox, 0, 3);
            this.updatePanel.Controls.Add(this.updateButton, 0, 4);
            this.updatePanel.Controls.Add(this.label10, 0, 0);
            this.updatePanel.Controls.Add(this.label12, 0, 2);
            this.updatePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.updatePanel.Location = new System.Drawing.Point(528, 108);
            this.updatePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Padding = new System.Windows.Forms.Padding(15);
            this.updatePanel.RowCount = 5;
            this.updatePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.updatePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.updatePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.updatePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.updatePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.updatePanel.Size = new System.Drawing.Size(432, 293);
            this.updatePanel.TabIndex = 11;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.16773F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.83227F));
            this.tableLayoutPanel6.Controls.Add(this.label16, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.hallUpdateComboBox, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(18, 66);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(396, 62);
            this.tableLayoutPanel6.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(196, 62);
            this.label16.TabIndex = 4;
            this.label16.Text = "Select Hall";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.UseCompatibleTextRendering = true;
            // 
            // hallUpdateComboBox
            // 
            this.hallUpdateComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hallUpdateComboBox.FormattingEnabled = true;
            this.hallUpdateComboBox.Location = new System.Drawing.Point(205, 2);
            this.hallUpdateComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hallUpdateComboBox.Name = "hallUpdateComboBox";
            this.hallUpdateComboBox.Size = new System.Drawing.Size(188, 40);
            this.hallUpdateComboBox.TabIndex = 5;
            // 
            // updateValueTextBox
            // 
            this.updateValueTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.updateValueTextBox.Location = new System.Drawing.Point(18, 181);
            this.updateValueTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateValueTextBox.Name = "updateValueTextBox";
            this.updateValueTextBox.Size = new System.Drawing.Size(396, 39);
            this.updateValueTextBox.TabIndex = 21;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.updateButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.updateButton.Location = new System.Drawing.Point(18, 227);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(396, 49);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "Update Capacity";
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
            this.label10.Size = new System.Drawing.Size(396, 49);
            this.label10.TabIndex = 0;
            this.label10.Text = "Update Hall";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label12.Location = new System.Drawing.Point(18, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(396, 32);
            this.label12.TabIndex = 23;
            this.label12.Text = "New Capacity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(1003, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "Hall Records:";
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.refreshButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refreshButton.Location = new System.Drawing.Point(528, 809);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(432, 82);
            this.refreshButton.TabIndex = 19;
            this.refreshButton.Text = "Refresh Data";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // seatsPanel
            // 
            this.seatsPanel.AllowDrop = true;
            this.seatsPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.seatsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.seatsPanel.ColumnCount = 1;
            this.seatsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.seatsPanel.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.seatsPanel.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.seatsPanel.Controls.Add(this.addSeatButton, 0, 3);
            this.seatsPanel.Controls.Add(this.label13, 0, 0);
            this.seatsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.seatsPanel.Location = new System.Drawing.Point(524, 454);
            this.seatsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seatsPanel.Name = "seatsPanel";
            this.seatsPanel.Padding = new System.Windows.Forms.Padding(15);
            this.seatsPanel.RowCount = 4;
            this.seatsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.seatsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.seatsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.seatsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.seatsPanel.Size = new System.Drawing.Size(436, 299);
            this.seatsPanel.TabIndex = 20;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.seatPlaceTextBox, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(18, 139);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(400, 54);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 54);
            this.label6.TabIndex = 4;
            this.label6.Text = "Place";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.UseCompatibleTextRendering = true;
            // 
            // seatPlaceTextBox
            // 
            this.seatPlaceTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.seatPlaceTextBox.Location = new System.Drawing.Point(123, 17);
            this.seatPlaceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seatPlaceTextBox.Name = "seatPlaceTextBox";
            this.seatPlaceTextBox.Size = new System.Drawing.Size(274, 35);
            this.seatPlaceTextBox.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.seatHallComboBox, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(18, 79);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(400, 54);
            this.tableLayoutPanel4.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 54);
            this.label7.TabIndex = 4;
            this.label7.Text = "Hall";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.UseCompatibleTextRendering = true;
            // 
            // seatHallComboBox
            // 
            this.seatHallComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seatHallComboBox.FormattingEnabled = true;
            this.seatHallComboBox.Location = new System.Drawing.Point(123, 2);
            this.seatHallComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seatHallComboBox.Name = "seatHallComboBox";
            this.seatHallComboBox.Size = new System.Drawing.Size(274, 37);
            this.seatHallComboBox.TabIndex = 5;
            // 
            // addSeatButton
            // 
            this.addSeatButton.Location = new System.Drawing.Point(18, 197);
            this.addSeatButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addSeatButton.Name = "addSeatButton";
            this.addSeatButton.Size = new System.Drawing.Size(400, 45);
            this.addSeatButton.TabIndex = 18;
            this.addSeatButton.Text = "Add Seat";
            this.addSeatButton.UseVisualStyleBackColor = true;
            this.addSeatButton.Click += new System.EventHandler(this.addSeatButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Info;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label13.Location = new System.Drawing.Point(18, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(400, 60);
            this.label13.TabIndex = 0;
            this.label13.Text = "Add Seat";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // halls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1898, 950);
            this.Controls.Add(this.seatsPanel);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updatePanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deletePanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.insertionPanel);
            this.Name = "halls";
            this.Text = "Halls Management";
            this.Load += new System.EventHandler(this.halls_Load);
            this.insertionPanel.ResumeLayout(false);
            this.insertionPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.deletePanel.ResumeLayout(false);
            this.deletePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.seatsPanel.ResumeLayout(false);
            this.seatsPanel.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void AddSeatButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Halls_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel insertionPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel deletePanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox hallIdTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox hallDeleteComboBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel updatePanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox hallUpdateComboBox;
        private System.Windows.Forms.TextBox updateValueTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TableLayoutPanel seatsPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox seatPlaceTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox seatHallComboBox;
        private System.Windows.Forms.Button addSeatButton;
        private System.Windows.Forms.Label label13;
    }
}