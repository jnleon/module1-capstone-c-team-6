using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.ItemType
{
    public class Drink :ItemProperties 
    {
        public Drink(string itemName, decimal itemPrice, int itemsLeftInStock) : base(itemName, itemPrice, itemsLeftInStock)
        {

        }

    }
}
