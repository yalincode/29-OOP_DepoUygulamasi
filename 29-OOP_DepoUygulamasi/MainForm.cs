using _29_OOP_DepoUygulamasi.DAL;
using _29_OOP_DepoUygulamasi.Entities;
using _29_OOP_DepoUygulamasi.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29_OOP_DepoUygulamasi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        ProductRepository productRepository;
        private void MainForm_Load(object sender, EventArgs e)
        {
            productRepository = new ProductRepository();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
            RefreshProducts();
        }

        public void RefreshProducts()
        {
            grdProducs.DataSource = null;
            grdProducs.DataSource = productRepository.Get();
        }

        private void grdProducs_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var products = (grdProducs.DataSource as List<Product>);
                var product = products[grdProducs.SelectedRows[0].Index];//[0. sı bizim double clik yaptığımız]

                ProductForm myForm = new ProductForm();
                myForm.Tag = product.Id;//Tanım yapmaya gerek kalmadan diğer forma bilgi gönderdik.
                myForm.ShowDialog();
            }
            catch (Exception ex)
            {

                Utility.ShowErrorMessage(ex.Message);
            }
            
        }
    }
}
