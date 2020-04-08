using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using ClassLibrary1;
using com.handpoint.api;

namespace GettingStartedWithSimulator
{
    class MyClass : Events.Required
    {
        Hapi api;
        private Form1 UIClass;
        public MyClass(Form1 form1)
        {
            InitApi();
            UIClass = form1;
        }

        public void InitApi()
        {
            string sharedSecret = "0102030405060708091011121314151617181920212223242526272829303132";
            api = HapiFactory.GetAsyncInterface(this).DefaultSharedSecret(sharedSecret);
            // The api is now initialized. Yay! we've even set a default shared secret!
            // The shared secret is a unique string shared between the card reader and your mobile application.
            // It prevents other people to connect to your card reader.
        }

        public void DeviceDiscoveryFinished(List<Device> devices)
        {
            // Only needed when using a payment terminal
            //Here you get a list of Bluetooth payment terminals paired with your PC
            // You can also get a list of serial / USB payment terminals attached to your computer

        }

        public void Connect()
        {
            Device device = new Device("Name", "Address", "Port", ConnectionMethod.SIMULATOR);
            api.UseDevice(device);
        }

        public bool PayWithSignatureAuthorized()
        {
            return api.Sale(new BigInteger(10000), Currency.GBP);
            // amount X00XX where X represents an integer [0;9] --> Signature authorized
        }

        public bool PayWithSignatureDeclined()
        {
            return api.Sale(new BigInteger(10100), Currency.GBP);
            // amount X01XX where X represents an integer [0;9] --> Signature declined
        }

        public bool PayWithPinAuthorized()
        {
            return api.Sale(new BigInteger(11000), Currency.GBP);
            // amount X10XX where X represents an integer [0;9] --> PIN authorized
        }
        public bool PayWithPinDeclined()
        {
            return api.Sale(new BigInteger(11100), Currency.GBP);
            // amount X11XX where X represents an integer [0;9] --> PIN declined
        }

        public void SignatureRequired(SignatureRequest signatureRequest, Device device)
        {
            // You'll be notified here if a sale process needs a signature verification
            // A signature verification is needed if the cardholder uses an MSR or a chip & signature card
            // This method will not be invoked if a transaction is made with a Chip & PIN card

            api.SignatureResult(true); // This line means that the cardholder ALWAYS accepts to sign the receipt.
                                       // A specific line will be displayed on the merchant receipt for the cardholder to be able to sign it
        }

        public void EndOfTransaction(TransactionResult transactionResult, Device device)
        {
            UIClass.DisplayReceipts(transactionResult.MerchantReceipt, transactionResult.CustomerReceipt);
            // The object TransactionResult stores the different receipts
            // Other information can be accessed through this object like the transaction ID, the amount...
        }
    }
}
