using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public class CreditCard : IInfoCard
    {
        private string cardName; 
        private string cardNum;
        private string startDate;
        private string expiryDate;
        private string cVC;
        private string nameOnCard;
        creditCardDisplay newCreditFormDisplay;

        public string CardName  
        {
            get
            {
                return cardName;
            }
            set
            {
                cardName = value;
            }
        }

        public string CardNum
        {
            get
            {
                return cardNum;
            }
            set
            {
                cardNum = value;
            }
        }

        public string StartDate
        {
            get
            {
                return startDate;
            }

            set
            {
                startDate = value;
            }
        }

        public string ExpiryDate
        {
            get
            {
                return expiryDate;
            }

            set
            {
                expiryDate = value;
            }
        }

        public string CVC
        {
            get
            {
                return cVC;
            }
            set
            {
                cVC = value;
            }
        }

        public string NameOnCard
        {
            get
            {
                return nameOnCard;
            }
            set
            {
                nameOnCard = value;
            }
        }

        public CreditCard()
        {
            cardName = string.Empty;
            cardNum = string.Empty;
            startDate = string.Empty;
            expiryDate = string.Empty;
            cVC = string.Empty;
            nameOnCard = string.Empty;
        }

        public CreditCard(string initialDetails)
        {
            string[] temp = initialDetails.Split('|');
            cardName = temp[1];
            cardNum = temp[2];
            startDate = temp[3];
            expiryDate = temp[4];
            cVC = temp[5];
            nameOnCard = temp[6];
        }

        public string Name
        {
            get
            { 
                return cardName; 
            }
            set
            { 
                cardName = value; 
            }
        }
        public string Category
        {
            get
            {
                return "Credit Card";
            }
        }
        public string GetDataAsString()
        {
            return "Credit Card" + "|" + cardName + "|" + cardNum + "|" + startDate + "|" + expiryDate + "|" + cVC + "|" + nameOnCard;
        }
        public void DisplayData(Panel displayPanel)
        {
            newCreditFormDisplay = new creditCardDisplay();
            newCreditFormDisplay.NewCreditCard = this;
            newCreditFormDisplay.ShowDialog();
        }

        public void CloseDisplay()
        {
            if (newCreditFormDisplay != null)
            {
                newCreditFormDisplay.Close();
                newCreditFormDisplay.Dispose();
            }
        }
        public bool EditData()
        {
            bool dataChanged = false;

            CreditCardEdit newCreditFormEdit = new CreditCardEdit();
            newCreditFormEdit.NewCreditCard = this; 

            if (newCreditFormEdit.ShowDialog() == DialogResult.OK)
            {
                dataChanged = true;
                cardName = newCreditFormEdit._cardName.Text;
                cardNum = newCreditFormEdit._cardNum.Text;
                startDate = newCreditFormEdit._startDate.Text;
                expiryDate = newCreditFormEdit._expiryDate.Text;
                cVC = newCreditFormEdit._cvc.Text;
                nameOnCard = newCreditFormEdit._nameOnCard.Text;
            }

            return dataChanged;
        }
    }
}
