using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Capstone
{
    class Items
    {
        public static void DisplayItems()
        {
            Console.Clear();
            Console.Write("\n");
           
            string directory = @"C:\Users\Zachary\Workspace\module1-capstone-c-team-6\Example Files\Inventory.txt";
            string directoryJuan = @"C:\Users\Student\Workspace\module1-capstone-c-team-6\Example Files\Inventory.txt";

            Dictionary<string, FoodProperties> itemsDicKeyValue = new Dictionary<string, FoodProperties>();

            using (StreamReader sw = new StreamReader(directoryJuan))
            {
                Console.WriteLine(String.Format("{0, 0} |  {1,-21} | {2,-5} |  {3,0}", " ITEM KEY", "PRODUCT NAME", "STOCK" , "PRICE"));
                Console.Write("---------------------------------------------------------\n");

                while (!sw.EndOfStream)
                {
                    //Make sure item is avaliable otherwise display SOLD OUT
                    string lineContents = sw.ReadLine();

                    string[] items = lineContents.Split("|");

                    string itemNumber = items[0];
                    string foodName = items[1];

                    int howManyItemsRemaining = 5;

                    decimal moneyMoneyPrice = decimal.Parse(items[2]);
                    FoodProperties valueItem;

                    switch (items[3])
                    {
                        case "Chip":
                            valueItem = new TypesFood.Chip(foodName, moneyMoneyPrice, howManyItemsRemaining);
                            break;

                        case "Candy":
                            valueItem = new TypesFood.Candy(foodName, moneyMoneyPrice, howManyItemsRemaining);
                            break;

                        case "Drink":
                            valueItem = new TypesFood.Drink(foodName, moneyMoneyPrice, howManyItemsRemaining);
                            break;

                        default:
                            valueItem = new TypesFood.Gum(foodName, moneyMoneyPrice, howManyItemsRemaining);
                            break;
                    }
                    itemsDicKeyValue.Add(items[0], valueItem);
                }
            }
            foreach (KeyValuePair<string, FoodProperties> kvp in itemsDicKeyValue)
            {
                if (kvp.Value.HowManyItemsRemaining > 0)
                {
                    string itemNumber = kvp.Key;
                    int itemsRemaining = kvp.Value.HowManyItemsRemaining;
                    string productName = kvp.Value.YummyName;
                    string price = kvp.Value.MoneyMoneyPrice.ToString();


                    if (itemsRemaining == 0)
                    {
                        Console.WriteLine(String.Format("{0,6}\t  |  {1,-18}    |{2,15}", itemNumber, productName, " **SOLD OUT**" ));
                    }
                    else
                        Console.WriteLine(String.Format("{0,6}\t  |  {1,-18}    |{2,4}   |  ${3,0}" , itemNumber, productName, itemsRemaining ,price ));
                }
            }
        }
    }
}