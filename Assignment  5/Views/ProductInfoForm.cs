using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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


            ManufactuerDataLabel.Text = Program.selectForm.ProductDataGridViewSelectedItem();
            ProductIDDataLabel.Text = Program.productInfo.ProductID.ToString();
            ConditionDataLabel.Text = Program.productInfo.Condition;
            CostDataLabel.Text = Program.productInfo.Cost.ToString();

            PlatformDataLabel.Text = Program.productInfo.Platform;
            ManufactuerDataLabel.Text = Program.productInfo.manufactuer;
            OSDataLabel.Text = Program.productInfo.OS;

            ModelDataLabel.Text = Program.productInfo.Model;
            MemoeryDataLabel.Text = Program.productInfo.Memory;
            CPUBrandDataLabel.Text = Program.productInfo.CPUBrand;
            CPUTypeDataLabel.Text = Program.productInfo.CPUType;
            LCDDataLabel.Text = Program.productInfo.LCD;

            CPUNumDataLabel.Text = Program.productInfo.CPUNumber;
            CPUSpeedDataLabel.Text = Program.productInfo.CPUSpeed;
            HDDDataLabel.Text = Program.productInfo.HDD;
            GPUTypeDataLabel.Text = Program.productInfo.GPUType;
            WebCamDataLabel.Text = Program.productInfo.WebCam;

        }


    }
}
