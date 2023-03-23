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
    public partial class GiftCardDisplay : Form
    {
        private GiftCard newGiftCard = new GiftCard();
        public GiftCard NewGiftCard
        {
            get
            {
                return newGiftCard;
            }
            set
            {
                newGiftCard = value;
            }
        }
        public GiftCardDisplay()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void GiftCardDisplay_Load(object sender, EventArgs e)
        {
            giftCardName.Text = newGiftCard.GiftCardName;
            giftFirstName.Text = newGiftCard.GiftCardFirstName;
            giftLastName.Text = newGiftCard.GiftCardLastName;
            giftAmount.Text = newGiftCard.GiftCardAmount;
            giftDateIssued.Text = newGiftCard.GiftCardDateIssued;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
