using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Jason Li    
/// 301012468   
/// Splash do have an event to let the user know something is appering after
/// </summary>
namespace Assignment__5.Views
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            
            Program.splashForm.Hide();
            Program.startForm.Show();
            SplashTimer.Enabled = false;
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }

       
    }
}
