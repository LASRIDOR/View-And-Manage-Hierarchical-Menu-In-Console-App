using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class ActionItem : MenuItem
    {
        public delegate void MenuOptionDelegate();

        public event MenuOptionDelegate MenuOptionToDoWhenChose;

        // for back and exit option in menu
        public ActionItem(string i_Title) : base(i_Title)
        {
            MenuOptionToDoWhenChose = null;
        }

        public ActionItem(string i_Title, MenuOptionDelegate i_ActionDelegate) : base(i_Title)
        {
            MenuOptionToDoWhenChose += i_ActionDelegate;
        }

        internal override void OnChose()
        {
            // lets tell the form that I was clicked:
            if (MenuOptionToDoWhenChose != null)
            {
                MenuOptionToDoWhenChose.Invoke();
            }
            else
            {
                Console.WriteLine("No Such Of Option");
            }
        }

        public override string ToString()
        {
            return string.Format("press {0} to {1}", ItemIndex, Title);
        }
    }
}
