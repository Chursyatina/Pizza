using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.ViewModel
{
    class VMBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //protected void OnPropertyChanged([CallerMemberName] string prop = "")
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        //}
    }
}
