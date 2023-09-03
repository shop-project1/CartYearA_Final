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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCart)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxChooseProduct
            // 
            this.comboBoxChooseProduct.FormattingEnabled = true;
            this.comboBoxChooseProduct.Location = new System.Drawing.Point(15, 45);
            this.comboBoxChooseProduct.Name = "comboBoxChooseProduct";
            this.comboBoxChooseProduct.Size = new System.Drawing.Size(130, 21);
            this.comboBoxChooseProduct.TabIndex = 0;
            this.comboBoxChooseProduct.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseProduct_SelectedItemChanged);
            // 
            // dataGridCart
            // 
            this.dataGridCart.AllowUserToAddRows = false;
            this.dataGridCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCart.Location = new System.Drawing.Point(350, 20);
            this.dataGridCart.Name = "dataGridCart";
            this.dataGridCart.Size = new System.Drawing.Size(437, 400);
            this.dataGridCart.TabIndex = 1;
            // 
            // comboBoxByCatgeory
            // 
            this.comboBoxByCatgeory.FormattingEnabled = true;
            this.comboBoxByCatgeory.Location = new System.Drawing.Point(15, 90);
            this.comboBoxByCatgeory.Name = "comboBoxByCatgeory";
            this.comboBoxByCatgeory.Size = new System.Drawing.Size(130, 21);
            this.comboBoxByCatgeory.TabIndex = 2;
            this.comboBoxByCatgeory.Visible = false;
            this.comboBoxByCatgeory.SelectedIndexChanged += new System.EventHandler(this.comboBoxByCatgeory_SelectedIndexChanged);
            // 
            // panelAddUserControl
            // 
            this.panelAddUserControl.Location = new System.Drawing.Point(15, 130);
            this.panelAddUserControl.Name = "panelAddUserControl";
            this.panelAddUserControl.Size = new System.Drawing.Size(250, 300);
            this.panelAddUserControl.TabIndex = 3;
            // 
            // gridSaveButton
            // 
            this.gridSaveButton.Location = new System.Drawing.Point(706, 393);
            this.gridSaveButton.Name = "gridSaveButton";
            this.gridSaveButton.Size = new System.Drawing.Size(75, 23);
            this.gridSaveButton.TabIndex = 4;
            this.gridSaveButton.Text = "Save";
            this.gridSaveButton.UseVisualStyleBackColor = true;
            this.gridSaveButton.Click += new System.EventHandler(this.gridSaveButton_Click);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridSaveButton);
            this.Controls.Add(this.panelAddUserControl);
            this.Controls.Add(this.comboBoxByCatgeory);
            this.Controls.Add(this.dataGridCart);
            this.Controls.Add(this.comboBoxChooseProduct);
            this.Name = "ShopForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ShopForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChooseProduct;
        private System.Windows.Forms.DataGridView dataGridCart;
        private System.Windows.Forms.ComboBox comboBoxByCatgeory;
        private System.Windows.Forms.Panel panelAddUserControl;
        private System.Windows.Forms.Button gridSaveButton;
    }
}

