using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Pizza.Navigation
{
    public abstract class BaseNavigation
    {
        public event PropertyChangedEventHandler CurrentPageChanged;

        private Page currentPage;
        public Page CurrentPage
        {
            get
            {
                return currentPage;
            }
            set
            {
                currentPage = value;
                CurrentPageChanged?.Invoke(null, new PropertyChangedEventArgs("CurrentPage"));
            }
        }

        protected Dictionary<string, Page> pages = new Dictionary<string, Page>();

        public void Navigate(Page page)
        {
            CurrentPage = pages[page.GetType().Name];
        }
    }
}
