namespace bd.forms
{
    partial class users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(users));
            this.users_dataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.back_toolstripbutton = new System.Windows.Forms.ToolStripButton();
            this.users_toolstriplabel = new System.Windows.Forms.ToolStripLabel();
            this.Rolename_label = new System.Windows.Forms.Label();
            this.rolename_textbox = new System.Windows.Forms.TextBox();
            this.Addrole_button = new System.Windows.Forms.Button();
            this.roles_datagridview = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.change_button = new System.Windows.Forms.Button();
            this.Registration_button = new System.Windows.Forms.Button();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.email_label = new System.Windows.Forms.Label();
            this.phone_textbox = new System.Windows.Forms.TextBox();
            this.phone_label = new System.Windows.Forms.Label();
            this.password_textbox2 = new System.Windows.Forms.TextBox();
            this.password_label2 = new System.Windows.Forms.Label();
            this.password_textbox1 = new System.Windows.Forms.TextBox();
            this.password_label1 = new System.Windows.Forms.Label();
            this.full_name_textbox = new System.Windows.Forms.TextBox();
            this.full_name_label = new System.Windows.Forms.Label();
            this.login_textbox = new System.Windows.Forms.TextBox();
            this.login_label = new System.Windows.Forms.Label();
            this.role_label = new System.Windows.Forms.Label();
            this.role_combobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.users_dataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roles_datagridview)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // users_dataGridView
            // 
            this.users_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.users_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.users_dataGridView.Location = new System.Drawing.Point(13, 148);
            this.users_dataGridView.Name = "users_dataGridView";
            this.users_dataGridView.ReadOnly = true;
            this.users_dataGridView.Size = new System.Drawing.Size(921, 431);
            this.users_dataGridView.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.back_toolstripbutton,
            this.users_toolstriplabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 39);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
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
            // users_toolstriplabel
            // 
            this.users_toolstriplabel.Margin = new System.Windows.Forms.Padding(20, 2, 20, 2);
            this.users_toolstriplabel.Name = "users_toolstriplabel";
            this.users_toolstriplabel.Size = new System.Drawing.Size(85, 35);
            this.users_toolstriplabel.Text = "Пользователи";
            // 
            // Rolename_label
            // 
            this.Rolename_label.Location = new System.Drawing.Point(14, 49);
            this.Rolename_label.Name = "Rolename_label";
            this.Rolename_label.Size = new System.Drawing.Size(91, 38);
            this.Rolename_label.TabIndex = 24;
            this.Rolename_label.Text = "Название роли";
            this.Rolename_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rolename_textbox
            // 
            this.rolename_textbox.Location = new System.Drawing.Point(120, 59);
            this.rolename_textbox.Name = "rolename_textbox";
            this.rolename_textbox.Size = new System.Drawing.Size(136, 20);
            this.rolename_textbox.TabIndex = 25;
            // 
            // Addrole_button
            // 
            this.Addrole_button.Location = new System.Drawing.Point(17, 90);
            this.Addrole_button.Name = "Addrole_button";
            this.Addrole_button.Size = new System.Drawing.Size(239, 23);
            this.Addrole_button.TabIndex = 26;
            this.Addrole_button.Text = "Добавить роль";
            this.Addrole_button.UseVisualStyleBackColor = true;
            this.Addrole_button.Click += new System.EventHandler(this.Addrole_button_Click);
            // 
            // roles_datagridview
            // 
            this.roles_datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.roles_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roles_datagridview.Location = new System.Drawing.Point(17, 148);
            this.roles_datagridview.Name = "roles_datagridview";
            this.roles_datagridview.ReadOnly = true;
            this.roles_datagridview.Size = new System.Drawing.Size(239, 431);
            this.roles_datagridview.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Удалить роль";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.deleterole_button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rolename_textbox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.roles_datagridview);
            this.panel1.Controls.Add(this.Addrole_button);
            this.panel1.Controls.Add(this.Rolename_label);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 592);
            this.panel1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 38);
            this.label1.TabIndex = 28;
            this.label1.Text = "Роли пользователей";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.delete_button);
            this.panel2.Controls.Add(this.change_button);
            this.panel2.Controls.Add(this.Registration_button);
            this.panel2.Controls.Add(this.email_textbox);
            this.panel2.Controls.Add(this.email_label);
            this.panel2.Controls.Add(this.phone_textbox);
            this.panel2.Controls.Add(this.phone_label);
            this.panel2.Controls.Add(this.password_textbox2);
            this.panel2.Controls.Add(this.password_label2);
            this.panel2.Controls.Add(this.password_textbox1);
            this.panel2.Controls.Add(this.password_label1);
            this.panel2.Controls.Add(this.full_name_textbox);
            this.panel2.Controls.Add(this.full_name_label);
            this.panel2.Controls.Add(this.login_textbox);
            this.panel2.Controls.Add(this.login_label);
            this.panel2.Controls.Add(this.role_label);
            this.panel2.Controls.Add(this.role_combobox);
            this.panel2.Controls.Add(this.users_dataGridView);
            this.panel2.Location = new System.Drawing.Point(301, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(951, 592);
            this.panel2.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(921, 38);
            this.label2.TabIndex = 29;
            this.label2.Text = "Пользователи";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(859, 120);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 23);
            this.delete_button.TabIndex = 20;
            this.delete_button.Text = "Удалить";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // change_button
            // 
            this.change_button.Location = new System.Drawing.Point(765, 120);
            this.change_button.Name = "change_button";
            this.change_button.Size = new System.Drawing.Size(88, 23);
            this.change_button.TabIndex = 20;
            this.change_button.Text = "Изменить";
            this.change_button.UseVisualStyleBackColor = true;
            this.change_button.Click += new System.EventHandler(this.change_button_Click);
            // 
            // Registration_button
            // 
            this.Registration_button.Location = new System.Drawing.Point(642, 120);
            this.Registration_button.Name = "Registration_button";
            this.Registration_button.Size = new System.Drawing.Size(117, 23);
            this.Registration_button.TabIndex = 20;
            this.Registration_button.Text = "Зарегестрировать";
            this.Registration_button.UseVisualStyleBackColor = true;
            this.Registration_button.Click += new System.EventHandler(this.Registration_button_Click);
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(765, 90);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(169, 20);
            this.email_textbox.TabIndex = 14;
            // 
            // email_label
            // 
            this.email_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.email_label.Location = new System.Drawing.Point(639, 89);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(120, 23);
            this.email_label.TabIndex = 7;
            this.email_label.Text = "Почта";
            this.email_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // phone_textbox
            // 
            this.phone_textbox.Location = new System.Drawing.Point(765, 58);
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.Size = new System.Drawing.Size(169, 20);
            this.phone_textbox.TabIndex = 15;
            // 
            // phone_label
            // 
            this.phone_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phone_label.Location = new System.Drawing.Point(639, 57);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(120, 23);
            this.phone_label.TabIndex = 8;
            this.phone_label.Text = "Телефон";
            this.phone_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // password_textbox2
            // 
            this.password_textbox2.Location = new System.Drawing.Point(452, 121);
            this.password_textbox2.Name = "password_textbox2";
            this.password_textbox2.Size = new System.Drawing.Size(169, 20);
            this.password_textbox2.TabIndex = 16;
            // 
            // password_label2
            // 
            this.password_label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password_label2.Location = new System.Drawing.Point(326, 120);
            this.password_label2.Name = "password_label2";
            this.password_label2.Size = new System.Drawing.Size(120, 23);
            this.password_label2.TabIndex = 9;
            this.password_label2.Text = "Пароль еще раз";
            this.password_label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // password_textbox1
            // 
            this.password_textbox1.Location = new System.Drawing.Point(452, 90);
            this.password_textbox1.Name = "password_textbox1";
            this.password_textbox1.Size = new System.Drawing.Size(169, 20);
            this.password_textbox1.TabIndex = 17;
            // 
            // password_label1
            // 
            this.password_label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password_label1.Location = new System.Drawing.Point(326, 89);
            this.password_label1.Name = "password_label1";
            this.password_label1.Size = new System.Drawing.Size(120, 23);
            this.password_label1.TabIndex = 10;
            this.password_label1.Text = "Пароль";
            this.password_label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // full_name_textbox
            // 
            this.full_name_textbox.Location = new System.Drawing.Point(13, 90);
            this.full_name_textbox.Name = "full_name_textbox";
            this.full_name_textbox.Size = new System.Drawing.Size(295, 20);
            this.full_name_textbox.TabIndex = 18;
            // 
            // full_name_label
            // 
            this.full_name_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.full_name_label.Location = new System.Drawing.Point(13, 57);
            this.full_name_label.Name = "full_name_label";
            this.full_name_label.Size = new System.Drawing.Size(295, 23);
            this.full_name_label.TabIndex = 11;
            this.full_name_label.Text = "ФИО";
            this.full_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login_textbox
            // 
            this.login_textbox.Location = new System.Drawing.Point(452, 58);
            this.login_textbox.Name = "login_textbox";
            this.login_textbox.Size = new System.Drawing.Size(169, 20);
            this.login_textbox.TabIndex = 19;
            // 
            // login_label
            // 
            this.login_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login_label.Location = new System.Drawing.Point(326, 57);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(120, 23);
            this.login_label.TabIndex = 12;
            this.login_label.Text = "Логин";
            this.login_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // role_label
            // 
            this.role_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.role_label.Location = new System.Drawing.Point(13, 120);
            this.role_label.Name = "role_label";
            this.role_label.Size = new System.Drawing.Size(120, 23);
            this.role_label.TabIndex = 13;
            this.role_label.Text = "Роль";
            this.role_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // role_combobox
            // 
            this.role_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.role_combobox.Location = new System.Drawing.Point(139, 121);
            this.role_combobox.Name = "role_combobox";
            this.role_combobox.Size = new System.Drawing.Size(169, 21);
            this.role_combobox.TabIndex = 6;
            // 
            // users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "users";
            ((System.ComponentModel.ISupportInitialize)(this.users_dataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roles_datagridview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView users_dataGridView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton back_toolstripbutton;
        private System.Windows.Forms.ToolStripLabel users_toolstriplabel;
        private System.Windows.Forms.Label Rolename_label;
        private System.Windows.Forms.TextBox rolename_textbox;
        private System.Windows.Forms.Button Addrole_button;
        private System.Windows.Forms.DataGridView roles_datagridview;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Registration_button;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.TextBox phone_textbox;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.TextBox password_textbox2;
        private System.Windows.Forms.Label password_label2;
        private System.Windows.Forms.TextBox password_textbox1;
        private System.Windows.Forms.Label password_label1;
        private System.Windows.Forms.TextBox full_name_textbox;
        private System.Windows.Forms.Label full_name_label;
        private System.Windows.Forms.TextBox login_textbox;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label role_label;
        private System.Windows.Forms.ComboBox role_combobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button change_button;
        private System.Windows.Forms.Button delete_button;
    }
}