namespace bd.forms
{
    partial class login
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
            this.login_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.login_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.registration_button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.title_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_label
            // 
            this.login_label.Location = new System.Drawing.Point(21, 77);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(68, 23);
            this.login_label.TabIndex = 0;
            this.login_label.Text = "Логин";
            this.login_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // password_label
            // 
            this.password_label.Location = new System.Drawing.Point(21, 114);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(68, 23);
            this.password_label.TabIndex = 0;
            this.password_label.Text = "Пароль";
            this.password_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // login_textbox
            // 
            this.login_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.login_textbox.Location = new System.Drawing.Point(95, 80);
            this.login_textbox.Name = "login_textbox";
            this.login_textbox.Size = new System.Drawing.Size(255, 20);
            this.login_textbox.TabIndex = 1;
            // 
            // password_textbox
            // 
            this.password_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.password_textbox.Location = new System.Drawing.Point(95, 117);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(255, 20);
            this.password_textbox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.registration_button);
            this.panel1.Controls.Add(this.login_button);
            this.panel1.Controls.Add(this.login_textbox);
            this.panel1.Controls.Add(this.password_textbox);
            this.panel1.Controls.Add(this.title_label);
            this.panel1.Controls.Add(this.login_label);
            this.panel1.Controls.Add(this.password_label);
            this.panel1.Location = new System.Drawing.Point(432, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 225);
            this.panel1.TabIndex = 2;
            // 
            // registration_button
            // 
            this.registration_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registration_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registration_button.Location = new System.Drawing.Point(21, 193);
            this.registration_button.Name = "registration_button";
            this.registration_button.Size = new System.Drawing.Size(329, 23);
            this.registration_button.TabIndex = 2;
            this.registration_button.Text = "Регистрация";
            this.registration_button.UseVisualStyleBackColor = true;
            this.registration_button.Click += new System.EventHandler(this.registration_button_Click);
            // 
            // login_button
            // 
            this.login_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Location = new System.Drawing.Point(21, 157);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(329, 30);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "Войти";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // title_label
            // 
            this.title_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title_label.Location = new System.Drawing.Point(21, 18);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(329, 23);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "Авторизация";
            this.title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox login_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button registration_button;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label title_label;
    }
}