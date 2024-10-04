namespace bd.forms
{
    partial class drug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(drug));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.back_toolstripbutton = new System.Windows.Forms.ToolStripButton();
            this.drug_toolstriplabel = new System.Windows.Forms.ToolStripLabel();
            this.Add_drug_button = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.category_combobox = new System.Windows.Forms.ComboBox();
            this.category_label = new System.Windows.Forms.Label();
            this.applychanges_button = new System.Windows.Forms.Button();
            this.quantity_label = new System.Windows.Forms.Label();
            this.discription_textbox = new System.Windows.Forms.TextBox();
            this.quantity_textbox = new System.Windows.Forms.TextBox();
            this.discription_label = new System.Windows.Forms.Label();
            this.medicine_name_label = new System.Windows.Forms.Label();
            this.price_textbox = new System.Windows.Forms.TextBox();
            this.medicine_name_textbox = new System.Windows.Forms.TextBox();
            this.price_label = new System.Windows.Forms.Label();
            this.Id_value_label = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.loadimage_button = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.back_toolstripbutton,
            this.drug_toolstriplabel,
            this.Add_drug_button});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 39);
            this.toolStrip1.TabIndex = 27;
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
            // drug_toolstriplabel
            // 
            this.drug_toolstriplabel.Margin = new System.Windows.Forms.Padding(20, 2, 20, 2);
            this.drug_toolstriplabel.Name = "drug_toolstriplabel";
            this.drug_toolstriplabel.Size = new System.Drawing.Size(64, 35);
            this.drug_toolstriplabel.Text = "Лекарство";
            // 
            // Add_drug_button
            // 
            this.Add_drug_button.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Add_drug_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Add_drug_button.Image = ((System.Drawing.Image)(resources.GetObject("Add_drug_button.Image")));
            this.Add_drug_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Add_drug_button.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.Add_drug_button.Name = "Add_drug_button";
            this.Add_drug_button.Padding = new System.Windows.Forms.Padding(5);
            this.Add_drug_button.Size = new System.Drawing.Size(130, 29);
            this.Add_drug_button.Text = "Добавить в корзину";
            this.Add_drug_button.Click += new System.EventHandler(this.Add_drug_button_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(256, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.category_combobox);
            this.panel1.Controls.Add(this.category_label);
            this.panel1.Controls.Add(this.applychanges_button);
            this.panel1.Controls.Add(this.quantity_label);
            this.panel1.Controls.Add(this.discription_textbox);
            this.panel1.Controls.Add(this.quantity_textbox);
            this.panel1.Controls.Add(this.discription_label);
            this.panel1.Controls.Add(this.medicine_name_label);
            this.panel1.Controls.Add(this.price_textbox);
            this.panel1.Controls.Add(this.medicine_name_textbox);
            this.panel1.Controls.Add(this.price_label);
            this.panel1.Controls.Add(this.Id_value_label);
            this.panel1.Controls.Add(this.id_label);
            this.panel1.Location = new System.Drawing.Point(533, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 341);
            this.panel1.TabIndex = 29;
            // 
            // category_combobox
            // 
            this.category_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category_combobox.Location = new System.Drawing.Point(233, 53);
            this.category_combobox.Name = "category_combobox";
            this.category_combobox.Size = new System.Drawing.Size(228, 21);
            this.category_combobox.TabIndex = 7;
            // 
            // category_label
            // 
            this.category_label.Location = new System.Drawing.Point(34, 51);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(172, 23);
            this.category_label.TabIndex = 14;
            this.category_label.Text = "Категория";
            this.category_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // applychanges_button
            // 
            this.applychanges_button.Location = new System.Drawing.Point(37, 309);
            this.applychanges_button.Name = "applychanges_button";
            this.applychanges_button.Size = new System.Drawing.Size(424, 23);
            this.applychanges_button.TabIndex = 21;
            this.applychanges_button.Text = "Применить изменения";
            this.applychanges_button.UseVisualStyleBackColor = true;
            this.applychanges_button.Click += new System.EventHandler(this.applychanges_button_Click);
            // 
            // quantity_label
            // 
            this.quantity_label.Location = new System.Drawing.Point(34, 125);
            this.quantity_label.Name = "quantity_label";
            this.quantity_label.Size = new System.Drawing.Size(172, 23);
            this.quantity_label.TabIndex = 13;
            this.quantity_label.Text = "Количество на складе";
            this.quantity_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // discription_textbox
            // 
            this.discription_textbox.Location = new System.Drawing.Point(233, 187);
            this.discription_textbox.Multiline = true;
            this.discription_textbox.Name = "discription_textbox";
            this.discription_textbox.Size = new System.Drawing.Size(228, 115);
            this.discription_textbox.TabIndex = 15;
            // 
            // quantity_textbox
            // 
            this.quantity_textbox.Location = new System.Drawing.Point(233, 125);
            this.quantity_textbox.Name = "quantity_textbox";
            this.quantity_textbox.Size = new System.Drawing.Size(228, 20);
            this.quantity_textbox.TabIndex = 20;
            // 
            // discription_label
            // 
            this.discription_label.Location = new System.Drawing.Point(34, 187);
            this.discription_label.Name = "discription_label";
            this.discription_label.Size = new System.Drawing.Size(172, 115);
            this.discription_label.TabIndex = 8;
            this.discription_label.Text = "Описание";
            this.discription_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // medicine_name_label
            // 
            this.medicine_name_label.Location = new System.Drawing.Point(34, 88);
            this.medicine_name_label.Name = "medicine_name_label";
            this.medicine_name_label.Size = new System.Drawing.Size(172, 23);
            this.medicine_name_label.TabIndex = 12;
            this.medicine_name_label.Text = "Название лекарства";
            this.medicine_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // price_textbox
            // 
            this.price_textbox.Location = new System.Drawing.Point(233, 161);
            this.price_textbox.Name = "price_textbox";
            this.price_textbox.Size = new System.Drawing.Size(228, 20);
            this.price_textbox.TabIndex = 16;
            // 
            // medicine_name_textbox
            // 
            this.medicine_name_textbox.Location = new System.Drawing.Point(233, 88);
            this.medicine_name_textbox.Name = "medicine_name_textbox";
            this.medicine_name_textbox.Size = new System.Drawing.Size(228, 20);
            this.medicine_name_textbox.TabIndex = 19;
            // 
            // price_label
            // 
            this.price_label.Location = new System.Drawing.Point(34, 161);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(172, 23);
            this.price_label.TabIndex = 9;
            this.price_label.Text = "Цена";
            this.price_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Id_value_label
            // 
            this.Id_value_label.Location = new System.Drawing.Point(230, 20);
            this.Id_value_label.Name = "Id_value_label";
            this.Id_value_label.Size = new System.Drawing.Size(172, 23);
            this.Id_value_label.TabIndex = 11;
            this.Id_value_label.Text = "id";
            this.Id_value_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id_label
            // 
            this.id_label.Location = new System.Drawing.Point(34, 20);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(172, 23);
            this.id_label.TabIndex = 11;
            this.id_label.Text = "Идентификатор";
            this.id_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadimage_button
            // 
            this.loadimage_button.Location = new System.Drawing.Point(256, 375);
            this.loadimage_button.Name = "loadimage_button";
            this.loadimage_button.Size = new System.Drawing.Size(261, 23);
            this.loadimage_button.TabIndex = 21;
            this.loadimage_button.Text = "Загрузить изображение";
            this.loadimage_button.UseVisualStyleBackColor = true;
            this.loadimage_button.Click += new System.EventHandler(this.loadimage_button_Click);
            // 
            // drug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loadimage_button);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "drug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "drug";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton back_toolstripbutton;
        private System.Windows.Forms.ToolStripLabel drug_toolstriplabel;
        private System.Windows.Forms.ToolStripButton Add_drug_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox category_combobox;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.Button applychanges_button;
        private System.Windows.Forms.Label quantity_label;
        private System.Windows.Forms.TextBox discription_textbox;
        private System.Windows.Forms.TextBox quantity_textbox;
        private System.Windows.Forms.Label discription_label;
        private System.Windows.Forms.Label medicine_name_label;
        private System.Windows.Forms.TextBox price_textbox;
        private System.Windows.Forms.TextBox medicine_name_textbox;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Button loadimage_button;
        private System.Windows.Forms.Label Id_value_label;
    }
}