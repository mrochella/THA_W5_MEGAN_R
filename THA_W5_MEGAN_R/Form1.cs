using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W5_MEGAN_R
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int counting = 0;
        int idNum = 0;
        List<Product> bubu = new List<Product>(); //LIST PRODUK
        List<string> bebe = new List<string>(); //LIST KATEGORI
        DataTable dtProdukSimpan = new DataTable();
        DataTable dtProdukTampil = new DataTable();
        DataTable dtCategory = new DataTable(); 
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Coral;
            dtProdukSimpan.Columns.Add("ID Product");
            dtProdukSimpan.Columns.Add("Nama Product");
            dtProdukSimpan.Columns.Add("Harga");
            dtProdukSimpan.Columns.Add("Stock");
            dtProdukSimpan.Columns.Add("ID Category");
            dgvProdukSimpan.DataSource = dtProdukSimpan;
            dtCategory.Columns.Add("ID Category");
            dtCategory.Columns.Add("Nama Category");
            dgvCategory.DataSource = dtCategory;
            dtProdukTampil.Columns.Add("ID Product");
            dtProdukTampil.Columns.Add("Nama Product");
            dtProdukTampil.Columns.Add("Harga");
            dtProdukTampil.Columns.Add("Stock");
            dtProdukTampil.Columns.Add("ID Category");
            bubu.Add(new Product("Jas Hitam", "100000", "10", "Jas"));
            bubu.Add(new Product("T-Shirt Black Pink", "70000", "20", "T-Shirt"));
            bubu.Add(new Product("T-Shirt Obsessive", "75000", "16", "T-Shirt"));
            bubu.Add(new Product("Rok Mini", "82000", "26", "Rok"));
            bubu.Add(new Product("Jeans Biru", "90000", "5", "Celana"));
            bubu.Add(new Product("Celana Pendek Coklat", "60000", "14", "Celana"));
            bubu.Add(new Product("Cawat Blink-Blink", "100000", "1", "Cawat"));
            bubu.Add(new Product("Rocca Shirt", "50000", "8", "T-Shirt"));

            foreach (Product product in bubu)
            {
                if (bebe.Contains(product.Category) == false)
                {
                    bebe.Add(product.Category);
                    counting++;
                    dtCategory.Rows.Add("C" + counting, product.Category);
                }
            }

            for (int i = 65; i <= 90; i++)
            {
                foreach (Product product in bubu)
                {
                    if (product.Name[0] == Convert.ToChar(i))
                    {
                        idNum++;
                        product.IDProduct = Convert.ToChar(i) + idNum.ToString("000");
                    }
                }
                idNum = 0;
            }
            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                comboBox_cat.Items.Add(dtCategory.Rows[i][1].ToString());
            }
            foreach (Product product in bubu)
            {
                product.CategoryID = generateIDcat(product);
                dtProdukSimpan.Rows.Add(product.IDProduct, product.Name, product.Harga, product.Stock, product.CategoryID);
            }
            comboBox_data.Enabled = false;
        }
        private string generateIDprod(Product product)
        {
            string IDProduct = "";
            for (int i = 65; i <= 90; i++)
            {
                if (product.Name[0] == Convert.ToChar(i))
                {
                    foreach (Product produck in bubu)
                    {
                        if (produck.Name[0] == product.Name[0])
                        {
                            idNum++;
                        }
                    }
                    IDProduct = Convert.ToChar(i) + idNum.ToString("000");
                }
                idNum = 0;
            }
            return IDProduct;
        }
        private string generateIDcat(Product product)
        {
            string categoryID = "";
            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                if (dtCategory.Rows[i][1].ToString() == product.Category)
                {
                    categoryID = dtCategory.Rows[i][0].ToString();
                }
            }
            return categoryID;
        }
        private void butt_addCategory_Click(object sender, EventArgs e)
        {
            counting++;
            if (string.IsNullOrEmpty(textBox_nameCat.Text) == false)
            {
                dtCategory.Rows.Add("C" + counting, textBox_nameCat.Text);
            }
            else
            {
                string msg = "Pls add category's name!";
                MessageBox.Show(msg);
            }
            comboBox_cat.Items.Clear();
            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                comboBox_cat.Items.Add(dtCategory.Rows[i][1].ToString());
            }
        }
        private void butt_all_Click(object sender, EventArgs e)
        {
            comboBox_data.Items.Clear();
            comboBox_data.Enabled = false;
            dgvProdukSimpan.DataSource = dtProdukSimpan;
        }
        private void butt_filter_Click(object sender, EventArgs e)
        {
            comboBox_data.Enabled = true;
            comboBox_data.Items.Clear();
            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                comboBox_data.Items.Add(dtCategory.Rows[i][1].ToString());
            }
        }
        private void comboBox_data_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dgvProdukSimpan.DataSource = dtProdukTampil;
            dtProdukTampil.Rows.Clear();
            foreach (Product product in bubu)
            {
                for (int i = 0; i < dtProdukSimpan.Rows.Count; i++)
                {
                    if (product.Name == dtProdukSimpan.Rows[i][1].ToString() && product.Category == comboBox_data.Text)
                    {
                        dtProdukTampil.Rows.Add(product.IDProduct, product.Name, product.Harga, product.Stock, product.CategoryID);
                    }
                }
            }
        }
        private void butt_addProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_nameDet.Text) == true || string.IsNullOrEmpty(textBox_hargaDet.Text) == true || string.IsNullOrEmpty(textBox_stockDet.Text) == true || string.IsNullOrEmpty(comboBox_cat.Text) == true)
            {
                string msg = "Pls fill all the text boxes!";
                MessageBox.Show(msg);
            }
            else
            {
                Product product = new Product(textBox_nameDet.Text, textBox_hargaDet.Text, textBox_stockDet.Text, comboBox_cat.Text);
                bubu.Add(product);

                product.IDProduct = generateIDprod(product);
                product.CategoryID = generateIDcat(product);
                dtProdukSimpan.Rows.Add(product.IDProduct, product.Name, product.Harga, product.Stock, product.CategoryID);
            }
        }
        private void butt_removeProduct_Click(object sender, EventArgs e)
        {
            dtProdukSimpan.Rows.RemoveAt(dgvProdukSimpan.CurrentCell.RowIndex);
        }
        private void butt_editProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_nameDet.Text) == true || string.IsNullOrEmpty(textBox_hargaDet.Text) == true || string.IsNullOrEmpty(textBox_stockDet.Text) == true || string.IsNullOrEmpty(comboBox_cat.Text) == true)
            {
                string msg = "Pls fill all the text boxes!";
                MessageBox.Show(msg);
            }
            else
            {
                int check = dgvProdukSimpan.CurrentCell.RowIndex;
                string productName = dtProdukSimpan.Rows[check][1].ToString();
                foreach (Product product in bubu)
                {
                    if (productName == product.Name)
                    {
                        product.Name = textBox_nameDet.Text; //NGEDIT NAMA
                        product.Category = comboBox_cat.Text;
                        product.Harga = textBox_hargaDet.Text;
                        product.Stock = textBox_stockDet.Text;
                        product.IDProduct = generateIDprod(product);
                        product.CategoryID = generateIDcat(product);
                        dtProdukSimpan.Rows.Clear();
                        foreach (Product produk in bubu)
                        {
                            dtProdukSimpan.Rows.Add(produk.IDProduct, produk.Name, produk.Harga, produk.Stock, produk.CategoryID);
                        }
                    }
                }
            }
            textBox_nameDet.Text = "";
            comboBox_cat.SelectedIndex = -1;
            textBox_hargaDet.Text = "";
            textBox_stockDet.Text = "";
        }
        private void dgvProdukSimpan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvProdukSimpan.CurrentCell.RowIndex;
            foreach (Product product in bubu)
            {
                if (dgvProdukSimpan.CurrentRow.Cells["Nama Product"].Value.ToString() == product.Name)
                {
                    textBox_nameDet.Text = product.Name;
                    comboBox_cat.Text = product.Category;
                    textBox_hargaDet.Text = product.Harga;
                    textBox_stockDet.Text = product.Stock;
                }
            }
        }
        private void butt_removeCategory_Click(object sender, EventArgs e)
        {
            int index = dgvProdukSimpan.CurrentCell.RowIndex;
            string removedCatID = dtCategory.Rows[index][0].ToString();
            for (int i = 0; i < dtProdukSimpan.Rows.Count; i++)
            {
                if (dtProdukSimpan.Rows[i][4].ToString() == removedCatID)
                {
                    dtProdukSimpan.Rows.RemoveAt(i);
                }
            }
            dtCategory.Rows.RemoveAt(index);
        }
    }
}

