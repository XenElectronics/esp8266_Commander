using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWindowsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeCommandList();
            InitializePortBox();
            InitializeBaudRateBox();
            InitializeAdvancedCommandBox();
        }

        private void refreshBtn_Click(object sender, MouseEventArgs e)
        {
            InitializePortBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
