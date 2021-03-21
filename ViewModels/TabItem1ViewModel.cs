using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Catel.MVVM;
using System.Threading.Tasks;

namespace CatelActiveViewModelsBug.ViewModels
{
    public class TabItem1ViewModel : ViewModelBase
    {
        public TabItem1ViewModel()
        {
            Title = "TabItem1ViewModelWithManualAttachedDataContext";
        }

    }
}
