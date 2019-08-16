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

            CostOrderDataLabel.Text = Program.productInfo.Cost;


            ConditionOrderDataLabel.Text = Program.productInfo.Condition;
            PlatformOrderDataLabel.Text = Program.productInfo.Platform;
            ManufacuterOrderDataLabel.Text = Program.productInfo.manufactuer;
            OSOrderDataLabel.Text = Program.productInfo.OS;

            ModelOrderDataLabel.Text = Program.productInfo.Model;
            MemoryOrderDataLabel.Text = Program.productInfo.Memory;
            CPUBrandOrderDataLabel.Text = Program.productInfo.CPUBrand;
            CPUTyprOrderDataLabel.Text = Program.productInfo.CPUType;
            LCDOrderDataLabel.Text = Program.productInfo.LCD;

            CPUNumOrderDataLabel.Text = Program.productInfo.CPUNumber;
            CPUSpeedOrderDataLabel.Text = Program.productInfo.CPUSpeed;
            HDDOrderDataLabel.Text = Program.productInfo.HDD;
            GPUTypeOrderDataLabel.Text = Program.productInfo.GPUType;
            WebCamOrderDataLabel.Text = Program.productInfo.WebCam;
        }
    }
}
