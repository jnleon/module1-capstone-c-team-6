using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.ItemType
{
    public class Candy : ItemProperties
    {
        public Candy(string itemName, decimal itemPrice, int itemsLeftInStock) : base(itemName, itemPrice, itemsLeftInStock)
        {

        }
    }
}
