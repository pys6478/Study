using Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Focus
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

        private bool _isTxtBoxFocused = false;

        public bool IsTxtBoxFocused
        {
            get { return _isTxtBoxFocused; }
            set
            {
                if (_isTxtBoxFocused == value)
                {
                    _isTxtBoxFocused = false;
                    OnPropertyChanged();
                }
                _isTxtBoxFocused = value;
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
            IsTxtBoxFocused = true;
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
