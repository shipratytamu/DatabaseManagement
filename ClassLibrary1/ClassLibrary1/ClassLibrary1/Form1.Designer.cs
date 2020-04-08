namespace ClassLibrary1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConnectToSimulator = new System.Windows.Forms.Button();
            this.PayWithSignatureDeclined = new System.Windows.Forms.Button();
            this.PayWithPinAuthorised = new System.Windows.Forms.Button();
            this.PayWithPinDeclined = new System.Windows.Forms.Button();
            this.PayWithSignatureAuthorized = new System.Windows.Forms.Button();
            this.MerchantReceiptBrowser = new System.Windows.Forms.WebBrowser();
            this.CardholderReceiptBrowser = new System.Windows.Forms.WebBrowser();
            this.MerchantReceiptLabel = new System.Windows.Forms.Label();
            this.CardholderReceiptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConnectToSimulator
            // 
            this.ConnectToSimulator.Location = new System.Drawing.Point(41, 30);
            this.ConnectToSimulator.Name = "ConnectToSimulator";
            this.ConnectToSimulator.Size = new System.Drawing.Size(141, 52);
            this.ConnectToSimulator.TabIndex = 0;
            this.ConnectToSimulator.Text = "Connect to Simulator";
            this.ConnectToSimulator.UseVisualStyleBackColor = true;
            this.ConnectToSimulator.Click += new System.EventHandler(this.ConnectToSimulator_Click);
            // 
            // PayWithSignatureDeclined
            // 
            this.PayWithSignatureDeclined.Location = new System.Drawing.Point(380, 30);
            this.PayWithSignatureDeclined.Name = "PayWithSignatureDeclined";
            this.PayWithSignatureDeclined.Size = new System.Drawing.Size(153, 52);
            this.PayWithSignatureDeclined.TabIndex = 2;
            this.PayWithSignatureDeclined.Text = "Pay With Signature Declined";
            this.PayWithSignatureDeclined.UseVisualStyleBackColor = true;
            this.PayWithSignatureDeclined.Click += new System.EventHandler(this.PayWithSignatureDeclined_Click);
            // 
            // PayWithPinAuthorised
            // 
            this.PayWithPinAuthorised.Location = new System.Drawing.Point(41, 101);
            this.PayWithPinAuthorised.Name = "PayWithPinAuthorised";
            this.PayWithPinAuthorised.Size = new System.Drawing.Size(141, 46);
            this.PayWithPinAuthorised.TabIndex = 3;
            this.PayWithPinAuthorised.Text = "Pay With Pin Authorised";
            this.PayWithPinAuthorised.UseVisualStyleBackColor = true;
            this.PayWithPinAuthorised.Click += new System.EventHandler(this.PayWithPinAuthorised_Click);
            // 
            // PayWithPinDeclined
            // 
            this.PayWithPinDeclined.Location = new System.Drawing.Point(215, 101);
            this.PayWithPinDeclined.Name = "PayWithPinDeclined";
            this.PayWithPinDeclined.Size = new System.Drawing.Size(164, 46);
            this.PayWithPinDeclined.TabIndex = 4;
            this.PayWithPinDeclined.Text = "Pay With Pin Declined";
            this.PayWithPinDeclined.UseVisualStyleBackColor = true;
            this.PayWithPinDeclined.Click += new System.EventHandler(this.PayWithPinDeclined_Click);
            // 
            // PayWithSignatureAuthorized
            // 
            this.PayWithSignatureAuthorized.Location = new System.Drawing.Point(215, 30);
            this.PayWithSignatureAuthorized.Name = "PayWithSignatureAuthorized";
            this.PayWithSignatureAuthorized.Size = new System.Drawing.Size(148, 52);
            this.PayWithSignatureAuthorized.TabIndex = 5;
            this.PayWithSignatureAuthorized.Text = "Pay With Signature Authorized";
            this.PayWithSignatureAuthorized.UseVisualStyleBackColor = true;
            this.PayWithSignatureAuthorized.Click += new System.EventHandler(this.PayWithSignatureAuthorized_Click);
            // 
            // MerchantReceiptBrowser
            // 
            this.MerchantReceiptBrowser.Location = new System.Drawing.Point(129, 196);
            this.MerchantReceiptBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.MerchantReceiptBrowser.Name = "MerchantReceiptBrowser";
            this.MerchantReceiptBrowser.Size = new System.Drawing.Size(250, 195);
            this.MerchantReceiptBrowser.TabIndex = 6;
            // 
            // CardholderReceiptBrowser
            // 
            this.CardholderReceiptBrowser.Location = new System.Drawing.Point(406, 196);
            this.CardholderReceiptBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.CardholderReceiptBrowser.Name = "CardholderReceiptBrowser";
            this.CardholderReceiptBrowser.Size = new System.Drawing.Size(250, 195);
            this.CardholderReceiptBrowser.TabIndex = 7;
            // 
            // MerchantReceiptLabel
            // 
            this.MerchantReceiptLabel.AutoSize = true;
            this.MerchantReceiptLabel.Location = new System.Drawing.Point(141, 207);
            this.MerchantReceiptLabel.Name = "MerchantReceiptLabel";
            this.MerchantReceiptLabel.Size = new System.Drawing.Size(98, 13);
            this.MerchantReceiptLabel.TabIndex = 8;
            this.MerchantReceiptLabel.Text = "Merchant Receipt :";
            this.MerchantReceiptLabel.Click += new System.EventHandler(this.MerchantReceiptLabel_Click);
            // 
            // CardholderReceiptLabel
            // 
            this.CardholderReceiptLabel.AutoSize = true;
            this.CardholderReceiptLabel.Location = new System.Drawing.Point(418, 207);
            this.CardholderReceiptLabel.Name = "CardholderReceiptLabel";
            this.CardholderReceiptLabel.Size = new System.Drawing.Size(98, 13);
            this.CardholderReceiptLabel.TabIndex = 9;
            this.CardholderReceiptLabel.Text = "Cardholder Receipt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CardholderReceiptLabel);
            this.Controls.Add(this.MerchantReceiptLabel);
            this.Controls.Add(this.CardholderReceiptBrowser);
            this.Controls.Add(this.MerchantReceiptBrowser);
            this.Controls.Add(this.PayWithSignatureAuthorized);
            this.Controls.Add(this.PayWithPinDeclined);
            this.Controls.Add(this.PayWithPinAuthorised);
            this.Controls.Add(this.PayWithSignatureDeclined);
            this.Controls.Add(this.ConnectToSimulator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectToSimulator;
        private System.Windows.Forms.Button PayWithSignatureDeclined;
        private System.Windows.Forms.Button PayWithPinAuthorised;
        private System.Windows.Forms.Button PayWithPinDeclined;
        private System.Windows.Forms.Button PayWithSignatureAuthorized;
        private System.Windows.Forms.WebBrowser MerchantReceiptBrowser;
        private System.Windows.Forms.WebBrowser CardholderReceiptBrowser;
        private System.Windows.Forms.Label MerchantReceiptLabel;
        private System.Windows.Forms.Label CardholderReceiptLabel;
    }
}