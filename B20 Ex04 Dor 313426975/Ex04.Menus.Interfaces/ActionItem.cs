using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class ActionItem : MenuItem
    {
        private IDoable m_Doable;

        public ActionItem(string i_Title) : base(i_Title)
        {
            m_Doable = null;
        }

        public ActionItem(string i_Title, IDoable i_ActionDelegate) : base(i_Title)
        {
            m_Doable = i_ActionDelegate;
        }

        public IDoable Do
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
