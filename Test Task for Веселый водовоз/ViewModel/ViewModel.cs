﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestTask.ViewModel
{
    public abstract class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
        protected virtual bool Set<T>(ref T filed, T value, [CallerMemberName] string PropertyName = null)
        {
            if (Equals(filed, value)) return false;
            filed = value;
            OnPropertyChanged(PropertyName);
            return true;
        }
    }
}
