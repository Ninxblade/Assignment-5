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
/// <summary>
/// Jason Li
/// 301012468
/// Form after splash, allows the user to select what to do with the application
/// </summary>
namespace Assignment__5.Views
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartOrderButton_Click(object sender, EventArgs e)
        {
            Program.startForm.Hide();
            Program.selectForm.Show();
        }

        private void Exitlbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenSavedOrderButton_Click(object sender, EventArgs e)
        {
            StartOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            StartOpenFileDialog.FileName = "Product.txt";
            StartOpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            var productID = Program.product.productID.ToString();
            var cost = Program.product.cost.ToString();
            var result = StartOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                // open a stream to write
                using (StreamReader intputStream = new StreamReader(
                    File.Open(StartOpenFileDialog.FileName, FileMode.Open)))
                {

                    // write stuff to the file
                    productID = intputStream.ReadLine();
                    Program.product.condition = intputStream.ReadLine();
                    cost = intputStream.ReadLine();
                    Program.product.platform = intputStream.ReadLine();
                    Program.product.OS = intputStream.ReadLine();
                    Program.product.manufacturer = intputStream.ReadLine();
                    Program.product.model = intputStream.ReadLine();
                    Program.product.RAM_size = intputStream.ReadLine();
                    Program.product.CPU_brand = intputStream.ReadLine(); ;
                    Program.product.CPU_type = intputStream.ReadLine();

                    Program.product.screensize = intputStream.ReadLine();
                    Program.product.CPU_number = intputStream.ReadLine();
                    Program.product.CPU_speed = intputStream.ReadLine();
                    Program.product.HDD_size = intputStream.ReadLine();
                    Program.product.GPU_Type = intputStream.ReadLine();
                    Program.product.webcam = intputStream.ReadLine();

                    // cleanup
                    intputStream.Close();
                    intputStream.Dispose();
                }
            }
            Program.startForm.Hide();
            Program.productInfoForm.Show();
        }

        private void StartOpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
          
        }
    }
}
