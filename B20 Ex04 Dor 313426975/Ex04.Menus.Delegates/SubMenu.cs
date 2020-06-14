
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public class SubMenu : MenuOption
    {
        private static readonly int sr_BackChoiceIndex = 0;  // For Back (or Exit in case of MainMenu).
        private static readonly string sr_Back = "Back";
        private readonly List<MenuOption> r_MenuOptions;


    }
}
