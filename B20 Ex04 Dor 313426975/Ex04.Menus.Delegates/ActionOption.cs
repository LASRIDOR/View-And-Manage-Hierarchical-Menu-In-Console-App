using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class ActionOption : MenuOption
    {
        public delegate void MenuOptionInvoker();

        public event MenuOptionInvoker m_MenuOptionInvoker;

        // for back and exit option in menu
        public ActionOption(string i_Title) : base(i_Title)
        {
            m_MenuOptionInvoker = null;
        }

        public ActionOption(string i_Title, MenuOptionInvoker i_ActionDelegate) : base(i_Title)
        {
            m_MenuOptionInvoker += i_ActionDelegate;
        }

        internal override void OnChose()
        {
            // lets tell the form that I was clicked:
            if (m_MenuOptionInvoker != null)
            {
                m_MenuOptionInvoker.Invoke();
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
