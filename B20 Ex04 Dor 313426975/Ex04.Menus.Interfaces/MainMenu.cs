using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private static readonly string sr_ExitName = "Exit";
        private static readonly int sr_ExitIndex = 0;
        private SubMenu m_MainMenu;

        public SubMenu Menu
        {
            get { return m_MainMenu; }
        }

        public MainMenu(string i_Title)
        {
            m_MainMenu = new SubMenu(i_Title);

            // replacing back of submenu for exit
            MenuItem exitOption = new ActionItem(sr_ExitName);

            exitOption.ItemIndex = sr_ExitIndex;
            m_MainMenu.MenuOptions[sr_ExitIndex] = exitOption;
        }

        public void Add(MenuItem i_Option)
        {
            m_MainMenu.Add(i_Option);
        }

        public void Show()
        {
            m_MainMenu.OnChose();
        }
    }
}
