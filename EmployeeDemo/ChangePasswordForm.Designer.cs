namespace EmployeeDemo
{
    partial class ChangePasswordForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.currentPasswordTxt = new System.Windows.Forms.TextBox();
            this.newPasswordTxt = new System.Windows.Forms.TextBox();
            this.updatePasswordBtn = new System.Windows.Forms.Button();
            this.goToUserHomeFormBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password";
            // 
            // currentPasswordTxt
            // 
            this.currentPasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPasswordTxt.Location = new System.Drawing.Point(240, 107);
            this.currentPasswordTxt.Multiline = true;
            this.currentPasswordTxt.Name = "currentPasswordTxt";
            this.currentPasswordTxt.PasswordChar = '*';
            this.currentPasswordTxt.Size = new System.Drawing.Size(241, 39);
            this.currentPasswordTxt.TabIndex = 2;
            // 
            // newPasswordTxt
            // 
            this.newPasswordTxt.Location = new System.Drawing.Point(240, 172);
            this.newPasswordTxt.Multiline = true;
            this.newPasswordTxt.Name = "newPasswordTxt";
            this.newPasswordTxt.PasswordChar = '*';
            this.newPasswordTxt.Size = new System.Drawing.Size(241, 39);
            this.newPasswordTxt.TabIndex = 3;
            // 
            // updatePasswordBtn
            // 
            this.updatePasswordBtn.Location = new System.Drawing.Point(277, 232);
            this.updatePasswordBtn.Name = "updatePasswordBtn";
            this.updatePasswordBtn.Size = new System.Drawing.Size(170, 43);
            this.updatePasswordBtn.TabIndex = 4;
            this.updatePasswordBtn.Text = "Update Password";
            this.updatePasswordBtn.UseVisualStyleBackColor = true;
            this.updatePasswordBtn.Click += new System.EventHandler(this.updatePasswordBtn_Click);
            // 
            // goToUserHomeFormBtn
            // 
            this.goToUserHomeFormBtn.Location = new System.Drawing.Point(57, 23);
            this.goToUserHomeFormBtn.Name = "goToUserHomeFormBtn";
            this.goToUserHomeFormBtn.Size = new System.Drawing.Size(250, 55);
            this.goToUserHomeFormBtn.TabIndex = 5;
            this.goToUserHomeFormBtn.Text = "Go to User Home Form";
            this.goToUserHomeFormBtn.UseVisualStyleBackColor = true;
            this.goToUserHomeFormBtn.Click += new System.EventHandler(this.goToUserHomeFormBtn_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goToUserHomeFormBtn);
            this.Controls.Add(this.updatePasswordBtn);
            this.Controls.Add(this.newPasswordTxt);
            this.Controls.Add(this.currentPasswordTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox currentPasswordTxt;
        private System.Windows.Forms.TextBox newPasswordTxt;
        private System.Windows.Forms.Button updatePasswordBtn;
        private System.Windows.Forms.Button goToUserHomeFormBtn;
    }
}