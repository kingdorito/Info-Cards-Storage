using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class CreditCardEdit : Form
    {
        private CreditCard newCreditCard = new CreditCard();
        public CreditCard NewCreditCard 
        {
            get
            {
                return newCreditCard;
            }
            set
            {
                newCreditCard = value;
            }
        }
        public CreditCardEdit()
        {
            InitializeComponent();


        }

        private void CreditCardEdit_Load(object sender, EventArgs e)
        {
            if (newCreditCard != null) 
            {
                _cardName.Text = newCreditCard.CardName; 
                _cardNum.Text = newCreditCard.CardNum;
                _startDate.Text = newCreditCard.StartDate;
                _expiryDate.Text = newCreditCard.ExpiryDate;
                _cvc.Text = newCreditCard.CVC;
                _nameOnCard.Text = newCreditCard.NameOnCard;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK; //This is the save button. 
            newCreditCard.CardName = _cardName.Text; 
            newCreditCard.CardNum = _cardNum.Text;
            newCreditCard.StartDate = _startDate.Text;
            newCreditCard.ExpiryDate = _expiryDate.Text;
            newCreditCard.CVC = _cvc.Text;
            newCreditCard.NameOnCard = _nameOnCard.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; //Cancel button to don't store the inputed data.
        }

        //These are ways to check the textboxes and what does the user writes in them. In some textboxes
        //like the Credit Card Number the user cannot write numbers, or in the name of the card
        //not being allowed to write letters and not enabling the save button if the user hasn't 
        //completely finished writing all the textboxes.
        public void _expiryDate_TextChanged(object sender, EventArgs e) 
        {
           if (string.IsNullOrEmpty(_expiryDate.Text) || string.IsNullOrEmpty(_startDate.Text) || string.IsNullOrEmpty(_cardName.Text) || string.IsNullOrEmpty(_cardNum.Text) || string.IsNullOrEmpty(_cvc.Text) || string.IsNullOrEmpty(_nameOnCard.Text))
           {
            saveButton.Enabled = false;
           }
           else saveButton.Enabled = true;
        }

        private void _cardName_TextChanged(object sender, EventArgs e)
        {
        if (string.IsNullOrEmpty(_expiryDate.Text) || string.IsNullOrEmpty(_startDate.Text) || string.IsNullOrEmpty(_cardName.Text) || string.IsNullOrEmpty(_cardNum.Text) || string.IsNullOrEmpty(_cvc.Text) || string.IsNullOrEmpty(_nameOnCard.Text))
        {
          saveButton.Enabled = false;
        }
        else saveButton.Enabled = true;

        }

        private void _nameOnCard_TextChanged(object sender, EventArgs e)
        {
        if (string.IsNullOrEmpty(_expiryDate.Text) || string.IsNullOrEmpty(_startDate.Text) || string.IsNullOrEmpty(_cardName.Text) || string.IsNullOrEmpty(_cardNum.Text) || string.IsNullOrEmpty(_cvc.Text) || string.IsNullOrEmpty(_nameOnCard.Text))
        {
        saveButton.Enabled = false;
        }
        else saveButton.Enabled = true;

        }

        private void _cardNum_TextChanged(object sender, EventArgs e)
        {
        if (string.IsNullOrEmpty(_expiryDate.Text) || string.IsNullOrEmpty(_startDate.Text) || string.IsNullOrEmpty(_cardName.Text) || string.IsNullOrEmpty(_cardNum.Text) || string.IsNullOrEmpty(_cvc.Text) || string.IsNullOrEmpty(_nameOnCard.Text))
        {
        saveButton.Enabled = false;
        }
        else saveButton.Enabled = true;
        }

        private void _nameOnCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == '\b') && !(e.KeyChar == ' '))
            {
                e.Handled = true;
            }
        }

        private void _expiryDate_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void _startDate_TextChanged(object sender, EventArgs e)
        {
        if (string.IsNullOrEmpty(_expiryDate.Text) || string.IsNullOrEmpty(_startDate.Text) || string.IsNullOrEmpty(_cardName.Text) || string.IsNullOrEmpty(_cardNum.Text) || string.IsNullOrEmpty(_cvc.Text) || string.IsNullOrEmpty(_nameOnCard.Text))
        {
        saveButton.Enabled = false;
        }
        else saveButton.Enabled = true;
        }

        private void _cardNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == ' ') && !(e.KeyChar == '\b');
        }

        private void _expiryDate_TextChanged_1(object sender, EventArgs e)
        {
        if (string.IsNullOrEmpty(_expiryDate.Text) || string.IsNullOrEmpty(_startDate.Text) || string.IsNullOrEmpty(_cardName.Text) || string.IsNullOrEmpty(_cardNum.Text) || string.IsNullOrEmpty(_cvc.Text) || string.IsNullOrEmpty(_nameOnCard.Text))
        {
        saveButton.Enabled = false;
        }
        else saveButton.Enabled = true;
        }

        private void _cvc_TextChanged(object sender, EventArgs e)
        {
        if (string.IsNullOrEmpty(_expiryDate.Text) || string.IsNullOrEmpty(_startDate.Text) || string.IsNullOrEmpty(_cardName.Text) || string.IsNullOrEmpty(_cardNum.Text) || string.IsNullOrEmpty(_cvc.Text) || string.IsNullOrEmpty(_nameOnCard.Text))
        {
        saveButton.Enabled = false;
        }
        else saveButton.Enabled = true;
        }

        private void _cvc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '\b') && !(e.KeyChar == ' ');
        }

        private void _expiryDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '\b') && !(e.KeyChar == ' ') && !(e.KeyChar == '/');
        }

        private void _startDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '\b') && !(e.KeyChar == ' ') && !(e.KeyChar == '/');
        }
    }
}
