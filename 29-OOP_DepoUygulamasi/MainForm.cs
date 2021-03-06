using _29_OOP_DepoUygulamasi.DAL;
using _29_OOP_DepoUygulamasi.DTO_DataTransferObject_.VM;
using _29_OOP_DepoUygulamasi.Entities;
using _29_OOP_DepoUygulamasi.FakeDb;
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

        FichMasterRepository fichMasterRepository;

        private void MainForm_Load(object sender, EventArgs e)
        {
            DummyData.Seed();//Örnek olması için içeriye depo ve ürünler basılıyor.
            
            productRepository = new ProductRepository();
            warehouseRepository = new WarehouseRepository();
            fichMasterRepository = new FichMasterRepository();

            FillData();
        }

        private void FillData()
        {
            RefreshProducts();
            RefreshWarehouse();
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

        private void btnWharehouseIn_Click(object sender, EventArgs e)
        {
            var form = new WarehouseInOutForm();
            form.ShowDialog();
            RefreshWarehouseInOutGrid();
        }

        public void RefreshWarehouseInOutGrid()
        {
            grdWarehouseInOut.DataSource = null;
            grdWarehouseInOut.DataSource = GetVmFichMaster(fichMasterRepository.Get());
            GridWarehouseInOutColumnVisibility();
        }

        private void GridWarehouseInOutColumnVisibility()
        {
            //Kapatalıcak kolonları yaptık.
            grdWarehouseInOut.Columns["Id"].Visible = false;
            grdWarehouseInOut.Columns["WarehouseInId"].Visible = false;
            grdWarehouseInOut.Columns["WarehouseOutId"].Visible = false;

            //Harder Text Bilgilerini ayarladık.
            grdWarehouseInOut.Columns["CompanyName"].HeaderText = "Şirket Adı";
            grdWarehouseInOut.Columns["TaxNumber"].HeaderText = "VKN";
            grdWarehouseInOut.Columns["Date"].HeaderText = "Tarih";
            grdWarehouseInOut.Columns["FichNumber"].HeaderText = "Fiş Numarası";
            grdWarehouseInOut.Columns["WarehouseInName"].HeaderText = "Giriş Deposu";
            grdWarehouseInOut.Columns["WarehouseOutName"].HeaderText = "Çıkış Deposu";
        }

        public List<VMFichMaster> GetVmFichMaster(List<FichMaster> fiches)
        {
            List<VMFichMaster> vMFichMasters = new List<VMFichMaster>();
            foreach (var item in fiches)
            {
                var vMFichMaster = new VMFichMaster();
                vMFichMaster.CompanyName = item.CompanyName;
                vMFichMaster.Date = item.Date;
                vMFichMaster.FichNumber = item.FichNumber;
                vMFichMaster.Id = item.Id;
                vMFichMaster.TaxNumber = item.TaxNumber;
                vMFichMaster.WarehouseInId = item.WarehouseIn;
                vMFichMaster.WarehouseInName = warehouseRepository.FindById(item.WarehouseIn) ?. WarehouseName;//Null dan farklıysa soru işaretinden sonrasına devam et.
                vMFichMaster.WarehouseOutId = item.WarehouseOut;
                vMFichMaster.WarehouseOutName = warehouseRepository.FindById(item.WarehouseOut)?.WarehouseName;

                vMFichMasters.Add(vMFichMaster);
            }
            return vMFichMasters;
        }

        private void grdWarehouseInOut_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var items = grdWarehouseInOut.DataSource as List<VMFichMaster>;//Amaç database e gitmeden halletmek. Database i yormamak.
                if (grdWarehouseInOut.SelectedRows.Count>0)
                {
                    int index = grdWarehouseInOut.SelectedRows[0].Index;
                    int id = items[index].Id;
                    WarehouseInOutForm form = new WarehouseInOutForm();
                    form.Tag = id;
                    form.ShowDialog();

                    RefreshWarehouseInOutGrid();
                }
            }
            catch (Exception ex)
            {

                Utility.ShowErrorMessage(ex.Message);
            }
        }
    }
}
