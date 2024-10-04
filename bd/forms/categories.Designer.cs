namespace bd.forms
{
    partial class categories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(categories));
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.category_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.category_datagridview = new System.Windows.Forms.DataGridView();
            this.Addrole_button = new System.Windows.Forms.Button();
            this.category_label = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.back_toolstripbutton = new System.Windows.Forms.ToolStripButton();
            this.categories_toolstriplabel = new System.Windows.Forms.ToolStripLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.category_datagridview)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.category_textbox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.category_datagridview);
            this.panel1.Controls.Add(this.Addrole_button);
            this.panel1.Controls.Add(this.category_label);
            this.panel1.Location = new System.Drawing.Point(448, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 468);
            this.panel1.TabIndex = 29;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(14, 11);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(277, 38);
            this.title.TabIndex = 28;
            this.title.Text = "Категории лекарств";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // category_textbox
            // 
            this.category_textbox.Location = new System.Drawing.Point(155, 59);
            this.category_textbox.Name = "category_textbox";
            this.category_textbox.Size = new System.Drawing.Size(136, 20);
            this.category_textbox.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Удалить категорию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // category_datagridview
            // 
            this.category_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.category_datagridview.Location = new System.Drawing.Point(17, 148);
            this.category_datagridview.Name = "category_datagridview";
            this.category_datagridview.ReadOnly = true;
            this.category_datagridview.Size = new System.Drawing.Size(274, 308);
            this.category_datagridview.TabIndex = 0;
            // 
            // Addrole_button
            // 
            this.Addrole_button.Location = new System.Drawing.Point(17, 90);
            this.Addrole_button.Name = "Addrole_button";
            this.Addrole_button.Size = new System.Drawing.Size(274, 23);
            this.Addrole_button.TabIndex = 26;
            this.Addrole_button.Text = "Добавить категорию";
            this.Addrole_button.UseVisualStyleBackColor = true;
            this.Addrole_button.Click += new System.EventHandler(this.addcategory_button_Click);
            // 
            // category_label
            // 
            this.category_label.Location = new System.Drawing.Point(14, 49);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(135, 38);
            this.category_label.TabIndex = 24;
            this.category_label.Text = "Название категории";
            this.category_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.back_toolstripbutton,
            this.categories_toolstriplabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 39);
            this.toolStrip1.TabIndex = 30;
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
            // categories_toolstriplabel
            // 
            this.categories_toolstriplabel.Margin = new System.Windows.Forms.Padding(20, 2, 20, 2);
            this.categories_toolstriplabel.Name = "categories_toolstriplabel";
            this.categories_toolstriplabel.Size = new System.Drawing.Size(116, 35);
            this.categories_toolstriplabel.Text = "Категории лекарств";
            // 
            // categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "categories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "categories";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.category_datagridview)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox category_textbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView category_datagridview;
        private System.Windows.Forms.Button Addrole_button;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton back_toolstripbutton;
        private System.Windows.Forms.ToolStripLabel categories_toolstriplabel;
    }
}