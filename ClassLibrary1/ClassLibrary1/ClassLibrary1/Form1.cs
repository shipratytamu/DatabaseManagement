using GettingStartedWithSimulator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public partial class Form1 : Form
    {
        MyClass my;
        public Form1()
        {
            InitializeComponent();
            my = new MyClass(this);
        }

        private void MerchantReceiptLabel_Click(object sender, EventArgs e)
        {

        }

        private void ConnectToSimulator_Click(object sender, EventArgs e)
        {
            my.Connect();
        }

        private void PayWithSignatureAuthorized_Click(object sender, EventArgs e)
        {
            my.PayWithSignatureAuthorized();
        }

        private void PayWithSignatureDeclined_Click(object sender, EventArgs e)
        {
            my.PayWithSignatureDeclined();
        }

        private void PayWithPinAuthorised_Click(object sender, EventArgs e)
        {
            my.PayWithPinAuthorized();
        }

        private void PayWithPinDeclined_Click(object sender, EventArgs e)
        {
            my.PayWithPinDeclined();
        }

        public delegate void UpdateReceiptsCallback(string MerchantReceipt, string CustomerReceipt);
        public void DisplayReceipts(string MerchantReceipt, string CustomerReceipt)
        {
            //Only need to check for one of the webBrowsers
            if (MerchantReceiptBrowser.InvokeRequired)
            {
                UpdateReceiptsCallback d = new UpdateReceiptsCallback(DisplayReceipts);
                this.Invoke(d, new object[] { MerchantReceipt, CustomerReceipt });
            }
            else
            {
                MerchantReceiptBrowser.DocumentText = MerchantReceipt;
                CardholderReceiptBrowser.DocumentText = CustomerReceipt;
            }
        }
    }
}
