using Assignment__5.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment__5.Views
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            if (!HasLoadedDataSource())
            {
                MessageBox.Show("DataSource Not Loaded", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Hide();
            Program.productInfoForm.Show();
        }
        public bool HasLoadedDataSource()
        {
            using (var db = new DollarComputersContext())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();
                if (productBindingSource.DataSource != null)
                {
                    return true;
                }
            }

            return false;
        }
        public string ProductDataGridViewSelectedItem()
        {
            var rowIndex = ProductDataGridView.CurrentCell.RowIndex;
            var currentRow = ProductDataGridView.Rows[rowIndex];
            var cost = currentRow.Cells[1].Value.ToString();
            var costDecimal = decimal.Parse(cost);
         
            double  tax = 0.13;
            decimal calsalesTotal = costDecimal * (decimal)tax;
            decimal calFinalTotal = calsalesTotal + costDecimal;


            var productID = currentRow.Cells[0].Value.ToString();
            var manufacturer = currentRow.Cells[2].Value.ToString();
            var model = currentRow.Cells[3].Value.ToString();
            var screenSize = currentRow.Cells[7].Value.ToString();

            var memory = currentRow.Cells[5].Value.ToString();
            var CPU_Brand = currentRow.Cells[10].Value.ToString();
            var CPU_Type = currentRow.Cells[11].Value.ToString();
            var CPU_Speed = currentRow.Cells[12].Value.ToString();

            var CPU_Num = currentRow.Cells[13].Value.ToString();
            var condition = currentRow.Cells[14].Value.ToString();
            var OS = currentRow.Cells[15].Value.ToString();
            var Platform = currentRow.Cells[16].Value.ToString();

            var HDD_Size = currentRow.Cells[17].Value.ToString();
            var GPU_Type = currentRow.Cells[19].Value.ToString();
            var webcam = currentRow.Cells[30].Value.ToString();

            string outputString = manufacturer + " " + model + " " + cost;
            var newProductID = short.Parse(productID);
            Program.product.productID = newProductID;
            Program.productInfo.salesReturn = calsalesTotal.ToString("C2");
            Program.productInfo.totalReturn = calFinalTotal.ToString("C2");
            Program.product.cost = costDecimal;
            Program.product.condition = condition;

            Program.product.platform = Platform;
            Program.product.manufacturer = manufacturer;
            Program.product.OS = OS;
            Program.product.model = model;

            Program.product.RAM_size = memory;
            Program.product.CPU_brand = CPU_Brand;
            Program.product.CPU_type = CPU_Type;

            Program.product.screensize = screenSize;
            Program.product.CPU_number = CPU_Num;
            Program.product.CPU_speed = CPU_Speed;

            Program.product.HDD_size = HDD_Size;
            Program.product.GPU_Type = GPU_Type;
            Program.product.webcam = webcam;

            return outputString;
        }

        private void ProductDataGridView_SelectionChanged(object sender, EventArgs e)
        {

            SelectLabel.Text = ProductDataGridViewSelectedItem();
      
        }

        private void SelectLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
