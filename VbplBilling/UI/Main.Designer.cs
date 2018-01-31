namespace VbplBilling.UI
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.sellHistoryButton = new System.Windows.Forms.Button();
            this.updateStockButton = new System.Windows.Forms.Button();
            this.persentStockButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.addClientButton = new System.Windows.Forms.Button();
            this.userControlButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.testcontroll1 = new VbplBilling.UI.testcontroll();
            this.clientAddedControll1 = new VbplBilling.Users.ClientAddedControll();
            this.userList1 = new VbplBilling.UI.UserList();
            this.presentStockControll1 = new VbplBilling.Users.PresentStockControll();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.sellHistoryButton);
            this.panel1.Controls.Add(this.updateStockButton);
            this.panel1.Controls.Add(this.persentStockButton);
            this.panel1.Controls.Add(this.addProductButton);
            this.panel1.Controls.Add(this.addClientButton);
            this.panel1.Controls.Add(this.userControlButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 603);
            this.panel1.TabIndex = 0;
            // 
            // sellHistoryButton
            // 
            this.sellHistoryButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.sellHistoryButton.FlatAppearance.BorderSize = 0;
            this.sellHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellHistoryButton.Font = new System.Drawing.Font("Century", 12F);
            this.sellHistoryButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sellHistoryButton.Location = new System.Drawing.Point(0, 417);
            this.sellHistoryButton.Name = "sellHistoryButton";
            this.sellHistoryButton.Size = new System.Drawing.Size(200, 58);
            this.sellHistoryButton.TabIndex = 1;
            this.sellHistoryButton.Text = "Sell History";
            this.sellHistoryButton.UseVisualStyleBackColor = false;
            // 
            // updateStockButton
            // 
            this.updateStockButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.updateStockButton.FlatAppearance.BorderSize = 0;
            this.updateStockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateStockButton.Font = new System.Drawing.Font("Century", 12F);
            this.updateStockButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateStockButton.Location = new System.Drawing.Point(0, 358);
            this.updateStockButton.Name = "updateStockButton";
            this.updateStockButton.Size = new System.Drawing.Size(200, 58);
            this.updateStockButton.TabIndex = 1;
            this.updateStockButton.Text = "Update Stock";
            this.updateStockButton.UseVisualStyleBackColor = false;
            // 
            // persentStockButton
            // 
            this.persentStockButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.persentStockButton.FlatAppearance.BorderSize = 0;
            this.persentStockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.persentStockButton.Font = new System.Drawing.Font("Century", 12F);
            this.persentStockButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.persentStockButton.Location = new System.Drawing.Point(0, 299);
            this.persentStockButton.Name = "persentStockButton";
            this.persentStockButton.Size = new System.Drawing.Size(200, 58);
            this.persentStockButton.TabIndex = 1;
            this.persentStockButton.Text = "Present Stock";
            this.persentStockButton.UseVisualStyleBackColor = false;
            this.persentStockButton.Click += new System.EventHandler(this.persentStockButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addProductButton.FlatAppearance.BorderSize = 0;
            this.addProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductButton.Font = new System.Drawing.Font("Century", 12F);
            this.addProductButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addProductButton.Location = new System.Drawing.Point(0, 240);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(200, 58);
            this.addProductButton.TabIndex = 1;
            this.addProductButton.Text = "Add Product";
            this.addProductButton.UseVisualStyleBackColor = false;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // addClientButton
            // 
            this.addClientButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addClientButton.FlatAppearance.BorderSize = 0;
            this.addClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addClientButton.Font = new System.Drawing.Font("Century", 12F);
            this.addClientButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addClientButton.Location = new System.Drawing.Point(0, 181);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(200, 58);
            this.addClientButton.TabIndex = 1;
            this.addClientButton.Text = "Add Client";
            this.addClientButton.UseVisualStyleBackColor = false;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // userControlButton
            // 
            this.userControlButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.userControlButton.FlatAppearance.BorderSize = 0;
            this.userControlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userControlButton.Font = new System.Drawing.Font("Century", 12F);
            this.userControlButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userControlButton.Location = new System.Drawing.Point(0, 122);
            this.userControlButton.Name = "userControlButton";
            this.userControlButton.Size = new System.Drawing.Size(200, 58);
            this.userControlButton.TabIndex = 1;
            this.userControlButton.Text = "User Control";
            this.userControlButton.UseVisualStyleBackColor = false;
            this.userControlButton.Click += new System.EventHandler(this.userControlButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dash Board";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(200, 518);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 1;
            // 
            // testcontroll1
            // 
            this.testcontroll1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.testcontroll1.Location = new System.Drawing.Point(200, 132);
            this.testcontroll1.Name = "testcontroll1";
            this.testcontroll1.Size = new System.Drawing.Size(824, 459);
            this.testcontroll1.TabIndex = 4;
            // 
            // clientAddedControll1
            // 
            this.clientAddedControll1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clientAddedControll1.Location = new System.Drawing.Point(200, 122);
            this.clientAddedControll1.Name = "clientAddedControll1";
            this.clientAddedControll1.Size = new System.Drawing.Size(830, 481);
            this.clientAddedControll1.TabIndex = 3;
            // 
            // userList1
            // 
            this.userList1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userList1.Location = new System.Drawing.Point(200, 122);
            this.userList1.Name = "userList1";
            this.userList1.Size = new System.Drawing.Size(830, 481);
            this.userList1.TabIndex = 2;
            // 
            // presentStockControll1
            // 
            this.presentStockControll1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.presentStockControll1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.presentStockControll1.Location = new System.Drawing.Point(200, 123);
            this.presentStockControll1.Name = "presentStockControll1";
            this.presentStockControll1.Size = new System.Drawing.Size(799, 480);
            this.presentStockControll1.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1032, 603);
            this.Controls.Add(this.presentStockControll1);
            this.Controls.Add(this.testcontroll1);
            this.Controls.Add(this.clientAddedControll1);
            this.Controls.Add(this.userList1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button sellHistoryButton;
        private System.Windows.Forms.Button updateStockButton;
        private System.Windows.Forms.Button persentStockButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.Button userControlButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private UserList userList1;
        private Users.ClientAddedControll clientAddedControll1;
        private testcontroll testcontroll1;
        private Users.PresentStockControll presentStockControll1;
    }
}