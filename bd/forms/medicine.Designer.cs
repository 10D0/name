namespace bd.forms
{
    partial class medicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(medicine));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Categories_toolstripcombobox = new System.Windows.Forms.ToolStripComboBox();
            this.Category_toolstriplabel = new System.Windows.Forms.ToolStripLabel();
            this.profile_toolstripbutton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cart_toolstripbutton = new System.Windows.Forms.ToolStripButton();
            this.Categories_toolstripbutton = new System.Windows.Forms.ToolStripButton();
            this.Users_toolstripbutton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Categories_toolstripcombobox,
            this.Category_toolstriplabel,
            this.profile_toolstripbutton,
            this.toolStripLabel1,
            this.cart_toolstripbutton,
            this.Categories_toolstripbutton,
            this.Users_toolstripbutton,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 40);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Categories_toolstripcombobox
            // 
            this.Categories_toolstripcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Categories_toolstripcombobox.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.Categories_toolstripcombobox.Name = "Categories_toolstripcombobox";
            this.Categories_toolstripcombobox.Size = new System.Drawing.Size(121, 30);
            this.Categories_toolstripcombobox.SelectedIndexChanged += new System.EventHandler(this.Categories_toolstripcombobox_SelectedIndexChanged);
            // 
            // Category_toolstriplabel
            // 
            this.Category_toolstriplabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Category_toolstriplabel.Margin = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.Category_toolstriplabel.Name = "Category_toolstriplabel";
            this.Category_toolstriplabel.Padding = new System.Windows.Forms.Padding(5);
            this.Category_toolstriplabel.Size = new System.Drawing.Size(74, 30);
            this.Category_toolstriplabel.Text = "Категории";
            // 
            // profile_toolstripbutton
            // 
            this.profile_toolstripbutton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.profile_toolstripbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.profile_toolstripbutton.Image = ((System.Drawing.Image)(resources.GetObject("profile_toolstripbutton.Image")));
            this.profile_toolstripbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.profile_toolstripbutton.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.profile_toolstripbutton.Name = "profile_toolstripbutton";
            this.profile_toolstripbutton.Padding = new System.Windows.Forms.Padding(5);
            this.profile_toolstripbutton.Size = new System.Drawing.Size(73, 30);
            this.profile_toolstripbutton.Text = "Профиль";
            this.profile_toolstripbutton.Click += new System.EventHandler(this.profile_toolstripbutton_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(13, 37);
            this.toolStripLabel1.Text = "0";
            // 
            // cart_toolstripbutton
            // 
            this.cart_toolstripbutton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cart_toolstripbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cart_toolstripbutton.Image = ((System.Drawing.Image)(resources.GetObject("cart_toolstripbutton.Image")));
            this.cart_toolstripbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cart_toolstripbutton.Margin = new System.Windows.Forms.Padding(10, 10, 1, 10);
            this.cart_toolstripbutton.Name = "cart_toolstripbutton";
            this.cart_toolstripbutton.Size = new System.Drawing.Size(23, 20);
            this.cart_toolstripbutton.Text = "Корзина";
            this.cart_toolstripbutton.Click += new System.EventHandler(this.cart_toolstripbutton_Click);
            // 
            // Categories_toolstripbutton
            // 
            this.Categories_toolstripbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Categories_toolstripbutton.Image = ((System.Drawing.Image)(resources.GetObject("Categories_toolstripbutton.Image")));
            this.Categories_toolstripbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Categories_toolstripbutton.Margin = new System.Windows.Forms.Padding(5);
            this.Categories_toolstripbutton.Name = "Categories_toolstripbutton";
            this.Categories_toolstripbutton.Padding = new System.Windows.Forms.Padding(5);
            this.Categories_toolstripbutton.Size = new System.Drawing.Size(134, 30);
            this.Categories_toolstripbutton.Text = "Изменить категории";
            this.Categories_toolstripbutton.Click += new System.EventHandler(this.Categories_toolstripbutton_Click);
            // 
            // Users_toolstripbutton
            // 
            this.Users_toolstripbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Users_toolstripbutton.Image = ((System.Drawing.Image)(resources.GetObject("Users_toolstripbutton.Image")));
            this.Users_toolstripbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Users_toolstripbutton.Margin = new System.Windows.Forms.Padding(5);
            this.Users_toolstripbutton.Name = "Users_toolstripbutton";
            this.Users_toolstripbutton.Size = new System.Drawing.Size(89, 30);
            this.Users_toolstripbutton.Text = "Пользователи";
            this.Users_toolstripbutton.Click += new System.EventHandler(this.Users_toolstripbutton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(5);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripButton1.Size = new System.Drawing.Size(80, 30);
            this.toolStripButton1.Text = "Все заказы";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1240, 513);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "medicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ассортимент";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox Categories_toolstripcombobox;
        private System.Windows.Forms.ToolStripLabel Category_toolstriplabel;
        private System.Windows.Forms.ToolStripButton profile_toolstripbutton;
        private System.Windows.Forms.ToolStripButton cart_toolstripbutton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton Categories_toolstripbutton;
        private System.Windows.Forms.ToolStripButton Users_toolstripbutton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}