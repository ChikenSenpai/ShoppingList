using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList
{
    public static class MenuCtrl
    {
        // Add Item:
        public static ArrayList AddItem(ArrayList list)
        {
            string item;
            bool itemInList;
            bool itemNotX = true;

            Console.WriteLine("\nEnter the name of the item you want to add and press 'Enter'\nWhen you're done write 'x' and press 'Enter' to stop");
            do
            {
                itemInList = false;
                item = Console.ReadLine();
                foreach(string i in list)
                {
                    if(i.ToLower() == item.ToLower())
                    {
                        Console.WriteLine("The item you're trying to add is already in your list\n");
                        itemInList = true;
                    }
                }
                if (!itemInList)
                {
                    if (item == "")
                    {

                    }
                    else if (item.ToLower() == "x")
                    {
                        itemNotX = false;
                    }
                    else
                    {
                        list.Add(item);
                    }
                }
            }while(itemNotX);
            return list;
        }

        //Show List:
        public static void ShowList(ArrayList list)
        {
            Console.WriteLine("");
            if(list.Count > 0)
            {
                list.Sort();
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
            else if(list.Count <= 0)
            {
                Console.WriteLine("There are no items in your list yet");
            }
            
        }

        //Remove Item:
        public static ArrayList RemoveItem(string defaultTxt, ArrayList list) 
        {
            string item;
            bool itemNotX = true;
            int i;


            
            Console.WriteLine("\nEnter the name of the item you want to remove and press 'Enter'\nWhen you're done write 'x' and press 'Enter' to stop");
            do
            {
                item = Console.ReadLine();
                if (item == "")
                {

                }
                else if (item.ToLower() == "x")
                {
                    itemNotX = false;
                }
                else
                {
                    for (i = 0; i < list.Count; i++)
                    {
                        if (list[i].ToString().ToLower() == item.ToLower())
                        {
                            Console.WriteLine($"{list[i]} was removed");
                            list.RemoveAt(i);
                        }
                    }

                }
            } while (itemNotX);
            return list;
        }

        //Exit:
        public static void Exit(string defaultTxt)
        {

            string choiceExit;
            bool loopExit = true;
            bool progExit = false;
            do
            {
                Console.WriteLine("\nAre you sure you want to close the programm?\n\n[1] Yes\n[2] No");
                choiceExit = Console.ReadLine();
                switch (choiceExit)
                {
                    case "1":
                        Console.WriteLine("\nClosing ...");
                        progExit = true;
                        loopExit = false;
                        break;

                    case "2":
                        loopExit = false;
                        loopExit = false;
                        break;

                    default:
                        Console.WriteLine(defaultTxt);
                        break;
                }
            } while (loopExit);
            if (progExit)
            {
                Environment.Exit(0);
            }

        }

    }
}
