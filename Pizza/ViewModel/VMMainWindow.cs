using Pizza.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Pizza.ViewModel
{
    class VMMainWindow: VMBase
    {
        public Page CurrentPage
        {
            get
            {
                return MainNavigation.Instance.CurrentPage;
            }
        }

        public VMMainWindow()
        {
            MainNavigation.Instance.CurrentPageChanged += (sender, e) => OnPropertyChanged(e.PropertyName);
        }
    }
}
