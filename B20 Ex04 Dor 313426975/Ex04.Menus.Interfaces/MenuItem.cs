using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        private string m_Title;
        private int m_ItemIndex;

        internal abstract void OnChose();

        // for c'tor of main-menu
        public MenuItem()
        {
            m_Title = string.Empty;
            m_ItemIndex = 0;
        }

        public MenuItem(string i_Title)
        {
            Title = i_Title;
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

        public abstract override string ToString();
    }
}