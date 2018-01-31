using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VbplBilling.Users;

namespace VbplBilling.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            userList1.BringToFront();
        }

        private void userControlButton_Click(object sender, EventArgs e)
        {
            userList1.BringToFront();

        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
           clientAddedControll1.BringToFront();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            
            testcontroll1.BringToFront();
        }

        private void persentStockButton_Click(object sender, EventArgs e)
        {
            presentStockControll1.BringToFront();
        }
    }
}
