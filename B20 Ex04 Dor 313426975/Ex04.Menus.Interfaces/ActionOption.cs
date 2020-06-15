using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class ActionOption : MenuOption
    {
        private Doable m_Doable;

        public ActionOption(string i_Title) : base(i_Title)
        {
            m_Doable = null;
        }

        public ActionOption(string i_Title, Doable i_ActionDelegate) : base(i_Title)
        {
            m_Doable = i_ActionDelegate;
        }

        public Doable Do
        {
            get { return m_Doable; }
            set { m_Doable = value; }
        }

        internal override void OnChose()
        {
            if (m_Doable == null)
            {
                Console.WriteLine("This Menu Option is not doable option");
            }
            else
            {
                m_Doable.Do();
            }
        }
        public override string ToString()
        {
            return string.Format("press {0} to {1}", ItemIndex, Title);
        }
    }
}
