namespace WindowsFormsApp1
{
    partial class Admin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxAdminId = new System.Windows.Forms.TextBox();
            this.textBoxAdminName = new System.Windows.Forms.TextBox();
            this.textBoxAdminEmail = new System.Windows.Forms.TextBox();
            this.textBoxAdminPassword = new System.Windows.Forms.TextBox();
            this.labelAdminId = new System.Windows.Forms.Label();
            this.labelAdminName = new System.Windows.Forms.Label();
            this.labelAdminEmail = new System.Windows.Forms.Label();
            this.labelAdminPassword = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(150, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.labelAdminId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAdminId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelAdminName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAdminName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelAdminEmail, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAdminEmail, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelAdminPassword, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAdminPassword, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(50, 80);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 200);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // textBoxAdminId
            // 
            this.textBoxAdminId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAdminId.Location = new System.Drawing.Point(123, 3);
            this.textBoxAdminId.Name = "textBoxAdminId";
            this.textBoxAdminId.Size = new System.Drawing.Size(274, 26);
            this.textBoxAdminId.TabIndex = 0;
            // 
            // textBoxAdminName
            // 
            this.textBoxAdminName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAdminName.Location = new System.Drawing.Point(123, 53);
            this.textBoxAdminName.Name = "textBoxAdminName";
            this.textBoxAdminName.Size = new System.Drawing.Size(274, 26);
            this.textBoxAdminName.TabIndex = 1;
            // 
            // textBoxAdminEmail
            // 
            this.textBoxAdminEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAdminEmail.Location = new System.Drawing.Point(123, 103);
            this.textBoxAdminEmail.Name = "textBoxAdminEmail";
            this.textBoxAdminEmail.Size = new System.Drawing.Size(274, 26);
            this.textBoxAdminEmail.TabIndex = 2;
            // 
            // textBoxAdminPassword
            // 
            this.textBoxAdminPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAdminPassword.Location = new System.Drawing.Point(123, 153);
            this.textBoxAdminPassword.Name = "textBoxAdminPassword";
            this.textBoxAdminPassword.Size = new System.Drawing.Size(274, 26);
            this.textBoxAdminPassword.TabIndex = 3;
            // 
            // labelAdminId
            // 
            this.labelAdminId.AutoSize = true;
            this.labelAdminId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAdminId.Location = new System.Drawing.Point(3, 0);
            this.labelAdminId.Name = "labelAdminId";
            this.labelAdminId.Size = new System.Drawing.Size(114, 50);
            this.labelAdminId.TabIndex = 4;
            this.labelAdminId.Text = "Admin ID:";
            this.labelAdminId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAdminName
            // 
            this.labelAdminName.AutoSize = true;
            this.labelAdminName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAdminName.Location = new System.Drawing.Point(3, 50);
            this.labelAdminName.Name = "labelAdminName";
            this.labelAdminName.Size = new System.Drawing.Size(114, 50);
            this.labelAdminName.TabIndex = 5;
            this.labelAdminName.Text = "Name:";
            this.labelAdminName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAdminEmail
            // 
            this.labelAdminEmail.AutoSize = true;
            this.labelAdminEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAdminEmail.Location = new System.Drawing.Point(3, 100);
            this.labelAdminEmail.Name = "labelAdminEmail";
            this.labelAdminEmail.Size = new System.Drawing.Size(114, 50);
            this.labelAdminEmail.TabIndex = 6;
            this.labelAdminEmail.Text = "Email:";
            this.labelAdminEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAdminPassword
            // 
            this.labelAdminPassword.AutoSize = true;
            this.labelAdminPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAdminPassword.Location = new System.Drawing.Point(3, 150);
            this.labelAdminPassword.Name = "labelAdminPassword";
            this.labelAdminPassword.Size = new System.Drawing.Size(114, 50);
            this.labelAdminPassword.TabIndex = 7;
            this.labelAdminPassword.Text = "Password:";
            this.labelAdminPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(50, 300);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 30);
            this.insertButton.TabIndex = 2;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(150, 300);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 30);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(250, 300);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 30);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(350, 300);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(100, 30);
            this.showAllButton.TabIndex = 5;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxAdminId;
        private System.Windows.Forms.TextBox textBoxAdminName;
        private System.Windows.Forms.TextBox textBoxAdminEmail;
        private System.Windows.Forms.TextBox textBoxAdminPassword;
        private System.Windows.Forms.Label labelAdminId;
        private System.Windows.Forms.Label labelAdminName;
        private System.Windows.Forms.Label labelAdminEmail;
        private System.Windows.Forms.Label labelAdminPassword;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button showAllButton;
    }
}
