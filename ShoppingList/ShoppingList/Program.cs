//Libraries:
using ShoppingList;
using System.Collections;

//Variables:
string? menuLiMain;
string switchDefaultText;
ArrayList shopList = new ArrayList();

//Declaration:
switchDefaultText = "Please enter one of the options from above";

do
{
    Console.WriteLine("\nShopping List\n----------\n[1] Add Items\n[2] Show List\n[3] Remove Item\n[4] Exit");
    menuLiMain = Console.ReadLine();

    switch (menuLiMain)
    {
        case "1":
            shopList = MenuCtrl.AddItem(shopList);
        break;

        case "2":
            MenuCtrl.ShowList(shopList);
        break;

        case "3":
            shopList = MenuCtrl.RemoveItem(switchDefaultText, shopList);
        break;

        case "4":
            MenuCtrl.Exit(switchDefaultText);
        break;

        default:
            Console.WriteLine($"\n{switchDefaultText}");
        break;

    }
} while (true);
