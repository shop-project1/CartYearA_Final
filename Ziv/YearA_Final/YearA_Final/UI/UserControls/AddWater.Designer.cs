//namespace YearA_Final.UI.UserControls
//{
//    partial class AddWater
//    {
//        /// <summary> 
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary> 
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Component Designer generated code

//        /// <summary> 
//        /// Required method for Designer support - do not modify 
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.buttonAdd = new System.Windows.Forms.Button();
//            this.label1 = new System.Windows.Forms.Label();
//            this.label2 = new System.Windows.Forms.Label();
//            this.label3 = new System.Windows.Forms.Label();
//            this.label4 = new System.Windows.Forms.Label();
//            this.label5 = new System.Windows.Forms.Label();
//            this.label6 = new System.Windows.Forms.Label();
//            this.textBoxQuantityToAdd = new System.Windows.Forms.TextBox();
//            this.textBoxShowPrice = new System.Windows.Forms.TextBox();
//            this.comboBoxTypeOfWater = new System.Windows.Forms.ComboBox();
//            this.textBoxExpDate = new System.Windows.Forms.TextBox();
//            this.checkBoxIsCarbon = new System.Windows.Forms.CheckBox();
//            this.textBoxVolume = new System.Windows.Forms.TextBox();
//            this.SuspendLayout();
//            // 
//            // buttonAdd
//            // 
//            this.buttonAdd.Location = new System.Drawing.Point(130, 310);
//            this.buttonAdd.Name = "buttonAdd";
//            this.buttonAdd.Size = new System.Drawing.Size(75, 25);
//            this.buttonAdd.TabIndex = 0;
//            this.buttonAdd.Text = "Add";
//            this.buttonAdd.UseVisualStyleBackColor = true;
//            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
//            this.label1.Location = new System.Drawing.Point(15, 30);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(44, 18);
//            this.label1.TabIndex = 1;
//            this.label1.Text = "Type:";
//            // 
//            // label2
//            // 
//            this.label2.AutoSize = true;
//            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
//            this.label2.Location = new System.Drawing.Point(15, 60);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(46, 18);
//            this.label2.TabIndex = 2;
//            this.label2.Text = "Price:";
//            // 
//            // label3
//            // 
//            this.label3.AutoSize = true;
//            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
//            this.label3.Location = new System.Drawing.Point(15, 90);
//            this.label3.Name = "label3";
//            this.label3.Size = new System.Drawing.Size(66, 18);
//            this.label3.TabIndex = 3;
//            this.label3.Text = "Quantity:";
//            // 
//            // label4
//            // 
//            this.label4.AutoSize = true;
//            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
//            this.label4.Location = new System.Drawing.Point(15, 120);
//            this.label4.Name = "label4";
//            this.label4.Size = new System.Drawing.Size(86, 13);
//            this.label4.TabIndex = 4;
//            this.label4.Text = "Exparation Date:";
//            // 
//            // label5
//            // 
//            this.label5.AutoSize = true;
//            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
//            this.label5.Location = new System.Drawing.Point(15, 150);
//            this.label5.Name = "label5";
//            this.label5.Size = new System.Drawing.Size(86, 15);
//            this.label5.TabIndex = 5;
//            this.label5.Text = "Is Carbonated:";
//            // 
//            // label6
//            // 
//            this.label6.AutoSize = true;
//            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
//            this.label6.Location = new System.Drawing.Point(15, 180);
//            this.label6.Name = "label6";
//            this.label6.Size = new System.Drawing.Size(62, 18);
//            this.label6.TabIndex = 6;
//            this.label6.Text = "Volume:";
//            // 
//            // textBoxQuantityToAdd
//            // 
//            this.textBoxQuantityToAdd.Location = new System.Drawing.Point(130, 90);
//            this.textBoxQuantityToAdd.Name = "textBoxQuantityToAdd";
//            this.textBoxQuantityToAdd.Size = new System.Drawing.Size(54, 20);
//            this.textBoxQuantityToAdd.TabIndex = 7;
//            // 
//            // textBoxShowPrice
//            // 
//            this.textBoxShowPrice.Location = new System.Drawing.Point(130, 60);
//            this.textBoxShowPrice.Name = "textBoxShowPrice";
//            this.textBoxShowPrice.ReadOnly = true;
//            this.textBoxShowPrice.Size = new System.Drawing.Size(54, 20);
//            this.textBoxShowPrice.TabIndex = 9;
//            this.textBoxShowPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
//            // 
//            // comboBoxTypeOfWater
//            // 
//            this.comboBoxTypeOfWater.FormattingEnabled = true;
//            this.comboBoxTypeOfWater.Location = new System.Drawing.Point(110, 30);
//            this.comboBoxTypeOfWater.Name = "comboBoxTypeOfWater";
//            this.comboBoxTypeOfWater.Size = new System.Drawing.Size(99, 21);
//            this.comboBoxTypeOfWater.TabIndex = 10;
//            this.comboBoxTypeOfWater.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeOfWater_SelectedIndexChanged);
//            // 
//            // textBoxExpDate
//            // 
//            this.textBoxExpDate.Location = new System.Drawing.Point(130, 120);
//            this.textBoxExpDate.Name = "textBoxExpDate";
//            this.textBoxExpDate.ReadOnly = true;
//            this.textBoxExpDate.Size = new System.Drawing.Size(54, 20);
//            this.textBoxExpDate.TabIndex = 11;
//            this.textBoxExpDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
//            // 
//            // checkBoxIsCarbon
//            // 
//            this.checkBoxIsCarbon.AutoSize = true;
//            this.checkBoxIsCarbon.Location = new System.Drawing.Point(150, 150);
//            this.checkBoxIsCarbon.Name = "checkBoxIsCarbon";
//            this.checkBoxIsCarbon.Size = new System.Drawing.Size(15, 14);
//            this.checkBoxIsCarbon.TabIndex = 12;
//            this.checkBoxIsCarbon.UseVisualStyleBackColor = true;
//            // 
//            // textBoxVolume
//            // 
//            this.textBoxVolume.Location = new System.Drawing.Point(130, 180);
//            this.textBoxVolume.Name = "textBoxVolume";
//            this.textBoxVolume.ReadOnly = true;
//            this.textBoxVolume.Size = new System.Drawing.Size(54, 20);
//            this.textBoxVolume.TabIndex = 13;
//            this.textBoxVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
//            // 
//            // AddWater
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.Controls.Add(this.textBoxVolume);
//            this.Controls.Add(this.checkBoxIsCarbon);
//            this.Controls.Add(this.textBoxExpDate);
//            this.Controls.Add(this.comboBoxTypeOfWater);
//            this.Controls.Add(this.textBoxShowPrice);
//            this.Controls.Add(this.textBoxQuantityToAdd);
//            this.Controls.Add(this.label6);
//            this.Controls.Add(this.label5);
//            this.Controls.Add(this.label4);
//            this.Controls.Add(this.label3);
//            this.Controls.Add(this.label2);
//            this.Controls.Add(this.label1);
//            this.Controls.Add(this.buttonAdd);
//            this.Name = "AddWater";
//            this.Size = new System.Drawing.Size(220, 345);
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.Button buttonAdd;
//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.Label label3;
//        private System.Windows.Forms.Label label4;
//        private System.Windows.Forms.Label label5;
//        private System.Windows.Forms.Label label6;
//        private System.Windows.Forms.TextBox textBoxQuantityToAdd;
//        private System.Windows.Forms.TextBox textBoxShowPrice;
//        private System.Windows.Forms.ComboBox comboBoxTypeOfWater;
//        private System.Windows.Forms.TextBox textBoxExpDate;
//        private System.Windows.Forms.CheckBox checkBoxIsCarbon;
//        private System.Windows.Forms.TextBox textBoxVolume;
//    }
//}
