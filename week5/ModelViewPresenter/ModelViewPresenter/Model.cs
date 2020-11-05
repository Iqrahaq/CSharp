using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewPresenter
{
    public class Model : IModel
    {
        private string m_textValue;
        public event EventHandler<CustomArgs> TextSet;
        public event EventHandler<CustomArgs> TextReverse;

        public Model()
        {
            m_textValue = "";
        }
        public void Set(string value)
        {
            string before = m_textValue;
            m_textValue = value;
            RaiseTextSetEvent(before, m_textValue);
        }
        public void Reverse(string value)
        {
            string before = m_textValue;
            m_textValue = value;
            RaiseTextSetEvent(before, m_textValue);
        }

        public void RaiseTextSetEvent(string before, string after)
        {
            TextSet(this, new CustomArgs(before, after));
        }
    }

    public class CustomArgs : EventArgs
    {
        public string m_before { get; set; }
        public string m_after { get; set; }

        public CustomArgs(string before, string after)
        {
            m_before = before;
            m_after = after;
        }
    }
}
