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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        ProductRepository repository;

        private void ProductForm_Load(object sender, EventArgs e)
        {
            repository = new ProductRepository();
            FillData();
        }

        private void FillData()
        {
            try
            {
                int id = Convert.ToInt32(this.Tag);
                if (id>0)
                {
                    Product product = repository.FindById(id);
                    if (product!=null)
                    {
                        txtProductCode.Text = product.ProductCode;
                        txtProductName.Text = product.ProductName;
                        txtAciklama.Text = product.Description;
                        nudPrice.Value = product.Price;
                    }
                }

            }
            catch (Exception ex)
            {

                Utility.ShowErrorMessage(ex.Message);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();
                product.ProductCode = txtProductCode.Text;
                product.ProductName = txtProductName.Text;
                product.Price = nudPrice.Value;
                product.Description = txtAciklama.Text;

                repository.Add(product);
                Utility.ShowSuccessMessage("Kayıt başarılı bir şekilde yapıldı.");
                this.Close();
            }
            catch (Exception ex)
            {

                Utility.ShowErrorMessage(ex.Message);
            }
            

        }

       
    }
}
