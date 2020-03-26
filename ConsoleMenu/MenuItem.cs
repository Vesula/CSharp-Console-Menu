using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMenu
{
    class MenuItem
    {
        public ConsoleColor foregroundColor { get; set; }
        public ConsoleColor backgroundColor { get; set; }
        public string text { get; set; }
        public bool isSelected { get; set; }

        public MenuItem(string itemText)
        {
            text = itemText;
            this.foregroundColor = ConsoleColor.White;
            this.backgroundColor = ConsoleColor.Black;
            this.isSelected = false;
        }
    }
}