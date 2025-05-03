using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class shows
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
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.hall_combobox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.adminManagerComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.endTimeTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.startTimeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.insertButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.deletePanel = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.showDeleteComboBox = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.updatePanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.showUpdateComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.fieldComboBox = new System.Windows.Forms.ComboBox();
            this.updateValueTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.viewPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.viewByComboBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.hallIdComboBox = new System.Windows.Forms.ComboBox();
            this.hallIdPanel = new System.Windows.Forms.TableLayoutPanel();
            this.hallIdLabel = new System.Windows.Forms.Label();
            this.insertionPanel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.deletePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.updatePanel.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.viewPanel.SuspendLayout();
            this.hallIdPanel.SuspendLayout();
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
            this.label1.Text = "Add Show";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // insertionPanel
            // 
            this.insertionPanel.AllowDrop = true;
            this.insertionPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.insertionPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.insertionPanel.ColumnCount = 1;
            this.insertionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.insertionPanel.Controls.Add(this.tableLayoutPanel5, 0, 5);
            this.insertionPanel.Controls.Add(this.tableLayoutPanel4, 0, 4);
            this.insertionPanel.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.insertionPanel.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.insertionPanel.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.insertionPanel.Controls.Add(this.label1, 0, 0);
            this.insertionPanel.Controls.Add(this.insertButton, 0, 7);
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
            this.insertionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.insertionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.insertionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.insertionPanel.Size = new System.Drawing.Size(441, 506);
            this.insertionPanel.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel5.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.hall_combobox, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(18, 317);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(405, 43);
            this.tableLayoutPanel5.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 43);
            this.label15.TabIndex = 4;
            this.label15.Text = "Hall";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.UseCompatibleTextRendering = true;
            // 
            // hall_combobox
            // 
            this.hall_combobox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hall_combobox.FormattingEnabled = true;
            this.hall_combobox.Location = new System.Drawing.Point(124, 2);
            this.hall_combobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hall_combobox.Name = "hall_combobox";
            this.hall_combobox.Size = new System.Drawing.Size(278, 37);
            this.hall_combobox.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.adminManagerComboBox, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(18, 259);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(405, 54);
            this.tableLayoutPanel4.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 54);
            this.label7.TabIndex = 4;
            this.label7.Text = "Admin";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.UseCompatibleTextRendering = true;
            // 
            // adminManagerComboBox
            // 
            this.adminManagerComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminManagerComboBox.FormattingEnabled = true;
            this.adminManagerComboBox.Location = new System.Drawing.Point(124, 2);
            this.adminManagerComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminManagerComboBox.Name = "adminManagerComboBox";
            this.adminManagerComboBox.Size = new System.Drawing.Size(278, 37);
            this.adminManagerComboBox.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.endTimeTextBox, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(18, 199);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(405, 54);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 54);
            this.label6.TabIndex = 4;
            this.label6.Text = "End Time";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.UseCompatibleTextRendering = true;
            // 
            // endTimeTextBox
            // 
            this.endTimeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endTimeTextBox.Location = new System.Drawing.Point(124, 3);
            this.endTimeTextBox.Name = "endTimeTextBox";
            this.endTimeTextBox.Size = new System.Drawing.Size(278, 35);
            this.endTimeTextBox.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.startTimeTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(18, 139);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(405, 54);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // startTimeTextBox
            // 
            this.startTimeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startTimeTextBox.Location = new System.Drawing.Point(124, 3);
            this.startTimeTextBox.Name = "startTimeTextBox";
            this.startTimeTextBox.Size = new System.Drawing.Size(278, 35);
            this.startTimeTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 54);
            this.label4.TabIndex = 4;
            this.label4.Text = "Start Time";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseCompatibleTextRendering = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.datePicker, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 79);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(405, 54);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 54);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // datePicker
            // 
            this.datePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datePicker.Location = new System.Drawing.Point(124, 3);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(278, 35);
            this.datePicker.TabIndex = 5;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(18, 378);
            this.insertButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(405, 50);
            this.insertButton.TabIndex = 18;
            this.insertButton.Text = "Add Show";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label5.Location = new System.Drawing.Point(29, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(464, 55);
            this.label5.TabIndex = 2;
            this.label5.Text = "Shows Management";
            // 
            // deletePanel
            // 
            this.deletePanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.deletePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deletePanel.ColumnCount = 1;
            this.deletePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.62012F));
            this.deletePanel.Controls.Add(this.label8, 0, 0);
            this.deletePanel.Controls.Add(this.label9, 0, 1);
            this.deletePanel.Controls.Add(this.showDeleteComboBox, 0, 2);
            this.deletePanel.Controls.Add(this.deleteButton, 0, 3);
            this.deletePanel.Controls.Add(this.label12, 0, 4);
            this.deletePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.deletePanel.Location = new System.Drawing.Point(503, 527);
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
            this.label8.Text = "Delete Show";
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
            this.label9.Text = "Select a Show";
            // 
            // showDeleteComboBox
            // 
            this.showDeleteComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.showDeleteComboBox.FormattingEnabled = true;
            this.showDeleteComboBox.Location = new System.Drawing.Point(18, 104);
            this.showDeleteComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showDeleteComboBox.Name = "showDeleteComboBox";
            this.showDeleteComboBox.Size = new System.Drawing.Size(405, 40);
            this.showDeleteComboBox.TabIndex = 5;
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.ForeColor = System.Drawing.Color.Firebrick;
            this.label12.Location = new System.Drawing.Point(18, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(360, 29);
            this.label12.TabIndex = 9;
            this.label12.Text = "Once deleted You cannot REDO";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.backButton.Location = new System.Drawing.Point(39, 744);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(436, 82);
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
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // updatePanel
            // 
            this.updatePanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.updatePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.updatePanel.ColumnCount = 1;
            this.updatePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.updatePanel.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.updatePanel.Controls.Add(this.tableLayoutPanel7, 0, 2);
            this.updatePanel.Controls.Add(this.updateValueTextBox, 0, 4);
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
            this.updatePanel.Size = new System.Drawing.Size(436, 378);
            this.updatePanel.TabIndex = 11;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.16773F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.83227F));
            this.tableLayoutPanel6.Controls.Add(this.label16, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.showUpdateComboBox, 1, 0);
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
            this.label16.Text = "Select Show";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.UseCompatibleTextRendering = true;
            // 
            // showUpdateComboBox
            // 
            this.showUpdateComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showUpdateComboBox.FormattingEnabled = true;
            this.showUpdateComboBox.Location = new System.Drawing.Point(207, 2);
            this.showUpdateComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showUpdateComboBox.Name = "showUpdateComboBox";
            this.showUpdateComboBox.Size = new System.Drawing.Size(190, 40);
            this.showUpdateComboBox.TabIndex = 5;
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
            "Show_start",
            "Show_end",
            "Hall_id",
            "Admin_id",
            "Show_date"});
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
            this.updateButton.Location = new System.Drawing.Point(18, 312);
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
            this.label10.Text = "Update Show";
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
            this.viewPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.78834F));
            this.viewPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.21166F));
            this.viewPanel.Controls.Add(this.label13, 0, 0);
            this.viewPanel.Controls.Add(this.viewByComboBox, 1, 0);
            this.viewPanel.Location = new System.Drawing.Point(1374, 765);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.RowCount = 1;
            this.viewPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.viewPanel.Size = new System.Drawing.Size(510, 61);
            this.viewPanel.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label13.Location = new System.Drawing.Point(3, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(227, 32);
            this.label13.TabIndex = 16;
            this.label13.Text = "Show Shows by:";
            // 
            // viewByComboBox
            // 
            this.viewByComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.viewByComboBox.FormattingEnabled = true;
            this.viewByComboBox.Items.AddRange(new object[] {
            "All",
            "Date",
            "Admin"});
            this.viewByComboBox.Location = new System.Drawing.Point(236, 30);
            this.viewByComboBox.Name = "viewByComboBox";
            this.viewByComboBox.Size = new System.Drawing.Size(271, 28);
            this.viewByComboBox.TabIndex = 15;
            this.viewByComboBox.SelectedIndexChanged += new System.EventHandler(this.viewByComboBox_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label14.Location = new System.Drawing.Point(1003, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(205, 32);
            this.label14.TabIndex = 18;
            this.label14.Text = "Show Records:";
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.refreshButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refreshButton.Location = new System.Drawing.Point(1003, 780);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(345, 60);
            this.refreshButton.TabIndex = 19;
            this.refreshButton.Text = "Refresh Data";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // hallIdComboBox
            // 
            this.hallIdComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hallIdComboBox.FormattingEnabled = true;
            this.hallIdComboBox.Location = new System.Drawing.Point(207, 2);
            this.hallIdComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hallIdComboBox.Name = "hallIdComboBox";
            this.hallIdComboBox.Size = new System.Drawing.Size(190, 28);
            this.hallIdComboBox.TabIndex = 5;
            // 
            // hallIdPanel
            // 
            this.hallIdPanel.ColumnCount = 2;
            this.hallIdPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.16773F));
            this.hallIdPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.83227F));
            this.hallIdPanel.Controls.Add(this.hallIdLabel, 0, 0);
            this.hallIdPanel.Controls.Add(this.hallIdComboBox, 1, 0);
            this.hallIdPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hallIdPanel.Location = new System.Drawing.Point(18, 190);
            this.hallIdPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hallIdPanel.Name = "hallIdPanel";
            this.hallIdPanel.RowCount = 1;
            this.hallIdPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.hallIdPanel.Size = new System.Drawing.Size(400, 62);
            this.hallIdPanel.TabIndex = 23;
            // 
            // hallIdLabel
            // 
            this.hallIdLabel.AutoSize = true;
            this.hallIdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hallIdLabel.Location = new System.Drawing.Point(3, 0);
            this.hallIdLabel.Name = "hallIdLabel";
            this.hallIdLabel.Size = new System.Drawing.Size(198, 62);
            this.hallIdLabel.TabIndex = 4;
            this.hallIdLabel.Text = "Hall";
            this.hallIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hallIdLabel.UseCompatibleTextRendering = true;
            // 
            // shows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1898, 924);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.viewPanel);
            this.Controls.Add(this.updatePanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deletePanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.insertionPanel);
            this.Name = "shows";
            this.Text = "Shows Management";
            this.Load += new System.EventHandler(this.ShowForm_Load);
            this.insertionPanel.ResumeLayout(false);
            this.insertionPanel.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
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
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.viewPanel.ResumeLayout(false);
            this.viewPanel.PerformLayout();
            this.hallIdPanel.ResumeLayout(false);
            this.hallIdPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox adminManagerComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox endTimeTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox startTimeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox showDeleteComboBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel updatePanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox showUpdateComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox fieldComboBox;
        private System.Windows.Forms.TextBox updateValueTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel viewPanel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox viewByComboBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ComboBox hallIdComboBox;
        private System.Windows.Forms.TableLayoutPanel hallIdPanel;
        private System.Windows.Forms.Label hallIdLabel;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label15;
        private ComboBox hall_combobox;
    }
}