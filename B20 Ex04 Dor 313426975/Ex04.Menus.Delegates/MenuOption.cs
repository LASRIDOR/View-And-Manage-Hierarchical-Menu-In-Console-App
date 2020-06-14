using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public abstract class MenuOption
    {
        private string m_Title = string.Empty;
        private int m_ItemIndex = 0;

        protected abstract void OnChose();

        public MenuOption(string i_Title, int i_ItemIndex)
        {
            m_Title = i_Title;
            m_ItemIndex = i_ItemIndex;
        }

        public int ItemIndex
        {
            get { return m_ItemIndex; }
            set { m_ItemIndex = value; }
        }

        public string Title
        {
            get { return m_Title; }
            set { m_Title = value; }
        }

        public override string ToString()
        {
            return m_Title;
        }
    }
}
