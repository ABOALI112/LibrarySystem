
namespace LibrarySystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.User_Login_Label = new System.Windows.Forms.Label();
            this.login_button = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Clear_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserName_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.user_password_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.user_password_textbox);
            this.panel1.Controls.Add(this.UserName_textbox);
            this.panel1.Controls.Add(this.Clear_Label);
            this.panel1.Controls.Add(this.login_button);
            this.panel1.Controls.Add(this.User_Login_Label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 329);
            this.panel1.TabIndex = 0;
            // 
            // User_Login_Label
            // 
            this.User_Login_Label.AutoSize = true;
            this.User_Login_Label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Login_Label.ForeColor = System.Drawing.Color.Crimson;
            this.User_Login_Label.Location = new System.Drawing.Point(40, 36);
            this.User_Login_Label.Name = "User_Login_Label";
            this.User_Login_Label.Size = new System.Drawing.Size(118, 23);
            this.User_Login_Label.TabIndex = 0;
            this.User_Login_Label.Text = "USER LOGIN";
            // 
            // login_button
            // 
            this.login_button.ActiveBorderThickness = 1;
            this.login_button.ActiveCornerRadius = 20;
            this.login_button.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.login_button.ActiveForecolor = System.Drawing.Color.White;
            this.login_button.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.login_button.BackColor = System.Drawing.SystemColors.Control;
            this.login_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login_button.BackgroundImage")));
            this.login_button.ButtonText = "LOGIN";
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.Color.SeaGreen;
            this.login_button.IdleBorderThickness = 1;
            this.login_button.IdleCornerRadius = 20;
            this.login_button.IdleFillColor = System.Drawing.Color.Crimson;
            this.login_button.IdleForecolor = System.Drawing.Color.White;
            this.login_button.IdleLineColor = System.Drawing.Color.Crimson;
            this.login_button.Location = new System.Drawing.Point(31, 221);
            this.login_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(127, 45);
            this.login_button.TabIndex = 4;
            this.login_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // Clear_Label
            // 
            this.Clear_Label.AutoSize = true;
            this.Clear_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_Label.ForeColor = System.Drawing.Color.Crimson;
            this.Clear_Label.Location = new System.Drawing.Point(66, 271);
            this.Clear_Label.Name = "Clear_Label";
            this.Clear_Label.Size = new System.Drawing.Size(57, 19);
            this.Clear_Label.TabIndex = 5;
            this.Clear_Label.Text = "CLEAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(313, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "CENTRAL CAMPUS";
            // 
            // UserName_textbox
            // 
            this.UserName_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserName_textbox.DefaultText = "";
            this.UserName_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserName_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserName_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserName_textbox.DisabledState.Parent = this.UserName_textbox;
            this.UserName_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserName_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserName_textbox.FocusedState.Parent = this.UserName_textbox;
            this.UserName_textbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UserName_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserName_textbox.HoverState.Parent = this.UserName_textbox;
            this.UserName_textbox.Location = new System.Drawing.Point(12, 109);
            this.UserName_textbox.Name = "UserName_textbox";
            this.UserName_textbox.PasswordChar = '\0';
            this.UserName_textbox.PlaceholderText = "Enter Your UserName";
            this.UserName_textbox.SelectedText = "";
            this.UserName_textbox.ShadowDecoration.Parent = this.UserName_textbox;
            this.UserName_textbox.Size = new System.Drawing.Size(171, 36);
            this.UserName_textbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.UserName_textbox.TabIndex = 6;
            // 
            // user_password_textbox
            // 
            this.user_password_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user_password_textbox.DefaultText = "";
            this.user_password_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.user_password_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.user_password_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.user_password_textbox.DisabledState.Parent = this.user_password_textbox;
            this.user_password_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.user_password_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.user_password_textbox.FocusedState.Parent = this.user_password_textbox;
            this.user_password_textbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.user_password_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.user_password_textbox.HoverState.Parent = this.user_password_textbox;
            this.user_password_textbox.Location = new System.Drawing.Point(12, 167);
            this.user_password_textbox.Name = "user_password_textbox";
            this.user_password_textbox.PasswordChar = '*';
            this.user_password_textbox.PlaceholderText = "Enter Your Password";
            this.user_password_textbox.SelectedText = "";
            this.user_password_textbox.ShadowDecoration.Parent = this.user_password_textbox;
            this.user_password_textbox.Size = new System.Drawing.Size(171, 36);
            this.user_password_textbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.user_password_textbox.TabIndex = 7;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(590, 329);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label User_Login_Label;
        private System.Windows.Forms.Label Clear_Label;
        private Bunifu.Framework.UI.BunifuThinButton2 login_button;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox user_password_textbox;
        private Guna.UI2.WinForms.Guna2TextBox UserName_textbox;
    }
}