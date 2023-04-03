namespace THA_W5_MEGAN_R
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
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.dgvProdukSimpan = new System.Windows.Forms.DataGridView();
            this.label_prod = new System.Windows.Forms.Label();
            this.label_category = new System.Windows.Forms.Label();
            this.butt_all = new System.Windows.Forms.Button();
            this.butt_filter = new System.Windows.Forms.Button();
            this.comboBox_data = new System.Windows.Forms.ComboBox();
            this.label_details = new System.Windows.Forms.Label();
            this.label_nameDet = new System.Windows.Forms.Label();
            this.label_cat = new System.Windows.Forms.Label();
            this.label_hargaDet = new System.Windows.Forms.Label();
            this.label_stockDet = new System.Windows.Forms.Label();
            this.label_nameCat = new System.Windows.Forms.Label();
            this.textBox_nameCat = new System.Windows.Forms.TextBox();
            this.textBox_nameDet = new System.Windows.Forms.TextBox();
            this.textBox_hargaDet = new System.Windows.Forms.TextBox();
            this.textBox_stockDet = new System.Windows.Forms.TextBox();
            this.butt_removeCategory = new System.Windows.Forms.Button();
            this.butt_addCategory = new System.Windows.Forms.Button();
            this.butt_addProduct = new System.Windows.Forms.Button();
            this.butt_removeProduct = new System.Windows.Forms.Button();
            this.butt_editProduct = new System.Windows.Forms.Button();
            this.comboBox_cat = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukSimpan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCategory
            // 
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(538, 47);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.Size = new System.Drawing.Size(241, 190);
            this.dgvCategory.TabIndex = 0;
            // 
            // dgvProdukSimpan
            // 
            this.dgvProdukSimpan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdukSimpan.Location = new System.Drawing.Point(12, 47);
            this.dgvProdukSimpan.Name = "dgvProdukSimpan";
            this.dgvProdukSimpan.Size = new System.Drawing.Size(508, 221);
            this.dgvProdukSimpan.TabIndex = 1;
            this.dgvProdukSimpan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdukSimpan_CellContentClick);
            // 
            // label_prod
            // 
            this.label_prod.AutoSize = true;
            this.label_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prod.Location = new System.Drawing.Point(46, 15);
            this.label_prod.Name = "label_prod";
            this.label_prod.Size = new System.Drawing.Size(68, 16);
            this.label_prod.TabIndex = 2;
            this.label_prod.Text = "Products";
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_category.Location = new System.Drawing.Point(549, 15);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(70, 16);
            this.label_category.TabIndex = 3;
            this.label_category.Text = "Category";
            // 
            // butt_all
            // 
            this.butt_all.Location = new System.Drawing.Point(154, 13);
            this.butt_all.Name = "butt_all";
            this.butt_all.Size = new System.Drawing.Size(75, 23);
            this.butt_all.TabIndex = 4;
            this.butt_all.Text = "All";
            this.butt_all.UseVisualStyleBackColor = true;
            this.butt_all.Click += new System.EventHandler(this.butt_all_Click);
            // 
            // butt_filter
            // 
            this.butt_filter.Location = new System.Drawing.Point(235, 13);
            this.butt_filter.Name = "butt_filter";
            this.butt_filter.Size = new System.Drawing.Size(75, 23);
            this.butt_filter.TabIndex = 5;
            this.butt_filter.Text = "Filter";
            this.butt_filter.UseVisualStyleBackColor = true;
            this.butt_filter.Click += new System.EventHandler(this.butt_filter_Click);
            // 
            // comboBox_data
            // 
            this.comboBox_data.FormattingEnabled = true;
            this.comboBox_data.Location = new System.Drawing.Point(327, 14);
            this.comboBox_data.Name = "comboBox_data";
            this.comboBox_data.Size = new System.Drawing.Size(121, 21);
            this.comboBox_data.TabIndex = 6;
            this.comboBox_data.SelectionChangeCommitted += new System.EventHandler(this.comboBox_data_SelectionChangeCommitted);
            // 
            // label_details
            // 
            this.label_details.AutoSize = true;
            this.label_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_details.Location = new System.Drawing.Point(44, 295);
            this.label_details.Name = "label_details";
            this.label_details.Size = new System.Drawing.Size(70, 16);
            this.label_details.TabIndex = 7;
            this.label_details.Text = "DETAILS";
            // 
            // label_nameDet
            // 
            this.label_nameDet.AutoSize = true;
            this.label_nameDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nameDet.Location = new System.Drawing.Point(44, 322);
            this.label_nameDet.Name = "label_nameDet";
            this.label_nameDet.Size = new System.Drawing.Size(49, 15);
            this.label_nameDet.TabIndex = 8;
            this.label_nameDet.Text = "Name:";
            // 
            // label_cat
            // 
            this.label_cat.AutoSize = true;
            this.label_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cat.Location = new System.Drawing.Point(44, 357);
            this.label_cat.Name = "label_cat";
            this.label_cat.Size = new System.Drawing.Size(67, 15);
            this.label_cat.TabIndex = 9;
            this.label_cat.Text = "Category:";
            // 
            // label_hargaDet
            // 
            this.label_hargaDet.AutoSize = true;
            this.label_hargaDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hargaDet.Location = new System.Drawing.Point(44, 392);
            this.label_hargaDet.Name = "label_hargaDet";
            this.label_hargaDet.Size = new System.Drawing.Size(50, 15);
            this.label_hargaDet.TabIndex = 10;
            this.label_hargaDet.Text = "Harga:";
            // 
            // label_stockDet
            // 
            this.label_stockDet.AutoSize = true;
            this.label_stockDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stockDet.Location = new System.Drawing.Point(44, 428);
            this.label_stockDet.Name = "label_stockDet";
            this.label_stockDet.Size = new System.Drawing.Size(46, 15);
            this.label_stockDet.TabIndex = 11;
            this.label_stockDet.Text = "Stock:";
            // 
            // label_nameCat
            // 
            this.label_nameCat.AutoSize = true;
            this.label_nameCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nameCat.Location = new System.Drawing.Point(549, 275);
            this.label_nameCat.Name = "label_nameCat";
            this.label_nameCat.Size = new System.Drawing.Size(49, 15);
            this.label_nameCat.TabIndex = 12;
            this.label_nameCat.Text = "Name:";
            // 
            // textBox_nameCat
            // 
            this.textBox_nameCat.Location = new System.Drawing.Point(611, 272);
            this.textBox_nameCat.Name = "textBox_nameCat";
            this.textBox_nameCat.Size = new System.Drawing.Size(148, 20);
            this.textBox_nameCat.TabIndex = 13;
            // 
            // textBox_nameDet
            // 
            this.textBox_nameDet.Location = new System.Drawing.Point(113, 319);
            this.textBox_nameDet.Name = "textBox_nameDet";
            this.textBox_nameDet.Size = new System.Drawing.Size(335, 20);
            this.textBox_nameDet.TabIndex = 14;
            // 
            // textBox_hargaDet
            // 
            this.textBox_hargaDet.Location = new System.Drawing.Point(113, 389);
            this.textBox_hargaDet.Name = "textBox_hargaDet";
            this.textBox_hargaDet.Size = new System.Drawing.Size(100, 20);
            this.textBox_hargaDet.TabIndex = 15;
            // 
            // textBox_stockDet
            // 
            this.textBox_stockDet.Location = new System.Drawing.Point(113, 425);
            this.textBox_stockDet.Name = "textBox_stockDet";
            this.textBox_stockDet.Size = new System.Drawing.Size(100, 20);
            this.textBox_stockDet.TabIndex = 16;
            // 
            // butt_removeCategory
            // 
            this.butt_removeCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_removeCategory.Location = new System.Drawing.Point(686, 317);
            this.butt_removeCategory.Name = "butt_removeCategory";
            this.butt_removeCategory.Size = new System.Drawing.Size(73, 53);
            this.butt_removeCategory.TabIndex = 18;
            this.butt_removeCategory.Text = "Remove Category";
            this.butt_removeCategory.UseVisualStyleBackColor = true;
            this.butt_removeCategory.Click += new System.EventHandler(this.butt_removeCategory_Click);
            // 
            // butt_addCategory
            // 
            this.butt_addCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_addCategory.Location = new System.Drawing.Point(611, 317);
            this.butt_addCategory.Name = "butt_addCategory";
            this.butt_addCategory.Size = new System.Drawing.Size(66, 53);
            this.butt_addCategory.TabIndex = 19;
            this.butt_addCategory.Text = "Add Category";
            this.butt_addCategory.UseVisualStyleBackColor = true;
            this.butt_addCategory.Click += new System.EventHandler(this.butt_addCategory_Click);
            // 
            // butt_addProduct
            // 
            this.butt_addProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_addProduct.Location = new System.Drawing.Point(235, 352);
            this.butt_addProduct.Name = "butt_addProduct";
            this.butt_addProduct.Size = new System.Drawing.Size(62, 54);
            this.butt_addProduct.TabIndex = 20;
            this.butt_addProduct.Text = "Add Product";
            this.butt_addProduct.UseVisualStyleBackColor = true;
            this.butt_addProduct.Click += new System.EventHandler(this.butt_addProduct_Click);
            // 
            // butt_removeProduct
            // 
            this.butt_removeProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_removeProduct.Location = new System.Drawing.Point(371, 352);
            this.butt_removeProduct.Name = "butt_removeProduct";
            this.butt_removeProduct.Size = new System.Drawing.Size(62, 54);
            this.butt_removeProduct.TabIndex = 21;
            this.butt_removeProduct.Text = "Remove Product";
            this.butt_removeProduct.UseVisualStyleBackColor = true;
            this.butt_removeProduct.Click += new System.EventHandler(this.butt_removeProduct_Click);
            // 
            // butt_editProduct
            // 
            this.butt_editProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_editProduct.Location = new System.Drawing.Point(303, 352);
            this.butt_editProduct.Name = "butt_editProduct";
            this.butt_editProduct.Size = new System.Drawing.Size(62, 54);
            this.butt_editProduct.TabIndex = 22;
            this.butt_editProduct.Text = "Edit Product";
            this.butt_editProduct.UseVisualStyleBackColor = true;
            this.butt_editProduct.Click += new System.EventHandler(this.butt_editProduct_Click);
            // 
            // comboBox_cat
            // 
            this.comboBox_cat.FormattingEnabled = true;
            this.comboBox_cat.Location = new System.Drawing.Point(113, 352);
            this.comboBox_cat.Name = "comboBox_cat";
            this.comboBox_cat.Size = new System.Drawing.Size(100, 21);
            this.comboBox_cat.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_cat);
            this.Controls.Add(this.butt_editProduct);
            this.Controls.Add(this.butt_removeProduct);
            this.Controls.Add(this.butt_addProduct);
            this.Controls.Add(this.butt_addCategory);
            this.Controls.Add(this.butt_removeCategory);
            this.Controls.Add(this.textBox_stockDet);
            this.Controls.Add(this.textBox_hargaDet);
            this.Controls.Add(this.textBox_nameDet);
            this.Controls.Add(this.textBox_nameCat);
            this.Controls.Add(this.label_nameCat);
            this.Controls.Add(this.label_stockDet);
            this.Controls.Add(this.label_hargaDet);
            this.Controls.Add(this.label_cat);
            this.Controls.Add(this.label_nameDet);
            this.Controls.Add(this.label_details);
            this.Controls.Add(this.comboBox_data);
            this.Controls.Add(this.butt_filter);
            this.Controls.Add(this.butt_all);
            this.Controls.Add(this.label_category);
            this.Controls.Add(this.label_prod);
            this.Controls.Add(this.dgvProdukSimpan);
            this.Controls.Add(this.dgvCategory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukSimpan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.DataGridView dgvProdukSimpan;
        private System.Windows.Forms.Label label_prod;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.Button butt_all;
        private System.Windows.Forms.Button butt_filter;
        private System.Windows.Forms.ComboBox comboBox_data;
        private System.Windows.Forms.Label label_details;
        private System.Windows.Forms.Label label_nameDet;
        private System.Windows.Forms.Label label_cat;
        private System.Windows.Forms.Label label_hargaDet;
        private System.Windows.Forms.Label label_stockDet;
        private System.Windows.Forms.Label label_nameCat;
        private System.Windows.Forms.TextBox textBox_nameCat;
        private System.Windows.Forms.TextBox textBox_nameDet;
        private System.Windows.Forms.TextBox textBox_hargaDet;
        private System.Windows.Forms.TextBox textBox_stockDet;
        private System.Windows.Forms.Button butt_removeCategory;
        private System.Windows.Forms.Button butt_addCategory;
        private System.Windows.Forms.Button butt_addProduct;
        private System.Windows.Forms.Button butt_removeProduct;
        private System.Windows.Forms.Button butt_editProduct;
        private System.Windows.Forms.ComboBox comboBox_cat;
    }
}

