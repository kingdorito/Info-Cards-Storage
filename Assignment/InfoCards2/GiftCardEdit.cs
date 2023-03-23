using System;
using System.Windows.Forms;

namespace Assignment
{
  public partial class GiftCardEdit : Form
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
    public GiftCardEdit()
    {
      InitializeComponent();
    }

    private void GiftCardEdit_Load(object sender, EventArgs e)
    {
      if (newGiftCard != null)
      {
        _giftCardName.Text = newGiftCard.GiftCardName;
        _giftCardFirstName.Text = newGiftCard.GiftCardFirstName;
        _giftCardLastName.Text = newGiftCard.GiftCardLastName;
        _giftCardAmount.Text = newGiftCard.GiftCardAmount;
        _giftCardDateIssued.Text = newGiftCard.GiftCardDateIssued;
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.OK;
      NewGiftCard.GiftCardName = _giftCardName.Text;
      NewGiftCard.GiftCardFirstName = _giftCardFirstName.Text;
      NewGiftCard.GiftCardLastName = _giftCardLastName.Text;
      NewGiftCard.GiftCardAmount = _giftCardAmount.Text;
      NewGiftCard.GiftCardDateIssued = _giftCardAmount.Text;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.Cancel;
    }
        //These are ways to check the textboxes and what does the user writes in them. In some textboxes
        //like the gift card amount the user cannot write numbers, or in the name or the last name of the card
        //not being allowed to write letters and not enabling the save button if the user hasn't 
        //completely finished writing all the textboxes.
        private void _giftCardFirstName_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == '\b') && !(e.KeyChar == ' '))
      {
        e.Handled = true;
      }
    }


    private void _giftCardLastName_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == '\b') && !(e.KeyChar == ' '))
      {
        e.Handled = true;
      }
    }

    private void _giftCardDateIssued_KeyPress(object sender, KeyPressEventArgs e)
    {
      e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '\b') && !(e.KeyChar == ' ') && !(e.KeyChar == '/');
    }

    private void _giftCardAmount_KeyPress(object sender, KeyPressEventArgs e)
    {
      e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
    }

    private void _giftCardDateIssued_TextChanged(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(_giftCardName.Text) || string.IsNullOrEmpty(_giftCardLastName.Text) || string.IsNullOrEmpty(_giftCardFirstName.Text) || string.IsNullOrEmpty(_giftCardDateIssued.Text) || string.IsNullOrEmpty(_giftCardAmount.Text))
      {
        saveButton.Enabled = false;
      }
      else saveButton.Enabled = true;
    }

    private void _giftCardFirstName_TextChanged(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(_giftCardName.Text) || string.IsNullOrEmpty(_giftCardLastName.Text) || string.IsNullOrEmpty(_giftCardFirstName.Text) || string.IsNullOrEmpty(_giftCardDateIssued.Text) || string.IsNullOrEmpty(_giftCardAmount.Text))
      {
        saveButton.Enabled = false;
      }
      else saveButton.Enabled = true;
    }

    private void _giftCardLastName_TextChanged(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(_giftCardName.Text) || string.IsNullOrEmpty(_giftCardLastName.Text) || string.IsNullOrEmpty(_giftCardFirstName.Text) || string.IsNullOrEmpty(_giftCardDateIssued.Text) || string.IsNullOrEmpty(_giftCardAmount.Text))
      {
        saveButton.Enabled = false;
      }
      else saveButton.Enabled = true;
    }

    private void _giftCardAmount_TextChanged(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(_giftCardName.Text) || string.IsNullOrEmpty(_giftCardLastName.Text) || string.IsNullOrEmpty(_giftCardFirstName.Text) || string.IsNullOrEmpty(_giftCardDateIssued.Text) || string.IsNullOrEmpty(_giftCardAmount.Text))
      {
        saveButton.Enabled = false;
      }
      else saveButton.Enabled = true;
    }

    private void _giftCardName_TextChanged(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(_giftCardName.Text) || string.IsNullOrEmpty(_giftCardLastName.Text) || string.IsNullOrEmpty(_giftCardFirstName.Text) || string.IsNullOrEmpty(_giftCardDateIssued.Text) || string.IsNullOrEmpty(_giftCardAmount.Text))
      {
        saveButton.Enabled = false;
      }
      else saveButton.Enabled = true;
    }
  }
}

