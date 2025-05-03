using System;

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
            this.label2 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label18 = new System.Windows.Forms.Label();
            this.viewByComboBox = new System.Windows.Forms.ComboBox();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.viewPanel.SuspendLayout();
            this.SuspendLayout();
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
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.backButton.Location = new System.Drawing.Point(65, 397);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(411, 82);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back to dashboard";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(557, 164);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(1289, 642);
            this.dataGridView1.TabIndex = 7;
            // 
            // viewPanel
            // 
            this.viewPanel.ColumnCount = 2;
            this.viewPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.54868F));
            this.viewPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.45133F));
            this.viewPanel.Controls.Add(this.label18, 0, 0);
            this.viewPanel.Controls.Add(this.viewByComboBox, 1, 0);
            this.viewPanel.Location = new System.Drawing.Point(65, 164);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.RowCount = 1;
            this.viewPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.viewPanel.Size = new System.Drawing.Size(411, 61);
            this.viewPanel.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label18.Location = new System.Drawing.Point(3, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(267, 32);
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
            this.viewByComboBox.Location = new System.Drawing.Point(276, 30);
            this.viewByComboBox.Name = "viewByComboBox";
            this.viewByComboBox.Size = new System.Drawing.Size(132, 28);
            this.viewByComboBox.TabIndex = 15;
            this.viewByComboBox.SelectedIndexChanged += new System.EventHandler(this.viewByComboBox_SelectedIndexChanged);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.refreshButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refreshButton.Location = new System.Drawing.Point(62, 288);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(411, 60);
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
            this.Controls.Add(this.viewPanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label2);
            this.Name = "payments";
            this.Text = "Payment Management";
            this.Load += new System.EventHandler(this.payments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.viewPanel.ResumeLayout(false);
            this.viewPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel viewPanel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox viewByComboBox;
        private System.Windows.Forms.Button refreshButton;
    }
}
