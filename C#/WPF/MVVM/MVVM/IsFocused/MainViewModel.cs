using Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace IsFocused
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public DelegateCommand BtnClickCommand { get; private set; }

        private string _txtBox { get; set; }

        public string TxtBox
        {
            get { return _txtBox; }
            set
            {
                if (_txtBox == value)
                    return;
                _txtBox = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            BtnClickCommand = new DelegateCommand(_btnClickCommandAction);
            TxtBox = "adsf";
        }

        private void _btnClickCommandAction(object obj)
        {
            MessageBox.Show(obj + "");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
