using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class AddInfoCardsFactory : IInfoCardFactory
    {
        //Creating the categories.
        public string[] categories = { "Credit Card", "Gift Card"};
        public string[] CategoriesSupported
        {
            get 
            { 
                return categories; 
            }
        }

        public IInfoCard CreateInfoCard(string initialDetails)
        {
            string[] temp = initialDetails.Split('|');
            string category = temp[0];
            if ("Credit Card" == category)
            {
                return new CreditCard(initialDetails);
            }
            if ("Gift Card" == category)
            { 
                return new GiftCard(initialDetails);
            }
            throw new Exception("Invalid category");
        }

        public IInfoCard CreateNewInfoCard(string category)
        {

            if ("Credit Card" == category)
            {
                return new CreditCard();
            }
            if ("Gift Card" == category)
            { 
               return new GiftCard();
            }
            throw new Exception("Invalid category");
        }

        //Creating and  assigning the descriptions of the categories.
        private string[] descriptions = new string[2] 
        {"Store a Credit Card.", "Store the information of a gift card."};

        public string GetDescription(string category)
        {
            switch (category)
            {
                case "Credit Card":
                    return descriptions[0];
                case "Gift Card":
                    return descriptions[1];
            }
            return null;
        }
    }
}
