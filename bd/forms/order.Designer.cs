namespace bd.forms
{
    partial class order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(order));
            this.orders_dataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.back_toolstripbutton = new System.Windows.Forms.ToolStripButton();
            this.order_toolstriplabel = new System.Windows.Forms.ToolStripLabel();
            this.order_button = new System.Windows.Forms.ToolStripButton();
            this.commet_richtextbox = new System.Windows.Forms.RichTextBox();
            this.comment_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orders_dataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orders_dataGridView
            // 
            this.orders_dataGridView.AllowUserToAddRows = false;
            this.orders_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orders_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orders_dataGridView.Location = new System.Drawing.Point(12, 36);
            this.orders_dataGridView.Name = "orders_dataGridView";
            this.orders_dataGridView.ReadOnly = true;
            this.orders_dataGridView.Size = new System.Drawing.Size(1240, 407);
            this.orders_dataGridView.TabIndex = 25;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.back_toolstripbutton,
            this.order_toolstriplabel,
            this.order_button});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 39);
            this.toolStrip1.TabIndex = 26;
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
            // order_toolstriplabel
            // 
            this.order_toolstriplabel.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.order_toolstriplabel.Name = "order_toolstriplabel";
            this.order_toolstriplabel.Size = new System.Drawing.Size(37, 29);
            this.order_toolstriplabel.Text = "Заказ";
            // 
            // order_button
            // 
            this.order_button.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.order_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.order_button.Image = ((System.Drawing.Image)(resources.GetObject("order_button.Image")));
            this.order_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.order_button.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.order_button.Name = "order_button";
            this.order_button.Padding = new System.Windows.Forms.Padding(5);
            this.order_button.Size = new System.Drawing.Size(68, 29);
            this.order_button.Text = "Заказать";
            this.order_button.Click += new System.EventHandler(this.order_button_Click);
            // 
            // commet_richtextbox
            // 
            this.commet_richtextbox.Location = new System.Drawing.Point(13, 497);
            this.commet_richtextbox.Name = "commet_richtextbox";
            this.commet_richtextbox.Size = new System.Drawing.Size(1239, 144);
            this.commet_richtextbox.TabIndex = 27;
            this.commet_richtextbox.Text = "";
            // 
            // comment_label
            // 
            this.comment_label.Location = new System.Drawing.Point(12, 456);
            this.comment_label.Name = "comment_label";
            this.comment_label.Size = new System.Drawing.Size(1240, 23);
            this.comment_label.TabIndex = 28;
            this.comment_label.Text = "Комментарий";
            this.comment_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.comment_label);
            this.Controls.Add(this.commet_richtextbox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.orders_dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "order";
            this.Text = "order";
            ((System.ComponentModel.ISupportInitialize)(this.orders_dataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView orders_dataGridView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton back_toolstripbutton;
        private System.Windows.Forms.ToolStripLabel order_toolstriplabel;
        private System.Windows.Forms.ToolStripButton order_button;
        private System.Windows.Forms.RichTextBox commet_richtextbox;
        private System.Windows.Forms.Label comment_label;
    }
}