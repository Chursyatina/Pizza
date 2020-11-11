using DAL.Entities;
using Pizza.Commands;
using Pizza.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Pizza.ViewModel
{
    class VMAuthorisation : VMBase
    {
        private LogInCommand logInCommand;
        public LogInCommand LogInCommand
        {
            get
            {
                return logInCommand ??
                  (logInCommand = new LogInCommand(obj =>
                  {
                      //TODO Authorization logic
                      MainNavigation.Instance.Navigate(new Pizza.Pages.Buyer());
                  }));
            }
        }
    }
}
