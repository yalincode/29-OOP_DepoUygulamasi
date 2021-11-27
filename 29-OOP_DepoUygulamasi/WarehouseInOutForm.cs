using _29_OOP_DepoUygulamasi.Core;
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
    public partial class WarehouseInOutForm : Form
    {
        public WarehouseInOutForm()
        {
            InitializeComponent();
        }

        WarehouseRepository warehouseRepository;
        ProductRepository productRepository;
        FichMasterRepository fichMasterRepository;

        private void WarehouseInOutForm_Load(object sender, EventArgs e)
        {
            warehouseRepository = new WarehouseRepository();
            productRepository = new ProductRepository();
            fichMasterRepository = new FichMasterRepository();
            
            FillForm();
            FillData();
        }

        private void FillData()
        {
            try
            {
                int id = Convert.ToInt32(this.Tag);
                if (id>0)
                {
                    FichMaster fichMaster = fichMasterRepository.FindById(id);
                    if (fichMaster!=null)
                    {
                        txtCompanyName.Text = fichMaster.CompanyName;
                        txtFisNumber.Text = fichMaster.TaxNumber;
                        txtTaxNember.Text = fichMaster.TaxNumber;
                        dtDate.Value = fichMaster.Date;
                        cmbWarehouseOut.SelectedIndex = FindWarehouseOutIndex(fichMaster.WarehouseOut);
                        cmbWarehouseIn.SelectedIndex = FindWareHouseInIndex(fichMaster.WarehouseIn);
                    }
                }
               
            }
            catch (Exception ex)
            {

                Utility.ShowErrorMessage(ex.Message);
            }
        }

        private void FillForm()
        {
            FillWarehouseIn();
            FillWarehouseOut();
            FillProducts();
        }

        private void FillProducts()
        {
            cmbProduct.Items.Clear();
            cmbProduct.Items.Insert(0, "Seçiniz");
            List<Product> products = new List<Product>();
            foreach (var product in products)
            {
                cmbProduct.Items.Add(product);
            }
            cmbProduct.SelectedIndex = 0;
        }

        private void FillWarehouseOut()
        {
            cmbWarehouseOut.Items.Clear();
            cmbWarehouseOut.Items.Insert(0, "Seçiniz");
            List<Warehouse> warehouses = warehouseRepository.Get();
            foreach (var warehouse in warehouses)
            {
                cmbWarehouseOut.Items.Add(warehouse);
            }
            cmbWarehouseOut.SelectedIndex = 0;
        }

        private int FindWarehouseOutIndex(int id) 
        {
            int index = 0;

            for (int i = 0; i < cmbWarehouseOut.Items.Count; i++)
            {
                var warehouse = (cmbWarehouseOut.Items[i] as Warehouse);
                if (warehouse!=null)
                {
                    if (warehouse.id == id)
                    {
                        index = i;
                        break;
                    }
                }
                
            }
            return index;
        }//ComboBox ın seçili olması için yapıyoruz update sırasında.
        private int FindWareHouseInIndex(int id)
        {
            int index = 0;
            for (int i = 0; i < cmbWarehouseIn.Items.Count; i++)
            {
                var warehouse = cmbWarehouseIn.Items[i] as Warehouse;
                if (warehouse!=null)
                {
                    if (warehouse.id==id)
                    {
                        index = i;
                        break;
                    }
                }
            }
            return index;
        }//ComboBox ın seçili olarak gelmesi Update sırasında.

        private void FillWarehouseIn()
        {
            cmbWarehouseIn.Items.Clear();
            cmbWarehouseIn.Items.Insert(0,"Seçiniz");


            List<Warehouse> warehouses = warehouseRepository.Get();
            foreach (var warehouse in warehouses)
            {
                cmbWarehouseIn.Items.Add(warehouse);
            }
            cmbWarehouseIn.SelectedIndex = 0;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormClear(this);
        }

        private void FormClear(Control control)
        {
            foreach (var item in control.Controls)
            {
                if (item is Panel)
                {
                    FormClear(item as Control);
                }
                else if (item is TextBox)
                {
                    (item as TextBox).Clear();
                }
                else if (item is ComboBox)
                {
                    (item as ComboBox).SelectedIndex = 0;
                }
                else if (item is DateTimePicker)
                {
                    (item as DateTimePicker).Value = DateTime.Now;
                }
                else if (item is NumericUpDown)
                {
                    (item as NumericUpDown).Value = 0;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                FichMaster fichMaster = new FichMaster();
                fichMaster.Id = Convert.ToInt32(this.Tag);
                fichMaster.CompanyName = txtCompanyName.Text;
                fichMaster.FichNumber = txtFisNumber.Text;
                fichMaster.TaxNumber = txtTaxNember.Text;
                fichMaster.Date = dtDate.Value;
                if (cmbWarehouseIn.SelectedIndex > 0)
                {
                    fichMaster.WarehouseIn = (cmbWarehouseIn.SelectedItem as Warehouse).id;
                }
                if (cmbWarehouseOut.SelectedIndex > 0)
                {
                    fichMaster.WarehouseOut = (cmbWarehouseOut.SelectedItem as Warehouse).id;
                }

                if (fichMaster.Id == 0)
                {
                    //İnsert işlemi
                    fichMasterRepository.Add(fichMaster);
                }
                else
                {
                    //Update işlemi
                    fichMasterRepository.Update(fichMaster);
                }
                Utility.ShowSuccessMessage(ConstMessages.RecordSuccessMessage);
            }
            catch (Exception ex)
            {

                Utility.ShowSuccessMessage(ex.Message);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(this.Tag);
                if (id>0)
                {
                    var result = Utility.ShowDialogResultInformationMessage(ConstMessages.RecordDeleteQuestionMessage);
                    if (result==DialogResult.OK)
                    {
                        fichMasterRepository.Delete(id);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                Utility.ShowErrorMessage(ex.Message);
            }
        }
    }
}
