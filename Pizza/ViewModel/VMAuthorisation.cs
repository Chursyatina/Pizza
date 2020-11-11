using Pizza.Commands;
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
        public string MassageText = "ХУЙ";

        public VMAuthorisation()
        {
        }

        public void DisplayMassageText()
        {
            MessageBox.Show(MassageText);
        }

        private LogInCommand logInCommand;
        public LogInCommand LogInCommand => logInCommand ??
                  (logInCommand = new LogInCommand(DisplayMassageText));
    }
}
