namespace bd.forms
{
    partial class profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profile));
            this.Registration_button = new System.Windows.Forms.Button();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.email_label = new System.Windows.Forms.Label();
            this.phone_textbox = new System.Windows.Forms.TextBox();
            this.phone_label = new System.Windows.Forms.Label();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.password_label1 = new System.Windows.Forms.Label();
            this.full_name_textbox = new System.Windows.Forms.TextBox();
            this.full_name_label = new System.Windows.Forms.Label();
            this.login_textbox = new System.Windows.Forms.TextBox();
            this.login_label = new System.Windows.Forms.Label();
            this.role_label = new System.Windows.Forms.Label();
            this.role_combobox = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.back_toolstripbutton = new System.Windows.Forms.ToolStripButton();
            this.profile_toolstriplabel = new System.Windows.Forms.ToolStripLabel();
            this.Exit_toolstripbutton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.registrationdate = new System.Windows.Forms.Label();
            this.registrationdate_label = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Registration_button
            // 
            this.Registration_button.Location = new System.Drawing.Point(37, 308);
            this.Registration_button.Name = "Registration_button";
            this.Registration_button.Size = new System.Drawing.Size(424, 23);
            this.Registration_button.TabIndex = 21;
            this.Registration_button.Text = "Применить изменения";
            this.Registration_button.UseVisualStyleBackColor = true;
            this.Registration_button.Click += new System.EventHandler(this.Registration_button_Click);
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(233, 243);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(228, 20);
            this.email_textbox.TabIndex = 15;
            // 
            // email_label
            // 
            this.email_label.Location = new System.Drawing.Point(34, 243);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(172, 23);
            this.email_label.TabIndex = 8;
            this.email_label.Text = "Почта";
            this.email_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phone_textbox
            // 
            this.phone_textbox.Location = new System.Drawing.Point(233, 205);
            this.phone_textbox.MaxLength = 11;
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.Size = new System.Drawing.Size(228, 20);
            this.phone_textbox.TabIndex = 16;
            // 
            // phone_label
            // 
            this.phone_label.Location = new System.Drawing.Point(34, 205);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(172, 23);
            this.phone_label.TabIndex = 9;
            this.phone_label.Text = "Телефон";
            this.phone_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(233, 169);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(228, 20);
            this.password_textbox.TabIndex = 18;
            // 
            // password_label1
            // 
            this.password_label1.Location = new System.Drawing.Point(34, 169);
            this.password_label1.Name = "password_label1";
            this.password_label1.Size = new System.Drawing.Size(172, 23);
            this.password_label1.TabIndex = 11;
            this.password_label1.Text = "Пароль";
            this.password_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // full_name_textbox
            // 
            this.full_name_textbox.Location = new System.Drawing.Point(233, 73);
            this.full_name_textbox.Name = "full_name_textbox";
            this.full_name_textbox.Size = new System.Drawing.Size(228, 20);
            this.full_name_textbox.TabIndex = 19;
            // 
            // full_name_label
            // 
            this.full_name_label.Location = new System.Drawing.Point(34, 73);
            this.full_name_label.Name = "full_name_label";
            this.full_name_label.Size = new System.Drawing.Size(172, 23);
            this.full_name_label.TabIndex = 12;
            this.full_name_label.Text = "ФИО";
            this.full_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login_textbox
            // 
            this.login_textbox.Location = new System.Drawing.Point(233, 125);
            this.login_textbox.Name = "login_textbox";
            this.login_textbox.Size = new System.Drawing.Size(228, 20);
            this.login_textbox.TabIndex = 20;
            // 
            // login_label
            // 
            this.login_label.Location = new System.Drawing.Point(34, 125);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(172, 23);
            this.login_label.TabIndex = 13;
            this.login_label.Text = "Логин";
            this.login_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // role_label
            // 
            this.role_label.Location = new System.Drawing.Point(34, 20);
            this.role_label.Name = "role_label";
            this.role_label.Size = new System.Drawing.Size(172, 23);
            this.role_label.TabIndex = 14;
            this.role_label.Text = "Роль";
            this.role_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // role_combobox
            // 
            this.role_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.role_combobox.Location = new System.Drawing.Point(233, 22);
            this.role_combobox.Name = "role_combobox";
            this.role_combobox.Size = new System.Drawing.Size(228, 21);
            this.role_combobox.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.back_toolstripbutton,
            this.profile_toolstriplabel,
            this.Exit_toolstripbutton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 39);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "v";
            // 
            // back_toolstripbutton
            // 
            this.back_toolstripbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.back_toolstripbutton.Image = ((System.Drawing.Image)(resources.GetObject("back_toolstripbutton.Image")));
            this.back_toolstripbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.back_toolstripbutton.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.back_toolstripbutton.Name = "back_toolstripbutton";
            this.back_toolstripbutton.Padding = new System.Windows.Forms.Padding(5);
            this.back_toolstripbutton.Size = new System.Drawing.Size(53, 29);
            this.back_toolstripbutton.Text = "Назад";
            this.back_toolstripbutton.Click += new System.EventHandler(this.back_toolstripbutton_Click);
            // 
            // profile_toolstriplabel
            // 
            this.profile_toolstriplabel.Margin = new System.Windows.Forms.Padding(20, 2, 20, 2);
            this.profile_toolstriplabel.Name = "profile_toolstriplabel";
            this.profile_toolstriplabel.Size = new System.Drawing.Size(59, 35);
            this.profile_toolstriplabel.Text = "Профиль";
            // 
            // Exit_toolstripbutton
            // 
            this.Exit_toolstripbutton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Exit_toolstripbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Exit_toolstripbutton.ForeColor = System.Drawing.Color.IndianRed;
            this.Exit_toolstripbutton.Image = ((System.Drawing.Image)(resources.GetObject("Exit_toolstripbutton.Image")));
            this.Exit_toolstripbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Exit_toolstripbutton.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.Exit_toolstripbutton.Name = "Exit_toolstripbutton";
            this.Exit_toolstripbutton.Size = new System.Drawing.Size(112, 29);
            this.Exit_toolstripbutton.Text = "Выйти из аккаунта";
            this.Exit_toolstripbutton.Click += new System.EventHandler(this.Exit_toolstripbutton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.role_combobox);
            this.panel1.Controls.Add(this.role_label);
            this.panel1.Controls.Add(this.Registration_button);
            this.panel1.Controls.Add(this.login_label);
            this.panel1.Controls.Add(this.email_textbox);
            this.panel1.Controls.Add(this.login_textbox);
            this.panel1.Controls.Add(this.registrationdate);
            this.panel1.Controls.Add(this.registrationdate_label);
            this.panel1.Controls.Add(this.email_label);
            this.panel1.Controls.Add(this.full_name_label);
            this.panel1.Controls.Add(this.phone_textbox);
            this.panel1.Controls.Add(this.full_name_textbox);
            this.panel1.Controls.Add(this.phone_label);
            this.panel1.Controls.Add(this.password_label1);
            this.panel1.Controls.Add(this.password_textbox);
            this.panel1.Location = new System.Drawing.Point(372, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 341);
            this.panel1.TabIndex = 23;
            // 
            // registrationdate
            // 
            this.registrationdate.Location = new System.Drawing.Point(230, 277);
            this.registrationdate.Name = "registrationdate";
            this.registrationdate.Size = new System.Drawing.Size(172, 23);
            this.registrationdate.TabIndex = 8;
            this.registrationdate.Text = "Дата регистрации";
            this.registrationdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registrationdate_label
            // 
            this.registrationdate_label.Location = new System.Drawing.Point(34, 277);
            this.registrationdate_label.Name = "registrationdate_label";
            this.registrationdate_label.Size = new System.Drawing.Size(172, 23);
            this.registrationdate_label.TabIndex = 8;
            this.registrationdate_label.Text = "Дата регистрации";
            this.registrationdate_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "profile";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Registration_button;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.TextBox phone_textbox;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Label password_label1;
        private System.Windows.Forms.TextBox full_name_textbox;
        private System.Windows.Forms.Label full_name_label;
        private System.Windows.Forms.TextBox login_textbox;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label role_label;
        private System.Windows.Forms.ComboBox role_combobox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton back_toolstripbutton;
        private System.Windows.Forms.ToolStripLabel profile_toolstriplabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label registrationdate_label;
        private System.Windows.Forms.Label registrationdate;
        private System.Windows.Forms.ToolStripButton Exit_toolstripbutton;
    }
}