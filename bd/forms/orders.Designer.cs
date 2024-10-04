namespace bd.forms
{
    partial class orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orders));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.back_toolstripbutton = new System.Windows.Forms.ToolStripButton();
            this.orders_toolstriplabel = new System.Windows.Forms.ToolStripLabel();
            this.orders_dataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orders_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.back_toolstripbutton,
            this.orders_toolstriplabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 39);
            this.toolStrip1.TabIndex = 23;
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
            // orders_toolstriplabel
            // 
            this.orders_toolstriplabel.Margin = new System.Windows.Forms.Padding(20, 2, 20, 2);
            this.orders_toolstriplabel.Name = "orders_toolstriplabel";
            this.orders_toolstriplabel.Size = new System.Drawing.Size(46, 35);
            this.orders_toolstriplabel.Text = "Заказы";
            // 
            // orders_dataGridView
            // 
            this.orders_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orders_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orders_dataGridView.Location = new System.Drawing.Point(12, 36);
            this.orders_dataGridView.Name = "orders_dataGridView";
            this.orders_dataGridView.Size = new System.Drawing.Size(1240, 541);
            this.orders_dataGridView.TabIndex = 24;
            // 
            // orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.orders_dataGridView);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "orders";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orders_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton back_toolstripbutton;
        private System.Windows.Forms.ToolStripLabel orders_toolstriplabel;
        private System.Windows.Forms.DataGridView orders_dataGridView;
    }
}