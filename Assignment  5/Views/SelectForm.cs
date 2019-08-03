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
            var costDecimal = Decimal.Parse(cost);

            cost = costDecimal.ToString("C2");

            var manufacturer = currentRow.Cells[2].Value.ToString();
            var model = currentRow.Cells[3].Value.ToString();

            string outputString = manufacturer + " " + model + " " + cost;

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
