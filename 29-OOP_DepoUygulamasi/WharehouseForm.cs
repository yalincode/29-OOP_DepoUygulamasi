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
    public partial class WharehouseForm : Form
    {
        public WharehouseForm()
        {
            InitializeComponent();
        }

        WarehouseRepository repository;
        private void WharehouseForm_Load(object sender, EventArgs e)
        {
            repository = new WarehouseRepository();
            FillData();
        }

        private void FillData()
        {
            try
            {
                int id = Convert.ToInt32(this.Tag);
                if (id > 0)
                {
                    var warehouse = repository.FindById(id);
                    if (warehouse != null)
                    {
                        txtDescription.Text = warehouse.Description;
                        txtWharehouseName.Text = warehouse.WarehouseName;
                    }
                }
            }
            catch (Exception ex)
            {
                Utility.ShowErrorMessage(ex.Message);
                
            }
            
        }

        public void FormClear()
        {
            txtDescription.Text = "";
            txtWharehouseName.Text = "";
            this.Tag = 0;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormClear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var item = new Warehouse();
                item.id = Convert.ToInt32(this.Tag);
                item.WarehouseName = txtWharehouseName.Text;
                item.Description = txtDescription.Text;
                if (item.id == 0)
                {
                    repository.Add(item);
                }
                else
                {
                    repository.Update(item);
                }
                Utility.ShowSuccessMessage(ConstMessages.RecordSuccessMessage);
                this.Close();
            }
            catch (Exception ex)
            {

                Utility.ShowErrorMessage(ex.Message);
            }
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(this.Tag);
                if (id>0)
                {
                    var result = Utility.ShowDialogResultInformationMessage(ConstMessages.RecordDeleteQuestionMessage);
                    if (result==DialogResult.OK)
                    {
                        repository.Delete(id);
                        Utility.ShowSuccessMessage(ConstMessages.RecordSuccessMessage);
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
