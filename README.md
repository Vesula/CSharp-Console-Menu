# Console Menu
## A lightweight C# console menu library

### Useage
Add DLL as a refrence - NuGet support coming soon.

#### Basic Menu:
```csharp
static void Main(string[] args)
{
    string[] menuItems = new string[] { "Option 1", "Option 2", "Option 3", "Option 4" };

    Menu menu = new Menu(menuItems, "Main Menu");

    switch (menu.displayMenu())
    {
        case 1:
            Console.WriteLine("Option 1");
            break;
        case 2:
            Console.WriteLine("Option 2");
            break;
        case 3:
            Console.WriteLine("Option 3");
            break;
        case 4:
            Console.WriteLine("Option 4");
            break;
        default:
            break;
    }
}
```

### Credits
- @MahonHughes - Initial codebase
- @ThomasSaunders - Expanding the origional codebase to where we are today
