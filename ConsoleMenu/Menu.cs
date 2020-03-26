using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu
{
    public class Menu
    {
        public string[] menuTextItems { get; set; }
        public string menuTitle { get; set; }

        public Menu(string[] menuItems, string title)
        {
            menuTextItems = menuItems;
            menuTitle = title;
        }

        public int displayMenu()
        {
            MenuItem[] menuItems = new MenuItem[menuTextItems.Length];

            for (int i = 0; i < menuItems.Length; i++)
            {
                menuItems[i] = new MenuItem(menuTextItems[i]);
            }

            menuItems[0].isSelected = true;
            int currentSelection = 0;

            while (true)
            {
                Console.CursorLeft = 0;
                Console.CursorTop = 0;
                Console.CursorVisible = false;

                foreach (MenuItem item in menuItems)
                {
                    if (!item.isSelected)
                    {
                        item.foregroundColor = ConsoleColor.White;
                        item.backgroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        item.foregroundColor = ConsoleColor.Black;
                        item.backgroundColor = ConsoleColor.White;
                        item.isSelected = false;
                    }

                }

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.BackgroundColor = ConsoleColor.Black;

                Console.WriteLine(menuTitle);

                foreach (MenuItem item in menuItems)
                {
                    Console.ForegroundColor = item.foregroundColor;
                    Console.BackgroundColor = item.backgroundColor;
                    Console.WriteLine(item.text);
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                ConsoleKey key = keyInfo.Key;

                if (key == ConsoleKey.UpArrow && currentSelection != 0)
                {
                    currentSelection--;

                    menuItems[currentSelection].isSelected = true;
                }
                else if (key == ConsoleKey.DownArrow && currentSelection != (menuItems.Length) - 1)
                {
                    currentSelection++;

                    menuItems[currentSelection].isSelected = true;
                }
                else if (key == ConsoleKey.Enter)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;

                    Console.Clear();

                    return currentSelection;
                }
            }
        }
    }
}