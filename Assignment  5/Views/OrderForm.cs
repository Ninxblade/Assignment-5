using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Jason Li 
/// 301012468 
/// Order Form to display what the user has selected and display after tax price
/// </summary>
namespace Assignment__5.Views
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
            ProductPrintForm.Print();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            Program.orderForm.Hide();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.orderForm.Hide();
            Program.aboutForm.Show();
        }

        private void Label16_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {

            CostOrderDataLabel.Text = Program.product.cost.ToString();
            SalesTaxOrderDataLabel.Text = Program.productInfo.salesReturn.ToString();
            TotalOrderDataLabel.Text = Program.productInfo.totalReturn.ToString();

            ConditionOrderDataLabel.Text = Program.product.condition;
            PlatformOrderDataLabel.Text = Program.product.platform;
            ManufacuterOrderDataLabel.Text = Program.product.manufacturer;
            OSOrderDataLabel.Text = Program.product.OS;

            ModelOrderDataLabel.Text = Program.product.model;
            MemoryOrderDataLabel.Text = Program.product.RAM_size;
            CPUBrandOrderDataLabel.Text = Program.product.CPU_brand;
            CPUTyprOrderDataLabel.Text = Program.product.CPU_type;
            LCDOrderDataLabel.Text = Program.product.screensize;

            CPUNumOrderDataLabel.Text = Program.product.CPU_number;
            CPUSpeedOrderDataLabel.Text = Program.product.CPU_speed;
            HDDOrderDataLabel.Text = Program.product.HDD_size;
            GPUTypeOrderDataLabel.Text = Program.product.GPU_Type;
            WebCamOrderDataLabel.Text = Program.product.webcam;
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            string message = "Thank you,for submitting your application.\n Your order will be processing within 7-10 days. ";
            MessageBox.Show(message);
            Application.Exit();
        }
    }
}
