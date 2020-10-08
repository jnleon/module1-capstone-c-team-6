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
            //ask user for filePath
            string directory = @"C:\Users\Zachary\Workspace\module1-capstone-c-team-6\Example Files\Inventory.txt";
            string directoryJuan = @"C:\Users\Student\Workspace\module1-capstone-c-team-6\Example Files\Inventory.txt";
            using (StreamReader sw = new StreamReader(directoryJuan))
            {
                Dictionary<string, FoodProperties> itemsDicKeyValue = new Dictionary<string, FoodProperties>();
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
        }
    }
}
                        /*
                    int lineNum = 1;
                    //ADDING EACH LINE TO ITS OWN ARRAY
                    string hello = new string(lineContents);
                    ItemList.Add(hello);
                    string[] splitLine = hello.Split("|");
                    //ITEM CHARACTERISTICS
                    string buttonNumber = splitLine[0];
                    string name = splitLine[1];
                    decimal price = decimal.Parse(splitLine[2]);
                    string type = splitLine[3];
                    lineNum++;
                    */