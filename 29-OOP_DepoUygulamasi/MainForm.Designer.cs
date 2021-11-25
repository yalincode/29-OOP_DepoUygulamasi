
namespace _29_OOP_DepoUygulamasi
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnWharehouseOut = new System.Windows.Forms.Button();
            this.btnWharehouseIn = new System.Windows.Forms.Button();
            this.btnWharehouse = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grdProducs = new System.Windows.Forms.DataGridView();
            this.grdWarehouse = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdWarehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnWharehouseOut);
            this.panel1.Controls.Add(this.btnWharehouseIn);
            this.panel1.Controls.Add(this.btnWharehouse);
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 78);
            this.panel1.TabIndex = 0;
            // 
            // btnWharehouseOut
            // 
            this.btnWharehouseOut.Location = new System.Drawing.Point(265, 25);
            this.btnWharehouseOut.Name = "btnWharehouseOut";
            this.btnWharehouseOut.Size = new System.Drawing.Size(75, 23);
            this.btnWharehouseOut.TabIndex = 3;
            this.btnWharehouseOut.Text = "Depo Çıkış";
            this.btnWharehouseOut.UseVisualStyleBackColor = true;
            // 
            // btnWharehouseIn
            // 
            this.btnWharehouseIn.Location = new System.Drawing.Point(184, 25);
            this.btnWharehouseIn.Name = "btnWharehouseIn";
            this.btnWharehouseIn.Size = new System.Drawing.Size(75, 23);
            this.btnWharehouseIn.TabIndex = 2;
            this.btnWharehouseIn.Text = "Depo Giriş";
            this.btnWharehouseIn.UseVisualStyleBackColor = true;
            // 
            // btnWharehouse
            // 
            this.btnWharehouse.Location = new System.Drawing.Point(103, 25);
            this.btnWharehouse.Name = "btnWharehouse";
            this.btnWharehouse.Size = new System.Drawing.Size(75, 23);
            this.btnWharehouse.TabIndex = 1;
            this.btnWharehouse.Text = "Depo Tanımı";
            this.btnWharehouse.UseVisualStyleBackColor = true;
            this.btnWharehouse.Click += new System.EventHandler(this.btnWharehouse_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(22, 25);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(75, 23);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Text = "Ürün Tanımı";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 78);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(517, 432);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grdProducs);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(509, 406);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ürünler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grdWarehouse);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(509, 406);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Depo Tanımlamaları";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grdProducs
            // 
            this.grdProducs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProducs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProducs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdProducs.Location = new System.Drawing.Point(3, 3);
            this.grdProducs.MultiSelect = false;
            this.grdProducs.Name = "grdProducs";
            this.grdProducs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProducs.Size = new System.Drawing.Size(503, 400);
            this.grdProducs.TabIndex = 0;
            this.grdProducs.DoubleClick += new System.EventHandler(this.grdProducs_DoubleClick);
            // 
            // grdWarehouse
            // 
            this.grdWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdWarehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdWarehouse.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdWarehouse.Location = new System.Drawing.Point(3, 3);
            this.grdWarehouse.MultiSelect = false;
            this.grdWarehouse.Name = "grdWarehouse";
            this.grdWarehouse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdWarehouse.Size = new System.Drawing.Size(503, 400);
            this.grdWarehouse.TabIndex = 1;
            this.grdWarehouse.DoubleClick += new System.EventHandler(this.grdWarehouse_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 510);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depo Uygulaması";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProducs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdWarehouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnWharehouseOut;
        private System.Windows.Forms.Button btnWharehouseIn;
        private System.Windows.Forms.Button btnWharehouse;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView grdProducs;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView grdWarehouse;
    }
}

