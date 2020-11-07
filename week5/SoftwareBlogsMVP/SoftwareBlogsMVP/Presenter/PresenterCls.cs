using SoftwareBlogsMVP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareBlogsMVP.Presenter
{
    public class PresenterCls
    {
        private IView view;
        private IModel model;
        public PresenterCls(IView view, IModel model)
        {
            this.view = view;
            this.model = model;
        }

        public void BindNameTextBox()
        {
            view.NameTextBox = model.getName();
        }
    }
}
