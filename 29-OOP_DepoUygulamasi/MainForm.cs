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

        WarehouseRepository warehouseRepository;

        private void MainForm_Load(object sender, EventArgs e)
        {
            productRepository = new ProductRepository();
            warehouseRepository = new WarehouseRepository();
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
                if (grdProducs.SelectedRows.Count>0)
                {
                    var product = products[grdProducs.SelectedRows[0].Index];//[0. sı bizim double clik yaptığımız]

                    ProductForm myForm = new ProductForm();
                    myForm.Tag = product.Id;//Tanım yapmaya gerek kalmadan diğer forma bilgi gönderdik.
                    myForm.ShowDialog();
                    RefreshProducts();
                }
               
            }
            catch (Exception ex)
            {

                Utility.ShowErrorMessage(ex.Message);
            }
            
        }

        private void btnWharehouse_Click(object sender, EventArgs e)
        {
            WharehouseForm form = new WharehouseForm();
            form.ShowDialog();
            RefreshWarehouse();
        }
        public void RefreshWarehouse()
        {
            grdWarehouse.DataSource = null;
            grdWarehouse.DataSource = warehouseRepository.Get();
        }

        private void grdWarehouse_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var items = grdWarehouse.DataSource as List<Warehouse>;
                if (grdWarehouse.SelectedRows.Count>0)
                {
                    var warehouse = items[grdWarehouse.SelectedRows[0].Index];
                    WharehouseForm form = new WharehouseForm();
                    form.Tag = warehouse.id;//İd forma repositoryden eklerken oluşturulur. Ve bu id açılan yeni açılacak warehouseformun tagine aktarılır ve bu id nosu oraya taşınmış olur.
                    form.ShowDialog();

                    RefreshWarehouse();
                }
            }
            catch (Exception ex)
            {

                Utility.ShowErrorMessage(ex.Message);
            }
        }
    }
}
