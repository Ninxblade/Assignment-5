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
            Program.startForm.Hide();
            Program.productInfoForm.Show();
        }
    }
}
