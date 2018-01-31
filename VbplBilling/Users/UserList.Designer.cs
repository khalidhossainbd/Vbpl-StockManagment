namespace VbplBilling.UI
{
    partial class UserList
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
            this.addUsersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addUsersButton
            // 
            this.addUsersButton.Location = new System.Drawing.Point(584, 92);
            this.addUsersButton.Name = "addUsersButton";
            this.addUsersButton.Size = new System.Drawing.Size(198, 42);
            this.addUsersButton.TabIndex = 0;
            this.addUsersButton.Text = "Add New Users";
            this.addUsersButton.UseVisualStyleBackColor = true;
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.addUsersButton);
            this.Name = "UserList";
            this.Size = new System.Drawing.Size(830, 529);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addUsersButton;
    }
}
