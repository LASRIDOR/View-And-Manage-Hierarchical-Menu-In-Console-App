using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public delegate void MenuOptionInvoker();

    public class ActionOption : MenuOption
    {
        public event MenuOptionInvoker m_MenuOptionInvoker = null;

        public ActionOption(string i_Title, int i_IndexOfOption, MenuOptionInvoker i_ActionDelegate): base(i_Title, i_IndexOfOption)
        {
            m_MenuOptionInvoker += i_ActionDelegate;
        }

        protected override void OnChose()
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
    }
}
