using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewPresenter
{
    public class Presenter
    {
        private readonly IView m_View;
        private IModel m_Model;


        public Presenter(IView view, IModel model)
        {
            this.m_View = view;
            this.m_Model = model;
        }

        public void ReverseTextValue()
        {
            string reversed = ReverseString(m_View.TextValue);
            m_Model.Reverse(reversed);
        }

        public void SetTextValue()
        {
            m_Model.Set(m_View.TextValue);
        }

        private static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

    }
}
