﻿namespace YearA_Final.UI.UserControls
{
    partial class AddChocolate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxChocolateType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddBread = new System.Windows.Forms.Button();
            this.textBoxExpDate = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxCalories = new System.Windows.Forms.TextBox();
            this.toolTipPriceChocolate = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // comboBoxChocolateType
            // 
            this.comboBoxChocolateType.FormattingEnabled = true;
            this.comboBoxChocolateType.Location = new System.Drawing.Point(25, 30);
            this.comboBoxChocolateType.Name = "comboBoxChocolateType";
            this.comboBoxChocolateType.Size = new System.Drawing.Size(190, 21);
            this.comboBoxChocolateType.TabIndex = 2;
            this.comboBoxChocolateType.SelectedIndexChanged += new System.EventHandler(this.comboBoxChocolateType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Expiry Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price:";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(10, 180);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(67, 16);
            this.labelQuantity.TabIndex = 6;
            this.labelQuantity.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Calories:";
            // 
            // buttonAddBread
            // 
            this.buttonAddBread.Location = new System.Drawing.Point(160, 265);
            this.buttonAddBread.Name = "buttonAddBread";
            this.buttonAddBread.Size = new System.Drawing.Size(75, 23);
            this.buttonAddBread.TabIndex = 12;
            this.buttonAddBread.Text = "Add";
            this.buttonAddBread.UseVisualStyleBackColor = true;
            this.buttonAddBread.Click += new System.EventHandler(this.buttonAddBread_Click);
            // 
            // textBoxExpDate
            // 
            this.textBoxExpDate.Location = new System.Drawing.Point(135, 100);
            this.textBoxExpDate.Name = "textBoxExpDate";
            this.textBoxExpDate.ReadOnly = true;
            this.textBoxExpDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxExpDate.TabIndex = 13;
            this.textBoxExpDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(135, 140);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 14;
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(135, 180);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantity.TabIndex = 15;
            this.textBoxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCalories
            // 
            this.textBoxCalories.Location = new System.Drawing.Point(125, 220);
            this.textBoxCalories.Name = "textBoxCalories";
            this.textBoxCalories.ReadOnly = true;
            this.textBoxCalories.Size = new System.Drawing.Size(121, 20);
            this.textBoxCalories.TabIndex = 16;
            this.textBoxCalories.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCalories.MouseHover += new System.EventHandler(this.textBoxCalories_MouseHover);
            // 
            // AddChocolate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxCalories);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxExpDate);
            this.Controls.Add(this.buttonAddBread);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxChocolateType);
            this.Name = "AddChocolate";
            this.Size = new System.Drawing.Size(250, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChocolateType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddBread;
        private System.Windows.Forms.TextBox textBoxExpDate;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxCalories;
        private System.Windows.Forms.ToolTip toolTipPriceChocolate;
    }
}
