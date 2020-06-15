using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private SubMenu m_MainMenu;
        private static readonly string sr_ExitName = "Exit";
        private static readonly int sr_ExitIndex = 0;

        public SubMenu Menu
        {
            get { return m_MainMenu; }
        }

        public MainMenu(string i_Title)
        {
            m_MainMenu = new SubMenu(i_Title);

            // replacing back of submenu for exit
            MenuOption exitOption = new ActionOption(sr_ExitName);

            exitOption.ItemIndex = sr_ExitIndex;
            m_MainMenu.MenuOptions[sr_ExitIndex] = exitOption;
        }

        public void Add(MenuOption i_Option)
        {
            m_MainMenu.Add(i_Option);
        }

        public void Show()
        {
            m_MainMenu.OnChose();
        }
    }
}
