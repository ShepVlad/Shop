namespace Shop
{
    partial class Form1
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
            this.groupBoxCategory = new System.Windows.Forms.GroupBox();
            this.groupBoxGoods = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddtoCart = new System.Windows.Forms.Button();
            this.Infa = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.listBoxGood = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxCart = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CartPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.Manufacturer = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.groupBoxCategory.SuspendLayout();
            this.groupBoxGoods.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Infa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCategory
            // 
            this.groupBoxCategory.Controls.Add(this.listBoxCategory);
            this.groupBoxCategory.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCategory.Name = "groupBoxCategory";
            this.groupBoxCategory.Size = new System.Drawing.Size(200, 290);
            this.groupBoxCategory.TabIndex = 0;
            this.groupBoxCategory.TabStop = false;
            this.groupBoxCategory.Text = "Категории";
            // 
            // groupBoxGoods
            // 
            this.groupBoxGoods.Controls.Add(this.listBoxGood);
            this.groupBoxGoods.Location = new System.Drawing.Point(252, 13);
            this.groupBoxGoods.Name = "groupBoxGoods";
            this.groupBoxGoods.Size = new System.Drawing.Size(200, 290);
            this.groupBoxGoods.TabIndex = 1;
            this.groupBoxGoods.TabStop = false;
            this.groupBoxGoods.Text = "Товары";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.CartPrice);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.listBoxCart);
            this.groupBox3.Location = new System.Drawing.Point(496, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 290);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Корзина";
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.Location = new System.Drawing.Point(575, 155);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(115, 36);
            this.btnAddtoCart.TabIndex = 2;
            this.btnAddtoCart.Text = "Добавить в Корзину ->\r\n";
            this.btnAddtoCart.UseVisualStyleBackColor = true;
            // 
            // Infa
            // 
            this.Infa.Controls.Add(this.Price);
            this.Infa.Controls.Add(this.Count);
            this.Infa.Controls.Add(this.Manufacturer);
            this.Infa.Controls.Add(this.name);
            this.Infa.Controls.Add(this.label4);
            this.Infa.Controls.Add(this.label3);
            this.Infa.Controls.Add(this.label2);
            this.Infa.Controls.Add(this.label1);
            this.Infa.Controls.Add(this.pictureBox1);
            this.Infa.Controls.Add(this.btnAddtoCart);
            this.Infa.Location = new System.Drawing.Point(13, 309);
            this.Infa.Name = "Infa";
            this.Infa.Size = new System.Drawing.Size(698, 212);
            this.Infa.TabIndex = 2;
            this.Infa.TabStop = false;
            this.Infa.Text = "Инфа о товаре";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(496, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 130);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ItalicC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя товара:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ItalicC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Цена:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ItalicC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Количество:";
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.Location = new System.Drawing.Point(7, 20);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(171, 251);
            this.listBoxCategory.TabIndex = 0;
            this.listBoxCategory.SelectedIndexChanged += new System.EventHandler(this.listBoxCategory_SelectedIndexChanged);
            // 
            // listBoxGood
            // 
            this.listBoxGood.FormattingEnabled = true;
            this.listBoxGood.Location = new System.Drawing.Point(7, 20);
            this.listBoxGood.Name = "listBoxGood";
            this.listBoxGood.Size = new System.Drawing.Size(187, 251);
            this.listBoxGood.TabIndex = 0;
            this.listBoxGood.SelectedIndexChanged += new System.EventHandler(this.listBoxGood_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("ItalicC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Производитель:";
            // 
            // listBoxCart
            // 
            this.listBoxCart.FormattingEnabled = true;
            this.listBoxCart.Location = new System.Drawing.Point(13, 20);
            this.listBoxCart.Name = "listBoxCart";
            this.listBoxCart.Size = new System.Drawing.Size(187, 186);
            this.listBoxCart.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Цена:";
            // 
            // CartPrice
            // 
            this.CartPrice.AutoSize = true;
            this.CartPrice.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CartPrice.Location = new System.Drawing.Point(72, 227);
            this.CartPrice.Name = "CartPrice";
            this.CartPrice.Size = new System.Drawing.Size(20, 20);
            this.CartPrice.TabIndex = 7;
            this.CartPrice.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(153, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "грн";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("ItalicC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(134, 29);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(43, 19);
            this.name.TabIndex = 7;
            this.name.Text = "Имя";
            // 
            // Manufacturer
            // 
            this.Manufacturer.AutoSize = true;
            this.Manufacturer.Font = new System.Drawing.Font("ItalicC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Manufacturer.Location = new System.Drawing.Point(154, 60);
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.Size = new System.Drawing.Size(67, 19);
            this.Manufacturer.TabIndex = 8;
            this.Manufacturer.Text = "Произв";
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Font = new System.Drawing.Font("ItalicC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count.Location = new System.Drawing.Point(121, 94);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(36, 19);
            this.Count.TabIndex = 9;
            this.Count.Text = "Кол";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("ItalicC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price.Location = new System.Drawing.Point(66, 125);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(134, 19);
            this.Price.TabIndex = 10;
            this.Price.Text = "Производитель";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 614);
            this.Controls.Add(this.Infa);
            this.Controls.Add(this.groupBoxGoods);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxCategory.ResumeLayout(false);
            this.groupBoxGoods.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Infa.ResumeLayout(false);
            this.Infa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCategory;
        private System.Windows.Forms.GroupBox groupBoxGoods;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddtoCart;
        private System.Windows.Forms.GroupBox Infa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBoxCategory;
        private System.Windows.Forms.ListBox listBoxGood;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CartPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxCart;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.Label Manufacturer;
        private System.Windows.Forms.Label name;
    }
}

