namespace YearA_Final
{
    partial class ShopForm
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
            this.comboBoxChooseProduct = new System.Windows.Forms.ComboBox();
            this.dataGridCart = new System.Windows.Forms.DataGridView();
            this.comboBoxByCatgeory = new System.Windows.Forms.ComboBox();
            this.panelAddUserControl = new System.Windows.Forms.Panel();
            this.gridSaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCart)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxChooseProduct
            // 
            this.comboBoxChooseProduct.FormattingEnabled = true;
            this.comboBoxChooseProduct.Location = new System.Drawing.Point(22, 69);
            this.comboBoxChooseProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxChooseProduct.Name = "comboBoxChooseProduct";
            this.comboBoxChooseProduct.Size = new System.Drawing.Size(193, 28);
            this.comboBoxChooseProduct.TabIndex = 0;
            this.comboBoxChooseProduct.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseProduct_SelectedItemChanged);
            // 
            // dataGridCart
            // 
            this.dataGridCart.AllowUserToAddRows = false;
            this.dataGridCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCart.Location = new System.Drawing.Point(406, 31);
            this.dataGridCart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridCart.Name = "dataGridCart";
            this.dataGridCart.RowHeadersWidth = 62;
            this.dataGridCart.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridCart.Size = new System.Drawing.Size(788, 631);
            this.dataGridCart.TabIndex = 1;
            this.dataGridCart.MouseCaptureChanged += new System.EventHandler(this.dataGridCart_MouseCaptureChanged);
            // 
            // comboBoxByCatgeory
            // 
            this.comboBoxByCatgeory.FormattingEnabled = true;
            this.comboBoxByCatgeory.Location = new System.Drawing.Point(22, 138);
            this.comboBoxByCatgeory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxByCatgeory.Name = "comboBoxByCatgeory";
            this.comboBoxByCatgeory.Size = new System.Drawing.Size(193, 28);
            this.comboBoxByCatgeory.TabIndex = 2;
            this.comboBoxByCatgeory.Visible = false;
            this.comboBoxByCatgeory.SelectedIndexChanged += new System.EventHandler(this.comboBoxByCatgeory_SelectedIndexChanged);
            // 
            // panelAddUserControl
            // 
            this.panelAddUserControl.Location = new System.Drawing.Point(22, 200);
            this.panelAddUserControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelAddUserControl.Name = "panelAddUserControl";
            this.panelAddUserControl.Size = new System.Drawing.Size(375, 462);
            this.panelAddUserControl.TabIndex = 3;
            // 
            // gridSaveButton
            // 
            this.gridSaveButton.Location = new System.Drawing.Point(1074, 620);
            this.gridSaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridSaveButton.Name = "gridSaveButton";
            this.gridSaveButton.Size = new System.Drawing.Size(112, 35);
            this.gridSaveButton.TabIndex = 4;
            this.gridSaveButton.Text = "Save";
            this.gridSaveButton.UseVisualStyleBackColor = true;
            this.gridSaveButton.Click += new System.EventHandler(this.gridSaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 634);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total:";
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Location = new System.Drawing.Point(471, 628);
            this.textBoxTotalPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.ReadOnly = true;
            this.textBoxTotalPrice.Size = new System.Drawing.Size(58, 26);
            this.textBoxTotalPrice.TabIndex = 6;
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.textBoxTotalPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridSaveButton);
            this.Controls.Add(this.panelAddUserControl);
            this.Controls.Add(this.comboBoxByCatgeory);
            this.Controls.Add(this.dataGridCart);
            this.Controls.Add(this.comboBoxChooseProduct);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ShopForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ShopForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChooseProduct;
        private System.Windows.Forms.DataGridView dataGridCart;
        private System.Windows.Forms.ComboBox comboBoxByCatgeory;
        private System.Windows.Forms.Panel panelAddUserControl;
        private System.Windows.Forms.Button gridSaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
    }
}

