namespace Ex04.Menus.Test
{
    public static class MenuTestBuilder
    {
        public static void RunInterfacesMenutest()
        {
            Ex04.Menus.Interfaces.MainMenu mainMenu = buildInterfaceMenu();
            mainMenu.Show();
        }

        private static Ex04.Menus.Interfaces.MainMenu buildInterfaceMenu()
        {
            Ex04.Menus.Interfaces.MainMenu mainMenu = new Ex04.Menus.Interfaces.MainMenu("Main Menu (Interfaces)");

            Ex04.Menus.Interfaces.SubMenu versionAndCapitals = new Ex04.Menus.Interfaces.SubMenu("Version and Capitals");
            versionAndCapitals.Add(new Ex04.Menus.Interfaces.ActionItem("Count Capitals", new MenuOptionsForTester.CountCaptials()));
            versionAndCapitals.Add(new Ex04.Menus.Interfaces.ActionItem("Show Version", new MenuOptionsForTester.ShowVersion()));
            mainMenu.Add(versionAndCapitals);

            Ex04.Menus.Interfaces.SubMenu dateAndTime = new Ex04.Menus.Interfaces.SubMenu("Show Date/Time");
            dateAndTime.Add(new Ex04.Menus.Interfaces.ActionItem("Show Time", new MenuOptionsForTester.ShowCurrTime()));
            dateAndTime.Add(new Ex04.Menus.Interfaces.ActionItem("Show Date", new MenuOptionsForTester.ShowCurrDate()));
            mainMenu.Add(dateAndTime);

            return mainMenu;
        }

        public static void RunDelegateMenuTest()
        {
            Ex04.Menus.Delegates.MainMenu mainMenu = buildDelegateMenu();
            mainMenu.Show();
        }

        private static Ex04.Menus.Delegates.MainMenu buildDelegateMenu()
        {
            Ex04.Menus.Delegates.MainMenu mainMenu = new Ex04.Menus.Delegates.MainMenu("Main Menu (Delegates)");

            Ex04.Menus.Delegates.SubMenu versionAndCapitals = new Ex04.Menus.Delegates.SubMenu("Version and Capitals");
            versionAndCapitals.Add(new Ex04.Menus.Delegates.ActionItem("Count Capitals", new MenuOptionsForTester.CountCaptials().Do));
            versionAndCapitals.Add(new Ex04.Menus.Delegates.ActionItem("Show Version", new MenuOptionsForTester.ShowVersion().Do));
            mainMenu.Add(versionAndCapitals);

            Ex04.Menus.Delegates.SubMenu dateAndTime = new Ex04.Menus.Delegates.SubMenu("Show Date/Time");
            dateAndTime.Add(new Ex04.Menus.Delegates.ActionItem("Show Time", new MenuOptionsForTester.ShowCurrTime().Do));
            dateAndTime.Add(new Ex04.Menus.Delegates.ActionItem("Show Date", new MenuOptionsForTester.ShowCurrDate().Do));
            mainMenu.Add(dateAndTime);

            return mainMenu;
        }
    }
}
