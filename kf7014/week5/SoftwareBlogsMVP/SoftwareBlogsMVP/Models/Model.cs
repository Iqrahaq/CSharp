using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareBlogsMVP.Models
{
    public class Model : IModel
    {
        string currentName = "Tim Hortons";
        public string getName()
        {
            return currentName;
        }
    }
}
