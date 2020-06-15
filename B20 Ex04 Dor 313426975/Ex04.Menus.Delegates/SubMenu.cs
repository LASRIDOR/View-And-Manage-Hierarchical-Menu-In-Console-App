﻿
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class SubMenu : MenuOption
    {
        private static readonly int sr_BackChoiceIndex = 0;  // For Back (or Exit in case of MainMenu).
        private static readonly string sr_Back = "Back";
        private readonly List<MenuOption> r_MenuOptions;

        /*
        public SubMenu()
        {
            // for submenu that doesnt need title
            r_MenuOptions = new List<MenuOption>();
        }
        */
        public SubMenu(string i_Title) : base(i_Title)
        {
            r_MenuOptions = new List<MenuOption>();
            // must have back option
            Add(new ActionOption(sr_Back));
        }

        public List<MenuOption> MenuOptions
        {
            get { return r_MenuOptions; }
        }

        internal override void OnChose()
        {
            if (r_MenuOptions.Count == 0)
            {
                Console.WriteLine("This Menu Option cant Do Anything");
            }
            else
            {
                showSubMenu();
            }
        }

        public void Add(MenuOption i_MenuSubItemToAdd)
        {
            // Update item index for the given MenuItem
            i_MenuSubItemToAdd.ItemIndex = r_MenuOptions.Count;

            // Append the given MenuItem to this item list
            r_MenuOptions.Add(i_MenuSubItemToAdd);
        }

        private void showSubMenu()
        {
            int choice;
            string msgForUser = string.Format("=========================={0}{1}{0}=========================={0}{2}==========================", Environment.NewLine, Title, this.ToString());

            do
            {
                System.Console.WriteLine(msgForUser);
                choice = getChoiceFromUser();
                Console.Clear();
                if (choice != sr_BackChoiceIndex)
                {
                    r_MenuOptions[choice].OnChose();
                }
            }
            while (choice != sr_BackChoiceIndex);
        }

        public override string ToString()
        {
            StringBuilder printListOfMenu = new StringBuilder();

            foreach (MenuOption option in r_MenuOptions)
            {
                if (option.ItemIndex != sr_BackChoiceIndex)
                {
                    if (option is ActionOption)
                    {
                        printListOfMenu.Append(option.ToString());
                    }
                    else if (option is SubMenu)
                    {
                        printListOfMenu.Append(string.Format("press {0} to {1}", option.ItemIndex, option.Title));
                    }
                    printListOfMenu.Append(Environment.NewLine);
                }
            }
            // back or exit menu will be at the end
            printListOfMenu.Append(r_MenuOptions[sr_BackChoiceIndex].ToString());
            printListOfMenu.Append(Environment.NewLine);

            return printListOfMenu.ToString();
        }

        private int getChoiceFromUser()
        {
            int choice;
            string choiceString;

            Console.Write("Your Choice: ");
            choiceString = Console.ReadLine();

            while (int.TryParse(choiceString, out choice) == false || (choice < 0 || choice > r_MenuOptions.Count - 1))
            {
                Console.Write("Please enter a number between {0} and {1}:", 0, r_MenuOptions.Count - 1);
                choiceString = Console.ReadLine();
            }

            return choice;
        }
    }
}
