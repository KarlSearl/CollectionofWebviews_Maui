﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace collectionofwebviews.viewmodel
{
    public abstract class BaseViewModel : BindableObject
    {
        public virtual Task InitializeAsync(object parameter)
        {
            return Task.CompletedTask;
        }

        protected bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                SetProperty(ref _isBusy, value);
            }
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
                          [CallerMemberName] string propertyName = "",
                          Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
            {
                return false;
            }
            backingStore = value;
            onChanged?.Invoke();

            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
