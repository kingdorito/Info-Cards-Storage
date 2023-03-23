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
    public partial class creditCardDisplay : Form
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

        public creditCardDisplay()
        {
            InitializeComponent();
        }

        private void CreditCardDisplay_Load(object sender, EventArgs e)
        {
            lblcardName.Text = newCreditCard.CardName; //Assigning with the methods in the main class.
            labelcardnum.Text = newCreditCard.CardNum;
            labelstartdate.Text = newCreditCard.StartDate;
            labelexpirydate.Text = newCreditCard.ExpiryDate;
            lablelnameoncard.Text = newCreditCard.NameOnCard;
            labelcvc.Text = newCreditCard.CVC;
        }

        private void _cardName_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK; //An OK button to stop displaying the card.
        }
    }
}
