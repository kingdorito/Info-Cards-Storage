using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public class GiftCard : IInfoCard
    {
        private string giftCardName;
        private string giftCardFirstName;
        private string giftCardLastName;
        private string giftCardAmount;
        private string giftCardDateIssued;
        GiftCardDisplay newGiftCardDisplay;

        public string GiftCardName
        {
            get
            {
                return giftCardName;
            }
            set
            {
                giftCardName = value;
            }
        }

        public string GiftCardFirstName
        {
            get
            {
                return giftCardFirstName;
            }
            set
            {
                giftCardFirstName = value;
            }
        }

        public string GiftCardLastName
        {
            get
            {
                return giftCardLastName;
            }
            set
            {
                giftCardLastName = value;
            }
        }

        public string GiftCardDateIssued
        {
            get
            {
                return giftCardDateIssued;
            }
            set
            {
                giftCardDateIssued = value;
            }
        }

        public string GiftCardAmount
        {
            get
            {
                return giftCardAmount;
            }
            set
            {
                giftCardAmount = value;
            }
        }
        public GiftCard()
        {
            giftCardName = string.Empty;
            giftCardFirstName = string.Empty;
            giftCardLastName = string.Empty;
            giftCardDateIssued = string.Empty;
            giftCardAmount = string.Empty;
        }

        public GiftCard(string initialDetails)
        {
            string[] temp = initialDetails.Split('|');
            giftCardName = temp[1];
            giftCardFirstName = temp[2];
            giftCardLastName = temp[3];
            giftCardAmount = temp[4];
            giftCardDateIssued = temp[5];
        }
        public string Name
        {
            get
            {
                return giftCardName;
            }
            set
            {
                giftCardName = value;
            }                      
        }

        public string Category
        {
            get
            {
               return "Gift Card";
            }
        }

        public void CloseDisplay()
        {
            if (newGiftCardDisplay != null)
            {
                newGiftCardDisplay.Close();
                newGiftCardDisplay.Dispose();
            }
        }
        public void DisplayData(Panel displayPanel)
        {
            newGiftCardDisplay = new GiftCardDisplay();
            newGiftCardDisplay.NewGiftCard = this;
            newGiftCardDisplay.ShowDialog();
        }

        public bool EditData()
        {
            bool dataChanged = false;
            GiftCardEdit newGiftCardEdit = new GiftCardEdit();
            newGiftCardEdit.NewGiftCard = this;
            if (newGiftCardEdit.ShowDialog() == DialogResult.OK)
            {
                dataChanged = true;
                giftCardName = newGiftCardEdit._giftCardName.Text;
                giftCardFirstName = newGiftCardEdit._giftCardFirstName.Text;
                giftCardLastName = newGiftCardEdit._giftCardLastName.Text;
                giftCardAmount = newGiftCardEdit._giftCardAmount.Text;
                giftCardDateIssued = newGiftCardEdit._giftCardDateIssued.Text;
            }
            return dataChanged;
        }

        public string GetDataAsString()
        {
            return "Gift Card" + "|" + giftCardName + "|" + giftCardFirstName + "|" + giftCardLastName + "|" + giftCardAmount + "|" + giftCardDateIssued;
        }
    }
}
