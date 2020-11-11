using Pizza.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Navigation
{
    class MainNavigation:BaseNavigation
    {
        private static volatile MainNavigation instance;
        private static object syncRoot = new Object();

        private MainNavigation()
        {
            pages.Add(typeof(Authorisation).Name, new Authorisation());
            pages.Add(typeof(Buyer).Name, new Buyer());
            CurrentPage = pages[typeof(Authorisation).Name];
        }

        public static MainNavigation Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new MainNavigation();
                    }
                }
                return instance;
            }
        }
    }
}
