﻿using ATM;
using ATMInterface.Tools;
using ATMInterface.Tools.Utilities;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ATMInterface.ViewModels
{
    internal class CheckBalanceViewModel
    {
        private string _balance;

        private Action _goToMain;

        private RelayCommand<object> _exitCommand;
        public eATM CurrentATM { get; set; }

        public CheckBalanceViewModel(Action goToMain, eATM currentATM)
        {
            _goToMain = goToMain;
            CurrentATM = currentATM;
            Balance = CurrentATM.Engine.OnUserInput(eUserAction.CHECK_BALANCE).Item2;
        }

        public void GoToMain()
        {
            _goToMain.Invoke();
        }

        public RelayCommand<object> ExitCommand
        {
            get
            {
                return _exitCommand ??= new RelayCommand<object>(_ => GoToMain(), Validation.AlwaysExecute);
            }
        }

        public string Balance 
        { get => _balance; 
          set
            {
                _balance = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
