using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment__5.Views
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Hide();
            Program.orderForm.Show();
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectAnotherpProductButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            Program.productInfoForm.Hide();
        }

        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            ProductIDDataLabel.Text = Program.product.productID.ToString();
            ConditionDataLabel.Text = Program.product.condition;
            CostDataLabel.Text = Program.product.cost.ToString();

            PlatformDataLabel.Text = Program.product.platform;
            ManufactuerDataLabel.Text = Program.product.manufacturer;
            OSDataLabel.Text = Program.product.OS;

            ModelDataLabel.Text = Program.product.model;
            MemoeryDataLabel.Text = Program.product.RAM_size;
            CPUBrandDataLabel.Text = Program.product.CPU_brand;
            CPUTypeDataLabel.Text = Program.product.CPU_type;
            LCDDataLabel.Text = Program.product.screensize;

            CPUNumDataLabel.Text = Program.product.CPU_number;
            CPUSpeedDataLabel.Text = Program.product.CPU_speed;
            HDDDataLabel.Text = Program.product.HDD_size;
            GPUTypeDataLabel.Text = Program.product.GPU_Type;
            WebCamDataLabel.Text = Program.product.webcam;
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configuration for saveFileDialog
            ProductsaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductsaveFileDialog.FileName = "Product.txt";
            ProductsaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";


            var result = ProductsaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                // open a stream to write
                using (StreamWriter outputStream = new StreamWriter(
                    File.Open(ProductsaveFileDialog.FileName, FileMode.Create)))
                {

                    // write stuff to the file
                    outputStream.WriteLine(Program.product.productID);
                    outputStream.WriteLine(Program.product.condition);
                    outputStream.WriteLine(Program.product.cost);
                    outputStream.WriteLine(Program.product.platform);
                    outputStream.WriteLine(Program.product.OS);
                    outputStream.WriteLine(Program.product.manufacturer);
                    outputStream.WriteLine(Program.product.model);
                    outputStream.WriteLine(Program.product.RAM_size);
                    outputStream.WriteLine(Program.product.CPU_brand);
                    outputStream.WriteLine(Program.product.CPU_type);

                    outputStream.WriteLine(Program.product.screensize);
                    outputStream.WriteLine(Program.product.CPU_number);
                    outputStream.WriteLine(Program.product.CPU_speed);
                    outputStream.WriteLine(Program.product.HDD_size);
                    outputStream.WriteLine(Program.product.GPU_Type);
                    outputStream.WriteLine(Program.product.webcam);

                    // cleanup
                    outputStream.Close();
                    outputStream.Dispose();
                }
                MessageBox.Show("File Saved Successfully!", "Saving...",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
