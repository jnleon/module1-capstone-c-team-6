using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
   public abstract class ItemProperties
    {
            public string ItemName { get; set; }

            public decimal ItemPrice { get; set; }

            public int ItemsLeftInStock { get; set; }

            public ItemProperties(string itemName, decimal itemPrice, int itemsLeftInStock)
            {
                ItemName = itemName;
                ItemPrice = itemPrice;
                ItemsLeftInStock = itemsLeftInStock;
            }
    }
}