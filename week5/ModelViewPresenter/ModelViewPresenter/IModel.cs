using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewPresenter
{
    public interface IModel
    {
        void Set(string value);
        void Reverse(string value);
    }
}
