using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGrid_MVVM
{
    public class ViewModel
    {
        public ViewModel()
        {
            this.DataFieldList = new List<string>() { "Item1", "Item2" , "Item3", "Item4", "Item5", "Item6", "Item7", "Item8", "Item9", "Item10" };
        }

        public List<string> DataFieldList
        {
            get;
            set;
        }
    }
}
